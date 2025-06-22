CREATE TABLE Foodi.dbo.Pago
(
  Id_Pago INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Activo INT NULL DEFAULT 1
);
GO

CREATE TABLE Foodi.dbo.Mesa
(
  Id_Mesa INT IDENTITY(1,1) PRIMARY KEY,
  Cap_Personas_Max INT NOT NULL,
  Ocupado INT NULL,
  Activo INT NULL DEFAULT 1
);
GO

CREATE TABLE Foodi.dbo.Menu
(
  Id_Menu INT PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Activo INT NULL DEFAULT 1
);
GO

CREATE TABLE Foodi.dbo.Rol
(
  Id_Rol INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Activo INT NULL DEFAULT 1
);
GO

CREATE TABLE Foodi.dbo.Producto
(
  Id_Producto INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Descripción VARCHAR(100) NULL,
  Precio FLOAT NOT NULL,
  Activo INT NOT NULL DEFAULT 1,
  Stock INT NOT NULL,
  Stock_minimo INT NOT NULL,
  Id_Menu INT NOT NULL,
  CONSTRAINT FK_Producto_Menu FOREIGN KEY (Id_Menu) REFERENCES Foodi.dbo.Menu(Id_Menu)
);
GO

CREATE TABLE Foodi.dbo.Usuario
(
  Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
  DNI INT NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Apellido VARCHAR(50) NOT NULL,
  Fecha_Incorporación DATE NOT NULL,
  Contraseña VARCHAR(150) NOT NULL,
  Activo INT NOT NULL DEFAULT 1,
  Id_Rol INT NOT NULL,
  CONSTRAINT FK_Usuario_Rol FOREIGN KEY (Id_Rol) REFERENCES Foodi.dbo.Rol(Id_Rol)
);
GO

CREATE TABLE Foodi.dbo.Pedido
(
  Id_Pedido INT IDENTITY(1,1) PRIMARY KEY,
  Total FLOAT NOT NULL,
  Fecha DATE NOT NULL,
  Id_Pago INT NOT NULL,
  Id_Usuario INT NOT NULL,
  Id_Mesa INT NOT NULL,
  CONSTRAINT FK_Pedido_Pago FOREIGN KEY (Id_Pago) REFERENCES Foodi.dbo.Pago(Id_Pago),
  CONSTRAINT FK_Pedido_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Foodi.dbo.Usuario(Id_Usuario),
  CONSTRAINT FK_Pedido_Mesa FOREIGN KEY (Id_Mesa) REFERENCES Foodi.dbo.Mesa(Id_Mesa)
); 
GO

CREATE TABLE Foodi.dbo.Pedido_Detalle
(
  Id_Pedido_Detalle INT IDENTITY(1,1) PRIMARY KEY,
  Cantidad INT NOT NULL,
  Subtotal FLOAT NOT NULL,
  Id_Pedido INT NOT NULL,
  Id_Producto INT NOT NULL,
  Precio FLOAT NOT NULL,
  CONSTRAINT FK_PedidoDetalle_Pedido FOREIGN KEY (Id_Pedido) REFERENCES Foodi.dbo.Pedido(Id_Pedido),
  CONSTRAINT FK_PedidoDetalle_Producto FOREIGN KEY (Id_Producto) REFERENCES Foodi.dbo.Producto(Id_Producto)
);
GO
------------------------------------------------------------------------------------------------
----------------------------------------PROCEDIMIENTOS------------------------------------------
------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------
--------------------------------------TABLA MENU------------------------------------------------
------------------------------------------------------------------------------------------------

/* REGISTRO DE MENU */
CREATE PROC SP_REGISTROMENU
(
@id_menu int,
@nombre varchar(50),
@activo varchar(1),
@Respuesta int output,
@Mensaje varchar(200) output
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    -- Para validar que no exista otro menu con mismo nombre
    IF EXISTS(SELECT * FROM dbo.Menu WHERE nombre = @nombre)
    BEGIN
        SET @Mensaje = 'Menú ya existente.'
        RETURN
    END

    INSERT INTO dbo.Menu (nombre, activo) 
    VALUES (@nombre, @activo)

    SET @Respuesta = SCOPE_IDENTITY(); -- Para realizar la carga del id con el ultimo generado
    SET @Mensaje = 'Menú creado exitosamente.'
END
GO
/* EDITAR DE MENU */

GO
CREATE PROC SP_EDITARMENU
(
@id_menu int,
@nombre varchar(50),
@activo varchar(1),
@Respuesta int output,
@Mensaje varchar(200) output
)
AS
BEGIN
    SET @Respuesta = 1
    SET @Mensaje = ''

    -- Para verificar si el menu está inactivo (activo = 0)
    IF EXISTS (SELECT * FROM dbo.Menu WHERE id_menu = @id_menu AND activo = 0)
    BEGIN
        -- Si está inactivo, permitir solo la modificación del campo 'activo'
        IF @activo = 1 -- Si se intenta reactivar
        BEGIN
            UPDATE dbo.Menu SET
                activo = @activo
            WHERE id_menu = @id_menu

            SET @Respuesta = 1;
            SET @Mensaje = 'Menú reactivado exitosamente.';
            RETURN;
        END
        ELSE
        BEGIN
            -- No permitir cambiar otros campos si el menu está inactivo
            SET @Respuesta = 0;
            SET @Mensaje = 'No se pueden editar los campos de un Menú inactivo.' + CHAR(13) + CHAR(10) + 'Necesita ser reactivado.';
            RETURN;
        END
    END

    -- Para validar que no exista otro menu con mismo nombre, distinto del menu que se quiere editar
    IF EXISTS(SELECT * FROM dbo.Menu WHERE nombre = @nombre AND id_menu != @id_menu)
    BEGIN
        SET @Respuesta = 0
        SET @Mensaje = 'No se pueden duplicar los menus.'
        RETURN
    END

    UPDATE dbo.Menu SET
        nombre = @nombre,
        activo = @activo
    WHERE id_menu = @id_menu

    SET @Respuesta = 1; -- Para realizar la carga del id con el ultimo generado
    SET @Mensaje = 'Menú editado exitosamente.'
END
GO

/* ELIMINAR DE MENU*/
GO
CREATE PROC SP_ELIMINARMENU
(
@id_menu int,
@Respuesta bit output,
@Mensaje varchar(200) output
)
AS
BEGIN
    SET @Respuesta = 1

    -- Verificar si el menu ya está eliminado (activo = 0)
    IF EXISTS (SELECT * FROM dbo.Menu WHERE id_menu = @id_menu AND activo = 0)
    BEGIN
        SET @Respuesta = 0;
        SET @Mensaje = 'El Menú ya se encuentra eliminado.';
        RETURN;
    END

    -- Para validar que no exista una asociacion del menu en otras tablas
    IF NOT EXISTS(SELECT * FROM dbo.menu menu 
					INNER JOIN dbo.producto producto 
					ON producto.Id_Menu = menu.Id_Menu
					WHERE menu.Id_Menu = @id_menu)
		BEGIN
			UPDATE dbo.Menu SET activo = 0
			WHERE Id_Menu = @id_menu
	
			SET @Mensaje = 'Menú eliminada exitosamente.'
			SET @Respuesta = 1
		END
	ELSE
		BEGIN
			SET @Respuesta = 0
			SET @Mensaje = 'Menú asociada a información en productos.'
		END
END 
GO
------------------------------------------------------------------------------------------------
--------------------------------------TABLA PRODUCTOS-------------------------------------------
------------------------------------------------------------------------------------------------

/* REGISTRO DE PRODUCTO*/
GO
CREATE OR ALTER PROC SP_REGISTROPRODUCTOS
(
    @id_producto INT,
    @id_menu INT,
    @nombre VARCHAR(50),
    @descripcion VARCHAR(100),
    @stock INT,
    @stock_minimo INT,
    @precio FLOAT,
    @activo INT,
    @Respuesta INT OUTPUT,
    @Mensaje VARCHAR(200) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    -- Validar que no exista otro producto con el mismo código
    IF EXISTS (SELECT 1 FROM dbo.Producto WHERE Nombre = @nombre)
    BEGIN
        SET @Mensaje = 'Producto ya existente con el mismo nombre.'
        RETURN
    END

    INSERT INTO dbo.Producto (Id_Menu, Nombre, Descripción, Stock, Stock_minimo, Precio, Activo)
    VALUES (@id_menu, @nombre, @descripcion, @stock, @stock_minimo, @precio, @activo)

    SET @Respuesta = SCOPE_IDENTITY(); -- Obtener el ID generado
    SET @Mensaje = 'Producto creado exitosamente.'
END
GO

/* EDICION DE PRODUCTO */

GO
CREATE OR ALTER PROC SP_EDITARPRODUCTO
(
    @id_producto INT,
    @id_menu INT,
    @nombre VARCHAR(50),
    @descripcion VARCHAR(100),
    @stock INT,
    @stock_minimo INT,
    @precio FLOAT,
    @activo INT,
    @Respuesta INT OUTPUT,
    @Mensaje VARCHAR(200) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 1
    SET @Mensaje = ''

    -- Validar si el producto ya está eliminado
    IF EXISTS (SELECT 1 FROM dbo.Producto WHERE Id_Producto = @id_producto AND Activo = 0)
    BEGIN
        -- Permitir solo cambiar 'Activo' para reactivarlo
        IF @activo = 1
        BEGIN
            UPDATE dbo.Producto
            SET Activo = @activo
            WHERE Id_Producto = @id_producto

            SET @Mensaje = 'Producto reactivado exitosamente.'
            RETURN
        END
        ELSE
        BEGIN
            SET @Respuesta = 0
            SET @Mensaje = 'No se pueden editar los campos de un producto eliminado.' + CHAR(13) + CHAR(10) + 'Necesita ser reactivado.';
            RETURN
        END
    END

    -- Actualizar el producto
    UPDATE dbo.Producto
    SET 
	    Id_Menu = @id_menu,
        Nombre = @nombre,
        Descripción = @descripcion,
		Stock = @stock,
        Stock_minimo = @stock_minimo,
        Precio = @precio,
        Activo = @activo
    WHERE Id_Producto = @id_producto

    SET @Mensaje = 'Producto editado exitosamente.'
END
GO

/* ELIMINACION DE PRODUCTO */
GO
CREATE OR ALTER PROC SP_ELIMINARPRODUCTO
(
    @id_producto INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(200) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 1
    SET @Mensaje = ''

    -- Verificar si ya está eliminado
    IF EXISTS (SELECT 1 FROM dbo.Producto WHERE Id_Producto = @id_producto AND Activo = 0)
    BEGIN
        SET @Respuesta = 0
        SET @Mensaje = 'El producto ya se encuentra eliminado.'
        RETURN
    END

    -- Marcar el producto como inactivo
    UPDATE dbo.Producto
    SET Activo = 0
    WHERE Id_Producto = @id_producto

    SET @Mensaje = 'Producto eliminado exitosamente.'
	SET @Respuesta = 1;
END
GO

------------------------------------------------------------------------------------------------
-------------------------------------------INSERTS----------------------------------------------
------------------------------------------------------------------------------------------------
INSERT INTO Menu (Id_Menu, Nombre) VALUES
(5, 'Entradas'),
(6, 'Principales'),
(7, 'Acompañamientos'),
(8, 'Kids'),
(9, 'Postres'),
(10, 'Brunch'),
(11, 'Bebidas');
GO

INSERT INTO Producto (Nombre, Descripción, Precio, Activo, Stock, Stock_minimo, Id_Menu) VALUES
-- Entradas
('Rabas', 'Con limón y alioli de lima', 12500, 1, 50, 10, 5),
('Tiradito de Surubí', 'Curado y ahumado. Con pan de campo', 10000, 1, 50, 10, 5),
('Gyozas de Langostino', 'Empanaditas chinas al vapor, con salsa de soja', 11000, 1, 50, 10, 5),
('Chorizo de Surubí de la casa', 'Con chucrut y puré de papas', 10000, 1, 50, 10, 5),
('Croquetas de Jamón', 'x4 unidades, salsa bechamel y jamón crudo', 8000, 1, 50, 10, 5),
('Provoleta Ahumada', 'Y dúo de pestos: genovés y tomates secos', 11000, 1, 50, 10, 5),
('Empanada de Carne Braseada', 'x2 unidades, al horno', 7000, 1, 50, 10, 5),
('Empanada de Surubí', 'x2 unidades, fritas con salsa llajwa', 7000, 1, 50, 10, 5),
('Papas Bravas', '', 7000, 1, 50, 10, 5),

-- Principales
('Pulpo Español', 'Acompañado con papas', 36000, 1, 50, 10, 6),
('Lomo de Surubí', '320g con salsa romesco', 20000, 1, 50, 10, 6),
('Bife de Chorizo', '350g con punto a elección, sale mariposa', 20000, 1, 50, 10, 6),
('Milanesa de Surubí', '', 18000, 1, 50, 10, 6),
('Paella de Mariscos', 'Arroz de calasparra origen España', 24000, 1, 50, 10, 6),
('Paella de Hongos', 'Champignon, shiitake y de pino. Arroz de calasparra origen España', 19000, 1, 50, 10, 6),
('Lasagna', 'Blend de quesos y pesto genovés', 18000, 1, 50, 10, 6),
('Tortellini de Trucha Ahumada', 'Con manteca de hierbas y eneldo', 18000, 1, 50, 10, 6),

-- Kids
('Mini Bife', 'Acompañado con papas fritas', 14000, 1, 50, 10, 8),
('Milanesa de Pollo', 'Con papas fritas', 12500, 1, 50, 10, 8),
('Ñoquis de Papa', 'Con salsa mixta', 11500, 1, 50, 10, 8),
('Cheeseburger', 'Hamburguesa con cheddar y papas fritas', 12500, 1, 50, 10, 8),

-- Postres
('Pavlova', 'De frutas de estación, ddl y chantilly', 8000, 1, 50, 10, 9),
('Cheesecake de Guayaba', 'Torta de queso con reducción de guayaba casera', 7000, 1, 50, 10, 9),
('Cubanitos Rellenos x2', 'De dulce de leche', 5000, 1, 50, 10, 9),
('Flan de dulce de leche', 'Y crema chantilly', 6000, 1, 50, 10, 9),
('Trampantojo de Naranja', 'Reversión del cheesecake con forma de naranja', 9000, 1, 50, 10, 9),

-- Brunch
('Porción Chipas', 'De frutas de estación, ddl y chantilly', 8000, 1, 50, 10, 10),
('Avocado Toast', 'Torta de queso con reducción de guayaba casera', 7000, 1, 50, 10, 10),
('Tostado de Jamón y Queso', 'De dulce de leche', 5000, 1, 50, 10, 10),

-- Bebidas
('Agua 500 cc', 'Con o sin gas', 2500, 1, 50, 10, 11),
('Agua Saborizada', 'Levite', 2500, 1, 50, 10, 11),
('Gaseosas', 'Línea Coca 375cc. Consultar variedades', 3000, 1, 50, 10, 11),
('Vaso Limonada', '', 4000, 1, 50, 10, 11),
('Jarra de Limonada', '', 10000, 1, 50, 10, 11);
GO

-- Insertar tipo de pagos en la tabla pagos
INSERT INTO dbo.pago (nombre, activo) VALUES 
			('Efectivo', 1), 
			('Mercado Pago',  1), 
			('Tarjeta de Crédito', 1),
			('Tarjeta de Débito', 1);
GO

INSERT INTO Rol (Nombre) VALUES ('Mozo'), ('Encargado'), ('Administrador');
GO

INSERT INTO Usuario (DNI, Nombre, Apellido, Fecha_Incorporación, Contraseña, Activo, Id_Rol) VALUES
(12345678, 'Admin1', 'Apellido1', '2025-06-22', '6c569aabbf7775ef8fc570e228c16b983caa4e44a23ecb3db9575f8aaf8f5b84b', 1, 1),
(87654321, 'Admin2', 'Apellido2', '2025-06-22', '6c569aabbf7775ef8fc570e228c16b983caa4e44a23ecb3db9575f8aaf8f5b84b', 1, 1);
GO


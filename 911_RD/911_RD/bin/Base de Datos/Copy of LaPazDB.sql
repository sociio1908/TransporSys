CREATE TABLE [Usuario] (
  [intUsuario] int IDENTITY(1,1) PRIMARY KEY,
  [userName] varchar(255),
  [password] varchar(255),
  [intEntidad] int NOT NULL,
  [intTipoUsuario] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoUsuario] (
  [intTipoUsuario] int IDENTITY(1,1) PRIMARY KEY,
  [tipo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoUsuarioVSPermisos] (
  [intTipoUsuario] int NOT NULL,
  [intPermiso] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Permisos] (
  [intPermiso] int IDENTITY(1,1) PRIMARY KEY,
  [permiso] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Entidad] (
  [intEntidad] int IDENTITY(1,1) PRIMARY KEY ,
  [nombre] nvarchar(255),
  [nacimiento] Date,
  [ced_rnc] int,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Persona] (
  [intPersona] int IDENTITY(1,1) PRIMARY KEY ,
  [apellido] nvarchar(255),
  [intSexo] int NOT NULL,
  [intEntidad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Sexo] (
  [intSexo] int IDENTITY(1,1) PRIMARY KEY ,
  [sexo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Telefono] (
  [intTelefono] int IDENTITY(1,1) PRIMARY KEY ,
  [intEntidad] int NOT NULL,
  [Telefono] nvarchar(255),
  [intTipoTelefono] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoTelefono] (
  [intTipoTelefono] int IDENTITY(1,1) PRIMARY KEY ,
  [tipo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Correo] (
  [intCorreo] int IDENTITY(1,1) PRIMARY KEY ,
  [correo] nvarchar(255),
  [intEntidad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Empleado] (
  [intEmpleado] int IDENTITY(1,1) PRIMARY KEY ,
  [intPersona] int NOT NULL,
  [intintEntidad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [EmpleadoVSCargo] (
  [intEmpleado] int NOT NULL,
  [intCargo] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Cargo] (
  [intCargo] int IDENTITY(1,1) PRIMARY KEY,
  [cargo] nvarchar(255),
  [salario]  float,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [DireccionVSEntidad] (
  [intEntidad] int NOT NULL,
  [intDireccion] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Direccion] (
  [intDireccion] int IDENTITY(1,1) PRIMARY KEY ,
  [intPais] int NOT NULL,
  [intRegion] int NOT NULL,
  [intCiudad] int NOT NULL,
  [intMunicipio] int NOT NULL,
  [intSector] int NOT NULL,
  [intCalle] int NOT NULL,
  [intCasa] int NOT NULL,
  [descripcion] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Pais] (
  [intPais] int,
  [descripcion] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Region] (
  [intRegion] int,
  [descripcion] nvarchar(255),
  [intPais] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Ciudad] (
  [intCiudad] int,
  [descripcion] nvarchar(255),
  [intRegion] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Municipio] (
  [intMunicipio] int,
  [descripcion] nvarchar(255),
  [intCiudad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Sector] (
  [intSector] int,
  [descripcion] nvarchar(255),
  [intMunicipio] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Calle] (
  [intCalle] int,
  [descripcion] nvarchar(255),
  [intSector] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Casa] (
  [intCasa] int,
  [numero] int,
  [referencia] nvarchar(255),
  [intCalle] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [intEntidad] (
  [intIdntidad] int IDENTITY(1,1) PRIMARY KEY ,
  [serie] nvarchar(255),
  [intTipointEntidad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoIdentidad] (
  [intTipointEntidad] int IDENTITY(1,1) PRIMARY KEY ,
  [tipo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Cliente] (
  [intCliente] int IDENTITY(1,1) PRIMARY KEY ,
  [intPersona] int NOT NULL,
  [intintEntidad] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [HistorialSuscripcion] (
  [intCliente] int NOT NULL,
  [intUsuario] int NOT NULL,
  [intTipoPlan] int NOT NULL,
  [intSuscripcion] int NOT NULL,
  [fecha] Date,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO



CREATE TABLE [Suscripcion] (
  [intSuscripcion] int IDENTITY(1,1) PRIMARY KEY ,
  [intCliente] int NOT NULL,
  [intTipoPlan] int NOT NULL,
  [monto]  float,
  [status] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Mensualintad] (
  [intMensualintad] int IDENTITY(1,1) PRIMARY KEY ,
  [intSuscripcion] int NOT NULL,
  [intTipoPago] int NOT NULL,
  [monto]  float,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoPlan] (
  [intTipoPlan] int IDENTITY(1,1) PRIMARY KEY ,
  [tipo] nvarchar(255),
  [monto]  float,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [UnintadMedinta] (
  [intUnintadMedinta] int IDENTITY(1,1) PRIMARY KEY ,
  [descripcion] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [ArmarPlan] (
  [intTipoPlan] int NOT NULL,
  [intProducto] int NOT NULL,
  [intUnintadMedinta] int NOT NULL,
  [cantintad] integer,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [ImagenProducto] (
  [intImagenProducto] int IDENTITY(1,1) PRIMARY KEY ,
  [url] nvarchar(255),
  [intProducto] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Producto] (
  [intProducto] int IDENTITY(1,1) PRIMARY KEY ,
  [nombre] nvarchar(255),
  [descripcion] nvarchar(255),
  [intTipoProducto] int NOT NULL,
  [intCategoria] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [ProductoLog] (
  [intProductoLog] int IDENTITY(1,1) PRIMARY KEY ,
  [stock] integer,
  [costo]  float,
  [precio]  float,
  [reorden] integer,
  [intProducto] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Categoria] (
  [intCategoria] int IDENTITY(1,1) PRIMARY KEY ,
  [categoria] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoProducto] (
  [intTipoProducto] int IDENTITY(1,1) PRIMARY KEY ,
  [tipo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [ProductoVSAlmacen] (
  [intProducto] int NOT NULL,
  [intAlmacen] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Almacen] (
  [intAlmacen] int IDENTITY(1,1) PRIMARY KEY ,
  [nombre] nvarchar(255),
  [capacintad] integer,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Factura] (
  [numFactura] int IDENTITY(1,1) PRIMARY KEY ,
  [intNCF] int NOT NULL,
  [intCliente] int NOT NULL,
  [intItebis] int NOT NULL,
  [total]  float,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO


CREATE TABLE [FacturaVSTipoPago] (
  [numFactura] int NOT NULL,
  [intTipoPago] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [DetalleFactura] (
  [numFactura] int NOT NULL,
  [intProducto] int NOT NULL,
  [cantintad] integer,
  [precio]  float,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO


CREATE TABLE [Itebis] (
  [intItebis] int IDENTITY(1,1) PRIMARY KEY ,
  [porcentaje]  float,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [TipoPago] (
  [intTipoPago] int IDENTITY(1,1) PRIMARY KEY ,
  [tipo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Suplidor] (
  [intSuplidorr] int IDENTITY(1,1) PRIMARY KEY ,
  [intPersona] int NOT NULL,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [ProductoVSSuplintor] (
  [intProducto] int NOT NULL,
  [intSuplintor] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Compra] (
  [numCompra] int IDENTITY(1,1) PRIMARY KEY ,
  [intSuplintor] int NOT NULL,
  [total]  float,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [CompraVSTipoPago] (
  [numCompra] int NOT NULL,
  [intTipoPago] int NOT NULL,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [DetalleCompra] (
  [numCompra] int NOT NULL,
  [intProducto] int NOT NULL,
  [cantintad] integer,
  [precio]  float,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Transporte] (
  [intTransporte] int IDENTITY(1,1) PRIMARY KEY ,
  [numFactura] int NOT NULL,
  [intEmpleado] int NOT NULL,
  [intVehiculo] int NOT NULL,
  [intDireccion] int NOT NULL,
  [hora] datetime,
  [status] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Vehiculo] (
  [intVehiculo] int IDENTITY(1,1) PRIMARY KEY ,
  [intMarca] int NOT NULL,
  [intModelo] int NOT NULL,
  [status] bit,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Marca] (
  [intMarca] int IDENTITY(1,1) PRIMARY KEY ,
  [marca] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [Modelo] (
  [intModelo] int IDENTITY(1,1) PRIMARY KEY ,
  [modelo] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [NCF] (
  [intNCF] int IDENTITY(1,1) PRIMARY KEY,
  [serie] char,
  [numTipo] int,
  [secuencia] int,
  [reorden] int,
  [estado] bit
)
GO

CREATE TABLE [TipoNCF] (
  [numTipo] int NOT NULL,
  [tipo] nvarchar(255)
)
GO

ALTER TABLE [Usuario] ADD FOREIGN KEY ([intEntidad]) REFERENCES [Entidad] ([intEntidad])
GO

ALTER TABLE [Usuario] ADD FOREIGN KEY ([intTipoUsuario]) REFERENCES [TipoUsuario] ([intTipoUsuario])
GO

ALTER TABLE [TipoUsuarioVSPermisos] ADD FOREIGN KEY ([intTipoUsuario]) REFERENCES [TipoUsuario] ([intTipoUsuario])
GO

ALTER TABLE [TipoUsuarioVSPermisos] ADD FOREIGN KEY ([intPermiso]) REFERENCES [Permisos] ([intPermiso])
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([intSexo]) REFERENCES [Sexo] ([intSexo])
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([intEntidad]) REFERENCES [Entidad] ([intEntidad])
GO

ALTER TABLE [Telefono] ADD FOREIGN KEY ([intEntidad]) REFERENCES [Entidad] ([intEntidad])
GO

ALTER TABLE [Telefono] ADD FOREIGN KEY ([intTipoTelefono]) REFERENCES [TipoTelefono] ([intTipoTelefono])
GO

ALTER TABLE [Correo] ADD FOREIGN KEY ([intEntidad]) REFERENCES [Entidad] ([intEntidad])
GO

ALTER TABLE [Empleado] ADD FOREIGN KEY ([intPersona]) REFERENCES [Persona] ([intPersona])
GO

ALTER TABLE [EmpleadoVSCargo] ADD FOREIGN KEY ([intEmpleado]) REFERENCES [Empleado] ([intEmpleado])
GO

ALTER TABLE [EmpleadoVSCargo] ADD FOREIGN KEY ([intCargo]) REFERENCES [Cargo] ([intCargo])
GO

ALTER TABLE [DireccionVSEntidad] ADD FOREIGN KEY ([intEntidad]) REFERENCES [Entidad] ([intEntidad])
GO

ALTER TABLE [DireccionVSEntidad] ADD FOREIGN KEY ([intDireccion]) REFERENCES [Direccion] ([intDireccion])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intPais]) REFERENCES [Pais] ([intPais])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intRegion]) REFERENCES [Region] ([intRegion])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intCiudad]) REFERENCES [Ciudad] ([intCiudad])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intMunicipio]) REFERENCES [Municipio] ([intMunicipio])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intSector]) REFERENCES [Sector] ([intSector])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intCalle]) REFERENCES [Calle] ([intCalle])
GO

ALTER TABLE [Direccion] ADD FOREIGN KEY ([intCasa]) REFERENCES [Casa] ([intCasa])
GO

ALTER TABLE [Region] ADD FOREIGN KEY ([intPais]) REFERENCES [Pais] ([intPais])
GO

ALTER TABLE [Ciudad] ADD FOREIGN KEY ([intRegion]) REFERENCES [Region] ([intRegion])
GO

ALTER TABLE [Municipio] ADD FOREIGN KEY ([intCiudad]) REFERENCES [Ciudad] ([intCiudad])
GO

ALTER TABLE [Sector] ADD FOREIGN KEY ([intMunicipio]) REFERENCES [Municipio] ([intMunicipio])
GO

ALTER TABLE [Calle] ADD FOREIGN KEY ([intSector]) REFERENCES [Sector] ([intSector])
GO

ALTER TABLE [Casa] ADD FOREIGN KEY ([intCalle]) REFERENCES [Calle] ([intCalle])
GO

ALTER TABLE [Cliente] ADD FOREIGN KEY ([intPersona]) REFERENCES [Persona] ([intPersona])
GO

ALTER TABLE [Producto] ADD FOREIGN KEY ([intTipoProducto]) REFERENCES [TipoProducto] ([intTipoProducto])
GO

ALTER TABLE [Producto] ADD FOREIGN KEY ([intCategoria]) REFERENCES [Categoria] ([intCategoria])
GO

ALTER TABLE [ProductoLog] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [ProductoVSAlmacen] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [ProductoVSAlmacen] ADD FOREIGN KEY ([intAlmacen]) REFERENCES [Almacen] ([intAlmacen])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([intNCF]) REFERENCES [NCF] ([intNCF])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([intCliente]) REFERENCES [Cliente] ([intCliente])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([intItebis]) REFERENCES [Itebis] ([intItebis])
GO

ALTER TABLE [DifuntoVSFactura] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO


ALTER TABLE [FacturaVSTipoPago] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [FacturaVSTipoPago] ADD FOREIGN KEY ([intTipoPago]) REFERENCES [TipoPago] ([intTipoPago])
GO

ALTER TABLE [DetalleFactura] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [DetalleFactura] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [EntradaServicios] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [EntradaServicios] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [SalintaServicios] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [SalintaServicios] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [HistorialTiempoServicios] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [Suplidor] ADD FOREIGN KEY ([intPersona]) REFERENCES [Persona] ([intPersona])
GO

ALTER TABLE [Suplintor] ADD FOREIGN KEY ([intintEntidad]) REFERENCES [intEntidad] ([intintEntidad])
GO

ALTER TABLE [ProductoVSSuplintor] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [ProductoVSSuplintor] ADD FOREIGN KEY ([intSuplidor]) REFERENCES [Suplintor] ([intSuplintor])
GO

ALTER TABLE [Compra] ADD FOREIGN KEY ([intSuplintor]) REFERENCES [Suplintor] ([intSuplintor])
GO

ALTER TABLE [CompraVSTipoPago] ADD FOREIGN KEY ([numCompra]) REFERENCES [Compra] ([numCompra])
GO

ALTER TABLE [CompraVSTipoPago] ADD FOREIGN KEY ([intTipoPago]) REFERENCES [TipoPago] ([intTipoPago])
GO

ALTER TABLE [DetalleCompra] ADD FOREIGN KEY ([numCompra]) REFERENCES [Compra] ([numCompra])
GO

ALTER TABLE [DetalleCompra] ADD FOREIGN KEY ([intProducto]) REFERENCES [Producto] ([intProducto])
GO

ALTER TABLE [Transporte] ADD FOREIGN KEY ([numFactura]) REFERENCES [Factura] ([numFactura])
GO

ALTER TABLE [Transporte] ADD FOREIGN KEY ([intEmpleado]) REFERENCES [Empleado] ([intEmpleado])
GO

ALTER TABLE [Transporte] ADD FOREIGN KEY ([intVehiculo]) REFERENCES [Vehiculo] ([intVehiculo])
GO

ALTER TABLE [Transporte] ADD FOREIGN KEY ([intDireccion]) REFERENCES [Direccion] ([intDireccion])
GO

ALTER TABLE [Vehiculo] ADD FOREIGN KEY ([intMarca]) REFERENCES [Marca] ([intMarca])
GO

ALTER TABLE [Vehiculo] ADD FOREIGN KEY ([intModelo]) REFERENCES [Modelo] ([intModelo])
GO

ALTER TABLE [TipoNCF] ADD FOREIGN KEY ([numTipo]) REFERENCES [NCF] ([numTipo])
GO

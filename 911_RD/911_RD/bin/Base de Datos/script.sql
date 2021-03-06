USE [TransporSys]
GO
/****** Object:  Table [dbo].[ALMACENES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALMACENES](
	[id_almacen] [int] IDENTITY(1,1) NOT NULL,
	[almacen] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_ALMACENES] PRIMARY KEY CLUSTERED 
(
	[id_almacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[id_articulo] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_unidad_de_medida] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[reorden] [int] NOT NULL,
	[codigo_barras] [varchar](200) NOT NULL,
	[precio] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[id_articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS](
	[id_articulo] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_descuento] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BENEFICIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENEFICIOS](
	[id_beneficio] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_membresia] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_BENEFICIOS] PRIMARY KEY CLUSTERED 
(
	[id_beneficio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CIUDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CIUDADES](
	[id_ciudad] [float] NOT NULL,
	[id_provincia] [int] NOT NULL,
	[ciudad] [varchar](50) NOT NULL,
 CONSTRAINT [PK__CIUDADES__B7DC4CD505F9CF47] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_tercero] [int] NOT NULL,
	[id_tipo_cliente] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COBROS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COBROS](
	[id_cobro] [int] IDENTITY(1,1) NOT NULL,
	[id_financiamiento] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[num_cuota] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[monto] [float] NOT NULL,
	[mora] [float] NOT NULL,
 CONSTRAINT [PK_COBROS] PRIMARY KEY CLUSTERED 
(
	[id_cobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMBUSTIBLE]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMBUSTIBLE](
	[id_combustible] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_COMBUSTIBLE] PRIMARY KEY CLUSTERED 
(
	[id_combustible] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPRAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPRAS](
	[num_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_suplidor] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_COMPRAS] PRIMARY KEY CLUSTERED 
(
	[num_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONDUCTOR]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONDUCTOR](
	[id_conductor] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[num_licencia] [int] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
 CONSTRAINT [PK_CONDUCTOR] PRIMARY KEY CLUSTERED 
(
	[id_conductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTINENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTINENTES](
	[id_continente] [int] IDENTITY(1,1) NOT NULL,
	[continente] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CONTINENTES] PRIMARY KEY CLUSTERED 
(
	[id_continente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COTIZACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COTIZACIONES](
	[num_cotizacion] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_COTIZACIONES] PRIMARY KEY CLUSTERED 
(
	[num_cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTAMENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTAMENTOS](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[departamento] [varchar](100) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_DEPARTAMENTOS] PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DESCUENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESCUENTOS](
	[id_descuento] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha_inicial] [datetime] NOT NULL,
	[fecha_final] [datetime] NOT NULL,
	[descuento] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_DESCUENTOS] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_COMPRAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_COMPRAS](
	[num_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLES_COMPRAS] PRIMARY KEY CLUSTERED 
(
	[num_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_COTIZACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_COTIZACIONES](
	[num_cotizacion] [int] IDENTITY(1,1) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLE_COTIZACION] PRIMARY KEY CLUSTERED 
(
	[num_cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_ENTRADAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_ENTRADAS](
	[num_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLES_ENTRADAS] PRIMARY KEY CLUSTERED 
(
	[num_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_SALIDAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_SALIDAS](
	[num_salida] [int] NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLES_SALIDAS] PRIMARY KEY CLUSTERED 
(
	[num_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_VENTAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_VENTAS](
	[num_fact] [int] NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLE_VENTAS] PRIMARY KEY CLUSTERED 
(
	[num_fact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECCIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECCIONES](
	[id_direccion] [int] IDENTITY(1,1) NOT NULL,
	[latitud] [float] NOT NULL,
	[longitud] [float] NOT NULL,
 CONSTRAINT [PK_DIRECCIONES] PRIMARY KEY CLUSTERED 
(
	[id_direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMAILS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMAILS](
	[id_email] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_EMAILS] PRIMARY KEY CLUSTERED 
(
	[id_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
	[fecha_ingreso] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS_VS_PUESTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS_VS_PUESTOS](
	[id_empleado] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
 CONSTRAINT [PK_EMPLEADOS_VS_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC,
	[id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ENTRADAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENTRADAS](
	[num_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_suplidor] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[nota] [varchar](200) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_ENTRADAS] PRIMARY KEY CLUSTERED 
(
	[num_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXISTENCIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXISTENCIAS](
	[id_articulo] [int] NOT NULL,
	[id_unidad_de_medida] [int] NOT NULL,
	[id_almacen] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_EXISTENCIAS_1] PRIMARY KEY CLUSTERED 
(
	[id_articulo] ASC,
	[id_unidad_de_medida] ASC,
	[id_almacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FINANCIAMIENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FINANCIAMIENTOS](
	[id_financiamiento] [int] IDENTITY(1,1) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[cant_cuota] [int] NOT NULL,
	[tasa] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[duracion] [varchar](50) NOT NULL,
	[monto] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_FINANCIAMIENTOS] PRIMARY KEY CLUSTERED 
(
	[id_financiamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GPS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPS](
	[id_vehiculo] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[latitud] [geography] NOT NULL,
	[longitud] [geography] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IDENTIFICACIONES](
	[id_identificacion] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_identificacion] [int] NOT NULL,
	[identificacion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_IDENTIFICACION] PRIMARY KEY CLUSTERED 
(
	[id_identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEBIS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEBIS](
	[intItebis] [int] IDENTITY(1,1) NOT NULL,
	[porcentaje] [float] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[intItebis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCA]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCA](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NULL,
 CONSTRAINT [PK__Marca__6763148EFE90443B] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODELO]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODELO](
	[id_modelo] [int] IDENTITY(1,1) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Modelo__2D4F2A63E8EB301C] PRIMARY KEY CLUSTERED 
(
	[id_modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NACIONALIDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NACIONALIDADES](
	[id_nacionalidad] [int] NOT NULL,
	[nacionalidad] [varchar](150) NOT NULL,
	[pais] [varchar](150) NOT NULL,
 CONSTRAINT [PK_NACIONALIDADES] PRIMARY KEY CLUSTERED 
(
	[id_nacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCF]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCF](
	[intNCF] [int] IDENTITY(1,1) NOT NULL,
	[serie] [char](1) NULL,
	[numTipo] [int] NULL,
	[secuencia] [int] NULL,
	[reorden] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[intNCF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PACIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PACIENTES](
	[id_paciente] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NOT NULL,
	[peso] [float] NOT NULL,
	[num_seguro] [varchar](50) NULL,
	[fecha_nacimiento] [datetime] NOT NULL,
	[alergias] [varchar](200) NULL,
	[estado_covid] [int] NOT NULL,
	[epilectico] [bit] NOT NULL,
	[historial_medico] [varchar](200) NOT NULL,
	[medicamentos] [varchar](200) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_PACIENTES] PRIMARY KEY CLUSTERED 
(
	[id_paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAISES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAISES](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[id_continente] [int] NOT NULL,
	[pais] [varchar](100) NOT NULL,
 CONSTRAINT [PK_PAISES] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[id_tercero] [int] NOT NULL,
	[id_sexo] [int] NOT NULL,
	[id_nacionalidad] [int] NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
 CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRECIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRECIOS](
	[id_precio] [int] IDENTITY(1,1) NOT NULL,
	[id_articulo] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[precio_neto] [float] NOT NULL,
	[precio_venta] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_PRECIOS] PRIMARY KEY CLUSTERED 
(
	[id_precio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[id_pais] [int] NOT NULL,
	[provincia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PROVINCIAS] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[id_puesto] [int] IDENTITY(1,1) NOT NULL,
	[puesto] [varchar](100) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[salario] [float] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTOS_VS_DEPARTAMENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS](
	[id_puesto] [int] NOT NULL,
	[id_departamento] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALIDAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALIDAS](
	[num_salida] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[nota] [varchar](200) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_SALIDAS] PRIMARY KEY CLUSTERED 
(
	[num_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEXOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEXOS](
	[id_sexo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
 CONSTRAINT [PK_SEXOS] PRIMARY KEY CLUSTERED 
(
	[id_sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPLIDORES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPLIDORES](
	[id_suplidor] [int] IDENTITY(1,1) NOT NULL,
	[id_tercero] [int] NOT NULL,
	[id_tipo_suplidor] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_SUPLIDORES] PRIMARY KEY CLUSTERED 
(
	[id_suplidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TELEFONOS](
	[id_telefono] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_telefono] [int] NOT NULL,
	[telefono] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TELEFONOS] PRIMARY KEY CLUSTERED 
(
	[id_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS](
	[id_tercero] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TERCEROS] PRIMARY KEY CLUSTERED 
(
	[id_tercero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_DIRECCIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_DIRECCIONES](
	[id_tercero] [int] NOT NULL,
	[id_direccion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_EMAILS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_EMAILS](
	[id_tercero] [int] NOT NULL,
	[id_email] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_IDENTIFICACIONES](
	[id_tercero] [int] NOT NULL,
	[id_identificacion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_TELEFONOS](
	[id_tercero] [int] NOT NULL,
	[id_telefono] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPONCF]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPONCF](
	[numTipo] [int] NOT NULL,
	[tipo] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CLIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_CLIENTES](
	[id_tipo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[tipo_cliente] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPOS_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_IDENTIFICACIONES](
	[id_tipo_identificacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPO_IDENTIFICACION] PRIMARY KEY CLUSTERED 
(
	[id_tipo_identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_MEMBRESIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_MEMBRESIAS](
	[id_tipo_membresia] [int] IDENTITY(1,1) NOT NULL,
	[tipo_membresia] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_TIPOS_MEMBRESIAS] PRIMARY KEY CLUSTERED 
(
	[id_tipo_membresia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_SUPLIDORES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_SUPLIDORES](
	[id_tipo_suplidor] [int] IDENTITY(1,1) NOT NULL,
	[tipo_suplidor] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPOS_SUPLIDORES] PRIMARY KEY CLUSTERED 
(
	[id_tipo_suplidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_TELEFONOS](
	[id_tipo_telefono] [int] IDENTITY(1,1) NOT NULL,
	[tipo_telefono] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPO_TELEFONOS] PRIMARY KEY CLUSTERED 
(
	[id_tipo_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_USUARIOS](
	[id_tipo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo_usuario] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPO_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOSPAGO]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOSPAGO](
	[id_tipoPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TIPOSPAGO] PRIMARY KEY CLUSTERED 
(
	[id_tipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOSVIAJES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOSVIAJES](
	[id_tipoViaje] [int] IDENTITY(1,1) NOT NULL,
	[descripcionViaje] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TIPOVIAJES] PRIMARY KEY CLUSTERED 
(
	[id_tipoViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNIDADES_DE_MEDIDA]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDADES_DE_MEDIDA](
	[id_unidad_de_medida] [int] IDENTITY(1,1) NOT NULL,
	[unidad_de_medida] [varchar](50) NOT NULL,
	[abreviatura] [varchar](10) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_UNIDADES_DE_MEDIDA] PRIMARY KEY CLUSTERED 
(
	[id_unidad_de_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_tipo_usuario] [int] NOT NULL,
	[contrasena] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_USUARIOS_1] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICULO]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULO](
	[id_vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[id_marca] [int] NOT NULL,
	[id_modelo] [int] NOT NULL,
	[id_conductor] [int] NULL,
	[num_chasis] [varchar](50) NOT NULL,
	[fecha_ingreso] [datetime] NOT NULL,
	[ano_fabricacion] [datetime] NOT NULL,
	[gasto_galon_combustible_kilometro] [float] NULL,
	[id_combustible] [int] NOT NULL,
	[num_gps] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK__Vehiculo__E5621DAA5168C61D] PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[num_fact] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_VENTAS] PRIMARY KEY CLUSTERED 
(
	[num_fact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIAJES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIAJES](
	[id_viaje] [int] IDENTITY(1,1) NOT NULL,
	[id_tipoPago] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_paciente] [int] NOT NULL,
	[id_tipoViaje] [int] NOT NULL,
	[id_conductor] [int] NULL,
	[oxigeno] [bit] NOT NULL,
	[silla_rueda] [bit] NOT NULL,
	[camilla] [bit] NOT NULL,
	[acompanante] [int] NOT NULL,
	[personal_ayudante] [int] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_recogida] [datetime] NOT NULL,
	[direc_recogida] [varchar](200) NOT NULL,
	[num_habitacion_recogida] [varchar](50) NULL,
	[instrucciones_recodida] [varchar](200) NULL,
	[contacto_recodigda] [varchar](50) NULL,
	[direc_destino] [varchar](200) NOT NULL,
	[num_habitacion_destino] [varchar](50) NULL,
	[instrucciones_destino] [varchar](200) NULL,
	[contacto_destino] [varchar](50) NULL,
	[notas_viaje] [varchar](50) NULL,
	[total_viaje] [float] NOT NULL,
	[subtotal_viaje] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_VIAJES] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ARTICULOS]  WITH NOCHECK ADD  CONSTRAINT [FK_ARTICULOS_CATEGORIAS] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[CATEGORIAS] ([id_categoria])
GO
ALTER TABLE [dbo].[ARTICULOS] NOCHECK CONSTRAINT [FK_ARTICULOS_CATEGORIAS]
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS] NOCHECK CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_ARTICULOS]
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_CATEGORIAS] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[CATEGORIAS] ([id_categoria])
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS] NOCHECK CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_CATEGORIAS]
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_DESCUENTOS] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[DESCUENTOS] ([id_descuento])
GO
ALTER TABLE [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS] NOCHECK CONSTRAINT [FK_ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS_DESCUENTOS]
GO
ALTER TABLE [dbo].[BENEFICIOS]  WITH NOCHECK ADD  CONSTRAINT [FK_BENEFICIOS_TIPOS_MEMBRESIAS] FOREIGN KEY([id_tipo_membresia])
REFERENCES [dbo].[TIPOS_MEMBRESIAS] ([id_tipo_membresia])
GO
ALTER TABLE [dbo].[BENEFICIOS] NOCHECK CONSTRAINT [FK_BENEFICIOS_TIPOS_MEMBRESIAS]
GO
ALTER TABLE [dbo].[CIUDADES]  WITH NOCHECK ADD  CONSTRAINT [FK_CIUDADES_PROVINCIAS] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[PROVINCIAS] ([id_provincia])
GO
ALTER TABLE [dbo].[CIUDADES] NOCHECK CONSTRAINT [FK_CIUDADES_PROVINCIAS]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH NOCHECK ADD  CONSTRAINT [FK_CLIENTES_TERCEROS] FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[CLIENTES] NOCHECK CONSTRAINT [FK_CLIENTES_TERCEROS]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH NOCHECK ADD  CONSTRAINT [FK_CLIENTES_TIPOS_CLIENTES] FOREIGN KEY([id_tipo_cliente])
REFERENCES [dbo].[TIPOS_CLIENTES] ([id_tipo_cliente])
GO
ALTER TABLE [dbo].[CLIENTES] NOCHECK CONSTRAINT [FK_CLIENTES_TIPOS_CLIENTES]
GO
ALTER TABLE [dbo].[COBROS]  WITH NOCHECK ADD  CONSTRAINT [FK_COBROS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[COBROS] NOCHECK CONSTRAINT [FK_COBROS_EMPLEADOS]
GO
ALTER TABLE [dbo].[COBROS]  WITH NOCHECK ADD  CONSTRAINT [FK_COBROS_FINANCIAMIENTOS] FOREIGN KEY([id_financiamiento])
REFERENCES [dbo].[FINANCIAMIENTOS] ([id_financiamiento])
GO
ALTER TABLE [dbo].[COBROS] NOCHECK CONSTRAINT [FK_COBROS_FINANCIAMIENTOS]
GO
ALTER TABLE [dbo].[COMPRAS]  WITH NOCHECK ADD  CONSTRAINT [FK_COMPRAS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[COMPRAS] NOCHECK CONSTRAINT [FK_COMPRAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[COMPRAS]  WITH NOCHECK ADD  CONSTRAINT [FK_COMPRAS_SUPLIDORES] FOREIGN KEY([id_suplidor])
REFERENCES [dbo].[SUPLIDORES] ([id_suplidor])
GO
ALTER TABLE [dbo].[COMPRAS] NOCHECK CONSTRAINT [FK_COMPRAS_SUPLIDORES]
GO
ALTER TABLE [dbo].[CONDUCTOR]  WITH CHECK ADD  CONSTRAINT [FK__CONDUCTOR__id_em__54CB950F] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[CONDUCTOR] CHECK CONSTRAINT [FK__CONDUCTOR__id_em__54CB950F]
GO
ALTER TABLE [dbo].[COTIZACIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_COTIZACIONES_CLIENTES] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTES] ([id_cliente])
GO
ALTER TABLE [dbo].[COTIZACIONES] NOCHECK CONSTRAINT [FK_COTIZACIONES_CLIENTES]
GO
ALTER TABLE [dbo].[COTIZACIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_COTIZACIONES_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[COTIZACIONES] NOCHECK CONSTRAINT [FK_COTIZACIONES_EMPLEADOS]
GO
ALTER TABLE [dbo].[DESCUENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_DESCUENTOS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[DESCUENTOS] NOCHECK CONSTRAINT [FK_DESCUENTOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[DETALLES_COMPRAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_COMPRAS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[DETALLES_COMPRAS] NOCHECK CONSTRAINT [FK_DETALLES_COMPRAS_ARTICULOS]
GO
ALTER TABLE [dbo].[DETALLES_COMPRAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_COMPRAS_COMPRAS] FOREIGN KEY([num_compra])
REFERENCES [dbo].[COMPRAS] ([num_compra])
GO
ALTER TABLE [dbo].[DETALLES_COMPRAS] NOCHECK CONSTRAINT [FK_DETALLES_COMPRAS_COMPRAS]
GO
ALTER TABLE [dbo].[DETALLES_COTIZACIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_COTIZACIONES_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[DETALLES_COTIZACIONES] NOCHECK CONSTRAINT [FK_DETALLES_COTIZACIONES_ARTICULOS]
GO
ALTER TABLE [dbo].[DETALLES_COTIZACIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_COTIZACIONES_COTIZACIONES] FOREIGN KEY([num_cotizacion])
REFERENCES [dbo].[COTIZACIONES] ([num_cotizacion])
GO
ALTER TABLE [dbo].[DETALLES_COTIZACIONES] NOCHECK CONSTRAINT [FK_DETALLES_COTIZACIONES_COTIZACIONES]
GO
ALTER TABLE [dbo].[DETALLES_ENTRADAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_ENTRADAS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[DETALLES_ENTRADAS] NOCHECK CONSTRAINT [FK_DETALLES_ENTRADAS_ARTICULOS]
GO
ALTER TABLE [dbo].[DETALLES_ENTRADAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_ENTRADAS_ENTRADAS] FOREIGN KEY([num_entrada])
REFERENCES [dbo].[ENTRADAS] ([num_entrada])
GO
ALTER TABLE [dbo].[DETALLES_ENTRADAS] NOCHECK CONSTRAINT [FK_DETALLES_ENTRADAS_ENTRADAS]
GO
ALTER TABLE [dbo].[DETALLES_SALIDAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_SALIDAS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[DETALLES_SALIDAS] NOCHECK CONSTRAINT [FK_DETALLES_SALIDAS_ARTICULOS]
GO
ALTER TABLE [dbo].[DETALLES_SALIDAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLES_SALIDAS_SALIDAS] FOREIGN KEY([num_salida])
REFERENCES [dbo].[SALIDAS] ([num_salida])
GO
ALTER TABLE [dbo].[DETALLES_SALIDAS] NOCHECK CONSTRAINT [FK_DETALLES_SALIDAS_SALIDAS]
GO
ALTER TABLE [dbo].[DETALLES_VENTAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLE_VENTAS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[DETALLES_VENTAS] NOCHECK CONSTRAINT [FK_DETALLE_VENTAS_ARTICULOS]
GO
ALTER TABLE [dbo].[DETALLES_VENTAS]  WITH NOCHECK ADD  CONSTRAINT [FK_DETALLE_VENTAS_VENTAS] FOREIGN KEY([num_fact])
REFERENCES [dbo].[VENTAS] ([num_fact])
GO
ALTER TABLE [dbo].[DETALLES_VENTAS] NOCHECK CONSTRAINT [FK_DETALLE_VENTAS_VENTAS]
GO
ALTER TABLE [dbo].[DIRECCIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_DIRECCIONES_CIUDADES] FOREIGN KEY([latitud])
REFERENCES [dbo].[CIUDADES] ([id_ciudad])
GO
ALTER TABLE [dbo].[DIRECCIONES] NOCHECK CONSTRAINT [FK_DIRECCIONES_CIUDADES]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD FOREIGN KEY([id_puesto])
REFERENCES [dbo].[PUESTOS] ([id_puesto])
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH NOCHECK ADD  CONSTRAINT [FK_EMPLEADOS_PERSONAS] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id_persona])
GO
ALTER TABLE [dbo].[EMPLEADOS] NOCHECK CONSTRAINT [FK_EMPLEADOS_PERSONAS]
GO
ALTER TABLE [dbo].[EMPLEADOS_VS_PUESTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_EMPLEADOS_VS_PUESTOS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[EMPLEADOS_VS_PUESTOS] NOCHECK CONSTRAINT [FK_EMPLEADOS_VS_PUESTOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[EMPLEADOS_VS_PUESTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_EMPLEADOS_VS_PUESTOS_PUESTOS] FOREIGN KEY([id_puesto])
REFERENCES [dbo].[PUESTOS] ([id_puesto])
GO
ALTER TABLE [dbo].[EMPLEADOS_VS_PUESTOS] NOCHECK CONSTRAINT [FK_EMPLEADOS_VS_PUESTOS_PUESTOS]
GO
ALTER TABLE [dbo].[ENTRADAS]  WITH NOCHECK ADD  CONSTRAINT [FK_ENTRADAS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[ENTRADAS] NOCHECK CONSTRAINT [FK_ENTRADAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[ENTRADAS]  WITH NOCHECK ADD  CONSTRAINT [FK_ENTRADAS_SUPLIDORES] FOREIGN KEY([id_suplidor])
REFERENCES [dbo].[SUPLIDORES] ([id_suplidor])
GO
ALTER TABLE [dbo].[ENTRADAS] NOCHECK CONSTRAINT [FK_ENTRADAS_SUPLIDORES]
GO
ALTER TABLE [dbo].[EXISTENCIAS]  WITH NOCHECK ADD  CONSTRAINT [FK_EXISTENCIAS_ALMACENES] FOREIGN KEY([id_almacen])
REFERENCES [dbo].[ALMACENES] ([id_almacen])
GO
ALTER TABLE [dbo].[EXISTENCIAS] NOCHECK CONSTRAINT [FK_EXISTENCIAS_ALMACENES]
GO
ALTER TABLE [dbo].[EXISTENCIAS]  WITH NOCHECK ADD  CONSTRAINT [FK_EXISTENCIAS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[EXISTENCIAS] NOCHECK CONSTRAINT [FK_EXISTENCIAS_ARTICULOS]
GO
ALTER TABLE [dbo].[EXISTENCIAS]  WITH NOCHECK ADD  CONSTRAINT [FK_EXISTENCIAS_UNIDADES_DE_MEDIDA] FOREIGN KEY([id_unidad_de_medida])
REFERENCES [dbo].[UNIDADES_DE_MEDIDA] ([id_unidad_de_medida])
GO
ALTER TABLE [dbo].[EXISTENCIAS] NOCHECK CONSTRAINT [FK_EXISTENCIAS_UNIDADES_DE_MEDIDA]
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_FINANCIAMIENTOS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS] NOCHECK CONSTRAINT [FK_FINANCIAMIENTOS_ARTICULOS]
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_FINANCIAMIENTOS_CLIENTES] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTES] ([id_cliente])
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS] NOCHECK CONSTRAINT [FK_FINANCIAMIENTOS_CLIENTES]
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_FINANCIAMIENTOS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[FINANCIAMIENTOS] NOCHECK CONSTRAINT [FK_FINANCIAMIENTOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[GPS]  WITH CHECK ADD  CONSTRAINT [FK_GPS] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[VEHICULO] ([id_vehiculo])
GO
ALTER TABLE [dbo].[GPS] CHECK CONSTRAINT [FK_GPS]
GO
ALTER TABLE [dbo].[GPS]  WITH CHECK ADD  CONSTRAINT [FK_GPsS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[GPS] CHECK CONSTRAINT [FK_GPsS]
GO
ALTER TABLE [dbo].[IDENTIFICACIONES]  WITH NOCHECK ADD  CONSTRAINT [FK_IDENTIFICACIONES_TIPOS_IDENTIFICACIONES] FOREIGN KEY([id_tipo_identificacion])
REFERENCES [dbo].[TIPOS_IDENTIFICACIONES] ([id_tipo_identificacion])
GO
ALTER TABLE [dbo].[IDENTIFICACIONES] NOCHECK CONSTRAINT [FK_IDENTIFICACIONES_TIPOS_IDENTIFICACIONES]
GO
ALTER TABLE [dbo].[PACIENTES]  WITH CHECK ADD  CONSTRAINT [FK_id_Ppersona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id_persona])
GO
ALTER TABLE [dbo].[PACIENTES] CHECK CONSTRAINT [FK_id_Ppersona]
GO
ALTER TABLE [dbo].[PAISES]  WITH NOCHECK ADD  CONSTRAINT [FK_PAISES_CONTINENTES] FOREIGN KEY([id_continente])
REFERENCES [dbo].[CONTINENTES] ([id_continente])
GO
ALTER TABLE [dbo].[PAISES] NOCHECK CONSTRAINT [FK_PAISES_CONTINENTES]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH NOCHECK ADD  CONSTRAINT [FK_PERSONAS_NACIONALIDADES] FOREIGN KEY([id_nacionalidad])
REFERENCES [dbo].[NACIONALIDADES] ([id_nacionalidad])
GO
ALTER TABLE [dbo].[PERSONAS] NOCHECK CONSTRAINT [FK_PERSONAS_NACIONALIDADES]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH NOCHECK ADD  CONSTRAINT [FK_PERSONAS_SEXOS] FOREIGN KEY([id_sexo])
REFERENCES [dbo].[SEXOS] ([id_sexo])
GO
ALTER TABLE [dbo].[PERSONAS] NOCHECK CONSTRAINT [FK_PERSONAS_SEXOS]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH NOCHECK ADD  CONSTRAINT [FK_PERSONAS_TERCEROS] FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[PERSONAS] NOCHECK CONSTRAINT [FK_PERSONAS_TERCEROS]
GO
ALTER TABLE [dbo].[PRECIOS]  WITH NOCHECK ADD  CONSTRAINT [FK_PRECIOS_ARTICULOS] FOREIGN KEY([id_articulo])
REFERENCES [dbo].[ARTICULOS] ([id_articulo])
GO
ALTER TABLE [dbo].[PRECIOS] NOCHECK CONSTRAINT [FK_PRECIOS_ARTICULOS]
GO
ALTER TABLE [dbo].[PRECIOS]  WITH NOCHECK ADD  CONSTRAINT [FK_PRECIOS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[PRECIOS] NOCHECK CONSTRAINT [FK_PRECIOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[PROVINCIAS]  WITH NOCHECK ADD  CONSTRAINT [FK_PROVINCIAS_PAISES] FOREIGN KEY([id_pais])
REFERENCES [dbo].[PAISES] ([id_pais])
GO
ALTER TABLE [dbo].[PROVINCIAS] NOCHECK CONSTRAINT [FK_PROVINCIAS_PAISES]
GO
ALTER TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_PUESTOS_VS_DEPARTAMENTOS_DEPARTAMENTOS] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[DEPARTAMENTOS] ([id_departamento])
GO
ALTER TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS] NOCHECK CONSTRAINT [FK_PUESTOS_VS_DEPARTAMENTOS_DEPARTAMENTOS]
GO
ALTER TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS]  WITH NOCHECK ADD  CONSTRAINT [FK_PUESTOS_VS_DEPARTAMENTOS_PUESTOS] FOREIGN KEY([id_puesto])
REFERENCES [dbo].[PUESTOS] ([id_puesto])
GO
ALTER TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS] NOCHECK CONSTRAINT [FK_PUESTOS_VS_DEPARTAMENTOS_PUESTOS]
GO
ALTER TABLE [dbo].[SALIDAS]  WITH NOCHECK ADD  CONSTRAINT [FK_SALIDAS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[SALIDAS] NOCHECK CONSTRAINT [FK_SALIDAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[SUPLIDORES]  WITH NOCHECK ADD  CONSTRAINT [FK_SUPLIDORES_TERCEROS] FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[SUPLIDORES] NOCHECK CONSTRAINT [FK_SUPLIDORES_TERCEROS]
GO
ALTER TABLE [dbo].[SUPLIDORES]  WITH NOCHECK ADD  CONSTRAINT [FK_SUPLIDORES_TIPOS_SUPLIDORES] FOREIGN KEY([id_tipo_suplidor])
REFERENCES [dbo].[TIPOS_SUPLIDORES] ([id_tipo_suplidor])
GO
ALTER TABLE [dbo].[SUPLIDORES] NOCHECK CONSTRAINT [FK_SUPLIDORES_TIPOS_SUPLIDORES]
GO
ALTER TABLE [dbo].[TELEFONOS]  WITH NOCHECK ADD  CONSTRAINT [FK_TELEFONOS_TIPOS_TELEFONOS] FOREIGN KEY([id_tipo_telefono])
REFERENCES [dbo].[TIPOS_TELEFONOS] ([id_tipo_telefono])
GO
ALTER TABLE [dbo].[TELEFONOS] NOCHECK CONSTRAINT [FK_TELEFONOS_TIPOS_TELEFONOS]
GO
ALTER TABLE [dbo].[TERCEROS_VS_DIRECCIONES]  WITH CHECK ADD FOREIGN KEY([id_direccion])
REFERENCES [dbo].[DIRECCIONES] ([id_direccion])
GO
ALTER TABLE [dbo].[TERCEROS_VS_DIRECCIONES]  WITH CHECK ADD FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[TERCEROS_VS_EMAILS]  WITH CHECK ADD FOREIGN KEY([id_email])
REFERENCES [dbo].[EMAILS] ([id_email])
GO
ALTER TABLE [dbo].[TERCEROS_VS_EMAILS]  WITH CHECK ADD FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[TERCEROS_VS_IDENTIFICACIONES]  WITH CHECK ADD FOREIGN KEY([id_identificacion])
REFERENCES [dbo].[IDENTIFICACIONES] ([id_identificacion])
GO
ALTER TABLE [dbo].[TERCEROS_VS_IDENTIFICACIONES]  WITH CHECK ADD FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[TERCEROS_VS_TELEFONOS]  WITH CHECK ADD FOREIGN KEY([id_tercero])
REFERENCES [dbo].[TERCEROS] ([id_tercero])
GO
ALTER TABLE [dbo].[TERCEROS_VS_TELEFONOS]  WITH CHECK ADD FOREIGN KEY([id_telefono])
REFERENCES [dbo].[TELEFONOS] ([id_telefono])
GO
ALTER TABLE [dbo].[USUARIOS]  WITH NOCHECK ADD  CONSTRAINT [FK_USUARIOS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[USUARIOS] NOCHECK CONSTRAINT [FK_USUARIOS_EMPLEADOS]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH NOCHECK ADD  CONSTRAINT [FK_USUARIOS_TIPO_USUARIOS] FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[TIPOS_USUARIOS] ([id_tipo_usuario])
GO
ALTER TABLE [dbo].[USUARIOS] NOCHECK CONSTRAINT [FK_USUARIOS_TIPO_USUARIOS]
GO
ALTER TABLE [dbo].[VEHICULO]  WITH CHECK ADD  CONSTRAINT [FK_vaehicualo] FOREIGN KEY([id_modelo])
REFERENCES [dbo].[MODELO] ([id_modelo])
GO
ALTER TABLE [dbo].[VEHICULO] CHECK CONSTRAINT [FK_vaehicualo]
GO
ALTER TABLE [dbo].[VEHICULO]  WITH CHECK ADD  CONSTRAINT [FK_vaehiculo] FOREIGN KEY([id_marca])
REFERENCES [dbo].[MARCA] ([id_marca])
GO
ALTER TABLE [dbo].[VEHICULO] CHECK CONSTRAINT [FK_vaehiculo]
GO
ALTER TABLE [dbo].[VENTAS]  WITH NOCHECK ADD  CONSTRAINT [FK_VENTAS_CLIENTES] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTES] ([id_cliente])
GO
ALTER TABLE [dbo].[VENTAS] NOCHECK CONSTRAINT [FK_VENTAS_CLIENTES]
GO
ALTER TABLE [dbo].[VENTAS]  WITH NOCHECK ADD  CONSTRAINT [FK_VENTAS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[VENTAS] NOCHECK CONSTRAINT [FK_VENTAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENte] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTES] ([id_cliente])
GO
ALTER TABLE [dbo].[VIAJES] CHECK CONSTRAINT [FK_CLIENte]
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD  CONSTRAINT [FK_conducto] FOREIGN KEY([id_conductor])
REFERENCES [dbo].[CONDUCTOR] ([id_conductor])
GO
ALTER TABLE [dbo].[VIAJES] CHECK CONSTRAINT [FK_conducto]
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD  CONSTRAINT [FK_paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[PACIENTES] ([id_paciente])
GO
ALTER TABLE [dbo].[VIAJES] CHECK CONSTRAINT [FK_paciente]
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD  CONSTRAINT [FK_PAGO] FOREIGN KEY([id_tipoPago])
REFERENCES [dbo].[TIPOSPAGO] ([id_tipoPago])
GO
ALTER TABLE [dbo].[VIAJES] CHECK CONSTRAINT [FK_PAGO]
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD  CONSTRAINT [FK_tipoviajes] FOREIGN KEY([id_tipoViaje])
REFERENCES [dbo].[TIPOSVIAJES] ([id_tipoViaje])
GO
ALTER TABLE [dbo].[VIAJES] CHECK CONSTRAINT [FK_tipoviajes]
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ALMACENES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_ALMACENES]
@id_almacen INT, @almacen VARCHAR(50), @descripcion VARCHAR(150), @estado BIT
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_almacen
		   FROM ALMACENES
		   WHERE id_almacen = @id_almacen)
begin
	UPDATE ALMACENES
	SET	almacen = @almacen, descripcion = @descripcion, estado = @estado
	WHERE id_almacen = @id_almacen

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO ALMACENES (almacen, descripcion, estado)
	VALUES ( @almacen, @descripcion, @estado)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_almacen != 0)
BEGIN
	SELECT id_almacen, almacen, descripcion, estado
	FROM ALMACENES
	WHERE id_almacen = @id_almacen
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_BENEFICIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_BENEFICIOS]
@id_beneficio INT, @id_tipo_membresia INT, @descuento float, @estado BIT
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_beneficio
		   FROM BENEFICIOS
		   WHERE id_beneficio = @id_beneficio)
begin
	UPDATE BENEFICIOS
	SET	id_tipo_membresia = @id_tipo_membresia, descuento = @descuento, estado = @estado
	WHERE id_beneficio = @id_beneficio

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO BENEFICIOS (id_beneficio, id_tipo_membresia, descuento, estado )
	VALUES (@id_beneficio, @id_tipo_membresia, @descuento, @estado )

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_beneficio != 0)
BEGIN
	SELECT id_beneficio, id_beneficio, id_tipo_membresia, descuento, estado
	FROM BENEFICIOS
	WHERE id_beneficio = @id_beneficio
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_CATEGORIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_CATEGORIAS]
@id_categoria INT, @categoria varchar(50), @descripcion varchar(150), @estado BIT
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_categoria
		   FROM CATEGORIAS
		   WHERE id_categoria = @id_categoria)
begin
	UPDATE CATEGORIAS
	SET	categoria = @categoria, descripcion = @descripcion, estado = @estado
	WHERE id_categoria = @id_categoria

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO CATEGORIAS (categoria, descripcion, estado )
	VALUES (@categoria, @descripcion, @estado )

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_categoria != 0)
BEGIN
	SELECT id_categoria, categoria, descripcion, estado
	FROM CATEGORIAS
	WHERE id_categoria = @id_categoria
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_CIUDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_CIUDADES]
@id_ciudad INT, @id_provincia int, @ciudad varchar(50)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_ciudad
		   FROM CIUDADES
		   WHERE id_ciudad = @id_ciudad)
begin
	UPDATE CIUDADES
	SET	id_provincia = @id_provincia, ciudad = @ciudad
	WHERE id_ciudad = @id_ciudad

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO CIUDADES(id_provincia, ciudad )
	VALUES (@id_provincia, @ciudad )

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_ciudad != 0)
BEGIN
	SELECT id_ciudad, id_provincia, ciudad
	FROM CIUDADES
	WHERE id_ciudad = @id_ciudad
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_CONTINENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_CONTINENTES]
@id_continente INT, @continente varchar(50)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_continente
		   FROM CONTINENTES
		   WHERE id_continente = @id_continente)
begin
	UPDATE CONTINENTES
	SET	continente = @continente
	WHERE id_continente = @id_continente

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO CONTINENTES(continente)
	VALUES (@continente)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_continente != 0)
BEGIN
	SELECT id_continente, continente
	FROM CONTINENTES
	WHERE id_continente = @id_continente
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_DEPARTAMENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_DEPARTAMENTOS]
@id_departamento INT, @departamento varchar(100), @descripcion varchar(150), @estado bit
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_departamento
		   FROM DEPARTAMENTOS
		   WHERE id_departamento = @id_departamento)
begin
	UPDATE DEPARTAMENTOS
	SET	departamento = @departamento, descripcion = @descripcion, estado = @estado
	WHERE id_departamento = @id_departamento

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO DEPARTAMENTOS(departamento, descripcion, estado)
	VALUES (@departamento, @descripcion, @estado)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_departamento != 0)
BEGIN
	SELECT id_departamento, departamento, descripcion, estado
	FROM DEPARTAMENTOS
	WHERE id_departamento = @id_departamento
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_DIRECCIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_DIRECCIONES]
@id_direccion INT, @id_ciudad int, @direccion varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_direccion
		   FROM DIRECCIONES
		   WHERE id_direccion = @id_direccion)
begin
	UPDATE DIRECCIONES
	SET	id_ciudad = @id_ciudad, direccion = @direccion
	WHERE id_direccion = @id_direccion

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO DIRECCIONES(id_ciudad, direccion)
	VALUES (@id_ciudad, @direccion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_direccion != 0)
BEGIN
	SELECT id_direccion, id_ciudad, direccion
	FROM DIRECCIONES
	WHERE id_direccion = @id_direccion
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_EMAILS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_EMAILS]
@id_email INT, @email varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_email
		   FROM EMAILS
		   WHERE id_email = @id_email)
begin
	UPDATE EMAILS
	SET	email = @email
	WHERE id_email = @id_email

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO EMAILS(email)
	VALUES (@email)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_email != 0)
BEGIN
	SELECT id_email, email
	FROM EMAILS
	WHERE id_email = @id_email
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_IDENTIFICACIONES]
@id_identificacion INT, @id_tipo_identificacion int, @identificacion varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_identificacion
		   FROM IDENTIFICACIONES
		   WHERE id_identificacion = @id_identificacion)
begin
	UPDATE IDENTIFICACIONES
	SET	id_tipo_identificacion = @id_tipo_identificacion, identificacion = @identificacion
	WHERE id_identificacion = @id_identificacion

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO IDENTIFICACIONES(id_tipo_identificacion, identificacion)
	VALUES (@id_tipo_identificacion, @identificacion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_identificacion != 0)
BEGIN
	SELECT id_identificacion, id_tipo_identificacion, identificacion
	FROM IDENTIFICACIONES
	WHERE id_identificacion = @id_identificacion
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_PAISES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_PAISES]
@id_pais int, @id_continente int, @pais varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_pais
		   FROM PAISES
		   WHERE id_pais = @id_pais)
begin
	UPDATE PAISES
	SET	id_continente = @id_continente, pais = @pais

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO PAISES(id_continente, pais)
	VALUES (@id_continente, @pais)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_pais != 0)
BEGIN
	SELECT id_pais, id_continente, pais
	FROM PAISES
	WHERE id_pais = @id_pais
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_PROVINCIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_PROVINCIAS]
@id_provincia int, @id_pais int, @provincia varchar(50)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_provincia
		   FROM PROVINCIAS
		   WHERE id_provincia = @id_provincia)
begin
	UPDATE PROVINCIAS
	SET	id_pais = @id_pais, provincia = @provincia

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO PROVINCIAS(id_pais, provincia)
	VALUES (@id_pais, @provincia)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_provincia != 0)
BEGIN
	SELECT id_provincia, id_pais, provincia
	FROM PROVINCIAS
	WHERE id_provincia = @id_provincia
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_PUESTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_PUESTOS]
@id_puesto int, @puesto varchar(100), @descripcion varchar(150), @estado bit
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_puesto
		   FROM PUESTOS
		   WHERE id_puesto = @id_puesto)
begin
	UPDATE PUESTOS
	SET	puesto = @puesto, descripcion = @descripcion, estado = @estado

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO PUESTOS(puesto, descripcion, estado)
	VALUES (@puesto, @descripcion, @estado)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_puesto != 0)
BEGIN
	SELECT id_puesto, puesto, descripcion, estado
	FROM PUESTOS
	WHERE id_puesto = @id_puesto
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_SEXOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_SEXOS]
@id_sexo int, @descripcion varchar(200)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_sexo
		   FROM SEXOS
		   WHERE id_sexo = @id_sexo)
begin
	UPDATE SEXOS
	SET	descripcion = @descripcion
	WHERE id_sexo = @id_sexo

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO SEXOS
	VALUES (@descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_sexo != 0)
BEGIN
	SELECT id_sexo, descripcion
	FROM SEXOS
	WHERE id_sexo = @id_sexo
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TELEFONOS]
@id_telefono int, @id_tipo_telefono int, @telefono varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_telefono
		   FROM TELEFONOS
		   WHERE id_telefono = @id_telefono)
begin
	UPDATE TELEFONOS
	SET	id_tipo_telefono = @id_tipo_telefono, telefono = @telefono
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TELEFONOS(id_tipo_telefono, telefono)
	VALUES (@id_tipo_telefono, @telefono)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_telefono != 0)
BEGIN
	SELECT id_telefono, id_tipo_telefono, telefono
	FROM TELEFONOS
	WHERE id_telefono = @id_telefono
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TERCEROS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TERCEROS]
@id_tercero int, @nombre varchar(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tercero
		   FROM TERCEROS
		   WHERE id_tercero = @id_tercero)
begin
	UPDATE TERCEROS
	SET	nombre = @nombre
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TERCEROS(nombre)
	VALUES (@nombre)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tercero != 0)
BEGIN
	SELECT id_tercero, nombre
	FROM TERCEROS
	WHERE id_tercero = @id_tercero
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_CLIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_CLIENTES]
@id_tipo_cliente int, @tipo_cliente varchar(50), @descripcion varchar(150)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_cliente
		   FROM TIPOS_CLIENTES
		   WHERE id_tipo_cliente = @id_tipo_cliente)
begin
	UPDATE TIPOS_CLIENTES
	SET	tipo_cliente = @tipo_cliente, descripcion = @descripcion
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_CLIENTES(tipo_cliente, descripcion)
	VALUES (@tipo_cliente, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_cliente != 0)
BEGIN
	SELECT id_tipo_cliente, tipo_cliente, descripcion
	FROM TIPOS_CLIENTES
	WHERE id_tipo_cliente = @id_tipo_cliente
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_IDENTIFICACIONES]
@id_tipo_identificacion int, @nombre varchar(150), @descripcion varchar(150)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_identificacion
		   FROM TIPOS_IDENTIFICACIONES
		   WHERE id_tipo_identificacion = @id_tipo_identificacion)
begin
	UPDATE TIPOS_IDENTIFICACIONES
	SET	nombre = @nombre, descripcion = @descripcion
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_IDENTIFICACIONES(nombre, descripcion)
	VALUES (@nombre, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_identificacion != 0)
BEGIN
	SELECT id_tipo_identificacion, nombre, descripcion
	FROM TIPOS_IDENTIFICACIONES
	WHERE id_tipo_identificacion = @id_tipo_identificacion
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_MEMBRESIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_MEMBRESIAS]
@id_tipo_membresia int, @tipo_membresia varchar(50), @descripcion varchar(150), @estado bit
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_membresia
		   FROM TIPOS_MEMBRESIAS
		   WHERE id_tipo_membresia = @id_tipo_membresia)
begin
	UPDATE TIPOS_MEMBRESIAS
	SET	tipo_membresia = @tipo_membresia, descripcion = @descripcion, estado = @estado
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_MEMBRESIAS(tipo_membresia, descripcion, estado)
	VALUES (@tipo_membresia, @descripcion, @estado)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_membresia != 0)
BEGIN
	SELECT id_tipo_membresia, tipo_membresia, descripcion, estado
	FROM TIPOS_MEMBRESIAS
	WHERE id_tipo_membresia = @id_tipo_membresia
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_SUPLIDORES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_SUPLIDORES]
@id_tipo_suplidor int, @tipo_suplidor varchar(50), @descripcion varchar(150)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_suplidor
		   FROM TIPOS_SUPLIDORES
		   WHERE id_tipo_suplidor = @id_tipo_suplidor)
begin
	UPDATE TIPOS_SUPLIDORES
	SET	tipo_suplidor = @tipo_suplidor, descripcion = @descripcion
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_SUPLIDORES(tipo_suplidor, descripcion)
	VALUES (@tipo_suplidor, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_suplidor != 0)
BEGIN
	SELECT id_tipo_suplidor, tipo_suplidor, descripcion
	FROM TIPOS_SUPLIDORES
	WHERE id_tipo_suplidor = @id_tipo_suplidor
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_TELEFONOS]
@id_tipo_telefono int, @tipo_telefono varchar(50), @descripcion varchar(150)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_telefono
		   FROM TIPOS_TELEFONOS
		   WHERE id_tipo_telefono = @id_tipo_telefono)
begin
	UPDATE TIPOS_TELEFONOS
	SET	tipo_telefono = @tipo_telefono, descripcion = @descripcion
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_TELEFONOS(tipo_telefono, descripcion)
	VALUES (@tipo_telefono, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_telefono != 0)
BEGIN
	SELECT id_tipo_telefono, tipo_telefono, descripcion
	FROM TIPOS_TELEFONOS
	WHERE id_tipo_telefono = @id_tipo_telefono
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TIPOS_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTUALIZAR_TIPOS_USUARIOS]
@id_tipo_usuario INT, @tipo_usuario VARCHAR(50), @descripcion VARCHAR(100)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_tipo_usuario
		   FROM TIPOS_USUARIOS
		   WHERE id_tipo_usuario = @id_tipo_usuario)
BEGIN
	UPDATE TIPOS_USUARIOS
	SET	tipo_usuario = @tipo_usuario, descripcion = @descripcion
	WHERE id_tipo_usuario = @id_tipo_usuario

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO TIPOS_USUARIOS
	VALUES (@tipo_usuario, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_tipo_usuario != 0)
BEGIN
	SELECT id_tipo_usuario, tipo_usuario, descripcion
	FROM TIPOS_USUARIOS
	WHERE id_tipo_usuario = @id_tipo_usuario
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_UNIDADES_DE_MEDIDA]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_UNIDADES_DE_MEDIDA]
@id_unidad_de_medida int, @unidad_de_medida varchar(50), @abreviatura varchar(10), @descripcion varchar(150)
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_unidad_de_medida
		   FROM UNIDADES_DE_MEDIDA
		   WHERE id_unidad_de_medida = @id_unidad_de_medida)
begin
	UPDATE UNIDADES_DE_MEDIDA
	SET	unidad_de_medida = @unidad_de_medida, abreviatura = @abreviatura, descripcion = @descripcion
	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO UNIDADES_DE_MEDIDA(unidad_de_medida, abreviatura, descripcion)
	VALUES (@unidad_de_medida, @abreviatura, @descripcion)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_unidad_de_medida != 0)
BEGIN
	SELECT id_unidad_de_medida, unidad_de_medida, abreviatura, descripcion
	FROM UNIDADES_DE_MEDIDA
	WHERE id_unidad_de_medida = @id_unidad_de_medida
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTUALIZAR_USUARIOS] 
@id_usuario INT, @id_empleado INT, @id_tipo_usuario INT, @usuario VARCHAR(50), @contrasena VARCHAR(100), @estado BIT
AS
SET NOCOUNT ON

DECLARE @resultado INT = 0

IF EXISTS (SELECT id_usuario
		   FROM USUARIOS
		   WHERE id_usuario = @id_usuario)
BEGIN
	UPDATE USUARIOS
	SET	id_empleado = @id_empleado, id_tipo_usuario = @id_tipo_usuario, usuario = @usuario, contrasena = @contrasena, estado = @estado
	WHERE id_usuario = @id_usuario

	SET @resultado = @@rowcount
END
ELSE
BEGIN
	INSERT INTO USUARIOS
	VALUES (@id_empleado, @id_tipo_usuario, @usuario, @contrasena, @estado)

	SET @resultado = @@rowcount
END	

IF (@resultado != 0 AND @id_usuario != 0)
BEGIN
	SELECT id_usuario, id_empleado, id_tipo_usuario, usuario, contrasena, estado
	FROM USUARIOS
	WHERE id_usuario = @id_usuario
	RETURN
END
ELSE
IF (@resultado != 0)
BEGIN
	SELECT 'Se actualizó correctamente!'
	RETURN
END
ELSE
BEGIN
	SELECT 'No se actualizó correctamente!'
	RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_ALMACENES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_ALMACENES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM ALMACENES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM ALMACENES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_BENEFICIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_BENEFICIOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( BENEFICIOS u
		  INNER JOIN TIPOS_MEMBRESIAS tu
		  ON u.id_tipo_membresia = tu.id_tipo_membresia)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( BENEFICIOS u
		  INNER JOIN TIPOS_MEMBRESIAS tu
		  ON u.id_tipo_membresia = tu.id_tipo_membresia)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CATEGORIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_CATEGORIAS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM CATEGORIAS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM CATEGORIAS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CIUDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_CIUDADES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( CIUDADES u
		  INNER JOIN PROVINCIAS tu
		  ON u.id_provincia = tu.id_provincia
		  INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( CIUDADES u
		  INNER JOIN PROVINCIAS tu
		  ON u.id_provincia = tu.id_provincia
		  INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CONTINENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_CONTINENTES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM CONTINENTES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM CONTINENTES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_DEPARTAMENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_DEPARTAMENTOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM DEPARTAMENTOS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM DEPARTAMENTOS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_DIRECCIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_DIRECCIONES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( DIRECCIONES a 
	      INNER JOIN CIUDADES u
		  ON a.id_ciudad = u.id_ciudad
		  INNER JOIN PROVINCIAS tu
		  ON u.id_provincia = tu.id_provincia
		  INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( DIRECCIONES a 
	      INNER JOIN CIUDADES u
		  ON a.id_ciudad = u.id_ciudad
		  INNER JOIN PROVINCIAS tu
		  ON u.id_provincia = tu.id_provincia
		  INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_EMAILS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BUSCAR_EMAILS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM EMAILS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM EMAILS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_IDENTIFICACIONES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( IDENTIFICACIONES a 
	      INNER JOIN TIPOS_IDENTIFICACIONES u
		  ON a.id_tipo_identificacion = u.id_tipo_identificacion)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM ( IDENTIFICACIONES a 
	      INNER JOIN TIPOS_IDENTIFICACIONES u
		  ON a.id_tipo_identificacion = u.id_tipo_identificacion)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_NACIONALIDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_NACIONALIDADES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM NACIONALIDADES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM NACIONALIDADES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PAISES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_PAISES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM (PAISES p
	      INNER JOIN CONTINENTES e
		  ON e.id_continente = p.id_continente)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM (PAISES p
	      INNER JOIN CONTINENTES e
		  ON e.id_continente = p.id_continente)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PROVINCIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_PROVINCIAS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM (PROVINCIAS tu
	      INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM (PROVINCIAS tu
	      INNER JOIN PAISES e
		  ON e.id_pais = tu.id_pais
		  INNER JOIN CONTINENTES p
		  ON p.id_continente = e.id_continente)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PUESTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_PUESTOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM PUESTOS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM PUESTOS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_SEXOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_SEXOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM SEXOS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM SEXOS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TELEFONOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM (TELEFONOS tu
	      INNER JOIN TIPOS_TELEFONOS e
		  ON e.id_tipo_telefono = tu.id_tipo_telefono)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM (TELEFONOS tu
	      INNER JOIN TIPOS_TELEFONOS e
		  ON e.id_tipo_telefono = tu.id_tipo_telefono)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TERCEROS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TERCEROS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TERCEROS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TERCEROS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_CLIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_CLIENTES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_CLIENTES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_CLIENTES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_IDENTIFICACIONES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_IDENTIFICACIONES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_IDENTIFICACIONES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_MEMBRESIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_MEMBRESIAS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_MEMBRESIAS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_MEMBRESIAS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_SUPLIDORES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_SUPLIDORES]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_SUPLIDORES';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_SUPLIDORES
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_TELEFONOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_TELEFONOS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_TELEFONOS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TIPOS_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_TIPOS_USUARIOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_USUARIOS';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM TIPOS_USUARIOS
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_UNIDADES_DE_MEDIDA]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BUSCAR_UNIDADES_DE_MEDIDA]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *
	FROM UNIDADES_DE_MEDIDA';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *
	FROM UNIDADES_DE_MEDIDA
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_USUARIOS]
@valor VARCHAR(200), @buscar_por VARCHAR(200)
AS
SET NOCOUNT ON

DECLARE @comando nvarchar(MAX);

IF(@valor = '0' AND @buscar_por = '0')
BEGIN
	SET @comando = N'
	SELECT *, t.nombre + '' '' + p.apellido AS nombre_completo
	FROM (USUARIOS u
		  INNER JOIN TIPOS_USUARIOS tu
		  ON u.id_tipo_usuario = tu.id_tipo_usuario
		  INNER JOIN EMPLEADOS e
		  ON e.id_empleado = u.id_empleado
		  INNER JOIN PERSONAS p
		  ON p.id_persona = e.id_persona
		  INNER JOIN TERCEROS t
		  ON t.id_tercero = p.id_tercero)';
END
ELSE
BEGIN
	SET @comando = N'
	SELECT *, t.nombre + '' '' + p.apellido AS nombre_completo
	FROM (USUARIOS u
		  INNER JOIN TIPOS_USUARIOS tu
		  ON u.id_tipo_usuario = tu.id_tipo_usuario
		  INNER JOIN EMPLEADOS e
		  ON e.id_empleado = u.id_empleado
		  INNER JOIN PERSONAS p
		  ON p.id_persona = e.id_persona
		  INNER JOIN TERCEROS t
		  ON t.id_tercero = p.id_tercero)
	WHERE ' + @buscar_por + ' LIKE ''%' + @valor + '%''';
END

EXEC sys.sp_executesql @comando;
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_ALMACENES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_ALMACENES]
@id_almacen INT
AS
SET NOCOUNT ON

IF(@id_almacen <= 0 OR NOT EXISTS(SELECT * 
									   FROM ALMACENES 
									   WHERE id_almacen = @id_almacen))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM ALMACENES 
		  WHERE id_almacen = @id_almacen)
BEGIN
	DELETE 
	FROM ALMACENES 
	WHERE id_almacen = @id_almacen
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_BENEFICIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_BENEFICIOS]
@id_beneficio INT
AS
SET NOCOUNT ON

IF(@id_beneficio <= 0 OR NOT EXISTS(SELECT * 
									   FROM BENEFICIOS 
									   WHERE id_beneficio = @id_beneficio))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM BENEFICIOS 
		  WHERE id_beneficio = @id_beneficio)
BEGIN
	DELETE 
	FROM BENEFICIOS 
	WHERE id_beneficio = @id_beneficio
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_CATEGORIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_CATEGORIAS]
@id_categoria INT
AS
SET NOCOUNT ON

IF(@id_categoria <= 0 OR NOT EXISTS(SELECT * 
									   FROM CATEGORIAS 
									   WHERE id_categoria = @id_categoria))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM CATEGORIAS 
		  WHERE id_categoria = @id_categoria)
BEGIN
	DELETE 
	FROM CATEGORIAS 
	WHERE id_categoria = @id_categoria
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_CIUDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_CIUDADES]
@id_ciudad INT
AS
SET NOCOUNT ON

IF(@id_ciudad <= 0 OR NOT EXISTS(SELECT * 
									   FROM CIUDADES 
									   WHERE id_ciudad = @id_ciudad))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM CIUDADES 
		  WHERE id_ciudad = @id_ciudad)
BEGIN
	DELETE 
	FROM CIUDADES 
	WHERE id_ciudad = @id_ciudad
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_CONTINENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_CONTINENTES]
@id_continente INT
AS
SET NOCOUNT ON

IF(@id_continente <= 0 OR NOT EXISTS(SELECT * 
									   FROM CONTINENTES 
									   WHERE id_continente = @id_continente))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM CONTINENTES 
		  WHERE id_continente = @id_continente)
BEGIN
	DELETE 
	FROM CONTINENTES 
	WHERE id_continente = @id_continente
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_DEPARTAMENTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_DEPARTAMENTOS]
@id_departamento INT
AS
SET NOCOUNT ON

IF(@id_departamento <= 0 OR NOT EXISTS(SELECT * 
									   FROM DEPARTAMENTOS 
									   WHERE id_departamento = @id_departamento))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM DEPARTAMENTOS 
		  WHERE id_departamento = @id_departamento)
BEGIN
	DELETE 
	FROM DEPARTAMENTOS 
	WHERE id_departamento = @id_departamento
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_DIRECCIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_DIRECCIONES]
@id_direccion INT
AS
SET NOCOUNT ON

IF(@id_direccion <= 0 OR NOT EXISTS(SELECT * 
									   FROM DIRECCIONES 
									   WHERE id_direccion = @id_direccion))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM DIRECCIONES 
		  WHERE id_direccion = @id_direccion)
BEGIN
	DELETE 
	FROM DIRECCIONES 
	WHERE id_direccion = @id_direccion
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_EMAILS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_EMAILS]
@id_email INT
AS
SET NOCOUNT ON

IF(@id_email <= 0 OR NOT EXISTS(SELECT * 
									   FROM EMAILS 
									   WHERE id_email = @id_email))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM EMAILS 
		  WHERE id_email = @id_email)
BEGIN
	DELETE 
	FROM EMAILS 
	WHERE id_email = @id_email
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_IDENTIFICACIONES]
@id_identificacion INT
AS
SET NOCOUNT ON

IF(@id_identificacion <= 0 OR NOT EXISTS(SELECT * 
									   FROM IDENTIFICACIONES 
									   WHERE id_identificacion = @id_identificacion))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM IDENTIFICACIONES 
		  WHERE id_identificacion = @id_identificacion)
BEGIN
	DELETE 
	FROM IDENTIFICACIONES 
	WHERE id_identificacion = @id_identificacion
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_NACIONALIDADES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_NACIONALIDADES]
@id_nacionalidad INT
AS
SET NOCOUNT ON

IF(@id_nacionalidad <= 0 OR NOT EXISTS(SELECT * 
									   FROM NACIONALIDADES 
									   WHERE id_nacionalidad = @id_nacionalidad))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM NACIONALIDADES 
		  WHERE id_nacionalidad = @id_nacionalidad)
BEGIN
	DELETE 
	FROM NACIONALIDADES 
	WHERE id_nacionalidad = @id_nacionalidad
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PAISES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_PAISES]
@id_pais INT
AS
SET NOCOUNT ON

IF(@id_pais <= 0 OR NOT EXISTS(SELECT * 
									   FROM PAISES 
									   WHERE id_pais = @id_pais))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM PAISES 
		  WHERE id_pais = @id_pais)
BEGIN
	DELETE 
	FROM PAISES 
	WHERE id_pais = @id_pais
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PROVINCIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_PROVINCIAS]
@id_provincia INT
AS
SET NOCOUNT ON

IF(@id_provincia <= 0 OR NOT EXISTS(SELECT * 
									   FROM PROVINCIAS 
									   WHERE id_provincia = @id_provincia))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM PROVINCIAS 
		  WHERE id_provincia = @id_provincia)
BEGIN
	DELETE 
	FROM PROVINCIAS 
	WHERE id_provincia = @id_provincia
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PUESTOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_PUESTOS]
@id_puesto INT
AS
SET NOCOUNT ON

IF(@id_puesto <= 0 OR NOT EXISTS(SELECT * 
									   FROM PUESTOS 
									   WHERE id_puesto = @id_puesto))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM PUESTOS 
		  WHERE id_puesto = @id_puesto)
BEGIN
	DELETE 
	FROM PUESTOS 
	WHERE id_puesto = @id_puesto
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_SEXOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_SEXOS]
@id_sexo INT
AS
SET NOCOUNT ON

IF(@id_sexo <= 0 OR NOT EXISTS(SELECT * 
									   FROM SEXOS 
									   WHERE id_sexo = @id_sexo))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM SEXOS 
		  WHERE id_sexo = @id_sexo)
BEGIN
	DELETE 
	FROM SEXOS 
	WHERE id_sexo = @id_sexo
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TELEFONOS]
@id_telefono INT
AS
SET NOCOUNT ON

IF(@id_telefono <= 0 OR NOT EXISTS(SELECT * 
									   FROM TELEFONOS 
									   WHERE id_telefono = @id_telefono))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TELEFONOS 
		  WHERE id_telefono = @id_telefono)
BEGIN
	DELETE 
	FROM TELEFONOS 
	WHERE id_telefono = @id_telefono
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TERCEROS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TERCEROS]
@id_tercero INT
AS
SET NOCOUNT ON

IF(@id_tercero <= 0 OR NOT EXISTS(SELECT * 
									   FROM TERCEROS 
									   WHERE id_tercero = @id_tercero))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TERCEROS 
		  WHERE id_tercero = @id_tercero)
BEGIN
	DELETE 
	FROM TERCEROS 
	WHERE id_tercero = @id_tercero
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_CLIENTES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_CLIENTES]
@id_tipo_cliente INT
AS
SET NOCOUNT ON

IF(@id_tipo_cliente <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_CLIENTES 
									   WHERE id_tipo_cliente = @id_tipo_cliente))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_CLIENTES 
		  WHERE id_tipo_cliente = @id_tipo_cliente)
BEGIN
	DELETE 
	FROM TIPOS_CLIENTES 
	WHERE id_tipo_cliente = @id_tipo_cliente
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_IDENTIFICACIONES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_IDENTIFICACIONES]
@id_tipo_identificacion INT
AS
SET NOCOUNT ON

IF(@id_tipo_identificacion <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_IDENTIFICACIONES 
									   WHERE id_tipo_identificacion = @id_tipo_identificacion))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_IDENTIFICACIONES 
		  WHERE id_tipo_identificacion = @id_tipo_identificacion)
BEGIN
	DELETE 
	FROM TIPOS_IDENTIFICACIONES 
	WHERE id_tipo_identificacion = @id_tipo_identificacion
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_MEMBRESIAS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_MEMBRESIAS]
@id_tipo_membresia INT
AS
SET NOCOUNT ON

IF(@id_tipo_membresia <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_MEMBRESIAS 
									   WHERE id_tipo_membresia = @id_tipo_membresia))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_MEMBRESIAS 
		  WHERE id_tipo_membresia = @id_tipo_membresia)
BEGIN
	DELETE 
	FROM TIPOS_MEMBRESIAS 
	WHERE id_tipo_membresia = @id_tipo_membresia
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_SUPLIDORES]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_SUPLIDORES]
@id_tipo_suplidor INT
AS
SET NOCOUNT ON

IF(@id_tipo_suplidor <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_SUPLIDORES 
									   WHERE id_tipo_suplidor = @id_tipo_suplidor))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_SUPLIDORES 
		  WHERE id_tipo_suplidor = @id_tipo_suplidor)
BEGIN
	DELETE 
	FROM TIPOS_SUPLIDORES 
	WHERE id_tipo_suplidor = @id_tipo_suplidor
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_TELEFONOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_TELEFONOS]
@id_tipo_telefono INT
AS
SET NOCOUNT ON

IF(@id_tipo_telefono <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_TELEFONOS 
									   WHERE id_tipo_telefono = @id_tipo_telefono))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_TELEFONOS 
		  WHERE id_tipo_telefono = @id_tipo_telefono)
BEGIN
	DELETE 
	FROM TIPOS_TELEFONOS 
	WHERE id_tipo_telefono = @id_tipo_telefono
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_TIPOS_USUARIOS]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ELIMINAR_TIPOS_USUARIOS]
@id_tipo_usuario INT
AS
SET NOCOUNT ON

IF(@id_tipo_usuario <= 0 OR NOT EXISTS(SELECT * 
									   FROM TIPOS_USUARIOS 
									   WHERE id_tipo_usuario = @id_tipo_usuario))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM TIPOS_USUARIOS 
		  WHERE id_tipo_usuario = @id_tipo_usuario)
BEGIN
	DELETE 
	FROM TIPOS_USUARIOS 
	WHERE id_tipo_usuario = @id_tipo_usuario
END


GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_UNIDADES_DE_MEDIDA]    Script Date: 24/07/2021 1:47:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ELIMINAR_UNIDADES_DE_MEDIDA]
@id_unidad_de_medida INT
AS
SET NOCOUNT ON

IF(@id_unidad_de_medida <= 0 OR NOT EXISTS(SELECT * 
									   FROM UNIDADES_DE_MEDIDA 
									   WHERE id_unidad_de_medida = @id_unidad_de_medida))
BEGIN
	SELECT 'Ingrese un id válido!'
	RETURN
END
ELSE
IF EXISTS(SELECT * 
	      FROM UNIDADES_DE_MEDIDA 
		  WHERE id_unidad_de_medida = @id_unidad_de_medida)
BEGIN
	DELETE 
	FROM UNIDADES_DE_MEDIDA 
	WHERE id_unidad_de_medida = @id_unidad_de_medida
END


GO

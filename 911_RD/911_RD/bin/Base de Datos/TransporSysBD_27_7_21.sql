USE [TransporSys]
GO
/****** Object:  Table [dbo].[ALMACENES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[ARTICULOS_VS_CATEGORIAS_VS_DESCUENTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[BENEFICIOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[CIUDADES]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CIUDADES](
	[id_ciudad] [decimal](18, 15) NOT NULL,
	[id_provincia] [int] NOT NULL,
	[ciudad] [varchar](50) NOT NULL,
 CONSTRAINT [PK__CIUDADES__B7DC4CD505F9CF47] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[COBROS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[COMBUSTIBLE]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[COMPRAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[CONDUCTOR]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[CONTINENTES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[COTIZACIONES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DEPARTAMENTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DESCUENTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DETALLES_COMPRAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DETALLES_COTIZACIONES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DETALLES_ENTRADAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DETALLES_SALIDAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[DETALLES_VENTAS]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_VENTAS](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[num_fact] [int] NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[itbis] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_DETALLES_VENTAS] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECCIONES]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECCIONES](
	[id_direccion] [int] IDENTITY(1,1) NOT NULL,
	[latitud] [decimal](18, 15) NOT NULL,
	[longitud] [decimal](18, 15) NOT NULL,
 CONSTRAINT [PK_DIRECCIONES] PRIMARY KEY CLUSTERED 
(
	[id_direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVIAJES]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVIAJES](
	[id_dviaje] [int] IDENTITY(1,1) NOT NULL,
	[id_viaje] [int] NOT NULL,
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
	[contacto_recogida] [varchar](50) NULL,
	[direc_destino] [varchar](200) NOT NULL,
	[num_habitacion_destino] [varchar](50) NULL,
	[instrucciones_destino] [varchar](200) NULL,
	[contacto_destino] [varchar](50) NULL,
 CONSTRAINT [PK_DVIAJES] PRIMARY KEY CLUSTERED 
(
	[id_dviaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMAILS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[EMPLEADOS_VS_PUESTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[ENTRADAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[EXISTENCIAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[FINANCIAMIENTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[GPS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[IDENTIFICACIONES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[ITEBIS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[MARCA]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[MODELO]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[NACIONALIDADES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[NCF]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PACIENTES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PAISES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PRECIOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[PUESTOS_VS_DEPARTAMENTOS]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS_VS_DEPARTAMENTOS](
	[id_puesto] [int] NOT NULL,
	[id_departamento] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALIDAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[SEXOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[SUPLIDORES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TELEFONOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TERCEROS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TERCEROS_VS_DIRECCIONES]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_DIRECCIONES](
	[id_tercero] [int] NOT NULL,
	[id_direccion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_EMAILS]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_EMAILS](
	[id_tercero] [int] NOT NULL,
	[id_email] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_IDENTIFICACIONES]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_IDENTIFICACIONES](
	[id_tercero] [int] NOT NULL,
	[id_identificacion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TERCEROS_VS_TELEFONOS]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TERCEROS_VS_TELEFONOS](
	[id_tercero] [int] NOT NULL,
	[id_telefono] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPONCF]    Script Date: 27/07/2021 19:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPONCF](
	[numTipo] [int] NOT NULL,
	[tipo] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CLIENTES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOS_IDENTIFICACIONES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOS_MEMBRESIAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOS_SUPLIDORES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOS_TELEFONOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOS_USUARIOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOSPAGO]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[TIPOSVIAJES]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[UNIDADES_DE_MEDIDA]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[VEHICULO]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[VENTAS]    Script Date: 27/07/2021 19:09:07 ******/
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
/****** Object:  Table [dbo].[VIAJES]    Script Date: 27/07/2021 19:09:07 ******/
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
ALTER TABLE [dbo].[TERCEROS_VS_DIRECCIONES]  WITH CHECK ADD  CONSTRAINT [FK__TERCEROS___id_di__3B95D2F1] FOREIGN KEY([id_direccion])
REFERENCES [dbo].[DIRECCIONES] ([id_direccion])
GO
ALTER TABLE [dbo].[TERCEROS_VS_DIRECCIONES] CHECK CONSTRAINT [FK__TERCEROS___id_di__3B95D2F1]
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

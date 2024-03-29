USE [master]
GO
/****** Object:  Database [ferropapus]    Script Date: 21/04/2023 06:27:02 p. m. ******/
CREATE DATABASE [ferropapus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ferrepapus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ferrepapus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ferrepapus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ferrepapus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ferropapus] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ferropapus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ferropapus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ferropapus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ferropapus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ferropapus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ferropapus] SET ARITHABORT OFF 
GO
ALTER DATABASE [ferropapus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ferropapus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ferropapus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ferropapus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ferropapus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ferropapus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ferropapus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ferropapus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ferropapus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ferropapus] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ferropapus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ferropapus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ferropapus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ferropapus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ferropapus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ferropapus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ferropapus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ferropapus] SET RECOVERY FULL 
GO
ALTER DATABASE [ferropapus] SET  MULTI_USER 
GO
ALTER DATABASE [ferropapus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ferropapus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ferropapus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ferropapus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ferropapus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ferropapus] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ferropapus', N'ON'
GO
ALTER DATABASE [ferropapus] SET QUERY_STORE = OFF
GO
USE [ferropapus]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Categoria] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Categori__02AA078581DDFC50] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Cliente] [varchar](50) NULL,
	[Direccion_Cliente] [varchar](255) NULL,
	[Telefono_Cliente] [varchar](20) NULL,
	[Email_Cliente] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Clientes__E005FBFF03E87B8E] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empleado] [varchar](50) NULL,
	[Direccion_Empleado] [varchar](255) NULL,
	[Telefono_Empleado] [varchar](20) NULL,
	[Email_Empleado] [varchar](50) NULL,
	[Cargo_Empleado] [varchar](50) NULL,
	[activo] [bit] NULL,
	[password] [nvarchar](max) NULL,
	[Nombre_Usuario] [nvarchar](50) NULL,
 CONSTRAINT [PK__Empleado__B7872C9077ABD0F1] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[ID_Marca] [int] IDENTITY(1,1) NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[Nombre_Marca] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Marcas__9B8F8DB2BF67BBCC] PRIMARY KEY CLUSTERED 
(
	[ID_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Producto] [varchar](50) NULL,
	[Descripcion_Producto] [varchar](255) NULL,
	[Marca_Producto] [varchar](50) NULL,
	[Precio_Producto] [decimal](6, 2) NULL,
	[ID_Categoria] [int] NOT NULL,
	[Stock_Disponible] [int] NULL,
	[ID_Marca] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Producto__9B4120E2F10D4AD5] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Proveedor] [varchar](50) NULL,
	[Direccion_Proveedor] [varchar](255) NULL,
	[Telefono_Proveedor] [varchar](20) NULL,
	[Email_Proveedor] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Proveedo__7D65272F11E8D19D] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Venta] [date] NULL,
	[Total_Venta] [decimal](6, 2) NULL,
	[ID_Cliente] [int] NULL,
	[ID_Empleado] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__Ventas__3CD842E5F6CC3FB4] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_categoria_add]
(
	@Nombre_Categoria nvarchar(50),
	@activo bit = 1
)
as
begin
	insert into Categorias values (@Nombre_Categoria, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_categoria_delete]
	@ID_Categoria int
as
begin
	update Categorias
	set activo = 0
	where ID_Categoria = @ID_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_categoria_getall]
as
begin
	select * from Categorias
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_getbydescripcion]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_categoria_getbydescripcion]
(
@Nombre_Categoria nvarchar(50)
)
as
begin
select * 
from [dbo].[Categorias]
where Nombre_Categoria = @Nombre_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_categoria_getbyid]
	@ID_Categoria int
as
	set nocount on;
	select * from Categorias where ID_Categoria = @ID_Categoria
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_getbynombre]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_categoria_getbynombre]
(
@Nombre_categoria nvarchar(50)
)
as
begin
select *
from [dbo].[Categorias]
where Nombre_Categoria = @Nombre_categoria 
end
GO
/****** Object:  StoredProcedure [dbo].[stp_categoria_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_categoria_update]
(
	@ID_Categoria int,
	@Nombre_Categoria nvarchar(50)
)
as
begin
	update Categorias
	set Nombre_Categoria = @Nombre_Categoria
	where ID_Categoria = @ID_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[stp_cliente_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_cliente_add]
(
	@Nombre_Cliente nvarchar(50),
	@Direccion_Cliente nvarchar(50),
	@Telefono_Cliente nvarchar(255),
	@Email_Cliente nvarchar(50),
	@activo bit = 1
)
as
begin
	insert into Clientes values (@Nombre_Cliente, @Direccion_Cliente,@Telefono_Cliente,@Email_Cliente, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_cliente_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_cliente_delete]
	@ID_Cliente int
as
begin
	update Clientes
	set activo = 0
	where ID_Cliente = @ID_Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[stp_cliente_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_cliente_getall]
as
begin
	select * from Clientes
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_cliente_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_cliente_getbyid]
	@ID_Cliente int
as
	set nocount on;
	select * from Clientes where ID_Cliente = @ID_Cliente
GO
/****** Object:  StoredProcedure [dbo].[stp_cliente_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_cliente_update]
(
	@ID_Cliente int,
	@Direccion_Cliente nvarchar(255),
	@Nombre_Cliente nvarchar(50),
	@Email_Cliente nvarchar(50),
	@Telefono_Cliente nvarchar(50)
)
as
begin
	update Clientes
	set Nombre_Cliente = @Nombre_Cliente
	where ID_Cliente = @ID_Cliente

	update Clientes
	set Direccion_Cliente = @Direccion_Cliente
	where ID_Cliente = @ID_Cliente
	update Clientes
	set Email_Cliente = @Email_Cliente
	where ID_Cliente = @ID_Cliente

	update Clientes
	set Telefono_Cliente = @Telefono_Cliente
	where ID_Cliente = @ID_Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[stp_clientes_getbyname]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[stp_clientes_getbyname]
(
	@Nombre_Cliente nvarchar(50)
)
AS
BEGIN
set nocount on;
	select * from clientes
	where Nombre_Cliente = @Nombre_Cliente
END
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_empleado_add]
(
	@Nombre_Empleado nvarchar(50),
	@Direccion_Empleado nvarchar(255),
	@Telefono_Empleado nvarchar(50),
	@Email_Empleado nvarchar(50),
	@Cargo_Empleado nvarchar(50),
	@password nvarchar(max),
	@Nombre_Usuario nvarchar(50),
	@activo bit = 1
)
as
begin
	insert into Empleados values (@Nombre_Empleado, @Direccion_Empleado, @Telefono_Empleado, @Email_Empleado,
	@Cargo_Empleado, @activo, @password, @Nombre_Usuario)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_empleado_delete]
	@ID_Empleado int
as
begin
	update Empleados
	set activo = 0
	where ID_Empleado = @ID_Empleado
end
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_empleado_getall]
as
begin
	select * from Empleados
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_empleado_getbyid]
	@ID_Empleado int
as
	set nocount on;
	select * from Empleados where ID_Empleado = @ID_Empleado
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_getbynombre]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create proc [dbo].[stp_empleado_getbynombre]
(
@Nombre_Usuario nvarchar(50)
)
as
begin
select *
from [dbo].[Empleados]
where Nombre_Usuario = @Nombre_Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_login]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[stp_empleado_login]
(
@Nombre_Usuario nvarchar(50),
@password nvarchar(max)
)
as
begin
set nocount on;
	select [ID_Empleado],[Nombre_Usuario],[password],[activo]
	from [dbo].[Empleados]
	where Nombre_Usuario = @Nombre_Usuario and [password] = @password
end
GO
/****** Object:  StoredProcedure [dbo].[stp_empleado_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_empleado_update]
(
	@ID_Empleado int,
	@Nombre_Empleado nvarchar(50),
	@Direccion_Empleado nvarchar(255),
	@Telefono_Empleado nvarchar(50),
	@Email_Empleado nvarchar(50),
	@Cargo_Empleado nvarchar(50),
	@password nvarchar(max),
	@Nombre_Usuario nvarchar(50)
)
as
begin
	update Empleados
	set Nombre_Empleado = @Nombre_Empleado
	where ID_Empleado = @ID_Empleado
	update Empleados
	set Direccion_Empleado = @Direccion_Empleado
	where ID_Empleado = @ID_Empleado
	update Empleados
	set Telefono_Empleado = @Telefono_Empleado
	where ID_Empleado = @ID_Empleado
	update Empleados
	set Email_Empleado = @Email_Empleado
	where ID_Empleado = @ID_Empleado
	update Empleados
	set Cargo_Empleado = @Cargo_Empleado
	where ID_Empleado = @ID_Empleado
	update Empleados
	set [password] = @password
	where ID_Empleado = @ID_Empleado
	update Empleados
	set Nombre_Usuario = @Nombre_Usuario
	where ID_Empleado = @ID_Empleado
end
GO
/****** Object:  StoredProcedure [dbo].[stp_marca_getbynombre]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_marca_getbynombre]
(
@Nombre_marca nvarchar(50)
)
as
begin
select *
from [dbo].[Marcas]
where Nombre_Marca = @Nombre_marca
end
GO
/****** Object:  StoredProcedure [dbo].[stp_marcas_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_marcas_add]
(
	@ID_Proveedor int,
	@Nombre_Marca nvarchar(50),
	@activo bit = 1
)
as
begin
	insert into Marcas values (@ID_Proveedor, @Nombre_Marca, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_marcas_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[stp_marcas_delete]
	@ID_Marca int
as
begin
	update Marcas
	set activo = 0
	where ID_Marca = @ID_Marca
end
GO
/****** Object:  StoredProcedure [dbo].[stp_marcas_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_marcas_getall]
as
begin
	select * from Marcas
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_marcas_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_marcas_getbyid]
	@ID_Marca int
as
	set nocount on;
	select * from Marcas where ID_Marca = @ID_Marca
GO
/****** Object:  StoredProcedure [dbo].[stp_marcas_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[stp_marcas_update]
(
	@ID_Marca int,
	@ID_Proveedor int,
	@Nombre_Marca nvarchar(50)
)
as
begin
	update Marcas
	set Nombre_Marca = @Nombre_Marca
	where ID_Marca = @ID_Marca

	update Marcas
	set ID_Proveedor = @ID_Proveedor
	where ID_Marca = @ID_Marca
end
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[stp_producto_add]
(
	@Nombre_Producto nvarchar(50),
	@Descripcion_Producto nvarchar(255),
	@Marca_Producto nvarchar(50),
	@Precio_Producto money,
	@ID_Categoria nvarchar(50),
	@Stock_Disponible int,
	@ID_Marca int,
	@activo bit = 1
)
as
begin
	insert into Productos values (@Nombre_Producto,@Descripcion_Producto,@Marca_Producto,
	@Precio_Producto, @ID_Categoria, @Stock_Disponible, @ID_Marca, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_producto_delete]
	@ID_Producto int
as
begin
	update Productos
	set activo = 0
	where ID_Producto = @ID_Producto
end
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_producto_getall]
as
begin
	select * from Productos
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_producto_getbyid]
	@ID_Producto int
as
	set nocount on;
	select * from Productos where ID_Producto = @ID_Producto
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_getbyname]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[stp_producto_getbyname]
(
	@Nombre_Producto nvarchar(50)
)
AS
BEGIN
set nocount on;
	select * from Productos
	where Nombre_Producto = @Nombre_Producto
END
GO
/****** Object:  StoredProcedure [dbo].[stp_producto_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_producto_update]
(
	@ID_Producto int,
	@Nombre_Producto nvarchar(50),
	@Descripcion_Producto nvarchar(255),
	@Marca_Producto nvarchar(50),
	@Precio_Producto money,
	@ID_Categoria int,
	@Stock_Disponible int,
	@ID_Marca int
)
as
begin
	update Productos
	set Nombre_Producto = @Nombre_Producto
	where ID_Producto = @ID_Producto
	update Productos
	set Descripcion_Producto = @Descripcion_Producto
	where ID_Producto = @ID_Producto
	update Productos
	set Marca_Producto = @Marca_Producto
	where ID_Producto = @ID_Producto
	update Productos
	set Precio_Producto = @Precio_Producto
	where ID_Producto = @ID_Producto
	update Productos
	set ID_Categoria = @ID_Categoria
	where ID_Producto = @ID_Producto
	update Productos
	set Stock_Disponible = @Stock_Disponible
	where ID_Producto = @ID_Producto
	update Productos
	set ID_Marca = @ID_Marca
	where ID_Producto = @ID_Producto
end
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_proveedor_add]
(
	@Nombre_Proveedor nvarchar(50),
	@Direccion_Proveedor nvarchar(50),
	@Telefono_Proveedor nvarchar(255),
	@Email_Proveedor nvarchar(50),
	@activo bit = 1
)
as
begin
	insert into Proveedores values (@Nombre_Proveedor, @Direccion_Proveedor,@Telefono_Proveedor,@Email_Proveedor, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_proveedor_delete]
	@ID_Proveedor int
as
begin
	update Proveedores
	set activo = 0
	where ID_Proveedor = @ID_Proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_proveedor_getall]
as
begin
	select * from Proveedores
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_proveedor_getbyid]
	@ID_Proveedor int
as
	set nocount on;
	select * from Proveedores where ID_Proveedor = @ID_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_getbynombre]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_proveedor_getbynombre]
(
@Nombre_proveedor nvarchar(50)
)
as
begin
select *
from [dbo].[Proveedores]
where Nombre_Proveedor = @Nombre_proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[stp_proveedor_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_proveedor_update]
(
	@ID_Proveedor int,
	@Direccion_Proveedor nvarchar(255),
	@Nombre_Proveedor nvarchar(50),
	@Email_Proveedor nvarchar(50),
	@Telefono_Proveedor nvarchar(50)
)
as
begin
	update Proveedores
	set Nombre_Proveedor = @Nombre_Proveedor
	where ID_Proveedor = @ID_Proveedor

	update Proveedores
	set Direccion_Proveedor = @Direccion_Proveedor
	where ID_Proveedor = @ID_Proveedor

	update Proveedores
	set Email_Proveedor = @Email_Proveedor
	where ID_Proveedor = @ID_Proveedor

	update Proveedores
	set Telefono_Proveedor = @Telefono_Proveedor
	where ID_Proveedor = @ID_Proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_add]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_venta_add]
(
	@Fecha_Venta date,
	@Total_Venta money,
	@ID_Cliente int,
	@ID_Empleado int,
	@activo bit = 1
)
as
begin
	insert into Ventas values (@Fecha_Venta, @Total_Venta,@ID_Cliente,@ID_Empleado, @activo)
	end
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_delete]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_venta_delete]
	@ID_Venta int
as
begin
	update Ventas
	set activo = 0
	where ID_Venta = @ID_Venta
end
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_getall]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[stp_venta_getall]
as
begin
	select * from Ventas
	where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_getarchivo]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[stp_venta_getarchivo]
AS
BEGIN
	select * from Ventas
	where activo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_getbyid]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_venta_getbyid]
	@ID_Venta int
as
	set nocount on;
	select * from Ventas where ID_Venta= @ID_Venta
GO
/****** Object:  StoredProcedure [dbo].[stp_venta_update]    Script Date: 21/04/2023 06:27:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[stp_venta_update]
(
	@ID_Venta int,
	@Fecha_Venta date,
	@Total_Venta money,
	@ID_Cliente int,
	@ID_Empleado int
)
as
begin
	update Ventas
	set Fecha_Venta = @Fecha_Venta
	where ID_Venta = @ID_Venta

	update Ventas
	set Total_Venta = @Total_Venta
	where ID_Venta = @ID_Venta

	update Ventas
	set ID_Cliente = @ID_Cliente
	where ID_Venta = @ID_Venta

	update Ventas
	set ID_Empleado = @ID_Empleado
	where ID_Venta = @ID_Venta
end
GO
USE [master]
GO
ALTER DATABASE [ferropapus] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [Bdd_SharpPhone]    Script Date: 24/04/2015 05:59:23 ******/
CREATE DATABASE [Bdd_SharpPhone]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bdd_SharpPhone', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Bdd_SharpPhone.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bdd_SharpPhone_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Bdd_SharpPhone_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Bdd_SharpPhone] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bdd_SharpPhone].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bdd_SharpPhone] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Bdd_SharpPhone] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bdd_SharpPhone] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bdd_SharpPhone] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bdd_SharpPhone] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bdd_SharpPhone] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET RECOVERY FULL 
GO
ALTER DATABASE [Bdd_SharpPhone] SET  MULTI_USER 
GO
ALTER DATABASE [Bdd_SharpPhone] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bdd_SharpPhone] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bdd_SharpPhone] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bdd_SharpPhone] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bdd_SharpPhone', N'ON'
GO
USE [Bdd_SharpPhone]
GO
/****** Object:  Table [dbo].[T_appels]    Script Date: 24/04/2015 05:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_appels](
	[appel_numEmetteur] [varchar](10) NOT NULL,
	[appel_numDestinataire] [varchar](10) NOT NULL,
	[appel_date] [date] NOT NULL,
	[appel_duree] [int] NULL,
	[appel_manque] [bit] NULL,
	[appel_id] [int] NOT NULL,
 CONSTRAINT [PK_T_appels] PRIMARY KEY CLUSTERED 
(
	[appel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_contact]    Script Date: 24/04/2015 05:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_contact](
	[contact_nom] [varchar](50) NOT NULL,
	[contact_prenom] [varchar](50) NULL,
	[contact_numTelephone] [varchar](10) NOT NULL,
	[contact_idTelephone] [varchar](10) NOT NULL,
 CONSTRAINT [PK_T_contact] PRIMARY KEY CLUSTERED 
(
	[contact_numTelephone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_sms]    Script Date: 24/04/2015 05:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_sms](
	[sms_message] [varchar](1000) NOT NULL,
	[sms_numEmetteur] [varchar](10) NOT NULL,
	[sms_numDestinataire] [varchar](10) NOT NULL,
	[sms_date] [date] NOT NULL,
	[sms_id] [int] NOT NULL,
 CONSTRAINT [PK_T_sms] PRIMARY KEY CLUSTERED 
(
	[sms_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_telephone]    Script Date: 24/04/2015 05:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_telephone](
	[tel_numTelephone] [varchar](10) NOT NULL,
	[tel_operateur] [varchar](100) NULL,
	[tel_sonnerie] [varchar](50) NULL,
 CONSTRAINT [PK_T_telephone] PRIMARY KEY CLUSTERED 
(
	[tel_numTelephone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[T_appels]  WITH CHECK ADD  CONSTRAINT [FK_T_appels_T_telephoneDest] FOREIGN KEY([appel_numDestinataire])
REFERENCES [dbo].[T_telephone] ([tel_numTelephone])
GO
ALTER TABLE [dbo].[T_appels] CHECK CONSTRAINT [FK_T_appels_T_telephoneDest]
GO
ALTER TABLE [dbo].[T_appels]  WITH CHECK ADD  CONSTRAINT [FK_T_appels_T_telephoneEmet] FOREIGN KEY([appel_numEmetteur])
REFERENCES [dbo].[T_telephone] ([tel_numTelephone])
GO
ALTER TABLE [dbo].[T_appels] CHECK CONSTRAINT [FK_T_appels_T_telephoneEmet]
GO
ALTER TABLE [dbo].[T_contact]  WITH CHECK ADD  CONSTRAINT [FK_T_contact_T_telephone] FOREIGN KEY([contact_idTelephone])
REFERENCES [dbo].[T_telephone] ([tel_numTelephone])
GO
ALTER TABLE [dbo].[T_contact] CHECK CONSTRAINT [FK_T_contact_T_telephone]
GO
ALTER TABLE [dbo].[T_sms]  WITH CHECK ADD  CONSTRAINT [FK_T_sms_T_telephoneDest] FOREIGN KEY([sms_numDestinataire])
REFERENCES [dbo].[T_telephone] ([tel_numTelephone])
GO
ALTER TABLE [dbo].[T_sms] CHECK CONSTRAINT [FK_T_sms_T_telephoneDest]
GO
ALTER TABLE [dbo].[T_sms]  WITH CHECK ADD  CONSTRAINT [FK_T_sms_T_telephoneEmet] FOREIGN KEY([sms_numEmetteur])
REFERENCES [dbo].[T_telephone] ([tel_numTelephone])
GO
ALTER TABLE [dbo].[T_sms] CHECK CONSTRAINT [FK_T_sms_T_telephoneEmet]
GO
USE [master]
GO
ALTER DATABASE [Bdd_SharpPhone] SET  READ_WRITE 
GO

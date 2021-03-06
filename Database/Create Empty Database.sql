USE [master]
GO
/****** Object:  Database [Club25TicketService]    Script Date: 2017-05-30 03:36:53 ******/
CREATE DATABASE [Club25TicketService]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Club25TicketService', FILENAME = N'D:\Uzytki\Microsoft SQL Server 2014\MSSQL12.SANDOZDB\MSSQL\DATA\Club25TicketService.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Club25TicketService_log', FILENAME = N'D:\Uzytki\Microsoft SQL Server 2014\MSSQL12.SANDOZDB\MSSQL\DATA\Club25TicketService_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Club25TicketService] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Club25TicketService].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Club25TicketService] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Club25TicketService] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Club25TicketService] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Club25TicketService] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Club25TicketService] SET ARITHABORT OFF 
GO
ALTER DATABASE [Club25TicketService] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Club25TicketService] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Club25TicketService] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Club25TicketService] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Club25TicketService] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Club25TicketService] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Club25TicketService] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Club25TicketService] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Club25TicketService] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Club25TicketService] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Club25TicketService] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Club25TicketService] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Club25TicketService] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Club25TicketService] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Club25TicketService] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Club25TicketService] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Club25TicketService] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Club25TicketService] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Club25TicketService] SET  MULTI_USER 
GO
ALTER DATABASE [Club25TicketService] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Club25TicketService] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Club25TicketService] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Club25TicketService] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Club25TicketService] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Club25TicketService]
GO
/****** Object:  User [club25]    Script Date: 2017-05-30 03:36:53 ******/
CREATE USER [club25] FOR LOGIN [club25] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [club25]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [club25]
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[id] [int] NOT NULL,
	[name] [nvarchar](25) NOT NULL,
	[www] [nvarchar](20) NULL,
	[youtube] [nvarchar](25) NULL,
	[soundcloud] [nvarchar](25) NULL,
	[mixcloud] [nvarchar](25) NULL,
	[booking_mail] [nvarchar](25) NULL,
	[booking_phone] [nvarchar](15) NULL,
	[booking_info] [nvarchar](250) NULL,
	[idPrice_min] [int] NULL,
	[idPrice_max] [int] NULL,
	[photo] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ArtistDescription]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtistDescription](
	[idArtist] [int] NOT NULL,
	[idLanguage] [int] NOT NULL,
	[description] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] NOT NULL,
	[id_person] [int] NOT NULL,
	[phone] [nvarchar](15) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Culture]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Culture](
	[id] [int] NOT NULL,
	[name] [nvarchar](25) NOT NULL,
	[shortName] [nvarchar](25) NOT NULL,
	[idCurrency] [int] NOT NULL,
	[idLanguage] [int] NOT NULL,
 CONSTRAINT [PK_Culture] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Currency]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[id] [int] NOT NULL,
	[name] [nvarchar](10) NOT NULL,
	[shortname] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Event]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[id] [int] NOT NULL,
	[date] [datetime2](7) NOT NULL,
	[idVenue] [int] NOT NULL,
	[fbEvent] [nvarchar](50) NULL,
	[flyer] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventArtists]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventArtists](
	[idEvent] [int] NOT NULL,
	[idArtist] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventDescription]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventDescription](
	[idEvent] [int] NOT NULL,
	[idLanguage] [int] NOT NULL,
	[description] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventMediaPartner]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventMediaPartner](
	[idSponsor] [int] NOT NULL,
	[idEvent] [int] NOT NULL,
	[price] [int] NULL,
	[description] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventSponsor]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventSponsor](
	[idSponsor] [int] NOT NULL,
	[idEvent] [int] NOT NULL,
	[idPrice] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventTag]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventTag](
	[idEvent] [int] NOT NULL,
	[idTag] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FeaturedEvents]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeaturedEvents](
	[idEvent] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Language]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[id] [int] NOT NULL,
	[name] [nvarchar](15) NOT NULL,
	[shortName] [nvarchar](4) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lineup]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lineup](
	[idEvent] [int] NOT NULL,
	[idStage] [int] NULL,
	[idArtist] [int] NULL,
	[startTime] [datetime2](7) NOT NULL,
	[stopTime] [datetime2](7) NOT NULL,
	[description] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MainSponsor]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainSponsor](
	[idSponsor] [int] NOT NULL,
	[dateStart] [datetime2](7) NULL,
	[dateEnd] [datetime2](7) NULL,
	[idPrice] [int] NULL,
	[description] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permission]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](160) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] NOT NULL,
	[name] [nvarchar](20) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Policy]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policy](
	[idUserGroup] [int] NOT NULL,
	[idPermission] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Price]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Price](
	[id] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[idCurrency] [int] NOT NULL,
 CONSTRAINT [PK_Price] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sponsor]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sponsor](
	[id] [int] NOT NULL,
	[name] [nvarchar](25) NOT NULL,
	[www] [nvarchar](20) NULL,
	[phone] [nvarchar](15) NULL,
	[email] [nvarchar](20) NULL,
	[details] [nvarchar](255) NULL,
	[logo] [varbinary](max) NOT NULL,
	[logoBlack] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_Sponsor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stage]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stage](
	[id] [int] NOT NULL,
	[name] [nvarchar](25) NULL,
	[min_capacity] [int] NULL,
	[max_capacity] [int] NULL,
	[id_venue] [int] NOT NULL,
	[idPrice_min] [int] NULL,
	[idPrice_max] [int] NULL,
 CONSTRAINT [PK_Stage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tag]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[id] [int] NOT NULL,
	[name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[id] [int] NOT NULL,
	[idClient] [int] NOT NULL,
	[soldDate] [datetime2](7) NOT NULL,
	[idTicketPool] [int] NOT NULL,
	[seatNumber] [int] NULL,
	[hash] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TicketMediaType]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketMediaType](
	[id] [int] NOT NULL,
	[name] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_TicketMediaType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TicketPool]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketPool](
	[id] [int] NOT NULL,
	[idTicketType] [int] NOT NULL,
	[idTicketMedia] [int] NOT NULL,
	[idEvent] [int] NOT NULL,
	[idVendor] [int] NOT NULL,
	[idPrice] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[dateStart] [datetime2](7) NULL,
	[dateEnd] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TicketPool] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TicketType]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketType](
	[id] [int] NOT NULL,
	[name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TicketType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] NOT NULL,
	[id_person] [int] NOT NULL,
	[id_group] [int] NOT NULL,
	[password] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[id] [int] NOT NULL,
	[name] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[email] [nvarchar](25) NULL,
	[phone] [nvarchar](25) NULL,
	[www] [nvarchar](25) NOT NULL,
	[hash] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venue]    Script Date: 2017-05-30 03:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venue](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](25) NULL,
	[email] [nvarchar](25) NULL,
	[www] [nvarchar](25) NULL,
	[gps_latitude] [decimal](18, 0) NULL,
	[gps_longitude] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Venue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Artist]  WITH CHECK ADD  CONSTRAINT [FK_Artist_Price] FOREIGN KEY([idPrice_min])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[Artist] CHECK CONSTRAINT [FK_Artist_Price]
GO
ALTER TABLE [dbo].[Artist]  WITH CHECK ADD  CONSTRAINT [FK_Artist_Price1] FOREIGN KEY([idPrice_max])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[Artist] CHECK CONSTRAINT [FK_Artist_Price1]
GO
ALTER TABLE [dbo].[ArtistDescription]  WITH CHECK ADD  CONSTRAINT [FK_ArtistDescription_Artist] FOREIGN KEY([idArtist])
REFERENCES [dbo].[Artist] ([id])
GO
ALTER TABLE [dbo].[ArtistDescription] CHECK CONSTRAINT [FK_ArtistDescription_Artist]
GO
ALTER TABLE [dbo].[ArtistDescription]  WITH CHECK ADD  CONSTRAINT [FK_ArtistDescription_Language] FOREIGN KEY([idLanguage])
REFERENCES [dbo].[Language] ([id])
GO
ALTER TABLE [dbo].[ArtistDescription] CHECK CONSTRAINT [FK_ArtistDescription_Language]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Person] FOREIGN KEY([id_person])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Person]
GO
ALTER TABLE [dbo].[Culture]  WITH CHECK ADD  CONSTRAINT [FK_Culture_Currency] FOREIGN KEY([idCurrency])
REFERENCES [dbo].[Currency] ([id])
GO
ALTER TABLE [dbo].[Culture] CHECK CONSTRAINT [FK_Culture_Currency]
GO
ALTER TABLE [dbo].[Culture]  WITH CHECK ADD  CONSTRAINT [FK_Culture_Language] FOREIGN KEY([idLanguage])
REFERENCES [dbo].[Language] ([id])
GO
ALTER TABLE [dbo].[Culture] CHECK CONSTRAINT [FK_Culture_Language]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Venue] FOREIGN KEY([idVenue])
REFERENCES [dbo].[Venue] ([id])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Venue]
GO
ALTER TABLE [dbo].[EventArtists]  WITH CHECK ADD  CONSTRAINT [FK_EventArtists_Artist] FOREIGN KEY([idArtist])
REFERENCES [dbo].[Artist] ([id])
GO
ALTER TABLE [dbo].[EventArtists] CHECK CONSTRAINT [FK_EventArtists_Artist]
GO
ALTER TABLE [dbo].[EventArtists]  WITH CHECK ADD  CONSTRAINT [FK_EventArtists_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[EventArtists] CHECK CONSTRAINT [FK_EventArtists_Event]
GO
ALTER TABLE [dbo].[EventDescription]  WITH CHECK ADD  CONSTRAINT [FK_EventDescription_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[EventDescription] CHECK CONSTRAINT [FK_EventDescription_Event]
GO
ALTER TABLE [dbo].[EventDescription]  WITH CHECK ADD  CONSTRAINT [FK_EventDescription_Language] FOREIGN KEY([idLanguage])
REFERENCES [dbo].[Language] ([id])
GO
ALTER TABLE [dbo].[EventDescription] CHECK CONSTRAINT [FK_EventDescription_Language]
GO
ALTER TABLE [dbo].[EventMediaPartner]  WITH CHECK ADD  CONSTRAINT [FK_EventMediaPartner_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[EventMediaPartner] CHECK CONSTRAINT [FK_EventMediaPartner_Event]
GO
ALTER TABLE [dbo].[EventMediaPartner]  WITH CHECK ADD  CONSTRAINT [FK_EventMediaPartner_Price] FOREIGN KEY([price])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[EventMediaPartner] CHECK CONSTRAINT [FK_EventMediaPartner_Price]
GO
ALTER TABLE [dbo].[EventMediaPartner]  WITH CHECK ADD  CONSTRAINT [FK_EventMediaPartner_Sponsor] FOREIGN KEY([idSponsor])
REFERENCES [dbo].[Sponsor] ([id])
GO
ALTER TABLE [dbo].[EventMediaPartner] CHECK CONSTRAINT [FK_EventMediaPartner_Sponsor]
GO
ALTER TABLE [dbo].[EventSponsor]  WITH CHECK ADD  CONSTRAINT [FK_EventSponsor_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[EventSponsor] CHECK CONSTRAINT [FK_EventSponsor_Event]
GO
ALTER TABLE [dbo].[EventSponsor]  WITH CHECK ADD  CONSTRAINT [FK_EventSponsor_Price] FOREIGN KEY([idPrice])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[EventSponsor] CHECK CONSTRAINT [FK_EventSponsor_Price]
GO
ALTER TABLE [dbo].[EventSponsor]  WITH CHECK ADD  CONSTRAINT [FK_EventSponsor_Sponsor] FOREIGN KEY([idSponsor])
REFERENCES [dbo].[Sponsor] ([id])
GO
ALTER TABLE [dbo].[EventSponsor] CHECK CONSTRAINT [FK_EventSponsor_Sponsor]
GO
ALTER TABLE [dbo].[EventTag]  WITH CHECK ADD  CONSTRAINT [FK_EventTag_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[EventTag] CHECK CONSTRAINT [FK_EventTag_Event]
GO
ALTER TABLE [dbo].[EventTag]  WITH CHECK ADD  CONSTRAINT [FK_EventTag_Tag] FOREIGN KEY([idTag])
REFERENCES [dbo].[Tag] ([id])
GO
ALTER TABLE [dbo].[EventTag] CHECK CONSTRAINT [FK_EventTag_Tag]
GO
ALTER TABLE [dbo].[FeaturedEvents]  WITH CHECK ADD  CONSTRAINT [FK_FeaturedEvents_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[FeaturedEvents] CHECK CONSTRAINT [FK_FeaturedEvents_Event]
GO
ALTER TABLE [dbo].[Lineup]  WITH CHECK ADD  CONSTRAINT [FK_Lineup_Artist] FOREIGN KEY([idArtist])
REFERENCES [dbo].[Artist] ([id])
GO
ALTER TABLE [dbo].[Lineup] CHECK CONSTRAINT [FK_Lineup_Artist]
GO
ALTER TABLE [dbo].[Lineup]  WITH CHECK ADD  CONSTRAINT [FK_Lineup_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[Lineup] CHECK CONSTRAINT [FK_Lineup_Event]
GO
ALTER TABLE [dbo].[Lineup]  WITH CHECK ADD  CONSTRAINT [FK_Lineup_Stage] FOREIGN KEY([idStage])
REFERENCES [dbo].[Stage] ([id])
GO
ALTER TABLE [dbo].[Lineup] CHECK CONSTRAINT [FK_Lineup_Stage]
GO
ALTER TABLE [dbo].[MainSponsor]  WITH CHECK ADD  CONSTRAINT [FK_MainSponsor_Price] FOREIGN KEY([idPrice])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[MainSponsor] CHECK CONSTRAINT [FK_MainSponsor_Price]
GO
ALTER TABLE [dbo].[MainSponsor]  WITH CHECK ADD  CONSTRAINT [FK_MainSponsor_Sponsor] FOREIGN KEY([idSponsor])
REFERENCES [dbo].[Sponsor] ([id])
GO
ALTER TABLE [dbo].[MainSponsor] CHECK CONSTRAINT [FK_MainSponsor_Sponsor]
GO
ALTER TABLE [dbo].[Policy]  WITH CHECK ADD  CONSTRAINT [FK_Policy_Permission] FOREIGN KEY([idPermission])
REFERENCES [dbo].[Permission] ([id])
GO
ALTER TABLE [dbo].[Policy] CHECK CONSTRAINT [FK_Policy_Permission]
GO
ALTER TABLE [dbo].[Policy]  WITH CHECK ADD  CONSTRAINT [FK_Policy_UserGroup] FOREIGN KEY([idUserGroup])
REFERENCES [dbo].[UserGroup] ([id])
GO
ALTER TABLE [dbo].[Policy] CHECK CONSTRAINT [FK_Policy_UserGroup]
GO
ALTER TABLE [dbo].[Price]  WITH CHECK ADD  CONSTRAINT [FK_Price_Currency] FOREIGN KEY([idCurrency])
REFERENCES [dbo].[Currency] ([id])
GO
ALTER TABLE [dbo].[Price] CHECK CONSTRAINT [FK_Price_Currency]
GO
ALTER TABLE [dbo].[Stage]  WITH CHECK ADD  CONSTRAINT [FK_Stage_Price] FOREIGN KEY([idPrice_max])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[Stage] CHECK CONSTRAINT [FK_Stage_Price]
GO
ALTER TABLE [dbo].[Stage]  WITH CHECK ADD  CONSTRAINT [FK_Stage_Price1] FOREIGN KEY([idPrice_min])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[Stage] CHECK CONSTRAINT [FK_Stage_Price1]
GO
ALTER TABLE [dbo].[Stage]  WITH CHECK ADD  CONSTRAINT [FK_Stage_Venue] FOREIGN KEY([id_venue])
REFERENCES [dbo].[Venue] ([id])
GO
ALTER TABLE [dbo].[Stage] CHECK CONSTRAINT [FK_Stage_Venue]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Client]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_TicketPool] FOREIGN KEY([idTicketPool])
REFERENCES [dbo].[TicketPool] ([id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_TicketPool]
GO
ALTER TABLE [dbo].[TicketPool]  WITH CHECK ADD  CONSTRAINT [FK_TicketPool_Event] FOREIGN KEY([idEvent])
REFERENCES [dbo].[Event] ([id])
GO
ALTER TABLE [dbo].[TicketPool] CHECK CONSTRAINT [FK_TicketPool_Event]
GO
ALTER TABLE [dbo].[TicketPool]  WITH CHECK ADD  CONSTRAINT [FK_TicketPool_Price] FOREIGN KEY([idPrice])
REFERENCES [dbo].[Price] ([id])
GO
ALTER TABLE [dbo].[TicketPool] CHECK CONSTRAINT [FK_TicketPool_Price]
GO
ALTER TABLE [dbo].[TicketPool]  WITH CHECK ADD  CONSTRAINT [FK_TicketPool_TicketMediaType] FOREIGN KEY([idTicketMedia])
REFERENCES [dbo].[TicketMediaType] ([id])
GO
ALTER TABLE [dbo].[TicketPool] CHECK CONSTRAINT [FK_TicketPool_TicketMediaType]
GO
ALTER TABLE [dbo].[TicketPool]  WITH CHECK ADD  CONSTRAINT [FK_TicketPool_TicketType] FOREIGN KEY([idTicketType])
REFERENCES [dbo].[TicketType] ([id])
GO
ALTER TABLE [dbo].[TicketPool] CHECK CONSTRAINT [FK_TicketPool_TicketType]
GO
ALTER TABLE [dbo].[TicketPool]  WITH CHECK ADD  CONSTRAINT [FK_TicketPool_Vendor] FOREIGN KEY([idVendor])
REFERENCES [dbo].[Vendor] ([id])
GO
ALTER TABLE [dbo].[TicketPool] CHECK CONSTRAINT [FK_TicketPool_Vendor]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Person] FOREIGN KEY([id_person])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Person]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserGroup] FOREIGN KEY([id_group])
REFERENCES [dbo].[UserGroup] ([id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserGroup]
GO
USE [master]
GO
ALTER DATABASE [Club25TicketService] SET  READ_WRITE 
GO

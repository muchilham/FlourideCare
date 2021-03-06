USE [master]
GO
/****** Object:  Database [FluorideCareDB]    Script Date: 2/29/2016 1:05:17 AM ******/
CREATE DATABASE [FluorideCareDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FluorideCareDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FluorideCareDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FluorideCareDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FluorideCareDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FluorideCareDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FluorideCareDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FluorideCareDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FluorideCareDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FluorideCareDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FluorideCareDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FluorideCareDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FluorideCareDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FluorideCareDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FluorideCareDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FluorideCareDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FluorideCareDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FluorideCareDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FluorideCareDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FluorideCareDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FluorideCareDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FluorideCareDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FluorideCareDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FluorideCareDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FluorideCareDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FluorideCareDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FluorideCareDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FluorideCareDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FluorideCareDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FluorideCareDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FluorideCareDB] SET  MULTI_USER 
GO
ALTER DATABASE [FluorideCareDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FluorideCareDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FluorideCareDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FluorideCareDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FluorideCareDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FluorideCareDB]
GO
/****** Object:  Table [dbo].[tbl_Antrian]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Antrian](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[no_antrian] [varchar](50) NOT NULL,
	[id_ruangan] [varchar](50) NOT NULL,
	[id_user] [int] NOT NULL,
	[tanggal] [date] NOT NULL,
 CONSTRAINT [PK_tbl_Antrian] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Diagnosa]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Diagnosa](
	[id_diagnosa] [varchar](50) NOT NULL,
	[id] [int] NOT NULL,
	[hasil_diagnosa] [text] NOT NULL,
	[resep] [text] NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Diagnosa] PRIMARY KEY CLUSTERED 
(
	[id_diagnosa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Dokter]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Dokter](
	[id_dokter] [int] NOT NULL,
	[nama] [varchar](250) NOT NULL,
	[jenis_kelamin] [varchar](50) NOT NULL,
	[tanggal_lahir] [date] NOT NULL,
	[alamat] [text] NOT NULL,
	[kota] [text] NOT NULL,
	[kodepos] [int] NOT NULL,
	[telepon] [varchar](50) NOT NULL,
	[email] [varchar](250) NOT NULL,
 CONSTRAINT [PK_tbl_Dokter] PRIMARY KEY CLUSTERED 
(
	[id_dokter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Jadwal]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Jadwal](
	[id_jadwal] [varchar](50) NOT NULL,
	[mulai] [time](7) NOT NULL,
	[selesai] [time](7) NOT NULL,
 CONSTRAINT [PK_tbl_Jadwal] PRIMARY KEY CLUSTERED 
(
	[id_jadwal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Obat]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Obat](
	[id_obat] [int] NOT NULL,
	[nama_obat] [varchar](250) NOT NULL,
	[harga] [float] NOT NULL,
	[stok] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Obat] PRIMARY KEY CLUSTERED 
(
	[id_obat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_PembayaranDetail]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_PembayaranDetail](
	[auto] [int] IDENTITY(1,1) NOT NULL,
	[id_pembayaran] [varchar](50) NOT NULL,
	[id_obat] [int] NOT NULL,
	[jumlah] [int] NOT NULL,
	[harga] [float] NOT NULL,
 CONSTRAINT [PK_tbl_PembayaranDetail] PRIMARY KEY CLUSTERED 
(
	[auto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_PembayaranMaster]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_PembayaranMaster](
	[id_pembayaran] [varchar](50) NOT NULL,
	[id_diagnosa] [varchar](50) NOT NULL,
	[total] [float] NOT NULL,
	[waktu_pembayaran] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_PembayaranMaster] PRIMARY KEY CLUSTERED 
(
	[id_pembayaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Ruangan]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Ruangan](
	[id_ruangan] [varchar](50) NOT NULL,
	[nama_ruangan] [varchar](250) NOT NULL,
	[id_tipe] [varchar](50) NOT NULL,
	[id_dokter] [int] NOT NULL,
	[id_jadwal] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Ruangan] PRIMARY KEY CLUSTERED 
(
	[id_ruangan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_tipe]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_tipe](
	[id_tipe] [varchar](50) NOT NULL,
	[nama] [varchar](250) NOT NULL,
 CONSTRAINT [PK_tbl_tipe] PRIMARY KEY CLUSTERED 
(
	[id_tipe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 2/29/2016 1:05:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[id_user] [int] NOT NULL,
	[nama] [varchar](250) NOT NULL,
	[jenis_kelamin] [varchar](50) NOT NULL,
	[tanggal_lahir] [date] NOT NULL,
	[alamat] [text] NOT NULL,
	[kota] [text] NOT NULL,
	[kodepos] [int] NOT NULL,
	[telepon] [varchar](50) NOT NULL,
	[email] [varchar](250) NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Antrian] ON 

INSERT [dbo].[tbl_Antrian] ([id], [no_antrian], [id_ruangan], [id_user], [tanggal]) VALUES (1, N'Antrian 1', N'RUANG - 1', 412315, CAST(N'2016-02-27' AS Date))
INSERT [dbo].[tbl_Antrian] ([id], [no_antrian], [id_ruangan], [id_user], [tanggal]) VALUES (2, N'Antrian 1', N'RUANG - 1', 412315, CAST(N'2016-02-23' AS Date))
INSERT [dbo].[tbl_Antrian] ([id], [no_antrian], [id_ruangan], [id_user], [tanggal]) VALUES (3, N'Antrian 1', N'RUANG - 2', 51235, CAST(N'2016-02-23' AS Date))
INSERT [dbo].[tbl_Antrian] ([id], [no_antrian], [id_ruangan], [id_user], [tanggal]) VALUES (4, N'Antrian 2', N'RUANG - 2', 412315, CAST(N'2016-02-23' AS Date))
INSERT [dbo].[tbl_Antrian] ([id], [no_antrian], [id_ruangan], [id_user], [tanggal]) VALUES (1002, N'Antrian 1', N'RUANG - 1', 412315, CAST(N'2016-02-28' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_Antrian] OFF
INSERT [dbo].[tbl_Diagnosa] ([id_diagnosa], [id], [hasil_diagnosa], [resep], [status]) VALUES (N'DIAG - 1', 1002, N'Bapak ini mengalami sakit gigi, dikarenakan giginya berlubang', N'- obat gigi 2x
- oba radang tenggorokan', N'SUDAH DI ANALISA')
INSERT [dbo].[tbl_Dokter] ([id_dokter], [nama], [jenis_kelamin], [tanggal_lahir], [alamat], [kota], [kodepos], [telepon], [email]) VALUES (512351, N'Drs. Budi Utomo', N'Laki - laki', CAST(N'1994-05-09' AS Date), N'Jalan Pegangsaan  6', N'Jakarta', 15623, N'08123456123', N'budiutomo@gmail.com')
INSERT [dbo].[tbl_Dokter] ([id_dokter], [nama], [jenis_kelamin], [tanggal_lahir], [alamat], [kota], [kodepos], [telepon], [email]) VALUES (512612, N'Drs. Irham Musthofa', N'Laki - laki', CAST(N'1994-06-07' AS Date), N'Gang 8', N'Jakarta', 13670, N'089151238', N'irham@gmail.com')
INSERT [dbo].[tbl_Dokter] ([id_dokter], [nama], [jenis_kelamin], [tanggal_lahir], [alamat], [kota], [kodepos], [telepon], [email]) VALUES (754234, N'Drs. Liliana Natsir', N'Perempuan', CAST(N'1989-06-13' AS Date), N'Jalan ini', N'Bogor', 15230, N'08124237289', N'liliana@gmail.com')
INSERT [dbo].[tbl_Jadwal] ([id_jadwal], [mulai], [selesai]) VALUES (N'JAD - 1', CAST(N'02:00:00' AS Time), CAST(N'10:00:00' AS Time))
INSERT [dbo].[tbl_Jadwal] ([id_jadwal], [mulai], [selesai]) VALUES (N'JAD - 2', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[tbl_Obat] ([id_obat], [nama_obat], [harga], [stok]) VALUES (15613, N'Paramex', 5000, 100)
INSERT [dbo].[tbl_Obat] ([id_obat], [nama_obat], [harga], [stok]) VALUES (124129, N'Panadol', 3000, 90)
INSERT [dbo].[tbl_Ruangan] ([id_ruangan], [nama_ruangan], [id_tipe], [id_dokter], [id_jadwal], [status]) VALUES (N'RUANG - 1', N'Ruangan 1', N'TIP - 1', 512612, N'JAD - 1', N'KOSONG')
INSERT [dbo].[tbl_Ruangan] ([id_ruangan], [nama_ruangan], [id_tipe], [id_dokter], [id_jadwal], [status]) VALUES (N'RUANG - 2', N'Ruangan 2', N'TIP - 2', 512351, N'JAD - 2', N'TERISI')
INSERT [dbo].[tbl_Ruangan] ([id_ruangan], [nama_ruangan], [id_tipe], [id_dokter], [id_jadwal], [status]) VALUES (N'RUANG - 3', N'Ruangan 3', N'TIP - 1', 512351, N'JAD - 1', N'KOSONG')
INSERT [dbo].[tbl_tipe] ([id_tipe], [nama]) VALUES (N'TIP - 1', N'Dental')
INSERT [dbo].[tbl_tipe] ([id_tipe], [nama]) VALUES (N'TIP - 2', N'Cosmetic')
INSERT [dbo].[tbl_User] ([id_user], [nama], [jenis_kelamin], [tanggal_lahir], [alamat], [kota], [kodepos], [telepon], [email]) VALUES (51235, N'Ilham Muchammad', N'Laki - laki', CAST(N'1998-06-06' AS Date), N'Jalan kampung Dukuh', N'Jakarta', 13550, N'089630100214', N'ilhammuchammad@gmail.com')
INSERT [dbo].[tbl_User] ([id_user], [nama], [jenis_kelamin], [tanggal_lahir], [alamat], [kota], [kodepos], [telepon], [email]) VALUES (412315, N'Muchammad Ilham', N'Laki - laki', CAST(N'1998-06-06' AS Date), N'Jalan Penggilingan Baru', N'Jakarta', 13550, N'081291665400', N'muh.ilham0606@gmail.com')
ALTER TABLE [dbo].[tbl_Antrian]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Antrian_tbl_Ruangan] FOREIGN KEY([id_ruangan])
REFERENCES [dbo].[tbl_Ruangan] ([id_ruangan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Antrian] CHECK CONSTRAINT [FK_tbl_Antrian_tbl_Ruangan]
GO
ALTER TABLE [dbo].[tbl_Antrian]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Antrian_tbl_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[tbl_User] ([id_user])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Antrian] CHECK CONSTRAINT [FK_tbl_Antrian_tbl_User]
GO
ALTER TABLE [dbo].[tbl_Diagnosa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Diagnosa_tbl_Antrian] FOREIGN KEY([id])
REFERENCES [dbo].[tbl_Antrian] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Diagnosa] CHECK CONSTRAINT [FK_tbl_Diagnosa_tbl_Antrian]
GO
ALTER TABLE [dbo].[tbl_PembayaranDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PembayaranDetail_tbl_Obat] FOREIGN KEY([id_obat])
REFERENCES [dbo].[tbl_Obat] ([id_obat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PembayaranDetail] CHECK CONSTRAINT [FK_tbl_PembayaranDetail_tbl_Obat]
GO
ALTER TABLE [dbo].[tbl_PembayaranDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PembayaranDetail_tbl_PembayaranMaster] FOREIGN KEY([id_pembayaran])
REFERENCES [dbo].[tbl_PembayaranMaster] ([id_pembayaran])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PembayaranDetail] CHECK CONSTRAINT [FK_tbl_PembayaranDetail_tbl_PembayaranMaster]
GO
ALTER TABLE [dbo].[tbl_PembayaranMaster]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PembayaranMaster_tbl_Diagnosa] FOREIGN KEY([id_diagnosa])
REFERENCES [dbo].[tbl_Diagnosa] ([id_diagnosa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PembayaranMaster] CHECK CONSTRAINT [FK_tbl_PembayaranMaster_tbl_Diagnosa]
GO
ALTER TABLE [dbo].[tbl_Ruangan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ruangan_tbl_Dokter] FOREIGN KEY([id_dokter])
REFERENCES [dbo].[tbl_Dokter] ([id_dokter])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Ruangan] CHECK CONSTRAINT [FK_tbl_Ruangan_tbl_Dokter]
GO
ALTER TABLE [dbo].[tbl_Ruangan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ruangan_tbl_Jadwal] FOREIGN KEY([id_jadwal])
REFERENCES [dbo].[tbl_Jadwal] ([id_jadwal])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Ruangan] CHECK CONSTRAINT [FK_tbl_Ruangan_tbl_Jadwal]
GO
ALTER TABLE [dbo].[tbl_Ruangan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ruangan_tbl_tipe] FOREIGN KEY([id_tipe])
REFERENCES [dbo].[tbl_tipe] ([id_tipe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Ruangan] CHECK CONSTRAINT [FK_tbl_Ruangan_tbl_tipe]
GO
USE [master]
GO
ALTER DATABASE [FluorideCareDB] SET  READ_WRITE 
GO

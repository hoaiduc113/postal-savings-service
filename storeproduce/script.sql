USE [master]
GO
/****** Object:  Database [TKBUUDIEN]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE DATABASE [TKBUUDIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TKBUUDIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TKBUUDIEN.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TKBUUDIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TKBUUDIEN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TKBUUDIEN] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TKBUUDIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TKBUUDIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TKBUUDIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TKBUUDIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TKBUUDIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TKBUUDIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TKBUUDIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [TKBUUDIEN] SET  MULTI_USER 
GO
ALTER DATABASE [TKBUUDIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TKBUUDIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TKBUUDIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TKBUUDIEN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TKBUUDIEN', N'ON'
GO
USE [TKBUUDIEN]
GO
/****** Object:  User [NV14      ]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE USER [NV14      ] FOR LOGIN [TUNG] WITH DEFAULT_SCHEMA=[NV14      ]
GO
/****** Object:  User [NV1]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE USER [NV1] FOR LOGIN [DUC] WITH DEFAULT_SCHEMA=[NV1]
GO
/****** Object:  DatabaseRole [quantri]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE ROLE [quantri]
GO
/****** Object:  DatabaseRole [nhanvien]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE ROLE [nhanvien]
GO
ALTER ROLE [nhanvien] ADD MEMBER [NV14      ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NV14      ]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [NV14      ]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [NV14      ]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [NV14      ]
GO
ALTER ROLE [quantri] ADD MEMBER [NV1]
GO
ALTER ROLE [db_owner] ADD MEMBER [NV1]
GO
ALTER ROLE [db_owner] ADD MEMBER [quantri]
GO
ALTER ROLE [db_datareader] ADD MEMBER [nhanvien]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [nhanvien]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [nhanvien]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [nhanvien]
GO
/****** Object:  Schema [NV1]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE SCHEMA [NV1]
GO
/****** Object:  Schema [NV14      ]    Script Date: 7/13/2018 1:24:15 PM ******/
CREATE SCHEMA [NV14      ]
GO
/****** Object:  StoredProcedure [dbo].[baocaodanhsachlaisuat]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[baocaodanhsachlaisuat]
AS
BEGIN
		 SELECT dv.MADV,dv.TENDV ,dv.KYHAN,ds.NGAYAD,ds.LAISUAT
 FROM dbo.DICHVU AS dv
 CROSS APPLY
 ( SELECT TOP 1 NGAYAD,ls.LAISUAT FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND GETDATE()>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
  WHERE GETDATE()>=ds.NGAYAD

END

GO
/****** Object:  StoredProcedure [dbo].[baocaophieuguiquahan]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[baocaophieuguiquahan]
AS
BEGIN
DECLARE @ngayhientai AS DATE
SET @ngayhientai=GETDATE()

SELECT dbo.KHACHHANG.HOTEN,PHIEUGUI.CMND,NGAYGUI,NGAYDENHAN,SOTIEN_GUI,TENDV,LAISUAT 
FROM dbo.PHIEUGUI 
INNER JOIN dbo.KHACHHANG
ON KHACHHANG.CMND = PHIEUGUI.CMND
INNER JOIN dbo.DICHVU
ON DICHVU.MADV = PHIEUGUI.MADV
WHERE NGAYDENHAN<@ngayhientai


END	
GO
/****** Object:  StoredProcedure [dbo].[baocaophieuguitrongkhoangthoigian]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[baocaophieuguitrongkhoangthoigian]
 @thangdau AS VARCHAR(15),
@thangcuoi AS VARCHAR(15)
AS
BEGIN

SELECT dbo.PHIEUGUI.MAPHIEU,dbo.KHACHHANG.HOTEN,dbo.KHACHHANG.CMND,dbo.PHIEUGUI.MADV,dbo.DICHVU.TENDV,dbo.DICHVU.KYHAN,dbo.PHIEUGUI.LAISUAT,dbo.PHIEUGUI.NGAYGUI,dbo.PHIEUGUI.NGAYDENHAN FROM dbo.PHIEUGUI INNER JOIN dbo.KHACHHANG
ON KHACHHANG.CMND = PHIEUGUI.CMND 
INNER JOIN dbo.DICHVU
ON DICHVU.MADV = PHIEUGUI.MADV
WHERE MONTH(dbo.PHIEUGUI.NGAYGUI) BETWEEN @thangdau AND @thangcuoi 
END	
GO
/****** Object:  StoredProcedure [dbo].[baocaotientheotungthang]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[baocaotientheotungthang]
@nam DATE
AS
SELECT SUM(SOTIEN_GUI) AS tongtien,MONTH(NGAYGUI) AS thang
FROM dbo.PHIEUGUI
WHERE YEAR(NGAYGUI) =YEAR(@nam)
GROUP BY MONTH(NGAYGUI)
GO
/****** Object:  StoredProcedure [dbo].[hienthikyhandv]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[hienthikyhandv]
@madv NCHAR(5),
@ngaygui DATE
AS
BEGIN
 SELECT kyhans=dv.KYHAN,ngays=ds.NGAYAD,lai=ds.LAISUAT
 FROM dbo.DICHVU AS dv
 CROSS APPLY
 ( SELECT TOP 1 NGAYAD,ls.LAISUAT FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND @ngaygui>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
  WHERE dv.MADV=@madv AND @ngaygui>=ds.NGAYAD
END	

GO
/****** Object:  StoredProcedure [dbo].[kiemtramadichvu]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[kiemtramadichvu]
@madv NCHAR(5)
AS
BEGIN
	IF EXISTS(SELECT MADV  FROM dbo.DICHVU WHERE MADV=@madv)
	BEGIN
		RETURN 1;
	END
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[kiemtramalaisuat]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[kiemtramalaisuat]
@madv NCHAR(5),
@ngay INT,
@thang INT,
@nam INT
AS
BEGIN
	DECLARE @date INT,
	@month INT,
	@year INT
	SELECT @month =MONTH(NGAYAD),@date=DAY(NGAYAD),@year=YEAR(NGAYAD) FROM dbo.LAISUAT 
	WHERE @month=@thang AND @date=@ngay AND	@year=@nam
	IF	EXISTS(SELECT 1 FROM dbo.LAISUAT WHERE @month=@thang AND @date=@ngay AND @year=@nam AND	MADV=@madv)
	BEGIN
		RETURN 1
	END
END

GO
/****** Object:  StoredProcedure [dbo].[kiemtramaphieugui]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[kiemtramaphieugui]
@maphieu NCHAR(9)
AS
BEGIN
		IF EXISTS(SELECT MAPHIEU FROM dbo.PHIEUGUI WHERE MAPHIEU=@maphieu)
		BEGIN
			RETURN 1;
		END
		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[ktmakhachhang]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ktmakhachhang]
@cmnd NCHAR(13)
AS
BEGIN
IF	EXISTS(SELECT 1 FROM dbo.KHACHHANG WHERE dbo.KHACHHANG.CMND=@cmnd)
	BEGIN
		RETURN 1
	END
 
end
GO
/****** Object:  StoredProcedure [dbo].[ngaydenhan]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ngaydenhan]
 @thang NVARCHAR(14),
 @ngaygui NVARCHAR(100)
 AS
 BEGIN
	DECLARE  @months INT
	SELECT  @months=CAST(@thang AS INT)
	SELECT DATEADD(month,  @months, @ngaygui) AS DateAdd;
 END
  


GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HOTEN FROM GDV  WHERE MAGDV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TaoTaiKhoan]
	@LGNAME VARCHAR(50),--tên của nhân viên đó
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),--lấy mã nhân viên
	
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TKBUUDIEN'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'quantri' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'nhanvien'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  

END
GO
/****** Object:  StoredProcedure [dbo].[thongtinphieurut]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[thongtinphieurut]
@maphieu NCHAR(9)
AS
BEGIN
SELECT dv.TENDV,dv.KYHAN,ph.CMND ,ph.LAISUAT,kh.DIACHI,kh.NGAYCAP,ph.NGAYDENHAN,dv.MADV,ph.SOTIEN_GUI,ph.NGAYGUI
FROM dbo.PHIEUGUI ph 
INNER JOIN dbo.KHACHHANG kh 
ON kh.CMND = ph.CMND 
INNER JOIN dbo.DICHVU dv 
ON dv.MADV = ph.MADV

WHERE ph.MAPHIEU=@maphieu	 
END
GO
/****** Object:  StoredProcedure [dbo].[tinhtienlai]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tinhtienlai]
@madv NCHAR(5),
@maphieugui NCHAR(9),
@ngayrut DATE,
@sotienrut FLOAT

AS
BEGIN
	DECLARE @ngaygui DATE,
	@ngaydenhan DATE,
	@phantram FLOAT,
	@tongsothang DATE,
	@i INT,
	@j INT,
	@tienlai FLOAT, 
	@songayguitien INT,
	@kyhan INT,
	@laisuat FLOAT,
	@tongtiengui FLOAT,	
	@tongtienrut FLOAT,
	@tongkyhan INT,
	@ngaydu DATE,
	@tongsongaydu INT,
	@tongtienlai FLOAT,
	@ngaychia FLOAT,
	@bienloi INT,
	@tongtiencondu FLOAT
	SELECT @ngaygui=NGAYGUI FROM dbo.PHIEUGUI WHERE MAPHIEU=@maphieugui
	SELECT @ngaydenhan=NGAYDENHAN FROM dbo.PHIEUGUI WHERE MAPHIEU=@maphieugui
	SELECT @kyhan=KYHAN FROM dbo.DICHVU WHERE MADV=@madv
	SELECT @tongtienrut=SUM(SOTIEN_RUT) FROM dbo.PHIEURUT WHERE MAPHIEU=@maphieugui 
	SELECT @tongtiengui=SOTIEN_GUI FROM dbo.PHIEUGUI WHERE MAPHIEU=@maphieugui	 
	SET @tienlai=0;
	SET @i=1;
	SET @tongkyhan=0;
	SET @ngaydu=@ngaygui;
	SET @tongtienlai=0
	SET @ngaychia=365
	SET @bienloi=0
	SET @tongtiencondu=0
	SET @tongtiencondu=@tongtiengui-@tongtienrut
	IF(@tongtienrut=@tongtiengui)
	BEGIN
			SET @bienloi=-4
			SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
			RETURN 
	END
    
	IF(@ngayrut <@ngaygui)
	BEGIN
				SET @bienloi=-2
				SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
				RETURN
	end
	IF	 EXISTS( SELECT *  FROM dbo.PHIEURUT WHERE MAPHIEU=@maphieugui)
	BEGIN
			SELECT @tongtienrut=SUM(SOTIEN_RUT) FROM dbo.PHIEURUT WHERE MAPHIEU=@maphieugui
			
	END
	ELSE
	BEGIN
			SET @tongtienrut=0
			
	END
	IF(@sotienrut>@tongtiengui)
	BEGIN
			SET @bienloi=-1
			SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
			RETURN;
	END
	IF (@sotienrut>@tongtiencondu AND @tongtienrut!=0)
	BEGIN
			SET @bienloi=-3
			SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
			RETURN;
	end
	ELSE IF(@tongtienrut<=@tongtiengui)
BEGIN
	IF(@ngayrut<@ngaydenhan OR @kyhan=0)
		BEGIN
			SELECT @songayguitien=DATEDIFF(DAY,@ngaygui,@ngayrut) 
			SELECT @kyhan=dv.KYHAN,@laisuat=ds.LAISUAT
			FROM dbo.DICHVU AS dv
			CROSS APPLY
			( SELECT TOP 1 NGAYAD,ls.LAISUAT,dv.KYHAN  FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND @ngaygui>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
			WHERE dv.KYHAN=0 AND @ngaygui>=ds.NGAYAD
			SET @phantram=(@laisuat/100)
			SET @tienlai=@sotienrut*(@songayguitien/@ngaychia)*@phantram
			SELECT tienlai=@tienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
			RETURN; 
		END
    ELSE IF(@ngayrut=@ngaydenhan)
		BEGIN
					SELECT @kyhan=dv.KYHAN,@laisuat=ds.LAISUAT
					FROM dbo.DICHVU AS dv
					CROSS APPLY
						( SELECT TOP 1 NGAYAD,ls.LAISUAT,dv.KYHAN  FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND @ngaygui>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
					WHERE dv.MADV=@madv AND @ngaygui>=ds.NGAYAD
					SET @phantram=(@laisuat/100)/12
					SET @tienlai=@sotienrut*@phantram*@kyhan
					SELECT tienlai=@tienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
					RETURN;
		END
	ELSE IF	(@ngayrut>@ngaydenhan)
			BEGIN
					WHILE(@i=1)
					BEGIN
								SELECT @kyhan=dv.KYHAN,@laisuat=ds.LAISUAT
								FROM dbo.DICHVU AS dv
								CROSS APPLY
								( SELECT TOP 1 NGAYAD,ls.LAISUAT,dv.KYHAN  FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND @ngaydu>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
								WHERE dv.MADV=@madv AND @ngaydu>=ds.NGAYAD
							
								SET @phantram=((@laisuat/100)/12)*(@kyhan)
						--cộng thêm kỳ hạn
								SET @tongkyhan+=@kyhan
						--cộng thêm tháng
						IF(@ngaydu<@ngayrut)
						BEGIN
								SELECT @ngaydu= DATEADD(MONTH,@tongkyhan,@ngaygui) 
						END	
						IF(@ngaydu>@ngayrut)
						BEGIN
								
								SELECT @ngaydu=DATEADD(MONTH,-@kyhan,@ngaydu)
								BREAK;
						END 		
						--tính tiền 
						IF(@ngayrut>@ngaydu)
						BEGIN
								SET @tienlai=(@tienlai+@sotienrut)*@phantram
								SET @tongtienlai+=@tienlai
						END
						IF(@ngayrut=@ngaydu)
						BEGIN
								SET @tienlai=(@tienlai+@sotienrut)*@phantram
								SET @tongtienlai+=@tienlai
								BREAK;		
						END
                        
							
					END
                    SELECT @tongsongaydu=DATEDIFF(DAY,@ngaydu,@ngayrut)
					--tính tiền lãi ngày dư nếu có 
					IF(@tongsongaydu>0)
					BEGIN
							SELECT @kyhan=dv.KYHAN,@laisuat=ds.LAISUAT
								FROM dbo.DICHVU AS dv
								CROSS APPLY
								( SELECT TOP 1 NGAYAD,ls.LAISUAT,dv.KYHAN  FROM dbo.LAISUAT ls WHERE ls.MADV=dv.MADV  AND @ngaydu>=ls.NGAYAD ORDER BY ls.NGAYAD DESC) AS ds 
								WHERE  dv.KYHAN=0 AND @ngaydu>=ds.NGAYAD
								
							SET @phantram=@laisuat/100
							SET @sotienrut=(@sotienrut+@tongtienlai)*(@tongsongaydu/@ngaychia)*(@phantram)
							SET @tongtienlai+=@sotienrut						
							SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
							RETURN; 
					END
					SELECT tienlai=@tongtienlai,tongtienrut=@tongtienrut,loi=@bienloi,tongtiengui=@tongtiengui,tongtiendarut=@tongtienrut
                    RETURN;
			END
	
				
  END


END	
GO
/****** Object:  StoredProcedure [dbo].[tongtiencotherut]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tongtiencotherut]
@maphieugui NCHAR(9)
AS
BEGIN
		DECLARE @tongtien FLOAT,
		@tongtienrut FLOAT,
		@tongtiencotherut FLOAT
		SELECT @tongtien=SOTIEN_GUI FROM dbo.PHIEUGUI WHERE MAPHIEU=@maphieugui
		IF	 EXISTS( SELECT *  FROM dbo.PHIEURUT WHERE MAPHIEU=@maphieugui)
			BEGIN
					SELECT @tongtienrut=SUM(SOTIEN_RUT) FROM dbo.PHIEURUT WHERE MAPHIEU=@maphieugui
			END
		ELSE
			BEGIN
				SET @tongtienrut=0
			END 
		SET @tongtiencotherut=@tongtien-@tongtienrut
		SELECT tongtiencotherut= @tongtiencotherut		 
end
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MADV] [nchar](5) NOT NULL,
	[KYHAN] [int] NOT NULL,
	[TENDV] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MADV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GDV]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GDV](
	[MAGDV] [nchar](10) NOT NULL,
	[HOTEN] [nvarchar](50) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[CMND] [nchar](15) NOT NULL,
	[SODT] [nchar](12) NULL,
 CONSTRAINT [PK_GDV] PRIMARY KEY CLUSTERED 
(
	[MAGDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Table_2_CMND] UNIQUE NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[HOTEN] [nvarchar](50) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[CMND] [nchar](13) NOT NULL,
	[NGAYCAP] [datetime] NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LAISUAT]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAISUAT](
	[MADV] [nchar](5) NOT NULL,
	[NGAYAD] [date] NOT NULL,
	[LAISUAT] [float] NOT NULL,
 CONSTRAINT [PK_LAISUAT] PRIMARY KEY CLUSTERED 
(
	[MADV] ASC,
	[NGAYAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUGUI]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUGUI](
	[MAPHIEU] [nchar](9) NOT NULL,
	[CMND] [nchar](13) NOT NULL,
	[MADV] [nchar](5) NOT NULL,
	[NGAYGUI] [date] NOT NULL,
	[LAISUAT] [float] NOT NULL,
	[SOTIEN_GUI] [float] NOT NULL,
	[NGAYDENHAN] [date] NOT NULL,
	[MAGDV_LPGUI] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PHIEUGUI] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEURUT]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEURUT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MAPHIEU] [nchar](9) NOT NULL,
	[MAGDV_LPRUT] [nchar](10) NULL,
	[NGAYRUT] [datetime] NOT NULL,
	[SOTIEN_RUT] [float] NOT NULL,
	[TIENLAI] [float] NULL,
 CONSTRAINT [PK_PHIEURUT] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[hienthimadv]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[hienthimadv]
AS
SELECT ten=MADV+TENDV,giatri=MADV FROM dbo.DICHVU

GO
/****** Object:  View [dbo].[hienthimakhachhang]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[hienthimakhachhang]
AS
SELECT ten=HOTEN,giatri=CMND FROM dbo.KHACHHANG
GO
/****** Object:  View [dbo].[hienthimanhanvien]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[hienthimanhanvien]
AS
SELECT ten=HOTEN,giatri=MAGDV FROM dbo.GDV
GO
/****** Object:  View [dbo].[makhachhangphieurut]    Script Date: 7/13/2018 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[makhachhangphieurut]
AS
SELECT ten=HOTEN+'-'+MAPHIEU,giatri=MAPHIEU FROM 
dbo.PHIEUGUI INNER JOIN dbo.KHACHHANG
ON KHACHHANG.CMND = PHIEUGUI.CMND
GO
ALTER TABLE [dbo].[PHIEUGUI] ADD  CONSTRAINT [DF_PHIEUGUI_NGAYGUI]  DEFAULT (getdate()) FOR [NGAYGUI]
GO
ALTER TABLE [dbo].[PHIEUGUI] ADD  CONSTRAINT [DF_PHIEUGUI_SOTIEN_GUI]  DEFAULT ((100000)) FOR [SOTIEN_GUI]
GO
ALTER TABLE [dbo].[PHIEURUT] ADD  CONSTRAINT [DF_PHIEURUT_TIENLAI]  DEFAULT ((0)) FOR [TIENLAI]
GO
ALTER TABLE [dbo].[LAISUAT]  WITH CHECK ADD  CONSTRAINT [FK_LAISUAT_DICHVU1] FOREIGN KEY([MADV])
REFERENCES [dbo].[DICHVU] ([MADV])
GO
ALTER TABLE [dbo].[LAISUAT] CHECK CONSTRAINT [FK_LAISUAT_DICHVU1]
GO
ALTER TABLE [dbo].[PHIEUGUI]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUGUI_DICHVU] FOREIGN KEY([MADV])
REFERENCES [dbo].[DICHVU] ([MADV])
GO
ALTER TABLE [dbo].[PHIEUGUI] CHECK CONSTRAINT [FK_PHIEUGUI_DICHVU]
GO
ALTER TABLE [dbo].[PHIEUGUI]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUGUI_GDV] FOREIGN KEY([MAGDV_LPGUI])
REFERENCES [dbo].[GDV] ([MAGDV])
GO
ALTER TABLE [dbo].[PHIEUGUI] CHECK CONSTRAINT [FK_PHIEUGUI_GDV]
GO
ALTER TABLE [dbo].[PHIEUGUI]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUGUI_KHACHHANG] FOREIGN KEY([CMND])
REFERENCES [dbo].[KHACHHANG] ([CMND])
GO
ALTER TABLE [dbo].[PHIEUGUI] CHECK CONSTRAINT [FK_PHIEUGUI_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEURUT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEURUT_GDV] FOREIGN KEY([MAGDV_LPRUT])
REFERENCES [dbo].[GDV] ([MAGDV])
GO
ALTER TABLE [dbo].[PHIEURUT] CHECK CONSTRAINT [FK_PHIEURUT_GDV]
GO
ALTER TABLE [dbo].[PHIEURUT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEURUT_PHIEUGUI] FOREIGN KEY([MAPHIEU])
REFERENCES [dbo].[PHIEUGUI] ([MAPHIEU])
GO
ALTER TABLE [dbo].[PHIEURUT] CHECK CONSTRAINT [FK_PHIEURUT_PHIEUGUI]
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD  CONSTRAINT [CK_DICHVU_1] CHECK  (([KYHAN]>=(0)))
GO
ALTER TABLE [dbo].[DICHVU] CHECK CONSTRAINT [CK_DICHVU_1]
GO
ALTER TABLE [dbo].[PHIEUGUI]  WITH CHECK ADD  CONSTRAINT [CK_PHIEUGUI] CHECK  (([SOTIEN_GUI]>=(100000)))
GO
ALTER TABLE [dbo].[PHIEUGUI] CHECK CONSTRAINT [CK_PHIEUGUI]
GO
ALTER TABLE [dbo].[PHIEURUT]  WITH CHECK ADD  CONSTRAINT [CK_PHIEURUT] CHECK  (([SOTIEN_RUT]>=(0)))
GO
ALTER TABLE [dbo].[PHIEURUT] CHECK CONSTRAINT [CK_PHIEURUT]
GO
USE [master]
GO
ALTER DATABASE [TKBUUDIEN] SET  READ_WRITE 
GO

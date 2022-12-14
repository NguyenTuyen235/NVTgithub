USE [QLDiem]
GO
/****** Object:  Table [dbo].[ThongTin]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin](
	[tinh] [nvarchar](50) NULL,
	[donViChuQuan] [nvarchar](100) NULL,
	[tenTruong] [nvarchar](100) NULL,
	[khoaHoc] [nvarchar](100) NULL,
	[nganhHoc] [nvarchar](100) NULL,
	[chuyenNganh] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[maHK] [nvarchar](50) NOT NULL,
	[tenHK] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[userName] [nvarchar](100) NOT NULL,
	[passWord] [nvarchar](100) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lops]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lops](
	[maLop] [nvarchar](50) NOT NULL,
	[tenLop] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHP]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHP](
	[maMon] [nvarchar](50) NOT NULL,
	[tenMon] [nvarchar](100) NULL,
	[soTinChi] [smallint] NULL,
	[maHK] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Lops_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[Lops_Update](
		@maLop nvarchar(50),
	@tenLop nvarchar(100)
)
AS
BEGIN
	UPDATE Lops SET tenLop=@tenLop WHERE maLop=@maLop
END
GO
/****** Object:  StoredProcedure [dbo].[Lops_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[Lops_SelectAll]
AS
BEGIN
	SELECT * FROM Lops
END
GO
/****** Object:  StoredProcedure [dbo].[Lops_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[Lops_Insert](
		@maLop nvarchar(50),
		@tenLop nvarchar(100)		
)
AS
BEGIN
	INSERT INTO Lops VALUES (@maLop,@tenLop)
END
GO
/****** Object:  StoredProcedure [dbo].[Lops_Delete]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[Lops_Delete](
	@maLop nvarchar(50)
	
)
AS
BEGIN
	DELETE FROM Lops WHERE maLop=@maLop
END
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HocKy_Update](
	@maHK nvarchar(50),
	@tenHK nvarchar(100)
)
AS
BEGIN
	UPDATE HocKy SET tenHK=@tenHK WHERE maHK=@maHK
END
GO
/****** Object:  StoredProcedure [dbo].[HocKy_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HocKy_SelectAll]
AS
BEGIN
	SELECT * FROM HocKy
END
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HocKy_Insert](
	@maHK nvarchar(50),
	@tenHK nvarchar(100)
)
AS
BEGIN
	INSERT INTO HocKy VALUES(@maHK,@tenHK)
END
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Delete]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HocKy_Delete](
	@maHK nvarchar(50)
)
AS
BEGIN
	DELETE FROM HocKy WHERE maHK=@maHK
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_Update]
	@userName nvarchar(100),
	@passWord nvarchar(100),
	@Quyen nvarchar(50) 
AS
BEGIN
	UPDATE DangNhap SET passWord=@passWord,Quyen=@Quyen WHERE userName=@userName
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_SelectQuyen]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_SelectQuyen]
	@Quyen nvarchar(50) 
AS
BEGIN
	SELECT * FROM DangNhap WHERE Quyen=@Quyen
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_SelectAll]
AS
BEGIN
	SELECT *FROM DangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_Insert]
	@userName nvarchar(100),
	@passWord nvarchar(100),
	@Quyen nvarchar(50) 
AS
BEGIN
	INSERT INTO DangNhap VALUES (@userName,@passWord,@Quyen)
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_Delete]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_Delete]
	@userName nvarchar(100) 
AS
BEGIN
	DELETE FROM DangNhap WHERE userName=@userName
END
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSV] [nvarchar](50) NOT NULL,
	[hoTen] [nvarchar](100) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[noiSinh] [nvarchar](100) NULL,
	[danToc] [nvarchar](100) NULL,
	[maLop] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongTin_Update](
	@tinh nvarchar (50),
	@donViChuQuan nvarchar(100),
	@tenTruong nvarchar(100),
	@khoaHoc nvarchar(100),
	@nganhHoc nvarchar(100),
	@chuyenNganh nvarchar(100)
)
AS
BEGIN
	UPDATE ThongTin SET tinh=@tinh,donViChuQuan=@donViChuQuan,tenTruong=@tenTruong,
	khoaHoc=@khoaHoc,nganhHoc=@nganhHoc,chuyenNganh=@chuyenNganh
END
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongTin_SelectAll]
AS
BEGIN
	SELECT * FROM ThongTin
END
GO
/****** Object:  Table [dbo].[DiemHP]    Script Date: 04/27/2017 19:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemHP](
	[maSV] [nvarchar](50) NOT NULL,
	[maMon] [nvarchar](50) NOT NULL,
	[diemLan1] [float] NULL,
	[diemLan2] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_Update](
	@maSV nvarchar(50),
	@hoTen nvarchar(100),
	@ngaySinh date,
	@gioiTinh nvarchar(50),
	@noiSinh nvarchar(100),
	@danToc nvarchar(100)	
)
AS
BEGIN
	UPDATE SinhVien SET hoTen=@hoTen,ngaySinh=@ngaySinh,gioiTinh=@gioiTinh,
	noiSinh=@noiSinh,danToc=@danToc WHERE maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectMaLop]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectMaLop](
@maLop nvarchar(50)
)
AS
BEGIN
	SELECT *FROM SinhVien WHERE maLop=@maLop
END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectID]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectID](
	@maSV nvarchar(50)
)
AS
BEGIN
	SELECT * FROM SinhVien WHERE maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectAll]
AS
BEGIN
	SELECT * FROM SinhVien
END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Search]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_Search](
	@hoTen nvarchar(100),
	@maLop nvarchar(50)
)
AS
BEGIN
	SELECT * FROM SinhVien WHERE hoTen LIKE '%@hoTen%' AND maLop=@maLop
END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_Insert](
	@maSV nvarchar(50),
	@hoTen nvarchar(100),
	@ngaySinh date,
	@gioiTinh nvarchar(50),
	@noiSinh nvarchar(100),
	@danToc nvarchar(100),
	@maLop nvarchar(50)
	
)
AS
BEGIN
	INSERT INTO SinhVien
	VALUES (@maSV,@hoTen,@ngaySinh,@gioiTinh,@noiSinh,@danToc,@maLop)
	END
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Delete]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_Delete](
	@maSV nvarchar(50)
)
AS
BEGIN
	DELETE FROM SinhVien
	WHERE maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Update]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[MonHP_Update](
	@maMon nvarchar(50),
	@tenMon nvarchar(100),
	@soTinChi smallint
)
AS
BEGIN
	UPDATE MonHP SET tenMon=@tenMon,soTinChi=@soTinChi WHERE maMon=@maMon
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectMaHK]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MonHP_SelectMaHK](
	@maHK nvarchar(50)
)
AS
BEGIN
	SELECT * FROM MonHP WHERE maHK=@maHK
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectAll]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[MonHP_SelectAll] 
AS
BEGIN
	SELECT * FROM MonHP
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MonHP_Insert](
	@maMon nvarchar(50),
	@tenMon nvarchar(100),
	@soTinChi smallint,
	@maHK nvarchar(50)
)
AS
BEGIN
	INSERT INTO MonHP VALUES (@maMon,@tenMon,@soTinChi,@maHK)
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Delete]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MonHP_Delete](
	@maMon nvarchar(50)
)
AS
BEGIN
	DELETE FROM MonHP WHERE maMon=@maMon
END
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_UpdateLan2]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DiemHP_UpdateLan2](
	@diemLan2 float,
	@maMon nvarchar(50),
	@maSV nvarchar(50)
)
AS
BEGIN
	UPDATE DiemHP SET diemLan2=@diemLan2 WHERE maMon=@maMon AND maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_UpdateLan1]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DiemHP_UpdateLan1](
	@diemLan1 float,
	@maMon nvarchar(50),
	@maSV nvarchar(50)
)
AS
BEGIN
	UPDATE DiemHP SET diemLan1=@diemLan1 WHERE maMon=@maMon AND maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Search]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DiemHP_Search](
	@maMon nvarchar(50),
	@maSV nvarchar(50)
)
AS
BEGIN
	SELECT * FROM DiemHP WHERE maMon=@maMon AND maSV=@maSV
END
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Insert]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DiemHP_Insert](
	@maMon nvarchar(50),
	@maSV nvarchar(50)
)
AS
BEGIN
	INSERT INTO DiemHP(maMon,maSV) VALUES(@maMon,@maSV)
END
GO
/****** Object:  StoredProcedure [dbo].[BangDiemHP]    Script Date: 04/27/2017 19:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BangDiemHP](
	@maLop nvarchar(50),
	@maMon nvarchar(50)
)
AS
BEGIN
	SELECT SinhVien.maSV,SinhVien.hoTen,SinhVien.ngaySinh,
	DiemHP.diemLan1,DiemHP.diemLan2
	FROM SinhVien INNER JOIN DiemHP ON SinhVien.maSV=DiemHP.maSV
	WHERE SinhVien.maLop=@maLop AND DiemHP.maMon=@maMon
END
GO
/****** Object:  ForeignKey [FK_DiemMonHP]    Script Date: 04/27/2017 19:11:28 ******/
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD  CONSTRAINT [FK_DiemMonHP] FOREIGN KEY([maMon])
REFERENCES [dbo].[MonHP] ([maMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DiemHP] CHECK CONSTRAINT [FK_DiemMonHP]
GO
/****** Object:  ForeignKey [FK_DiemSV]    Script Date: 04/27/2017 19:11:28 ******/
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD  CONSTRAINT [FK_DiemSV] FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DiemHP] CHECK CONSTRAINT [FK_DiemSV]
GO
/****** Object:  ForeignKey [FK_HKMonHP]    Script Date: 04/27/2017 19:11:28 ******/
ALTER TABLE [dbo].[MonHP]  WITH CHECK ADD  CONSTRAINT [FK_HKMonHP] FOREIGN KEY([maHK])
REFERENCES [dbo].[HocKy] ([maHK])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MonHP] CHECK CONSTRAINT [FK_HKMonHP]
GO
/****** Object:  ForeignKey [FK_LopSinhVien]    Script Date: 04/27/2017 19:11:28 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_LopSinhVien] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lops] ([maLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_LopSinhVien]
GO

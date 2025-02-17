USE [QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[MaBaoCaoTon] [varchar](10) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [Nam]) VALUES (N'BCT001', 1, 2020)
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [Nam]) VALUES (N'BCT002', 2, 2020)
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [Nam]) VALUES (N'BCT003', 3, 2020)
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [Nam]) VALUES (N'BCT004', 2, 2020)
/****** Object:  Table [dbo].[BAOCAOCONGNO]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAOCAOCONGNO](
	[MaBaoCaoCongNo] [varchar](10) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoCongNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [Nam]) VALUES (N'BCCN001', 2, 2020)
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [Nam]) VALUES (N'BCCN002', 3, 2020)
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [Nam]) VALUES (N'BCCN003', 4, 2020)
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 01/07/2021 09:40:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK 
			END 
				SET @COUNTER1 = @COUNTER1 +1 
		END 
				SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO
/****** Object:  Table [dbo].[PHIEUNHAPSACH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAPSACH](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[NgayNhap] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [NgayNhap]) VALUES (N'PN001', N'01/01/2020')
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [NgayNhap]) VALUES (N'PN002', N'01/02/2020')
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [NgayNhap]) VALUES (N'PN003', N'01/03/2020')
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [NgayNhap]) VALUES (N'PN004', N'03/01/2021')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](90) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
	[DiaChi] [nvarchar](90) NOT NULL,
	[TienNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH001', N'Nguyễn Anh Khoa', N'khoa188@gmail.com', N'0927364591', N'236/78 Cách Mạng Tháng 8, Quận 10, TP Hồ Chí Minh', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH002', N'Lê Hoàn', N'hoanle001@gmail.com', N'0726482918', N'33/8 Vạn Kiếp, Quận 8, TP Hồ Chí Minh', 13000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH003', N'Trần Nguyễn Hoàng Anh', N'hoanhanh@gmail.com', N'0183654726', N'123 Cây Keo, Thủ Đức, TP Hồ Chí Minh', 15000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH004', N'Hoàng Quốc Diệp Huỳnh', N'huynhcute@gmail.com', N'0372891998', N'187/90 Vạn Kiếp, Quận 8, TP Hồ Chí Minh', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH005', N'Nguyễn Ngọc Trinh', N'trinhnguyen@gmail.com', N'0284581749', N'78 An Phú, Quận 2, TP Hồ Chí Minh', 20000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH006', N'Lê Bá Thức', N'bathuc@gmail.com', N'0927348651', N'79/70A Nguyễn Phúc Nguyên, Quận 3, TP Hồ Chí Minh', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH007', N'Nguyễn Thị Thủy Tiên', N'tiendepgai@gmail.com', N'0737297461', N'227/3 Trần Phú, Quận 5, TP Hồ Chí Minh', 12000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH008', N'Nguyễn Bảo Trâm', N'baotramchua18@gmail.com', N'0918372661', N'90/90A Nguyễn Thị Minh Khai, Quận 1, TP Hồ Chí Minh', 10000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH009', N'Nguyễn Anh Thư', N'anhthu@gmail.com', N'0991827429', N'12/90 Nguyễn Xuân Phụng, Quận 6, TP Hồ Chí Minh', 90000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [Email], [SDT], [DiaChi], [TienNo]) VALUES (N'KH010', N'Trần Đức Công', N'congtran@gmail.com', N'0981827382', N'99/8 Phan Ích Khiêm Quận 7, TP Hồ Chí Minh', 0)
/****** Object:  Table [dbo].[SACH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[TacGia] [nvarchar](50) NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS001', N'Kính Vạn Hoa - Trọn bộ', N'Truyện Ngắn', N'Nguyễn Nhật Ánh', 342, 300000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS002', N'Hoa Thiên Cốt - Trọn bộ', N'Tiểu Thuyết', N'Fresh Quả Quả', 288, 240000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS003', N'Narnia - Trọn bộ', N'Sách Lịch Sử', N'Clive Staples Lewis', 397, 220000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS004', N'Truyện Kiều', N'Sách Văn Học', N'Nguyễn Du', 349, 40000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS005', N'Another - Trọn bộ 2 tập', N'Sách Văn Học - Truyện Ngắn - Tiểu Thuyết', N'Ayatsuji Yukito-Kadokawa Shoten', 294, 160000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS006', N'5 Centimet trên giây', N'Sách Văn Học - Truyện Ngắn - Tiểu Thuyết', N'Shinkai Makoto', 297, 50000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS007', N'Hỏa Ngục', N'Tiểu Thuyết', N' Dan Brown', 143, 248000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS008', N'Mật mã Da Vinci', N'Tiểu Thuyết', N' Dan Brown', 147, 222000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS009', N'Thiên thần và ác quỷ', N'Tiểu Thuyết', N'Dan Brown', 394, 212000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS010', N'Pháo đài số', N'Tiểu Thuyết', N'Dan Brown', 145, 204000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS011', N'Sword Art Online: Aincrad - Tập 1', N'Tiểu Thuyết', N'Kawahara Reki', 146, 96000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS012', N'Ma sói', N'Kinh Dị', N'Iwasaki Natsumi', 148, 98000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS013', N'Daren Shan - Trọn Bộ', N'Truyện Ngắn', N' Darren O-Shaughnessy', 150, 212000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS014', N'Sherlock Holmes - Trọn bộ', N'Trinh Thám', N'Conan Doyle', 148, 270000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS015', N'Bài học yêu của tiểu ma vương', N'Truyện Ngắn', N'Minh Nguyệt', 150, 110000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS016', N'Đấu phá thương khung', N'Võ Hiệp', N'Doupo Cangqiong', 150, 420000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS017', N'Đại chúa tể', N'Truyện Tranh', N'Thiên Tàm Thổ Đậu', 150, 450000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS018', N'Đấu la đại lục', N'Huyễn Hiệp', N'Đấu La Đại Lục', 150, 210000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS019', N'Đế bá', N'Truyện Tranh', N'Yếm Bút Tiêu Sinh', 149, 520000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS020', N'Vệ sĩ thần cấp của nữ tổng giám đốc', N'Truyện Tranh', N'Mai Can Thái Thiếu Bính', 342, 300000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS021', N'Doraemon: Chú khủng long của Nobita', N'Truyện Tranh', N'Fujiko F. Fujio', 150, 20000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS022', N'Yêu cung', N'Truyện Tranh', N'Minh Nguyệt', 150, 366000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS023', N'Sword Art Online: Aincrad - Tập 2', N'Tiểu Thuyết', N'Kawahara Reki', 149, 96000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS024', N'Bộ sách giáo khoa lớp 9', N'Sách Giáo Khoa', N'Nhiều tác giả', 149, 106000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS025', N'Bộ vở bài tập lớp 9', N'Sách Giáo Khoa', N'Nhiều tác giả', 149, 72000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS026', N'Nấu ăn bằng cả trái tim', N'Truyện Ngắn', N'Christine Hà', 150, 82000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS027', N'Tài liệu luyện thi năng lực Nhật ngữ N5 (Kèm CD)', N'Sách Học Ngoại Ngữ', N'Nhiều tác giả', 150, 50000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS028', N'Chúa tể những chiếc nhẫn: Đoàn hộ nhẫn', N'Tiểu Thuyết', N'J. R. R. Tolkie', 149, 180000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS029', N'Chúa tể những chiếc nhẫn: Hai tòa tháp', N'Tiểu Thuyết', N'J. R. R. Tolkie', 149, 180000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS030', N'Chúa tể những chiếc nhẫn: Nhà vua trở về', N'Tiểu Thuyết', N'J. R. R. Tolkie', 149, 180000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS031', N'Doraemon: Vương quốc trên mây', N'Truyện Tranh', N'Fujiko F. Fujio', 149, 10000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS032', N'Sach-32', N'theloai32', N'tacgia32', 248, 20000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS033', N'Sach-33', N'theloai33', N'tacgia33', 59, 30000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS034', N'Sach-34', N'theloai34', N'tacgia34', 160, 40000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGiaBan]) VALUES (N'MS035', N'Sach-35', N'theloai35', N'tacgia35', 160, 50000)
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[SoLuongNhapToiThieu] [int] NOT NULL,
	[SoLuongTonToiThieuDeNhap] [int] NOT NULL,
	[TienNoToiDa] [int] NOT NULL,
	[SoLuongTonToiThieuSauKhiBan] [int] NOT NULL,
	[DuocThuVuotSoTienKhachHangDangNo] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[QUYDINH] ([SoLuongNhapToiThieu], [SoLuongTonToiThieuDeNhap], [TienNoToiDa], [SoLuongTonToiThieuSauKhiBan], [DuocThuVuotSoTienKhachHangDangNo]) VALUES (150, 300, 20000, 20, 0)
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[MaPhieuThuTien] [varchar](10) NOT NULL,
	[MaKhachHang] [varchar](10) NOT NULL,
	[NgayThuTien] [varchar](20) NULL,
	[SoTienThu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT001', N'KH001', N'19/02/2020', 3408000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT002', N'KH002', N'23/04/2020', 1720000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT003', N'KH003', N'11/05/2020', 80000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT004', N'KH004', N'10/08/2020', 126000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT005', N'KH005', N'21/10/2020', 424000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT006', N'KH006', N'29/09/2020', 523000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT007', N'KH007', N'21/11/2020', 992000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT008', N'KH008', N'12/12/2020', 222000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT009', N'KH009', N'21/12/2020', 270000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThuTien], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (N'PT010', N'KH010', N'30/12/2020', 204000)
/****** Object:  Table [dbo].[CHITIETBAOCAOTON]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAOTON](
	[MaBaoCaoTon] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[SoLuongTonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[SoLuongTonCuoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS001', 342, 1, 341)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS002', 288, 0, 288)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS003', 147, 0, 147)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS004', 149, 0, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS005', 294, 0, 294)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS006', 297, 0, 297)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS007', 143, 5, 138)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS008', 148, 0, 148)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS009', 394, 4, 390)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT001', N'MS010', 145, 5, 140)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS011', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS012', 147, 0, 147)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS013', 149, 0, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS014', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS015', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS016', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS017', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS018', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS019', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT002', N'MS020', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS021', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS022', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS023', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS024', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS025', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS026', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS027', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS028', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS029', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS030', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT003', N'MS031', 150, 0, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT004', N'MS001', 342, 1, 341)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT004', N'MS007', 143, 5, 138)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT004', N'MS009', 394, 4, 390)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [SoLuongTonDau], [PhatSinh], [SoLuongTonCuoi]) VALUES (N'BCT004', N'MS010', 145, 5, 140)
/****** Object:  Table [dbo].[CHITIETBAOCAOCONGNO]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAOCONGNO](
	[MaBaoCaoCongNo] [varchar](10) NOT NULL,
	[MaKhachHang] [varchar](10) NOT NULL,
	[SoNoDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[SoNoCuoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoCongNo] ASC,
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH001', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH002', 13000, 0, 13000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH003', 15000, 0, 15000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH004', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH005', 20000, 0, 20000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH006', 14000, 0, 14000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH007', 12000, 0, 12000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH008', 10000, 0, 10000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH009', 10000, 0, 10000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN001', N'KH010', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH001', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH002', 9000, 0, 9000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH003', 7000, 0, 7000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH004', 20000, 0, 20000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH005', 9000, 0, 9000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH006', 9000, 0, 9000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH007', 2000, 0, 2000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH008', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH009', 10000, 0, 10000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN002', N'KH010', 15000, 0, 15000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH001', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH002', 15000, 0, 15000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH003', 7000, 0, 7000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH004', 2000, 0, 2000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH005', 9000, 0, 9000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH006', 9000, 0, 9000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH007', 2000, 0, 2000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH008', 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH009', 10000, 0, 10000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [SoNoDau], [PhatSinh], [SoNoCuoi]) VALUES (N'BCCN003', N'KH010', 0, 0, 0)
/****** Object:  StoredProcedure [dbo].[updateSoLuongTonSauKhiNhap]    Script Date: 01/07/2021 09:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE
proc [dbo].[updateSoLuongTonSauKhiNhap](@masach varchar(15), @soluongnhap int)
as
begin
	declare @soluongnhapMoi int
	select @soluongnhapMoi = s.SoLuongTon + @soluongnhap
	from SACH s
	where s.MaSach = @masach
	update SACH set SoLuongTon = @soluongnhapMoi where MaSach = @masach
end
GO
/****** Object:  StoredProcedure [dbo].[updateSoLuongTonSauKhiBanKhongThanhCong]    Script Date: 01/07/2021 09:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSoLuongTonSauKhiBanKhongThanhCong](@masach varchar(15), @soluongdaban int)
as 
begin
	declare @soluongtonMoi int
	select @soluongtonMoi = SoLuongTon + @soluongdaban
	from SACH
	where MaSach = @masach
	update SACH set SoLuongTon = @soluongtonMoi where MaSach = @masach
end
GO
/****** Object:  StoredProcedure [dbo].[updateSoLuongTonSauKhiBan]    Script Date: 01/07/2021 09:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create 
--alter
proc [dbo].[updateSoLuongTonSauKhiBan](@masach varchar(15), @soluongdaban int)
as
begin
	declare @soluongtonMoi int
	select @soluongtonMoi = SoLuongTon - @soluongdaban
	from SACH
	where MaSach = @masach
	update SACH set SoLuongTon = @soluongtonMoi where MaSach = @masach
end
GO
/****** Object:  Table [dbo].[HOADONBANSACH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADONBANSACH](
	[MaHoaDon] [varchar](10) NOT NULL,
	[NgayLapHoaDon] [varchar](15) NULL,
	[MaKhachHang] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD001', N'19/02/2020', N'KH001')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD002', N'23/04/2020', N'KH002')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD003', N'11/05/2020', N'KH003')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD004', N'10/08/2020', N'KH004')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD005', N'21/10/2020', N'KH005')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD006', N'29/09/2020', N'KH006')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD007', N'21/11/2020', N'KH007')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD008', N'12/12/2020', N'KH008')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD009', N'21/12/2020', N'KH009')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD010', N'30/12/2020', N'KH010')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD011', N'03/01/2021', N'KH001')
INSERT [dbo].[HOADONBANSACH] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'HD012', N'05/01/2021', N'KH001')
/****** Object:  Table [dbo].[CHITIETPHIEUNHAPSACH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAPSACH](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN001', N'MS001', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN001', N'MS002', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN001', N'MS003', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN001', N'MS004', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN001', N'MS005', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS006', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS019', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS021', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS022', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS023', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS027', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN002', N'MS029', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS010', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS011', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS013', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS015', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS016', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN003', N'MS030', 150)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN004', N'MS003', 250)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN004', N'MS004', 200)
INSERT [dbo].[CHITIETPHIEUNHAPSACH] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'PN004', N'MS009', 250)
/****** Object:  Table [dbo].[CHITIETHOADONBANSACH]    Script Date: 01/07/2021 09:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADONBANSACH](
	[MaHoaDon] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD001', N'MS001', 1, 300000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD001', N'MS007', 5, 248000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD001', N'MS009', 4, 212000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD001', N'MS010', 5, 204000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD002', N'MS001', 5, 300000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD002', N'MS003', 1, 22000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD003', N'MS004', 2, 40000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD004', N'MS005', 1, 160000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD005', N'MS009', 2, 212000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD006', N'MS030', 3, 180000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD007', N'MS019', 4, 248000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD008', N'MS020', 1, 222000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD009', N'MS014', 1, 270000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD010', N'MS010', 1, 204000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD011', N'MS034', 90, 40000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD011', N'MS035', 90, 50000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD012', N'MS032', 2, 2000)
INSERT [dbo].[CHITIETHOADONBANSACH] ([MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (N'HD012', N'MS033', 1, 3000)
/****** Object:  UserDefinedFunction [dbo].[tinhSoTienPhaiThu]    Script Date: 01/07/2021 09:40:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create 
--alter
function [dbo].[tinhSoTienPhaiThu](@mahd varchar(15), @makh varchar(15))
returns int
as
begin
	declare @sotienphaithu int
	select @sotienphaithu = sum(ct.SoLuongBan * ct.DonGiaBan) 
	from CHITIETHOADONBANSACH ct, KHACHHANG kh join HOADONBANSACH hd on kh.MaKhachHang = hd.MaKhachHang
	where (ct.MaHoaDon = @mahd) and (kh.MaKhachHang = @makh) and (ct.MaHoaDon = hd.MaHoaDon)
	return @sotienphaithu
end
GO
/****** Object:  UserDefinedFunction [dbo].[thanhToanTienNoChoKhachHang]    Script Date: 01/07/2021 09:40:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create 
--alter
function [dbo].[thanhToanTienNoChoKhachHang](@mahd varchar(15), @makh varchar(15))
returns int
as
begin
		declare @sotienphaithu int
		declare @sotiennocuakh int, @tongtiencuahoadon int
		-- lấy số tiền nợ của khách hàng
		select @sotiennocuakh = KHACHHANG.TienNo 
		from KHACHHANG where MaKhachHang = @makh
		-- lấy tổng số tiền hóa đơn của khách hàng
		select @tongtiencuahoadon = sum(cthd.SoLuongBan * cthd.DonGiaBan)
		from CHITIETHOADONBANSACH cthd
		where cthd.MaHoaDon = @mahd
		-- số tiền phải thu = tổng tiền hóa đơn - số tiền đang nợ
		set @sotienphaithu = @tongtiencuahoadon - @sotiennocuakh
		return @sotienphaithu
end
GO
/****** Object:  ForeignKey [FK__CHITIETBA__MaBao__656C112C]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO]  WITH CHECK ADD FOREIGN KEY([MaBaoCaoCongNo])
REFERENCES [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo])
GO
/****** Object:  ForeignKey [FK__CHITIETBA__MaKha__66603565]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
/****** Object:  ForeignKey [FK__CHITIETBA__MaBao__6383C8BA]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETBAOCAOTON]  WITH CHECK ADD FOREIGN KEY([MaBaoCaoTon])
REFERENCES [dbo].[BAOCAOTON] ([MaBaoCaoTon])
GO
/****** Object:  ForeignKey [FK__CHITIETBA__MaSac__6477ECF3]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETBAOCAOTON]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
/****** Object:  ForeignKey [FK__CHITIETHO__MaHoa__619B8048]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETHOADONBANSACH]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADONBANSACH] ([MaHoaDon])
GO
/****** Object:  ForeignKey [FK__CHITIETPH__MaPhi__60A75C0F]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAPSACH]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap])
GO
/****** Object:  ForeignKey [FK__CHITIETPH__MaSac__5FB337D6]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAPSACH]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
/****** Object:  ForeignKey [FK__HOADONBAN__MaKha__628FA481]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[HOADONBANSACH]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_KHACHHANG]    Script Date: 01/07/2021 09:40:54 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO

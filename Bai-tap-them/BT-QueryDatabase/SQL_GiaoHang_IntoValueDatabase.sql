USE QL_GIAOHANG
GO

-- 1. Nhập data Nhân viên
INSERT INTO NHANVIEN(MANHANVIEN, HO, TEN, NGAYSINH, NGAYLAMVIEC, DIACHI, DIENTHOAI, LUONGCOBAN, PHUCAP)
VALUES	(1, N'Nguyễn Văn ', N'Tài','1993-05-16','2015-08-21',N'31 Phan Chu Trinh, TP Huế', '0903123234', 8000000, 1000000),
		(2, N'Nguyễn Thị ', N'Hằng','1990-09-25','2014-03-15',N'6 Nguyễn Trãi, TP Huế', '0344523759', 10000000, 500000),
		(3, N'Trần Đức ', N'Tiến','1985-02-09','2010-11-27',N'123 An Dương Vương, TP Huế', '0909678999', 15000000, 0),
		(4, N'Hồ Văn ', N'Dũng','1987-02-09','2015-07-19',N'9 Hàn Mặc Tử, TP Huế', '0703445177', 8000000, 500000),
		(5, N'Lê Thị ', N'Thảo','1989-10-19','2010-05-05',N'8 Lê Lợi, TP Huế', '0707889999', 18000000, 500000)

-- 2. Nhập data Khách hàng
INSERT INTO KHACHHANG(MAKHACHHANG, TENCONGTY, TENGIAODICH, DIACHI, EMAIL, DIENTHOAI, FAX)
VALUES	(1, N'Tân Đại Phát', 'TDP',N'54 Hùng Vương,TP Huế','tandaiphat@gmail.com','0234-3123123', '+84 (24) 57719999'),
		(2, N'Quyết Đại Thắng', 'QDT',N'12 Hoàng Hoa Thám,TP Huế','quyetdaithang@gmail.com','0234-3551446', '+84 (24) 22135588'),
		(3, N'Đại Toàn Thắng', 'DTT',N'89 Trần Nguyên Đán,TP Huế','daitoanthang@gmail.com','0234-3552389', '+84 (24) 44189234'),
		(4, N'Nhất Tiến', 'NT',N'136 An Dương Vương,TP Huế','nhattien@gmail.com','0234-3583461', '+84 (24) 65751877'),
		(5, N'Đại Toàn Nhất', 'DTN',N'9 Nguyễn Huệ,TP Huế','daitoannhat@gmail.com','0234-3588466', '+84 (24) 71955222'),
		(6, N'Vinh Phát', 'VP',N'67 Bạch Đằng,TP Huế','vinhphat@gmail.com','0234-3876666', '+84 (24) 23445566'),
		(7, N'Định Tiến', 'DT',N'100 Nguyễn Tất Thành,TP Huế','dinhtien@gmail.com','0234-3533267', '+84 (24) 3315489'),
		(8, N'Thắng Lợi', 'TL',N'17 Dạ Lê,TP Huế','thangloi@gmail.com','0234-3557123', '+84 (24) 45346789'),
		(9, N'Nhân Tâm', 'NTM',N'103 Nguyễn Phúc Nguyên,TP Huế','nhantam@gmail.com','0234-3599644', '+84 (24) 77342888'),
		(10, N'Việt Tiến', 'VT',N'88 Bùi Thị Xuân, TP Huế','viettien@gmail.com','0234-3543221', '+84 (24) 25286977')
-- 3. Nhập data Nhà cung cấp
INSERT INTO NHACUNGCAP(MACONGTY, TENCONGTY, TENGIAODICH, DIACHI, EMAIL, DIENTHOAI, FAX)
VALUES	(1, N'Vinamilk', 'VNM',N'22 Phạm Ngũ Lão, Hà Nội','vinamilk@gmail.com','0333-3532444', '+84 (55) 345337846'),
		(2, N'Kokomi', 'KKM',N'79 Quang Trung, TP Hồ Chí Minh','kokomi@gmail.com','0333-5234623', '+84 (11) 77823465'),
		(3, N'Huda Huế', 'HDH',N'125 Lý Tự Trọng, TP Huế','hudahue@gmail.com','0234-3555555', '+84 (24) 55667788'),
		(4, N'Việt Tiến', 'VT',N'88 Bùi Thị Xuân, TP Huế','viettien@gmail.com','0234-3543221', '+84 (24) 25286977')
-- 4. Nhập data Loại hàng
INSERT INTO LOAIHANG(MALOAIHANG, TENLOAIHANG)
VALUES	(1, N'Sữa tươi'),
		(2, N'Thực phẩm'),
		(3, N'Nước giải khát')
-- 5. Nhập data Mặt hàng
INSERT INTO MATHANG(MAHANG, TENHANG, MACONGTY, MALOAIHANG, SOLUONG, DONVITINH, GIAHANG)
VALUES	(1, N'Sữa hộp XYZ', 1, 1, 5000, N'Thùng', 257000),
		(2, N'Mỳ tôm chua cay', 2, 2, 10000, N'Thùng', 67000),
		(3, N'Bia lon Huda', 3, 3, 10000, N'Thùng', 225000),
		(4, N'Sữa hộp ABC', 1, 1, 10000, N'Thùng', 210000),
		(5, N'Sữa hộp F++', 1, 1, 40, N'Thùng', 123000),
		(6, N'Nước ngọt', 4, 3, 7000, N'Két', 65000)
-- 6. Nhập data Đơn dặt hàng 
INSERT INTO DONDATHANG(SOHOADON, MAKHACHHANG, MANHANVIEN, NGAYDATHANG, NGAYGIAOHANG, NGAYCHUYENHANG, NOIGIAOHANG)
VALUES	(1, 5, 4, '2018-07-18', '2018-07-28', '2018-07-22', N'9 Nguyễn Huệ,TP Huế'),
		(2, 2, 2, '2018-09-10', '2018-09-20', '2018-09-15', N'12 Hoàng Hoa Thám,TP Huế'),
		(3, 4, 1, '2018-11-21', '2018-12-01', '2018-11-27', N'136 An Dương Vương,TP Huế'),
		(4, 1, 1, '2019-02-02', '2019-02-12', '2019-02-07', N'54 Hùng Vương,TP Huế'),
		(5, 6, 3, '2019-05-30', '2019-06-10', '2019-06-05', N'67 Bạch Đằng,TP Huế'),
		(6, 6, 4, '2019-10-10', '2019-10-20', '2019-10-15', N'24 Đống Đa,TP Huế'),
		(7, 6, 1, '2019-11-22', '2019-10-20', '2019-10-15', N'258 Lê Duẩn,TP Huế'),
		(8, 6, 1, '2019-11-25', '2019-11-25', NULL, N'258 Lê Duẩn,TP Huế'),
		(9, 6, 1, '2019-12-20', '2019-12-30', '2019-12-25', NULL)
-- 7. Nhập data Chi tiết đặt hàng
INSERT INTO CHITIETDATHANG(SOHOADON, MAHANG, GIABAN, SOLUONG, MUCGIAMGIA)
VALUES	(1, 3, 230000, 2000, 0.1),
		(2, 2, 70000, 3000, 0.05),
		(3, 1, 260000, 1000, 0),
		(4, 1, 260000, 3000, 0.05),
		(5, 2, 70000, 6000, 0.15),
		(6, 6, 70000, 4000, 0.15),
		(7, 6, 70000, 1000, 0)
------------- TẠO CÁC BẢNG TRONG DATABASE THUCTAP -------------

CREATE DATABASE QL_THUCTAP
GO

USE QL_THUCTAP
GO

CREATE TABLE Khoa(
MaKhoa VARCHAR(10) NOT NULL,
TenKhoa VARCHAR(30) NOT NULL,
DienThoai VARCHAR(10) NOT NULL
CONSTRAINT PK_MaKhoa PRIMARY KEY (MaKhoa)
)
GO

CREATE TABLE GiangVien(
MaGV INT NOT NULL,
HoTenGV VARCHAR(30) NOT NULL,
Luong DECIMAL(5,2) NOT NULL,
MaKhoa VARCHAR(10) NOT NULL
CONSTRAINT PK_MaGV PRIMARY KEY (MaGV)
CONSTRAINT FK_MaKhoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)
GO

CREATE TABLE SinhVien(
MaSV INT NOT NULL,
HoTenSV VARCHAR(30) NOT NULL,
MaKhoa VARCHAR(10) NOT NULL,
NamSinh INT NOT NULL,
QueQuan VARCHAR(30) NOT NULL
CONSTRAINT PK_MaSV PRIMARY KEY (MaSV)
CONSTRAINT FK_MaKhoa_SV FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)
GO

CREATE TABLE DeTai(
MaDT VARCHAR(10) NOT NULL,
TenDT VARCHAR(30) NOT NULL,
KinhPhi INT NOT NULL,
NoiThucTap VARCHAR(30) NOT NULL
CONSTRAINT PK_MaDT PRIMARY KEY (MaDT)
)
GO

CREATE TABLE HuongDan(
MaSV INT NOT NULL,
MaDT VARCHAR(10) NOT NULL,
MaGV INT NOT NULL,
KetQua DECIMAL(5,2) NOT NULL
CONSTRAINT PK_HuongDan PRIMARY KEY (MaSV,MaDT,MaGV)
CONSTRAINT FK_MaSV_HD FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
CONSTRAINT FK_MaDT_HD FOREIGN KEY (MaDT) REFERENCES DeTai(MaDT),
CONSTRAINT FK_MaGV_HD FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
)
GO

------------- NHẬP DỮ LIỆU VÀO BẢNG TRONG DATABASE THUCTAP -------------

USE QL_THUCTAP
GO

-- 1. Nhập data Khoa
INSERT INTO Khoa(MaKhoa, TenKhoa, DienThoai)
VALUES	('CN','CONG NGHE SINH HOC','123789456'),
		('TA','TOAN','123456789'),
		('DL','DIA LY','789456123'),
		('QN','QLTN','456123789')

-- 2. Nhập data Giảng viên
INSERT INTO GiangVien(MaGV, HoTenGV, Luong, MaKhoa)
VALUES	(1,'Nguyen Van An', 5, 'TA'),
		(2,'Tran Duc Tam', 5, 'DL'),
		(3,'Ho Quang Hieu', 5, 'QN'),
		(4,'Le Thi Nhung', 5, 'CN'),
		(5,'Tran Son', 5, 'TA')
-- 3. Nhập data Sinh viên
INSERT INTO SinhVien(MaSV, HoTenSV, MaKhoa, NamSinh, QueQuan)
VALUES	(1,'Huynh Quang Thanh','CN', 1999, 'Hue'),
		(2,'Nguyen Van Tai','TA', 1998, 'Quang Tri'),
		(3,'Le Van Son','DL', 1999, 'Da Nang')

-- 4. Nhập data Đề tài
INSERT INTO DeTai(MaDT, TenDT, KinhPhi, NoiThucTap)
VALUES	('QBSP','Quan Ba San Pham', 1000000, 'The goi di dong '),
		('QLKS','Quan Ly Khach San', 1000000, 'Khach san Royal')

-- 5. Nhập data Hướng dẫn
INSERT INTO HuongDan(MaSV, MaDT, MaGV, KetQua)
VALUES	(1, 'QLKS', 5, 8.5),
		(2, 'QLKS', 5, 0),
		(3, 'QLKS', 5, 9.5)

		
------------- TRUY XUẤT DỮ LIỆU VÀO BẢNG TRONG DATABASE THUCTAP -------------

USE QL_THUCTAP
GO

---- Truy xuất CƠ BẢN ----
--1. Đưa ra thông tin gồm mã số, họ tên và tên khoa của tất cả các giảng viên
SELECT	G.MaGV, 
		G.HoTenGV, 
		K.TenKhoa
FROM GiangVien AS G INNER JOIN Khoa AS K ON G.MaKhoa = K.MaKhoa
GO

--2. Đưa ra thông tin gồm mã số, họ tên và tên khoa của các giảng viên của khoa DIA LY va QLTN
SELECT	G.MaGV, 
		G.HoTenGV, 
		K.TenKhoa
FROM GiangVien AS G INNER JOIN Khoa AS K ON G.MaKhoa = K.MaKhoa
WHERE K.TenKhoa = 'DIA LY' OR K.TenKhoa = 'QLTN'
GO

--3. Cho biết số sinh viên của khoa CONG NGHE SINH HOC
SELECT	K.TenKhoa, 
		COUNT(S.MaKhoa) 'Số SV'
FROM SinhVien AS S INNER JOIN Khoa AS K ON S.MaKhoa = K.MaKhoa
WHERE K.TenKhoa = 'CONG NGHE SINH HOC'
GROUP BY K.TenKhoa
GO

--4. Đưa ra danh sách gồm mã số, họ tên và tuổi của các sinh viên khoa TOAN
SELECT	S.MaSV,
		S.HoTenSV,
		S.NamSinh
FROM SinhVien AS S INNER JOIN Khoa AS K ON S.MaKhoa = K.MaKhoa
WHERE K.TenKhoa = 'TOAN'
GO
--5. Cho biết số giảng viên của khoa CONG NGHE SINH HOC
SELECT	K.TenKhoa, 
		COUNT(G.MaKhoa) 'Số GV'
FROM GiangVien AS G INNER JOIN Khoa AS K ON G.MaKhoa = K.MaKhoa
WHERE K.TenKhoa = 'CONG NGHE SINH HOC'
GROUP BY K.TenKhoa
GO

--6. Cho biết thông tin về sinh viên không tham gia thực tập
SELECT *
FROM SinhVien
WHERE MaSV <>	(SELECT S.MaSV
				FROM SinhVien AS S INNER JOIN HuongDan AS H ON S.MaSV = H.MaSV)

--7. Đưa ra mã khoa, tên khoa và số giảng viên của mỗi khoa
SELECT	K.MaKhoa, 
		K.TenKhoa,
		COUNT(G.MaKhoa) 'So GV'
FROM Khoa AS K INNER JOIN GiangVien AS G ON K.MaKhoa = G.MaKhoa
GROUP BY K.MaKhoa, K.TenKhoa
GO

-- 8. Cho biết số điện thoại của khoa mà sinh viên có tên ‘Le van son’ đang theo học
SELECT	K.TenKhoa,
		K.DienThoai
FROM Khoa AS K INNER JOIN SinhVien AS S ON K.MaKhoa = S.MaKhoa
WHERE S.HoTenSV = 'Le van son'
GO

---- Truy xuất NÂNG CAO ----
--1. Cho biết mã số và tên của các đề tài do giảng viên ‘Tran son’ hướng dẫn
SELECT	D.MaDT,
		D.TenDT
FROM HuongDan AS H	INNER JOIN GiangVien AS G ON H.MaGV = G.MaGV
					INNER JOIN DeTai AS D ON H.MaDT = D.MaDT
WHERE G.HoTenGV = 'Tran son'
GROUP BY D.MaDT, D.TenDT
GO

--2. Cho biết tên đề tài không có sinh viên nào thực tập
SELECT*
FROM DeTai 
WHERE MaDT NOT IN (SELECT H.MaDT 
					FROM HuongDan AS H INNER JOIN DeTai AS D ON H.MaDT = D.MaDT)
GO

--3. Cho biết mã số, họ tên, tên khoa của các giảng viên hướng dẫn từ 3 sinh viên trở lên.
SELECT	H.MaGV,
		G.HoTenGV,
		K.TenKhoa
FROM GiangVien AS G		INNER JOIN Khoa AS K ON G.MaKhoa = K.MaKhoa
						INNER JOIN HuongDan AS H ON G.MaGV = H.MaGV
GROUP BY H.MaGV, G.HoTenGV, K.TenKhoa
HAVING COUNT(H.MaGV) >= 3
GO

--4. Cho biết mã số, tên đề tài của đề tài có kinh phí cao nhất
SELECT * 
FROM DeTai
WHERE KinhPhi IN(	SELECT TOP(1) KinhPhi
					FROM DeTai
					ORDER BY KinhPhi DESC)
GO

--5. Cho biết mã số và tên các đề tài có nhiều hơn 2 sinh viên tham gia thực tập
SELECT	H.MaDT, 
		D.TenDT
FROM HuongDan AS H INNER JOIN DeTai AS D ON H.MaDT = D.MaDT
GROUP BY H.MaDT, D.TenDT
HAVING COUNT(H.MaSV) > 2
GO

--6. Đưa ra mã số, họ tên và điểm của các sinh viên khoa ‘DIALY và QLTN’
SELECT	S.MaSV,
		S.HoTenSV,
		H.KetQua
FROM SinhVien AS S INNER JOIN HuongDan AS H ON S.MaSV = H.MaSV
WHERE S.MaKhoa = 'DL' OR S.MaKhoa = 'QLTN'
GO

--7. Đưa ra tên khoa, số lượng sinh viên của mỗi khoa
SELECT	K.TenKhoa,
		COUNT(S.MaSV) AS 'So luong SV'
FROM Khoa AS K LEFT JOIN SinhVien AS S ON K.MaKhoa = S.MaKhoa
GROUP BY K.TenKhoa
GO

--8. Cho biết thông tin về các sinh viên thực tập tại quê nhà
SELECT S.*
FROM HuongDan AS H	INNER JOIN SinhVien AS S ON H.MaSV = S.MaSV
					INNER JOIN DeTai AS D ON H.MaDT = D.MaDT
WHERE S.QueQuan = D.NoiThucTap
GO

--9. Hãy cho biết thông tin về những sinh viên chưa có điểm thực tập
SELECT	S.*,
		H.KetQua
FROM SinhVien AS S INNER JOIN HuongDan AS H ON S.MaSV = H.MaSV
WHERE H.KetQua IS NULL
GO

--10. Đưa ra danh sách gồm mã số, họ tên các sinh viên có điểm thực tập bằng 0
SELECT	S.MaSV,
		S.HoTenSV,
		H.KetQua
FROM SinhVien AS S INNER JOIN HuongDan AS H ON S.MaSV = H.MaSV
WHERE H.KetQua = 0
GO
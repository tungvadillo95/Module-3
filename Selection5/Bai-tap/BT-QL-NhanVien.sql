USE QL_GIAOHANG
GO

-- Sử dụng view để viết chức năng hiển thị danh sách nhân viên.
CREATE VIEW vw_XemDanhSachNV 
AS
SELECT *
FROM NHANVIEN
GO

-- Sử dụng StoreProcedure để viết chức năng thêm mới nhân viên.
CREATE PROCEDURE proc_ThemNV
(	
@MANHANVIEN INT,
@HO NVARCHAR(20),
@TEN NVARCHAR(10),
@NGAYSINH DATE,
@NGAYLAMVIEC DATE,
@DIACHI NVARCHAR(50),
@DIENTHOAI VARCHAR(20),
@LUONGCOBAN FLOAT,
@PHUCAP FLOAT
)  
AS  
  BEGIN 
		INSERT INTO NHANVIEN  
						( MANHANVIEN,  
                         HO,  
                         TEN,  
                         NGAYSINH,  
                         NGAYLAMVIEC,
						 DIACHI,
						 DIENTHOAI,
						 LUONGCOBAN,
						 PHUCAP) 
            VALUES     ( @MANHANVIEN,  
                         @HO,  
                         @TEN,  
                         @NGAYSINH,  
                         @NGAYLAMVIEC,
						 @DIACHI,
						 @DIENTHOAI,
						 @LUONGCOBAN,
						 @PHUCAP) 
  END  

-- Sử dụng Function để tính trung bình lương của nhân viên.
CREATE FUNCTION fun_TinhTrungBinhLuongNV()
RETURNS FLOAT
AS
BEGIN
	DECLARE @tbLuong FLOAT
	SELECT @tbLuong = AVG(LUONGCOBAN + PHUCAP)
	FROM NHANVIEN
	RETURN @tbLuong
END


SELECT dbo.fun_TinhTrungBinhLuongNV() 'Trung bình lương NV';
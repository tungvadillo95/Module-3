-- 1. Thiết kế và tạo CSLD
CREATE DATABASE QLBH_TB_DienTu
GO

USE QLBH_TB_DienTu
GO

CREATE TABLE MATHANG
(
MAHANG INT NOT NULL,
TEN NVARCHAR(30) NOT NULL,
LOAIHANG INT NOT NULL,
SOLUONG INT NOT NULL,
GIABAN FLOAT NOT NULL
CONSTRAINT PK_MAHANG PRIMARY KEY (MAHANG)
)
GO

CREATE TABLE DONBANHANG
(
MADONHANG INT NOT NULL,
NGAYDATHANG DATE NOT NULL,
HOTEN NVARCHAR(30) NOT NULL,
DIACHI NVARCHAR(30) NOT NULL,
CONSTRAINT PK_MADONHANG PRIMARY KEY (MADONHANG)
)
GO

CREATE TABLE CHITIETDONHANG
(
MADONHANG INT NOT NULL,
MAHANG INT NOT NULL,
GIABAN FLOAT NOT NULL,
SOLUONG INT NOT NULL,
CONSTRAINT PK_CHITIETDONHANG PRIMARY KEY (MADONHANG,MAHANG),
CONSTRAINT FK_MADONHANG FOREIGN KEY (MADONHANG) REFERENCES DONBANHANG(MADONHANG),
CONSTRAINT FK_MAHANG FOREIGN KEY (MAHANG) REFERENCES MATHANG(MAHANG)
)
GO

CREATE TABLE PHIEUTHU
(
SOPHIEU INT NOT NULL,
MADONHANG INT NOT NULL,
NGAYTHU DATE NOT NULL,
SOTIENTHU FLOAT NOT NULL,
CONSTRAINT PK_SOPHIEU PRIMARY KEY (SOPHIEU),
CONSTRAINT FK_MADONHANG_PHIEUTHU FOREIGN KEY (MADONHANG) REFERENCES DONBANHANG(MADONHANG)
)
GO

-- 2. Tạo Stored Procedure
CREATE PROCEDURE proc_InsertOrUpdateData_MaHang 
(	
@MAHANG INT,
@TEN NVARCHAR(30),
@LOAIHANG INT,
@SOLUONG INT,
@GIABAN FLOAT,
@StatementType NVARCHAR(20) = ''
)  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO MATHANG  
                        (MAHANG,  
                         TEN,  
                         LOAIHANG,  
                         SOLUONG,  
                         GIABAN)  
            VALUES     ( @MAHANG,  
                         @TEN,  
                         @LOAIHANG,  
                         @SOLUONG,  
                         @GIABAN)  
        END 
  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE MATHANG  
            SET    TEN = @TEN,  
                   LOAIHANG = @LOAIHANG,  
                   SOLUONG = @SOLUONG,  
                   GIABAN = @GIABAN  
            WHERE  MAHANG = @MAHANG  
        END  
      
  END   
  GO

CREATE PROCEDURE proc_InsertOrUpdateData_PhieuThu
(	
@SOPHIEU INT,
@MADONHANG INT,
@NGAYTHU DATE,
@SOTIENTHU FLOAT,
@StatementType NVARCHAR(20) = ''
)  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO PHIEUTHU  
                        (SOPHIEU,  
                         MADONHANG,  
                         NGAYTHU,  
                         SOTIENTHU)  
            VALUES     ( @SOPHIEU,  
                         @MADONHANG,  
                         @NGAYTHU,  
                         @SOTIENTHU)  
        END 
  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE PHIEUTHU  
            SET    MADONHANG = @MADONHANG,  
                   NGAYTHU = @NGAYTHU,  
                   SOTIENTHU = @SOTIENTHU
            WHERE  SOPHIEU = @SOPHIEU  
        END  
  END 
  GO

CREATE PROCEDURE proc_InsertOrUpdateData_DonBanHang
(	
@MADONHANG INT,
@NGAYDATHANG DATE,
@HOTEN NVARCHAR(30),
@DIACHI NVARCHAR(30),
@StatementType NVARCHAR(20) = ''
)  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO DONBANHANG  
                        (MADONHANG,  
                         NGAYDATHANG,  
                         HOTEN,  
                         DIACHI)  
            VALUES     ( @MADONHANG,  
                         @NGAYDATHANG,  
                         @HOTEN,  
                         @DIACHI)  
        END 
  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE DONBANHANG  
            SET    NGAYDATHANG = @NGAYDATHANG,  
                   HOTEN = @HOTEN,  
                   DIACHI = @DIACHI
            WHERE  MADONHANG = @MADONHANG  
        END  
  END 
  GO

CREATE PROCEDURE proc_InsertOrUpdateData_ChiTietDonHang
(	
@MADONHANG INT,
@MAHANG INT,
@GIABAN FLOAT,
@SOLUONG INT,
@StatementType NVARCHAR(20) = ''
)  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO CHITIETDONHANG  
                        (MADONHANG,  
                         MAHANG,  
                         GIABAN,  
                         SOLUONG)  
            VALUES     ( @MADONHANG,  
                         @MAHANG,  
                         @GIABAN,  
                         @SOLUONG)  
        END 
  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE CHITIETDONHANG  
            SET		GIABAN = @GIABAN,  
					SOLUONG = @SOLUONG
            WHERE  MADONHANG = @MADONHANG AND MAHANG = @MAHANG
        END  
  END 
  GO

-- 3. Thiết kế view tất cả chứng từ trong CSDL
CREATE VIEW vw_Xem_DonBanHang 
AS
SELECT *
FROM DONBANHANG
GO

-- 4. Viết thủ tục hiển thị thông tin chi tiết của mặt hàng có trong CSDL
CREATE PROCEDURE proc_HienThiMatHang
(	
@MADONHANG INT
)  
AS  
  BEGIN   
        BEGIN  
            SELECT *  
            FROM CHITIETDONHANG AS C INNER JOIN MATHANG AS M ON C.MAHANG = M.MAHANG
			WHERE C.MADONHANG = @MADONHANG
        END  
  END 
  GO

-- 5. Viết thủ tục hiển thị thông tin chi tiết của Đơn hàng có trong CSDL
CREATE PROCEDURE proc_HienThiDonHang
(	
@MADONHANG INT
)  
AS  
  BEGIN   
        BEGIN  
            SELECT *  
            FROM DONBANHANG
        END  
  END 
  GO
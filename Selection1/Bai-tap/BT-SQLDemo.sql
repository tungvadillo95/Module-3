CREATE TABLE Khoa(
makhoa varchar(10) NOT NULL PRIMARY KEY,
tenkhoa varchar(30),
dienthoai varchar(10)
);
CREATE TABLE GiangVien(
magv int NOT NULL PRIMARY KEY, 
hotengv varchar(30), 
luong decimal(5,2), 
makhoa varchar(10),
FOREIGN KEY (makhoa) REFERENCES Khoa(makhoa),
);
CREATE TABLE SinhVien(
masv int NOT NULL PRIMARY KEY, 
hotensv varchar(30), 
makhoa varchar(10), 
namsinh int, 
quequan varchar(30),
FOREIGN KEY (makhoa) REFERENCES Khoa(makhoa)
);
CREATE TABLE DeTai(
madt varchar(10) NOT NULL PRIMARY KEY, 
tendt varchar(30), 
kinhphi int, 
NoiThucTap varchar(30)
);
CREATE TABLE HuongDan(
masv int, 
madt varchar(10), 
magv int, 
ketqua decimal(5,2),
FOREIGN KEY (masv) REFERENCES SinhVien(masv),
FOREIGN KEY (madt) REFERENCES DeTai(madt),
FOREIGN KEY (magv) REFERENCES GiangVien(magv),
);
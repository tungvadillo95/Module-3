USE BikeStores
GO

-- Truy vấn này tìm thấy khách hàng với email 'caren.stephens@msn.com'
SELECT
    customer_id,
    email
FROM sales.customers
WHERE email = 'caren.stephens@msn.com';
GO

-- Truy vấn trả về một tập kết quả trống.Nó có nghĩa là không có giá trị trùng lặp trong cột email.
SELECT
    email,
    COUNT(email)
FROM sales.customers
GROUP BY email
HAVING COUNT(email) > 1;
GO

-- Tạo một unique index cho cột email của bảng sales.customers
-- Để tối ưu hóa truy vấn sẽ tận dụng chỉ mục ix_cust_email và sử dụng phương pháp tìm kiếm chỉ mục để tìm kiếm hàng qua email.
CREATE UNIQUE INDEX ix_cust_email
ON sales.customers(email)
GO
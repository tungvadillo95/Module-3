USE BikeStores
GO

------- THỰC HÀNH 1: Sử dụng câu lệnh SQL Server CREATE INDEX để tạo một nonclustered index cho một cột ví dụ ------- 
SELECT
    customer_id,
	city
FROM sales.customers
WHERE city = 'Atwater';
GO
-- Để cải thiện tốc độ của truy vấn này, bạn có thể tạo một chỉ mục mới có tên ix_customers_city cho cột city
CREATE INDEX ix_customers_city
ON sales.customers(city);
GO

------- THỰC HÀNH 2: Sử dụng câu lệnh SQL Server CREATE INDEX để tạo một nonclustered index cho nhiều cột ví dụ ------- 
SELECT
    customer_id,
    first_name,
    last_name
FROM sales.customers
WHERE last_name = 'Berg' AND first_name = 'Monika';
GO


-- Câu lệnh sau đây tìm thấy khách hàng có last_name là Albert.
SELECT
    customer_id,
    first_name,
    last_name
FROM sales.customers
WHERE last_name = 'Albert';
GO

-- Câu lệnh sau tìm thấy khách hàng có first_name là Adam.
SELECT
    customer_id,
    first_name,
    last_name
FROM sales.customers
WHERE first_name = 'Adam';

-- Để tăng tốc độ truy xuất dữ liệu, bạn có thể tạo một nonclustered index bao gồm cả cột last_name và first_name
CREATE INDEX ix_customers_name
ON sales.customers(last_name, first_name);
GO
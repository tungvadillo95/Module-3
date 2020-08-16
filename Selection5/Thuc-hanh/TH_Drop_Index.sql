-- Sử dụng câu lệnh DROP INDEX để xóa chỉ mục ix_cust_email khỏi bảng sales.customers
DROP INDEX IF EXISTS ix_cust_email
ON sales.customers
GO

-- Sử dụng câu lệnh DROP INDEX để xóa các chỉ mục ix_cust_city, ix_cust_fullname khỏi bảng sales.customers
DROP INDEX
    ix_cust_city ON sales.customers,
    ix_cust_fullname ON sales.customers
GO
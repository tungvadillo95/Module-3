


ALTER TABLE Employees
ADD CONSTRAINT FK_Employees
FOREIGN KEY (reportTo) REFERENCES Employees(employeeNumber);

ALTER TABLE Employees
DROP COLUMN reportTo;

ALTER TABLE Employees
ADD reportTo INT; 
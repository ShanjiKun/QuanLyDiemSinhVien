--Create Database Role

USE QLDSV
GO

--Create roles
CREATE ROLE PGV
CREATE ROLE KHOA
CREATE ROLE SINHVIEN

--Add permisson
EXEC sp_addrolemember 'db_datareader', 'PGV'
EXEC sp_addrolemember'db_datawriter', 'PGV'

EXEC sp_addrolemember 'db_datareader', 'KHOA'
EXEC sp_addrolemember'db_datawriter', 'KHOA'

EXEC sp_addrolemember 'db_datareader', 'SINHVIEN'
EXEC sp_addrolemember'db_datawriter', 'SINHVIEN'

--Add Execute sp permission
GRANT EXECUTE TO PGV
GRANT EXECUTE TO KHOA
GRANT EXECUTE TO SINHVIEN
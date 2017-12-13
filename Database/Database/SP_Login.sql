CREATE PROC SP_Login
	@login NVARCHAR (50)
AS
DECLARE @user NVARCHAR(50)
DECLARE @role nvarchar(50)
DECLARE @hoTen nvarchar(50)

--Get user from login
SELECT @user=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@login)

--Get role of user
SELECT @role = name
FROM sys.sysusers 
WHERE UID = (SELECT GROUPUID 
             FROM SYS.SYSMEMBERS 
              WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										WHERE NAME=@user))

--Get name from user
IF(@role = 'PGV')
BEGIN
	SELECT @hoTen = Ten FROM NHAN_VIEN WHERE MaNV = @user
END
ELSE
BEGIN
	IF(@role = 'KHOA')
	BEGIN
		SELECT @hoTen = HoTen FROM GIANG_VIEN WHERE MaGV = @user
	END
	ELSE
	IF(@role = 'SINHVIEN')
		BEGIN
			SELECT @hoTen = HoTen FROM SINH_VIEN WHERE MaSV = @user
		END
END

--Return result
SELECT @user as Id, @hoTen as Name, @role as Role
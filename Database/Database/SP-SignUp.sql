--Create by Vinh Huynh 11/16/2017

CREATE PROCEDURE SP_SignUp
(
	@login varchar(20),
	@password varchar(20),
	@id varchar(20),
	@role varchar(20)
)
AS
--Declare var
DECLARE @RET INT

--Add Login
EXEC @RET= SP_ADDLOGIN @login, @password,'QLDSV'
IF (@RET =1)  -- LOGIN NAME BI TRUNG
    RETURN 1
 
--Map login to user
EXEC @RET= SP_GRANTDBACCESS @login, @id
IF (@RET =1)  -- USER  NAME BI TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @login
		RETURN 2
	END

--Check valid role
IF (@role != 'PGV' AND @role != 'KHOA' AND @role != 'SINHVIEN')
	BEGIN
		EXEC SP_DROPLOGIN @login
		EXEC SP_DROPUSER @id
		RETURN 3 --	INVALID ROLE
	END

--Map user to role
IF (@role = 'PGV' OR @role = 'KHOA')
	BEGIN
		EXEC sp_addsrvrolemember @login, 'SecurityAdmin'
	END
EXEC sp_addrolemember @role, @id

--Sign up success
RETURN 0  -- THANH CONG

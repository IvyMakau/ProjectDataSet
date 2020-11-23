CREATE PROCEDURE upcroEmployeeNum
@EmployeeNum int
AS
    BEGIN
            SELECT EmployeeNum FROM AspNetUsers WHERE
            EmployeeNum =@EmployeeNum

    END
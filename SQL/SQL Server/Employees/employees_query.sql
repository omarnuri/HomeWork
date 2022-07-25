SELECT * FROM Employees ORDER BY StartDate
SELECT * FROM History

SELECT Employees.BusinessEntityID, firstname, lastname, Employees.CountryRegionName, Employees.StateProvinceName
FROM Employees
WHERE CountryRegionName LIKE N'United States'

SELECT  DISTINCT JobTitle, COUNT(JobTitle)
FROM Employees
GROUP BY JobTitle

SELECT DISTINCT Employees.FirstName, COUNT(FirstName)
FROM Employees
GROUP BY FirstName

SELECT TOP 1 Employees.FirstName
FROM Employees
GROUP BY FirstName
ORDER BY COUNT(FirstName) DESC

SELECT TOP(1) Employees.FirstName
FROM Employees
GROUP BY FirstName
ORDER BY COUNT(FirstName)

SELECT TOP 5 City
FROM Employees
GROUP BY City
ORDER BY COUNT(DISTINCT JobTitle)  DESC

--ALTER TABLE Employees
--ADD WorkEmail NVARCHAR(50)
UPDATE Employees
SET WorkEmail = N'workemail@mail.ru'
FROM Employees
WHERE StartDate LIKE CAST('01/01/2012' AS DATE)

SELECT YEAR(Employees.StartDate), COUNT(StartDate), CountryRegionName
FROM Employees
Group By  CountryRegionName, YEAR(StartDate)

UPDATE Employees
SET Employees.EndDate = History.EndDate
FROM Employees, History
WHERE Employees.BusinessEntityID LIKE History.BusinessEntityID

SELECT YEAR(EndDate), COUNT(EndDate)
FROM Employees
GROUP BY YEAR(EndDate)
HAVING YEAR(EndDate) IS NOT NULL

SELECT COUNT(DATEDIFF(MONTH, EndDate, StartDate))
FROM Employees
WHERE DATEDIFF(MONTH, EndDate, StartDate)<12








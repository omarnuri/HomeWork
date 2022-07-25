SELECT  Name, CAST(Price*Pressrun as nvarchar)+N'$' as N'Price of pressrun'
FROM Books_En

SELECT DISTINCT Category 
FROM Books_En

SELECT DISTINCT Topic
From Books_En

SELECT Code, Price/Pages as N'Price of a page'
FROM Books_En
WHERE Pages != 0
ORDER BY Code

SELECT *
FROM Books_En
WHERE Category LIKE N'C&C++' OR Category Like  N'Tutorials' AND Publisher LIKE N'Peter' OR Publisher LIKE 'DiaSoft'

SELECT *
FROM Books_En
WHERE Name LIKE '%Visual%'

SELECT *
FROM Books_En
WHERE Name LIKE N'%Visual%' AND  Name NOT LIKE N'%Basic%'

SELECT *
FROM Books_En
WHERE Name LIKE '%[0-9]%'

SELECT *
FROM Books_En 
WHERE Name LIKE '%[0-9]% %[0-9]% %[0-9]%'

SELECT *
FROM Books_En 
WHERE Name LIKE '%[0-9]%%[0-9]%%[0-9]%%[0-9]%' AND Name NOT LIKE  '%[0-9]%%[0-9]%%[0-9]%%[0-9]%%[0-9]%'
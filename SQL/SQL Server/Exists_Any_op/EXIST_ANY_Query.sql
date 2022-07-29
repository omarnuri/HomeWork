USE Library


SELECT *
FROM Books
WHERE EXISTS(SELECT* FROM T_Cards WHERE EXISTS(SELECT* FROM S_Cards WHERE S_Cards.Id_Book LIKE Books.Id) AND Books.Id LIKE T_Cards.Id_Book)

SELECT *
FROM Books
WHERE Id = ANY(SELECT T_Cards.Id_Book FROM T_Cards) AND Id = ANY(SELECT S_Cards.Id_Book FROM S_Cards)





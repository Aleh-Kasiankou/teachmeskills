CREATE TABLE Authors(
"Id" uniqueidentifier NOT NULL PRIMARY KEY,
"FirstName" nvarchar(255) NOT NULL, 
"LastName" nvarchar(255) NOT NULL,
"Country" nvarchar(255) NOT NULL,
"BirthDate" date NOT NULL
);



CREATE TABLE Books(
"Id" uniqueidentifier NOT NULL PRIMARY KEY,
"Name" nvarchar(255) NOT NULL,
"AuthorId" uniqueidentifier NOT NULL,
"Year" smallint NOT NULL,
CONSTRAINT CHK_Year_validity 
   CHECK (Year >= 1000 and Year <= YEAR(GETDATE())),
CONSTRAINT FK_AuthorBook FOREIGN KEY(AuthorId)
REFERENCES Authors(Id)
);



CREATE TABLE Users(
"Id" uniqueidentifier NOT NULL PRIMARY KEY,
"FirstName" nvarchar(255) NOT NULL, 
"LastName" nvarchar(255) NOT NULL,
"Email" nvarchar(255) UNIQUE NOT NULL,
"BirthDate" date NOT NULL,
"Age" tinyint NOT NULL,
"Address" nvarchar(255) NOT NULL,
"ExpiredDate" date NOT NULL
);



CREATE TABLE UserBooks(
"Id" uniqueidentifier NOT NULL PRIMARY KEY,
"UserId" uniqueidentifier NOT NULL,
"BookId" uniqueidentifier NOT NULL,
"CreatedDate" date,
CONSTRAINT FK_UserUserBook FOREIGN KEY(UserID)
REFERENCES Users(Id) ON DELETE CASCADE,
CONSTRAINT FK_BookUserBook FOREIGN KEY(BookID)
REFERENCES Books(Id) ON DELETE CASCADE,
);



/*Basic Task Acomplished*/

CREATE TRIGGER TR_UserBooks_Insert
ON UserBooks INSTEAD OF INSERT AS
   INSERT INTO UserBooks(Id, UserId, BookId, CreatedDate)
   SELECT Id, UserId, BookId, GETDATE() FROM INSERTED;



CREATE TRIGGER TR_Users_Insert
ON Users INSTEAD OF INSERT AS
   INSERT INTO Users 
   SELECT Id, FirstName, LastName, Email, BirthDate, DATEDIFF(YEAR, BirthDate, GETDATE()), Address, DATEADD(YEAR, 1, GetDATE()) FROM INSERTED;



CREATE TRIGGER TR_Users_Update
ON Users FOR UPDATE AS
UPDATE Users 
SET Age = DATEDIFF(YEAR, BirthDate, GETDATE())
WHERE Id IN (SELECT TOP 1 ID from INSERTED);



ALTER TABLE UserBooks 
  ADD CONSTRAINT uq_UserBooks UNIQUE(UserId, BookId);



INSERT INTO Authors
VALUES(
NEWID(),'Jane', 'Austen','UK', '1775/12/16'),
(NEWID(), 'Harper', 'Lee', 'USA', '1926/04/28'),
(NEWID(), 'Aldous', 'Huxley', 'UK', '1894/07/26'),
(NEWID(), 'Charlotte', 'Bronte', 'UK', '1816/04/21'),
(NEWID(), 'Fyodor', 'Dostoevsky', 'Russia', '1821/11/11'),
(NEWID(), 'George', 'Eliot', 'UK', '1819/11/22');



INSERT INTO Books 
VALUES
(NEWID(), 'Pride and Prejudice', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Austen'), 1813),   
(NEWID(), 'To Kill a Mockingbird', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Lee'), 1960),
(NEWID(), 'Brave New World', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Huxley'), 1932),
(NEWID(), 'Jane Eyre', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Bronte'), 1847),
(NEWID(), 'Crime and Punishment', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Dostoevsky'), 1866),
(NEWID(), 'Persuasion', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Austen'), 1818),
(NEWID(), 'Middlemarch', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Eliot'), 1871),
(NEWID(), 'The Mill on the Floss', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Eliot'), 1860),
(NEWID(), 'Silas Marner', (SELECT TOP 1 ID FROM Authors WHERE LastName LIKE 'Eliot'), 1861);



INSERT INTO Users(Id, FirstName, LastName, Email, BirthDate, Address)
VALUES
(NEWID(), 'Max', 'Verstappen', 'max@verstappen.com', '1997/09/30', 'Hasselt, Belgium'),
(NEWID(), 'Lewis', 'Hamilton', 'lewis@hamilton.com', '1985/07/01', 'Stevenage, UK'),
(NEWID(), 'Sergio', 'Pérez', 'sergio@perez.com', '1990/01/26', 'Guadalajara, Mexico'),
(NEWID(), 'Lando', 'Norris', 'lando@norris.com', '1999/11/13', 'Bristol, UK'),
(NEWID(), 'Charles', 'Leclerc', 'charles@leclerc.com', '1997/10/16', 'Monte-Carlo, Monaco'),
(NEWID(), 'Carlos', 'Sainz', 'carlos@sainzjr.com', '1994/09/01', 'Madrid, Spain'),
(NEWID(), 'George', 'Russell', 'george@russell.com', '1998/02/15', 'King''s Lynn, UK'),
(NEWID(), 'Fernando', 'Alonso', 'fernando@alonso.com', '1981/07/29', 'Oviedo, Spain'),
(NEWID(), 'Daniel', 'Ricciardo', 'dan@ricciardo.com', '1989/07/1', 'Perth, Australia');


INSERT INTO UserBooks(ID, UserId, BookId)
VALUES
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Hamilton'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Mockingbird%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Alonso'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Persuasion%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Norris'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Middlemarch%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Hamilton'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%New World%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Sainz'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Prejudice%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Pérez'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Eyre%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Alonso'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Marner%')),
(NEWID(), (SELECT TOP 1 ID from Users WHERE LastName LIKE 'Alonso'), (SELECT TOP 1 ID from Books WHERE Name LIKE '%Punishment%'));


CREATE VIEW UsersInfo AS
SELECT 
u.Id AS UserId, 
CONCAT(u.FirstName, ' ', u.LastName) AS UserFullName , 
Age AS UserAge, 
CONCAT(a.FirstName, ' ', a.LastName) AS AuthorFullName, 
b.Name AS BookName, 
b.Year AS BookYear
FROM Users u 
LEFT JOIN UserBooks ub ON u.Id = ub.UserId
LEFT JOIN Books b ON b.Id = ub.BookId
LEFT JOIN Authors a ON b.AuthorId = a.Id;


CREATE PROCEDURE DeleteUsersByExpiredDate AS
BEGIN
SELECT DISTINCT u.Id, COUNT(BookId) BooksCount INTO #Temp 
FROM Users u LEFT JOIN UserBooks ub ON u.Id  = ub.UserId  
WHERE u.ExpiredDate <= GETDATE()
GROUP BY u.Id;

SELECT Id INTO #ToDelete
FROM #Temp
WHERE BooksCount = 0;

DELETE FROM Users 
WHERE Id IN(SELECT * FROM #ToDelete);

IF(SELECT COUNT(Id) FROM #Temp WHERE Id NOT IN (SELECT * FROM #ToDelete)) > 0
BEGIN
DECLARE @warning AS NVARCHAR(255) 
SELECT @warning = CONCAT('The following users have expired but haven''t returned some books yet:', (SELECT STRING_AGG(CONVERT(NVARCHAR(255), Id), ', ')
FROM #Temp
WHERE Id NOT IN (SELECT * FROM #ToDelete)));

PRINT(@warning)
END
END;

/*Main Task Accomplished*/

CREATE PROCEDURE GiveBookToUser 
@emailUser nvarchar(100),
@firstNameAuthor nvarchar(100),
@lastNameAuthor nvarchar(100),
@titleBook nvarchar(100)

AS
BEGIN
	IF(SELECT COUNT(*) FROM Books b INNER JOIN Authors a ON b.AuthorId = a.Id 
		WHERE b.Name = @titleBook AND a.FirstName = @firstNameAuthor AND a.LastName = @lastNameAuthor) = 0
		BEGIN
			PRINT('The requested book does not exist');
			RETURN;
		END
	
	ELSE IF(SELECT COUNT(u.Email) FROM Users u WHERE u.Email = @emailUser) = 0 
		BEGIN		
			PRINT('The requested user is not found');
			RETURN;
		END
	
		IF(SELECT COUNT(*) 
			FROM UserBooks ub INNER JOIN Users u ON ub.UserId = u.Id INNER JOIN Books b ON ub.BookId = b.Id INNER JOIN Authors a on b.AuthorId = a.Id 
			WHERE u.Email = @emailUser and b.Name = @titleBook and a.FirstName = @firstNameAuthor AND a.LastName = @lastNameAuthor) > 0
			
			BEGIN
				PRINT(CONCAT('The specified user has taken this book already: ', @titlebook , ' by ', @firstNameAuthor, ' ', @lastNameAuthor));
				RETURN;
			END
			
		
			
		ELSE IF(SELECT COUNT(*) 
			FROM UserBooks ub INNER JOIN Books b ON ub.BookId = b.Id INNER JOIN Authors a on b.AuthorId = a.Id 
			WHERE b.Name = @titleBook and a.FirstName = @firstNameAuthor AND a.LastName = @lastNameAuthor) > 0
			
			BEGIN
				PRINT(CONCAT('The book has already been taken: ', @titlebook , ' by ', @firstNameAuthor, ' ', @lastNameAuthor));
				RETURN;
			END
			
		ELSE
			BEGIN
				DECLARE @userId uniqueidentifier;
				DECLARE @bookId uniqueidentifier;
				SET @userId = (SELECT TOP 1 u.Id FROM Users u WHERE u.Email = @emailUser);
				SET @bookId = (SELECT b.Id FROM Books b INNER JOIN Authors a on b.AuthorId = a.Id 
						WHERE b.Name = @titleBook and a.FirstName = @firstNameAuthor AND a.LastName = @lastNameAuthor);
				
				INSERT INTO UserBooks(Id, UserId, BookId)
				VALUES(NEWID(),@userId, @bookId);
			END
	
END;


ALTER TABLE UserBooks 
ADD ToCharge real;


CREATE FUNCTION GetCharge
(@dateOfIssue date,
@returnInDays int = 60)
RETURNS real
AS
BEGIN
	DECLARE @overdueChargeSum real;
	DECLARE @overdueDays smallint;
	DECLARE @fee real;
	SET @fee = 2.7;
	
	SET @overdueDays = DATEDIFF(DAY, @dateOfIssue, DATEADD(DAY, - @returnInDays, GETDATE()));
	SET @overdueChargeSum = IIF(@overdueDays > 0, @overdueDays * @fee, 0);
	RETURN(@overdueChargeSum);
	
END;

/*DECLARE @Date date;
SET @Date = DATEADD(DAY, -91, GETDATE());
SELECT ROUND(dbo.GetCharge(@Date, DEFAULT), 2);*/


CREATE PROCEDURE ChargeUser
@Email nvarchar(100),
@BookId uniqueidentifier
AS
BEGIN
	IF(SELECT COUNT(u.Email) FROM Users u WHERE u.Email = @Email) = 0 
		BEGIN		
			PRINT('The requested user is not found');
			RETURN;
		END
	
	IF(SELECT COUNT(b.Id) FROM Books b WHERE b.Id = @BookId) = 0 
	BEGIN		
		PRINT('The requested book does not exist');
		RETURN;
	END
	
	IF(SELECT COUNT(*) 
			FROM UserBooks ub INNER JOIN Users u ON ub.UserId = u.Id INNER JOIN Books b ON ub.BookId = b.Id
			WHERE u.Email = @Email and b.Id = @BookId) = 0
			
			BEGIN
				PRINT(CONCAT('The specified user doesn''t have the book: ',@BookId));
				RETURN;
			END
	
	DECLARE @Date date;
	SET @Date = (SELECT TOP 1 ub.CreatedDate FROM UserBooks ub INNER JOIN Users u ON ub.UserId = u.Id WHERE ub.BookId = @BookId AND u.Email = @Email);
	
	UPDATE UserBooks 
	SET ToCharge =dbo.GetCharge(@Date, DEFAULT)
	WHERE UserId IN (SELECT TOP 1 u.Id FROM Users u WHERE u.Email = @Email) AND BookId = @BookId;
END;



CREATE PROCEDURE ReturnBook
@Email nvarchar(100),
@BookId uniqueidentifier
AS
BEGIN
	EXECUTE ChargeUser @Email, @BookId
	
	DECLARE @UserFee real;
	SET @UserFee = (SELECT ToCharge FROM UserBooks INNER JOIN Users u ON UserBooks.UserId = u.Id WHERE UserBooks.BookId = @BookId AND u.Email = @Email);
	PRINT(CONCAT('User with mail ', @Email, ' paid ', @UserFee, ' roubles'))
	
	DELETE FROM UserBooks 
	WHERE UserBooks.Id = 
		(SELECT UserBooks.Id FROM UserBooks INNER JOIN Users ON UserBooks.UserId = Users.Id WHERE UserBooks.BookId = @BookId AND UserBooks.UserId IN (SELECT TOP 1 Users.Id FROM Users WHERE Users.Email = @Email));
END;



/*SQL SCRIPT ROUTINE*/
BEGIN
TRUNCATE TABLE UserBooks;
EXECUTE GiveBookToUser 'lando@norris.com', 'George', 'Eliot', 'The Mill on the Floss';
EXECUTE GiveBookToUser 'lewis@hamilton.com', 'Harper', 'Lee', 'To Kill a Mockingbird'; 

UPDATE UserBooks SET CreatedDate = DATEADD(DAY, -100, GETDATE()) WHERE UserBooks.UserId = (SELECT u.Id FROM Users u WHERE u.Email = 'lewis@hamilton.com');

DECLARE @norrisBook uniqueidentifier;
SELECT TOP 1 @norrisBook = b.Id FROM dbo.Books b WHERE b.Name = 'The Mill on the Floss';


DECLARE @hamiltonBook uniqueidentifier;
SELECT TOP 1 @hamiltonBook = b.Id FROM dbo.Books b WHERE b.Name = 'To Kill a Mockingbird';


EXECUTE ReturnBook 'lando@norris.com', @norrisBook;
EXECUTE ReturnBook 'lewis@hamilton.com', @hamiltonBook;

EXECUTE GiveBookToUser 'fernando@alonso.com', 'Harper', 'Lee', 'To Kill a Mockingbird'; 

EXECUTE DeleteUsersByExpiredDate;
END;

			


/*1*/
SELECT COUNT(p.Id) population, a.City  
FROM Persons p INNER JOIN Addresses a ON p.AddressId = a.Id 
WHERE a.City LIKE 'Lake%'
GROUP BY a.City;

/*Result: 37 people*/

/*2*/
SELECT DISTINCT country
FROM Addresses a;

/*Result: 78 rows*/

/*3*/
SELECT * 
FROM Persons p INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId INNER JOIN Addresses a ON p.AddressId = a.Id
WHERE Name LIKE 'D%';

/*Result: 14 rows*/

/*4*/
SELECT * 
FROM Persons p
WHERE Id IN (SELECT ProfessorId FROM StudySubjects ss) 
	AND Name LIKE '%C%'; 
	
/*Result: 13 rows*/

/*5*/
SELECT StudentId, Age, u.Name
FROM Persons p
	INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
WHERE Age > 30 AND u.Name LIKE '%Carter%';

/*Result: 44 rows*/

/*6*/
SELECT * 
FROM Persons p
WHERE p.Id NOT IN (SELECT pss.StudentId  FROM PersonsStudySubjects pss);

/*Result: 201 rows*/

/*7*/
SELECT *
FROM Persons p 
WHERE p.Id NOT IN (SELECT ss.ProfessorId  FROM StudySubjects ss);
/*Result: 326 rows*/

/*8*/
SELECT * 
FROM Persons p INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	INNER JOIN Addresses a ON u.AddressId = a.Id
WHERE u.Name LIKE 'Baile%' AND a.City LIKE 'Lake%';

/*Result: 0*/
	
/*9*/
SELECT u.Name, COUNT (p.Id)
FROM Persons p INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	GROUP BY u.Name;
/*Result:
Bailey Group	71
Carter - Gusikowski	55
Kutch, Hoppe and McDermott	21
Prohaska LLC	19
Veum, Turner and Mertz	31
*/

/*10 - Students*/
SELECT u.Name, AVG(p.Age) 
FROM Persons p INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	GROUP BY u.Name;
/*
Bailey Group	46
Carter - Gusikowski	45
Kutch, Hoppe and McDermott	47
Prohaska LLC	40
Veum, Turner and Mertz	45
*/

/*10 Professors*/
SELECT u.Name, AVG(p.Age) 
FROM Persons p INNER JOIN StudySubjects ss ON ss.ProfessorId = p.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	GROUP BY u.Name;

/*
Bailey Group	41
Carter - Gusikowski	37
Kutch, Hoppe and McDermott	33
Prohaska LLC	48
Veum, Turner and Mertz	31
*/

/*10 ALL*/



SELECT Name, SUM(age)/COUNT(age) avg_age FROM ((SELECT u.Name, AVG(p.Age) age
	FROM Persons p INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	GROUP BY u.Name) 
	UNION 
	(SELECT u.Name, AVG(p.Age) age
	FROM Persons p INNER JOIN StudySubjects ss ON ss.ProfessorId = p.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	GROUP BY u.Name)) joinedTable
GROUP BY Name;

/*
Bailey Group	43
Carter - Gusikowski	41
Kutch, Hoppe and McDermott	40
Prohaska LLC	44
Veum, Turner and Mertz	38
 */

/*11*/
SELECT a.City , u.Name, COUNT (p.Id) students_number
FROM Persons p 
	INNER JOIN Addresses a on p.AddressId = a.Id 
	INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
GROUP BY a.City, u.Name
ORDER BY u.Name, students_number DESC;


/*12*/
SELECT DISTINCT p.Id, p.Name, a.City person_addr, a2.City univ_addr
FROM Persons p 
	INNER JOIN Addresses a on p.AddressId = a.Id 
	INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
	INNER JOIN StudySubjects ss ON pss.SubjectId = ss.Id 
	INNER JOIN Universities u ON ss.UniversityId = u.Id
	INNER JOIN Addresses a2 ON a2.Id = u.AddressId
	WHERE a.City = a2.City;

/* Result: 2 rows (3 without distinct)*/

/*13*/
SELECT a.City , AVG(p.Age) avg_age
FROM Persons p 
	INNER JOIN Addresses a on p.AddressId = a.Id 
	INNER JOIN PersonsStudySubjects pss ON p.Id = pss.StudentId 
GROUP BY a.City;

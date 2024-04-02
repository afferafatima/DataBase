
    --Q1
	SELECT DISTINCT
    u.Email AS EmailId,
    c.CourseTitle AS CourseName
	FROM
		dbo.AspNetUsers u
	JOIN
		dbo.SpikoStudent s ON u.Id = s.UserId
	JOIN
		dbo.SpikoStudentSection ss ON s.StudentId = ss.StudentId
	JOIN
		dbo.SpikoSection sec ON ss.SectionId = sec.Id
	JOIN
		dbo.SpikoCourse c ON sec.CourseId = c.CourseId
	WHERE
		NOT EXISTS (
			SELECT 1
			FROM dbo.SpikoAssignmentSubmission sa
			JOIN dbo.SpikoAssignment a ON sa.AssignmentId = a.Id
			WHERE sa.StudentId = s.StudentId
			AND a.SectionId = sec.Id
		)


	/*
	--Q2
	SELECT DISTINCT
    CASE 
        WHEN MONTH(ss.EnrolledOn) BETWEEN 1 AND 5 THEN 'Spring ' + CAST(YEAR(ss.EnrolledOn) AS NVARCHAR(4))
        WHEN MONTH(ss.EnrolledOn) BETWEEN 6 AND 8 THEN 'Summer ' + CAST(YEAR(ss.EnrolledOn) AS NVARCHAR(4))
        WHEN MONTH(ss.EnrolledOn) BETWEEN 9 AND 12 THEN 'Fall ' + CAST(YEAR(ss.EnrolledOn) AS NVARCHAR(4))
    END AS SemesterName
	FROM
    dbo.SpikoStudentSection ss
	--Q3
	SELECT DISTINCT c.CourseTitle AS CourseName
	FROM dbo.SpikoCourse c
	LEFT JOIN dbo.SpikoSection s ON c.CourseId = s.CourseId
	LEFT JOIN dbo.SpikoStudentSection ss ON s.Id = ss.SectionId
	WHERE ss.SectionId IS NULL
	--Q4
	SELECT
    s.FullName AS StudentName,
    SUM(se.ObtainedMarks) AS TotalMarks
	FROM
		dbo.SpikoStudent s
	JOIN
		dbo.SpikoStudentSection ss ON s.StudentId = ss.StudentId
	JOIN
		dbo.SpikoSection sec ON ss.SectionId = sec.Id
	JOIN
		dbo.SpikoCourse c ON sec.CourseId = c.CourseId
	LEFT JOIN
		dbo.SpikoStudentEvaluation se ON s.StudentId = se.StudentId
	WHERE
		c.CourseId = 1015
	GROUP BY
		s.FullName

	--Q5
	SELECT
    c.CourseTitle AS CourseName
	FROM
		dbo.SpikoCourse c
	INNER JOIN
		dbo.SpikoAnnouncement a ON c.CourseId = a.CourseId
	GROUP BY
		c.CourseTitle
	HAVING
		COUNT(a.Id) > 5

	--Q6
	SELECT
    s.FullName AS StudentName
	FROM
		dbo.SpikoStudent s
	JOIN
		dbo.SpikoAssignmentSubmission sa ON s.StudentId = sa.StudentId
	JOIN
		dbo.SpikoAssignment a ON sa.AssignmentId = a.Id
	WHERE
		DATEDIFF(hour, a.DeadLine, sa.SubmittedOn) = 1  -- Submitted one hour before the deadline
	GROUP BY
		s.FullName
	HAVING
		COUNT(DISTINCT sa.AssignmentId) > 2  -- More than two assignments submitted at eleventh hour

	--Q7
	SELECT
    c.CourseTitle AS CourseName
	FROM
		dbo.SpikoCourse c
	INNER JOIN
		dbo.SpikoSection sec ON c.CourseId = sec.CourseId
	INNER JOIN
		dbo.SpikoStudentSection ss ON sec.Id = ss.SectionId
	GROUP BY
		c.CourseTitle
	HAVING
		COUNT(DISTINCT ss.StudentId) > 50

	--Q8
	SELECT
    a.Id AS AssignmentId
	FROM
		dbo.SpikoAssignment a
	LEFT JOIN
		dbo.SpikoAssignmentSubmission sa ON a.Id = sa.AssignmentId
	GROUP BY
		a.Id
	HAVING
		COUNT(sa.AssignmentId) <= 2

	--Q9
	SELECT DISTINCT
    c.CourseTitle AS CourseName
	FROM
		dbo.SpikoCourse c
	INNER JOIN
		dbo.SpikoSection sec ON c.CourseId = sec.CourseId
	INNER JOIN
		dbo.SpikoAssignment a ON sec.Id = a.SectionId
	WHERE
		a.OpenDate <= GETDATE()  -- Check if the assignment open date is less than or equal to the current date
		AND GETDATE() <= a.DeadLine  -- Check if the current date is less than or equal to the assignment deadline

	--Q10
	SELECT DISTINCT
    s1.RegistrationNumber AS RegistrationNumber1,
    s2.RegistrationNumber AS RegistrationNumber2
	FROM
		dbo.SpikoStudentSection ss1
	JOIN
		dbo.SpikoStudentSection ss2 ON ss1.StudentId < ss2.StudentId
	JOIN
		dbo.SpikoStudent s1 ON ss1.StudentId = s1.StudentId
	JOIN
		dbo.SpikoStudent s2 ON ss2.StudentId = s2.StudentId
	WHERE
		ss1.SectionId = ss2.SectionId
	GROUP BY
		s1.RegistrationNumber, s2.RegistrationNumber
	HAVING
		COUNT(DISTINCT ss1.SectionId) > 3
	*/
	--Q11
	SELECT DISTINCT
    s1.RegistrationNumber AS RegistrationNumber1,
    s2.RegistrationNumber AS RegistrationNumber2
FROM
    dbo.SpikoAssignmentSubmission sa1
JOIN
    dbo.SpikoAssignmentSubmission sa2 ON sa1.AssignmentId = sa2.AssignmentId
        AND sa1.StudentId < sa2.StudentId
JOIN
    dbo.SpikoStudent s1 ON sa1.StudentId = s1.StudentId
JOIN
    dbo.SpikoStudent s2 ON sa2.StudentId = s2.StudentId
WHERE
    DATEDIFF(minute, sa1.SubmittedOn, sa2.SubmittedOn) = 0
    AND sa1.AssignmentId = sa2.AssignmentId 
GROUP BY
    s1.RegistrationNumber, s2.RegistrationNumber, sa1.AssignmentId
HAVING
    COUNT(*) > 2


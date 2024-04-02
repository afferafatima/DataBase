
-- 1
SELECT DISTINCT u.Email AS EmailId, c.CourseTitle AS CourseName FROM AspNetUsers u JOIN SpikoStudent s ON u.Id = s.UserId JOIN SpikoStudentSection ss ON s.StudentId = ss.StudentId JOIN SpikoSection sec ON ss.SectionId = sec.Id JOIN SpikoCourse c ON sec.CourseId = c.CourseId WHERE s.StudentId NOT IN ( SELECT s1.StudentId FROM SpikoStudent s1 JOIN SpikoStudentSection ss1 ON s1.StudentId = ss1.StudentId JOIN SpikoAssignmentSubmission sa ON ss1.StudentId = sa.StudentId JOIN SpikoAssignment a ON sa.AssignmentId = a.Id JOIN SpikoSection sec1 ON ss1.SectionId = sec1.Id AND sec1.Id = a.SectionId WHERE sec1.CourseId = c.CourseId ) ORDER BY u.Email, c.CourseTitle;



--2
SELECT DISTINCT CONCAT(c.Session, ' ', c.Year) AS SemesterName FROM SpikoCourse c JOIN SpikoSection sc ON c.CourseId = sc.CourseId JOIN SpikoStudentSection sss ON sss.SectionId = sc.Id ORDER BY CONCAT(c.Session, ' ', c.Year);


--3
SELECT DISTINCT c.CourseTitle AS CourseName FROM  SpikoSection Sp  JOIN SpikoCourse c ON sp.CourseId = c.CourseId WHERE C.CourseId NOT IN ( SELECT DISTINCT c.CourseId FROM SpikoStudent s JOIN SpikoStudentSection ss ON s.StudentId = ss.StudentId join SpikoSection Sp on sp.id=ss .SectionId JOIN SpikoCourse c ON sp.CourseId = c.CourseId)


--4
SELECT s.FullName, SUM(se.ObtainedMarks) AS TotalMarks FROM SpikoStudent s JOIN SpikoStudentEvaluation se ON s.StudentId = se.StudentId JOIN SpikoEvaluation ev ON se.EvaluationId = ev.Id JOIN SpikoCourse c ON ev.CourseId = c.CourseId WHERE c.CourseId = 1015 GROUP BY s.FullName ORDER BY TotalMarks DESC;


--5
select sc.CourseTitle from SpikoCourse as sc JOIN SpikoAnnouncement as sa ON sc.CourseId = sa.CourseId GROUP BY sc.CourseTitle HAVING COUNT(sa.Id) > 5;

--6
SELECT DISTINCT ss.FullName AS StudentName FROM SpikoStudent ss inner join SpikoStudentSection sec ON sec.StudentId = ss.StudentId inner JOIN SpikoAssignmentSubmission sas ON ss.StudentId = sas.StudentId inner JOIN SpikoAssignment sa ON sas.AssignmentId = sa.Id inner JOIN SpikoSection sc ON sc.Id = sec.SectionId inner JOIN SpikoCourse c ON sc.CourseId = c.CourseId WHERE DATEDIFF(hour, sa.DeadLine, sas.SubmittedOn) = -1 GROUP BY ss.FullName, c.CourseId HAVING COUNT(DISTINCT sa.Id) > 2;

--7
select distinct c.CourseTitle AS CourseName from SpikoCourse as c JOIN SpikoSection as S ON c.CourseId = S.CourseId JOIN SpikoStudentSection as ss ON S.Id =ss.SectionId  GROUP BY c.CourseTitle HAVING COUNT(DISTINCT ss.StudentId)>50;

--8
SELECT sa.Id   FROM SpikoAssignment sa JOIN SpikoAssignmentSubmission sas ON sa.Id = sas.AssignmentId WHERE sas.SubmittedOn <= sa.DeadLine GROUP BY sa.Id   HAVING COUNT(sas.StudentId) <= 2;

--9
SELECT DISTINCT c.CourseTitle AS CourseName FROM SpikoCourse c JOIN SpikoSection sec ON c.CourseId = sec.CourseId JOIN SpikoAssignment sa ON sec.Id = sa.SectionId WHERE sa.OpenDate <= GETDATE() AND sa.DeadLine >= GETDATE();




--10
SELECT DISTINCT s1.RegistrationNumber AS RegistrationNumber1, s2.RegistrationNumber AS RegistrationNumber2 FROM SpikoStudentSection ss1 JOIN SpikoStudent s1 ON ss1.StudentId = s1.StudentId JOIN SpikoSection sec1 ON ss1.SectionId = sec1.Id JOIN SpikoStudentSection ss2 ON sec1.Id = ss2.SectionId JOIN SpikoStudent s2 ON ss2.StudentId = s2.StudentId JOIN SpikoSection sec2 ON ss2.SectionId = sec2.Id WHERE s1.StudentId <> s2.StudentId AND sec1.CourseId=sec2.CourseId GROUP BY s1.RegistrationNumber, s2.RegistrationNumber HAVING COUNT(DISTINCT sec1.CourseId) > 3 AND COUNT(DISTINCT sec2.CourseId) > 3;

--11
SELECT DISTINCT s1.RegistrationNumber AS RegistrationNumber1, s2.RegistrationNumber AS RegistrationNumber2 
FROM SpikoAssignmentSubmission sub1 
JOIN SpikoStudent s1 ON sub1.StudentId = s1.StudentId
JOIN SpikoAssignmentSubmission sub2 ON sub1.AssignmentId = sub2.AssignmentId 
JOIN SpikoStudent s2 ON sub2.StudentId = s2.StudentId 
WHERE sub1.SubmittedOn < sub2.SubmittedOn AND DATEDIFF(MINUTE, sub1.SubmittedOn, sub2.SubmittedOn) <= 2  GROUP BY s1.RegistrationNumber, s2.RegistrationNumber HAVING COUNT(*) > 2;

SELECT DISTINCT
    s1.RegistrationNumber AS RegistrationNumber1,
    s2.RegistrationNumber AS RegistrationNumber2
FROM
    SpikoAssignmentSubmission sub1
    JOIN SpikoStudent s1 ON sub1.StudentId = s1.StudentId
    JOIN SpikoAssignmentSubmission sub2 ON sub1.AssignmentId = sub2.AssignmentId
    JOIN SpikoStudent s2 ON sub2.StudentId = s2.StudentId
    JOIN SpikoAssignment ass ON sub1.AssignmentId = ass.Id
WHERE
    sub1.SubmittedOn < sub2.SubmittedOn
    AND s1.StudentId <> s2.StudentId
    AND DATEDIFF(MINUTE, sub1.SubmittedOn, sub2.SubmittedOn) <= 2
GROUP BY
    s1.RegistrationNumber,
    s2.RegistrationNumber
    --sub1.AssignmentId  
HAVING
    COUNT(*) > 2;  

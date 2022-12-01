--Part 1
--Jobs table has columns Id, Name and EmployerId.

--Part 2
SELECT * FROM techjobs.employers
WHERE Location ="Saint Louis";


--Part 3
--Next line is a query that will return a list of names and descriptions of all skills
SELECT skills.Name, skills.Description 
FROM techjobs.skills
JOIN jobskills ON skills.Id = jobskills.SkillId
ORDER BY skills.name ASC;
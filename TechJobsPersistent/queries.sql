--Part 1
-- "List the columns and their data types in the Jobs table"
-- MySQL Jobs table: column=Id type=int, column=Name type=longtext, column= EmployerId type=int

--Part 2
-- "Write a query to list the names of the employers in St. Louis City"
-- SELECT NAME FROM EMPLOYERS WHERE LOCATION = "St. Louis City";

--Part 3
-- "Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order."
-- "If a skill does not have a job listed, it should not be included in the results of this query."
-- SELECT DISTINCT s.name, s.description FROM skills s JOIN jobskills js WHERE js.SkillId = s.Id ORDER BY s.Name;

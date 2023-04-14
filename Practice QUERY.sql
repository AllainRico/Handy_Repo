SELECT a.firstname, a.lastname FROM Homeowners a
INNER JOIN Users b ON b.username = a.username
WHERE a.username = 'earl'

SELECT c.firstname, c.lastname FROM Handyman c
INNER JOIN Users b ON b.username = c.username
WHERE c.username = 'kyle'

SELECT a.job_description FROM Createjob a
INNER JOIN Homeowners b ON b.homeowner_ID = a.homeowner_ID


Select c.job_description,a.pay FROM Applyjob a
INNER JOIN Handyman b ON b.handyman_ID = a.handyman_ID
INNER JOIN Createjob c ON c.job_ID = a.job_ID


Select c.pay, b.job_description FROM Joblisting a
INNER JOIN Createjob b ON b.job_ID = a.job_ID
INNER JOIN Applyjob c ON c.apply_ID = a.apply_ID
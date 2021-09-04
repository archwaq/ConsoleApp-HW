-- Get all clients born after year 1990.
USE sql_banking;

SELECT *
FROM clients
WHERE yearofbirth >= '1990-01-01'
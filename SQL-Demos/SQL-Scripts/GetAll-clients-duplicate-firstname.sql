-- Get all clients with duplicate firstname.
USE sql_banking;

SELECT firstname
FROM clients
WHERE firstname = 'Orlin'
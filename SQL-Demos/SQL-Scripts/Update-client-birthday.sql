-- Update client's birthday by id.
USE sql_banking;

UPDATE clients
SET yearofbirth = '1990-04-15'
WHERE client_id = 3
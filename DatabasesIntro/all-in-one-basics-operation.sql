-- 2. Направете следните заявки, като накрая ги запишете с .SQL файл и ги качете в вашето repository.​
-- Изведете всички потребители​
-- Изведете всички потребители с едно и също първо име (примерно Ivan)​
-- Изведете само имената на потребителите родени след дадена година (примерно след 1990)​
-- Променете година и датата на даден потребител (само на 1)​
-- Изведете всички сметки в системата​
-- Изведете всички сметки на даден потребител​
-- Променете сума на дадена сметка на даден потребител (само на 1)​
-- Изтрийте само една сметка на даден потребител​
-- Изтрийте всички сметки на даден потребител​
-- Изтрите даденият потребител (останал без сметки)​

-- Get all clients by their firstname, surname, familyname.
SELECT firstname, surname, familyname FROM clients

-- Get all clients with the duplicate firstname Orlin.
SELECT firstname
FROM clients
WHERE firstname = 'Orlin';

-- Get all clients born after 1990 year.
SELECT firstname
FROM clients
WHERE yearofbirth > '1990';

-- Get all sums.
SELECT sum_total
FROM bank_accounts

-- Get all sums from particular client.
SELECT sum_total
FROM bank_accounts
WHERE client_id = 2;

-- Update yearofbirth of particular client.
UPDATE clients
SET yearofbirth = '1990-04-15'
WHERE client_id = 3;

-- Update client's balance.
UPDATE bank_accounts
SET sum_total = 50000
WHERE account_id = 3;

-- Delete particular client balance.
DELETE FROM bank_accounts
WHERE account_id = 2;

-- Delete client's transactions.
DELETE FROM bank_accounts
WHERE client_id = 1;

-- Deleting client.
DELETE FROM clients
WHERE client_id = 1;
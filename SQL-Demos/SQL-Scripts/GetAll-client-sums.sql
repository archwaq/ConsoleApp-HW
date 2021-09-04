-- Get all client's sums
USE sql_banking;

SELECT sum_total, statuse
FROM bank_accounts
WHERE client_id = 1
-- Get all sums from system.
USE sql_banking;

SELECT sum_total, firstname, familyname
FROM bank_accounts
JOIN clients 
	ON bank_accounts.client_id=clients.client_id
    
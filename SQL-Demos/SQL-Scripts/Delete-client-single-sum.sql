-- Delete particular client balance.
USE sql_banking;

DELETE FROM bank_accounts
WHERE account_id = 2;
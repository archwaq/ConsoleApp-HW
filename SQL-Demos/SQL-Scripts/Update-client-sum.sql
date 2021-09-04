-- Update client's balance.
USE sql_banking;

UPDATE bank_accounts
SET sum_total = 3000
WHERE account_id = 9;
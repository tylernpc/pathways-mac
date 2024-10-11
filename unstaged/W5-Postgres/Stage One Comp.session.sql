-- CREATE TABLE customer (
--     account_id CHAR(5),
--     email_address VARCHAR(50),
--     account_type VARCHAR(50),
--     annual_fee INT,
--     total_amount_spent INT,
--     type_of_nonprofit VARCHAR(50)

--     CHECK (account_type = 'Nonprofit' OR type_of_nonprofit IS NULL)
-- );

-- INSERT INTO customer (account_id, email_address, account_type, annual_fee, total_amount_spent)
-- VALUES ('TLE22', 'tle@dontpaniclabs.com', 'Executive', '300', '40000');

-- INSERT INTO customer (account_id, email_address, account_type, annual_fee, total_amount_spent, type_of_nonprofit)
-- VALUES ('JKD33', 'jkd@dontpaniclabs.com', 'Nonprofit', '300', '40000', 'Educational');

SELECT * FROM customer;
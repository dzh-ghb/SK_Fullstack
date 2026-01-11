DELETE FROM employees 
WHERE id = 18;

DELETE FROM employees 
WHERE id >= 17;

-- Error while executing SQL query on database 'organisation': FOREIGN KEY constraint failed
DELETE FROM employees 
WHERE id = 16;

DELETE FROM employee_details 
WHERE id = 16;

SELECT * FROM employee_details;

-- CREATE >> INSERT
-- READ >> SELECT
-- UPDETE >> UPDETE
-- DELETE >> DELETE

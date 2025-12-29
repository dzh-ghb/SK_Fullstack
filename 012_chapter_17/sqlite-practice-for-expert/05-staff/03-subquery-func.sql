SELECT * FROM employees;
SELECT * FROM departments;

SELECT AVG(salary) AS average_salary
FROM employees;

SELECT MAX(salary) AS max_salary
FROM employees;

SELECT COUNT(*) AS total_employees
FROM employees;

SELECT MIN(age) AS min_age
FROM employee_details;

SELECT * 
FROM employees 
WHERE salary < (SELECT AVG(salary) AS average_salary
FROM employees);

SELECT 
    department_id AS 'Департамент',
    count(*) AS 'Всего числится'
FROM employees
GROUP BY department_id;

SELECT department_id, MAX(salary) AS max_salary
FROM employees
GROUP BY department_id;

SELECT department_id, name
FROM employees
WHERE department_id = (SELECT id FROM departments WHERE name = 'Отдел разработки');

SELECT *
FROM employees
WHERE department_id = (SELECT id FROM departments WHERE name = 'Отдел разработки');

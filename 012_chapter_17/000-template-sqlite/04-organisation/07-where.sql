SELECT DISTINCT name, position FROM employees;

SELECT 
    id, name, position
FROM employees
LIMIT 3 OFFSET 6;

SELECT 
    id, name, position 
FROM employees
WHERE id < 5;

SELECT 
    * 
FROM employee_details as d
WHERE d.age >= 27 AND d.age <= 30;

SELECT 
    * 
FROM employee_details as d
WHERE d.age = 25 OR d.age = 28;

SELECT 
    * 
FROM employee_details as d
WHERE NOT d.age = 25;

SELECT 
    * 
FROM employee_details as d
WHERE d.age != 25;

-- < > <= >= !=, <> =

SELECT 
    * 
FROM employees as e
WHERE e.salary >= 53000 AND e.salary <= 60000;

SELECT 
    * 
FROM employees as e
WHERE e.salary BETWEEN 53000 AND 55000;

SELECT 
    * 
FROM employees as e
WHERE e.position IN ('Разработчик', 'Аналитик');

SELECT 
    * 
FROM employees as e
WHERE e.id <= 8 AND NOT (e.position IN ('Разработчик', 'Аналитик'));

SELECT 
    * 
FROM employees as e
WHERE e.position IS NOT NULL;

SELECT 
    * 
FROM employee_details as d
WHERE d.address LIKE '%д. _0%';

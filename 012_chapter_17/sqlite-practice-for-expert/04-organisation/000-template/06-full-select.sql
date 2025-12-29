SELECT * FROM employees;
SELECT * FROM employee_details;

SELECT 
    name AS 'Полное имя', 
    email AS 'Электронная почта' 
FROM employees;

SELECT 
    employees.name AS 'Полное имя', 
    employees.email AS 'Электронная почта' 
FROM employees;

SELECT 
    employees.name AS 'Полное имя', 
    employees.email AS 'Электронная почта',
    employee_details.age AS 'Возраст',
    employee_details.phone AS 'Телефон'
FROM employees
JOIN employee_details 
ON employees.id = employee_details.employee_id;

SELECT 
    e.name AS 'Полное имя', 
    e.email AS 'Электронная почта',
    d.age AS 'Возраст',
    d.phone AS 'Телефон'
FROM employees AS e
JOIN employee_details AS d
ON e.id = d.employee_id;

SELECT 
    e.name,
    e.email,
    d.age,
    d.phone
FROM employees e
JOIN employee_details d
ON e.id = d.employee_id;

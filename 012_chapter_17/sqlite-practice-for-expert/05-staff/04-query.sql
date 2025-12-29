SELECT * FROM employees;
SELECT * FROM departments;
SELECT * FROM employee_details;

-- 1. Запрос, который выводит список сотрудников 
--    с их отделами (INNER JOIN)

SELECT 
    e.name AS 'Имя сотрудника',
    d.name AS 'Департамент'
FROM employees AS e
INNER JOIN departments AS d 
ON e.department_id = d.id;

-- 2. Запрос, который выводит список всех сотрудников 
--    и их отделов, включая тех сотрудников, 
--    которые не назначены ни в один отдел (LEFT JOIN)

SELECT 
    e.name,
    d.name
FROM employees AS e
LEFT JOIN departments AS d 
ON e.department_id = d.id;

-- 3. Запрос, который выводит декартово произведение всех 
--    сотрудников и всех отделов (каждый сотрудник будет
--    сопоставлен с каждым отделом) CROSS JOIN

SELECT 
    e.name,
    d.name
FROM employees e, departments d; 

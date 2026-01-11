CREATE TABLE IF NOT EXISTS employees (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    position TEXT,    
    salary REAL,
    email TEXT NOT NULL UNIQUE 
);

DROP TABLE IF EXISTS employees;

CREATE TABLE IF NOT EXISTS employee_details (
    id INTEGER PRIMARY KEY,
    employee_id INTEGER UNIQUE,
    address TEXT,
    phone TEXT,
    age INTEGER CHECK(age >= 18),
    FOREIGN KEY (employee_id) REFERENCES employees (id)
);

DROP TABLE IF EXISTS employee_details;

INSERT INTO employees (id, name, position, salary, email)
VALUES (1, 'Иван Иванов', 'Менеджер', 50000.00, 'ivan.ivanov@example.com');

INSERT INTO employees (id, name, position, salary, email)
VALUES (2, 'Анна Смирнова', 'Разработчик', 60000.00, 'anna.smirnova@example.com'),
       (3, 'Петр Петров', 'Аналитик', 55000.00, 'petr.petrov@example.com');

INSERT INTO employees (name, position, salary, email)
VALUES ('Елена Кузнецова', 'Тестировщик', 48000.00, 'elena.kuznetsova@example.com');

INSERT INTO employees (name, salary, email)
VALUES ('Максим Соколов', 52000.00, 'maxim.sokolov@example.com');

SELECT * FROM employees;

-- Решение 
INSERT INTO employee_details (id, employee_id, address, phone, age) VALUES 
(1, 3, 'ул. Ленина, д. 1, кв. 101, Москва', '+7-999-123-4567', 35),
(2, 5, 'ул. Пушкина, д. 2, кв. 202, Санкт-Петербург', '+7-999-234-5678', 29),
(3, 4, 'ул. Чехова, д. 3, кв. 303, Новосибирск', '+7-999-345-6789', 40),
(4, 1, 'ул. Толстого, д. 4, кв. 404, Екатеринбург', '+7-999-456-7890', 25),
(5, 2, 'ул. Тургенева, д. 5, кв. 505, Смоленск', '+7-999-567-8901', 32);

SELECT * FROM employee_details;

-- Ошибка вставки записи. Ограничение на поле age
INSERT INTO employee_details (id, employee_id, address, phone, age) VALUES 
(6, 6, 'ул. Гоголя, д. 6, кв. 606, Самара', '+7-999-678-9012', 12);

-- Ошибка вставки записи. Отсутствие записи в employees
INSERT INTO employee_details (id, employee_id, address, phone, age) VALUES 
(6, 6, 'ул. Гоголя, д. 6, кв. 606, Самара', '+7-999-678-9012', 18);

INSERT INTO employees (name, position, salary, email) VALUES 
('Мария Сидорова', 'HR-менеджер', 65000.00, 'maria.sidorova@example.com');

SELECT * FROM employees;
SELECT * FROM employee_details;

-- Select и псевдонимы
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

-- Добавление записей
-- Вставка данных в таблицу employees
INSERT INTO employees (id, name, position, salary, email) VALUES
(7, 'Мария Петрова', 'Разработчик', 60000.00, 'petrova@example.com'),
(8, 'Алексей Смирнов', 'Аналитик', 55000.00, 'smirnov@example.com'),
(9, 'Инна Сидорова', 'Тестировщик', 45000.00, 'sidorova@example.com'),
(10, 'Дмитрий Козлов', 'Дизайнер', 52000.00, 'kozlov@example.com'),
(11, 'Елена Новикова', 'Менеджер проектов', 58000.00, 'novikova@example.com'),
(12, 'Сергей Морозов', 'Системный администратор', 53000.00, 'morozov@example.com'),
(13, 'Анна Волкова', 'HR-специалист', 48000.00, 'volkova@example.com'),
(14, 'Павел Соколов', 'Маркетолог', 51000.00, 'sokolov@example.com'),
(15, 'Татьяна Лебедева', 'Бухгалтер', 49000.00, 'lebedeva@example.com'),
(16, 'Иван Иванов', 'Менеджер', 50000.00, 'ivanov@example.com');

INSERT INTO employees (id, name, position, salary, email) VALUES
(17, 'Мария Петрова', 'Разработчик', 60000.00, 'petrova_1@example.com'),
(18, 'Мария Петрова', 'Разработчик', 60000.00, 'petrova_2@example.com'),
(19, 'Мария Петрова', 'Разработчик', 60000.00, 'petrova_3@example.com');

-- Вставка данных в таблицу employee_details
INSERT INTO employee_details (id, employee_id, address, phone, age) VALUES
(7, 7, 'ул. Пушкина, д. 20', '+7-900-234-56-78', 28),
(8, 8, 'ул. Гагарина, д. 30', '+7-900-345-67-89', 28),
(9, 9, 'ул. Чехова, д. 40', '+7-900-456-78-90', 29),
(10, 10, 'ул. Толстого, д. 50', '+7-900-567-89-01', 29),
(11, 11, 'ул. Достоевского, д. 60', '+7-900-678-90-12', 29),
(12, 12, 'ул. Тургенева, д. 70', '+7-900-789-01-23', 30),
(13, 13, 'ул. Гоголя, д. 80', '+7-900-890-12-34', 28),
(14, 14, 'ул. Лермонтова, д. 90', '+7-900-901-23-45', 31),
(15, 15, 'ул. Есенина, д. 100', '+7-900-012-34-56', 29),
(16, 16, 'ул. Ленина, д. 10', '+7-900-123-45-67', 30);

SELECT * FROM employees;

SELECT * FROM employee_details;

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
WHERE e.position IN ('Разработчик','Аналитик');

SELECT 
    * 
FROM employees as e
WHERE e.id <= 8 AND NOT (e.position IN ('Разработчик','Аналитик'));

SELECT 
    * 
FROM employees as e
WHERE e.position IS NOT NULL;

SELECT 
    * 
FROM employee_details as d
WHERE d.address LIKE '%д. _0%';

SELECT * FROM employees;

UPDATE employees 
SET position = 'Разработчик', salary =  ROUND(salary * 1.15)
WHERE id = 5;

UPDATE employees 
SET salary =  salary - 100000;

SELECT * FROM employees;

DELETE FROM employees 
WHERE id = 18;

DELETE FROM employees 
WHERE id >= 17;

DELETE FROM employee_details 
WHERE id = 16;

DELETE FROM employees 
WHERE id = 16;

SELECT * FROM employee_details;

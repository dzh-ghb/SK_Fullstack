select * from emps;
select * from emps_details;

insert into emps_details (emp_id, address, phone, age)
values (3, '1``', '222', 18),
       (1, '\\_', '\', 18),
       (2, '%', '222\%', 18);

select * from emps_details
where address like '%\\%\_' escape '\';

select
    e.id as ID,
    e.name as NAME,
    ed.age as AGE,
    e.email as EMAIL
from emps as e
join emps_details as ed
on e.id=ed.emp_id;

INSERT INTO emps (name, position, salary, email) VALUES
('Мария Петрова', 'Разработчик', 60000.00, 'petrova@example.com'),
('Алексей Смирнов', 'Аналитик', 55000.00, 'smirnov@example.com'),
('Инна Сидорова', 'Тестировщик', 45000.00, 'sidorova@example.com'),
('Дмитрий Козлов', 'Дизайнер', 52000.00, 'kozlov@example.com'),
('Елена Новикова', 'Менеджер проектов', 58000.00, 'novikova@example.com'),
('Сергей Морозов', 'Системный администратор', 53000.00, 'morozov@example.com'),
('Анна Волкова', 'HR-специалист', 48000.00, 'volkova@example.com'),
('Павел Соколов', 'Маркетолог', 51000.00, 'sokolov@example.com'),
('Татьяна Лебедева', 'Бухгалтер', 49000.00, 'lebedeva@example.com'),
('Иван Иванов', 'Менеджер', 50000.00, 'ivanov@example.com');

INSERT INTO emps (name, position, salary, email) VALUES
('Мария Петрова', 'Разработчик', 60000.00, 'petrova_1@example.com'),
('Мария Петрова', 'Разработчик', 60000.00, 'petrova_2@example.com'),
('Мария Петрова', 'Разработчик', 60000.00, 'petrova_3@example.com');

select
    id, name, position
from emps
limit 5 offset 3;

select * from emps as e
where NOT (e.id <= 8 and e.position in ('Разработчик','Тестировщик'));

select * from emps where position like '%walker%'
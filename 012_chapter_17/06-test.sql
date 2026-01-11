CREATE TABLE IF NOT EXISTS emps (
    id       INTEGER PRIMARY KEY AUTOINCREMENT,
    name     TEXT    NOT NULL
                     DEFAULT ('joe peach'),
    position TEXT    DEFAULT ('slave'),
    salary   REAL    DEFAULT ('300$'),
    email    TEXT    NOT NULL
                     UNIQUE
);

CREATE TABLE IF NOT EXISTS emps_details (
    id      INTEGER PRIMARY KEY AUTOINCREMENT,
    emp_id  INTEGER UNIQUE,
    address TEXT    DEFAULT ('Privet Drive'),
    phone   TEXT,
    age     INTEGER NOT NULL
                    CHECK (age >= 18),
    FOREIGN KEY (
        emp_id
    )
    REFERENCES emps (id) 
);

INSERT INTO emps VALUES (
                     NULL,
                     'Мария Петрова',
                     'Разработчик',
                     1000,
                     'petrova1@example.com'
                 );

INSERT INTO emps (
                     name,
                     position,
                     salary,
                     email
                 )
                 VALUES (
                     'Мария Петрова',
                     'Разработчик',
                     60000.0,
                     'petrova@example.com'
                 ),
                 (
                     'Алексей Смирнов',
                     'Аналитик',
                     55000.0,
                     'smirnov@example.com'
                 ),
                 (
                     'Инна Сидорова',
                     'Тестировщик',
                     45000.0,
                     'sidorova@example.com'
                 ),
                 (
                     'Дмитрий Козлов',
                     'Дизайнер',
                     52000.0,
                     'kozlov@example.com'
                 ),
                 (
                     'Елена Новикова',
                     'Менеджер проектов',
                     58000.0,
                     'novikova@example.com'
                 ),
                 (
                     'Сергей Морозов',
                     'Системный администратор',
                     53000.0,
                     'morozov@example.com'
                 ),
                 (
                     'Анна Волкова',
                     'HR-специалист',
                     48000.0,
                     'volkova@example.com'
                 ),
                 (
                     'Павел Соколов',
                     'Маркетолог',
                     51000.0,
                     'sokolov@example.com'
                 ),
                 (
                     'Татьяна Лебедева',
                     'Бухгалтер',
                     49000.0,
                     'lebedeva@example.com'
                 ),
                 (
                     'Иван Иванов',
                     'Менеджер',
                     50000.0,
                     'ivanov@example.com'
                 ),
                 (
                     'Мария Петрова',
                     'Разработчик',
                     60000.0,
                     'petrova_1@example.com'
                 ),
                 (
                     'Мария Петрова',
                     'Разработчик',
                     60000.0,
                     'petrova_2@example.com'
                 ),
                 (
                     'Мария Петрова',
                     'Разработчик',
                     60000.0,
                     'petrova_3@example.com'
                 );

INSERT INTO emps_details (
                             emp_id,
                             address,
                             phone,
                             age
                         )
                         VALUES (
                             5,
                             '1%1',
                             '22  %%3\\21',
                             28
                         ),
                         (
                             1,
                             '11_2',
                             '12\324',
                             18
                         ),
                         (
                             2,
                             '%_%',
                             '222\%',
                             25
                         );

SELECT *
  FROM emps;

SELECT *
  FROM emps_details;

SELECT *
  FROM emps_details
 WHERE phone LIKE '%\\\\%' ESCAPE '\';

SELECT DISTINCT e.id AS ID,
                e.name AS NAME,
                ed.age AS AGE,
                e.email AS EMAIL
  FROM emps AS e
       JOIN
       emps_details AS ed ON e.id = ed.emp_id
 ORDER BY 1;

SELECT id,
       name,
       position
  FROM emps
 LIMIT 5 OFFSET 0;

SELECT *
  FROM emps AS e
 WHERE NOT (e.id <= 8 AND
            e.position IN ('Разработчик', 'Тестировщик') );

SELECT *
  FROM emps
 WHERE position LIKE '%Разраб%';

UPDATE emps
   SET name = 'dzh_its',
       salary = 137750,
       email = 'dzh.its@ndbt.ye'
 WHERE id = 14;

UPDATE emps_details
   SET emp_id = 10
 WHERE id = 15;

UPDATE emps
   SET salary = round(salary * 1.15) 
 WHERE id = 14;

DELETE FROM emps
      WHERE id = 10;

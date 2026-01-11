UPDATE employees 
SET position = 'Тестировщик'
WHERE id = 5;

UPDATE employees 
SET position = 'Разработчик', salary =  ROUND(salary * 1.15)
WHERE id = 5;

UPDATE employees 
SET salary =  salary + 100000;

UPDATE employees 
SET salary =  salary - 100000;

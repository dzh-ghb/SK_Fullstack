## Извлечения данных с использованием различных условий и операторов.

### 1. Уникальные значения
```sql
SELECT DISTINCT name, position FROM employees;
```
Этот запрос выбирает уникальные комбинации значений столбцов `name` и `position` из таблицы `employees`.

### 2. Лимит и смещение
```sql
SELECT 
    id, name, position
FROM employees
LIMIT 3 OFFSET 6;
```
Этот запрос выбирает столбцы `id`, `name` и `position` из таблицы `employees`, начиная с 7-й записи (OFFSET 6) и возвращает 3 записи.

### 3. Условие на значение столбца
```sql
SELECT 
    id, name, position 
FROM employees
WHERE id < 5;
```
Этот запрос выбирает столбцы `id`, `name` и `position` из таблицы `employees` для записей, где `id` меньше 5.

### 4. Условие на диапазон значений
```sql
SELECT 
    * 
FROM employee_details as d
WHERE d.age >= 27 AND d.age <= 30;
```
Этот запрос выбирает все столбцы из таблицы `employee_details`, где значение столбца `age` находится в диапазоне от 27 до 30 лет включительно.

### 5. Условие на конкретные значения
```sql
SELECT 
    * 
FROM employee_details as d
WHERE d.age = 25 OR d.age = 28;
```
Этот запрос выбирает все столбцы из таблицы `employee_details`, где возраст (`age`) равен 25 или 28.

### 6. Исключение значения
```sql
SELECT 
    * 
FROM employee_details as d
WHERE NOT d.age = 25;
```
Этот запрос выбирает все столбцы из таблицы `employee_details`, где возраст (`age`) не равен 25. Эквивалент:
```sql
SELECT 
    * 
FROM employee_details as d
WHERE d.age != 25;
```

### 7. Диапазон зарплат
```sql
SELECT 
    * 
FROM employees as e
WHERE e.salary >= 53000 AND e.salary <= 60000;
```
Этот запрос выбирает все столбцы из таблицы `employees`, где зарплата (`salary`) находится в диапазоне от 53000 до 60000.

### 8. Условие BETWEEN
```sql
SELECT 
    * 
FROM employees as e
WHERE e.salary BETWEEN 53000 AND 55000;
```
Этот запрос выбирает все столбцы из таблицы `employees`, где зарплата (`salary`) находится в диапазоне от 53000 до 55000 включительно.

### 9. Условие IN
```sql
SELECT 
    * 
FROM employees as e
WHERE e.position IN ('Разработчик', 'Аналитик');
```
Этот запрос выбирает все столбцы из таблицы `employees`, где должность (`position`) является либо 'Разработчик', либо 'Аналитик'.

### 10. Условие NOT IN
```sql
SELECT 
    * 
FROM employees as e
WHERE e.id <= 8 AND NOT (e.position IN ('Разработчик', 'Аналитик'));
```
Этот запрос выбирает все столбцы из таблицы `employees`, где `id` меньше или равно 8 и должность (`position`) не является ни 'Разработчик', ни 'Аналитик'.

### 11. Проверка на NULL
```sql
SELECT 
    * 
FROM employees as e
WHERE e.position IS NOT NULL;
```
Этот запрос выбирает все столбцы из таблицы `employees`, где значение в столбце `position` не является NULL.

### 12. Условие LIKE
```sql
SELECT 
    * 
FROM employee_details as d
WHERE d.address LIKE '%д. _0%';
```
Этот запрос выбирает все столбцы из таблицы `employee_details`, где в адресе (`address`) содержится подстрока, соответствующая шаблону '%д. _0%'. Подчеркивание (\_) используется для представления одного произвольного символа.

Эти запросы демонстрируют базовые операции SQL для извлечения данных с использованием различных условий и операторов.

Примеры запросов с использованием различных типов JOIN в SQLite.

### INNER JOIN

Запрос, который выводит список сотрудников с их отделами:

```sql
SELECT employees.name AS employee_name, departments.name AS department_name
FROM employees
INNER JOIN departments ON employees.department_id = departments.id;
```

### LEFT JOIN

Запрос, который выводит список всех сотрудников и их отделов, включая тех сотрудников, которые не назначены ни в один отдел:

```sql
SELECT employees.name AS employee_name, departments.name AS department_name
FROM employees
LEFT JOIN departments ON employees.department_id = departments.id;
```

### CROSS JOIN

Запрос, который выводит декартово произведение всех сотрудников и всех отделов (каждый сотрудник будет сопоставлен с каждым отделом):

```sql
SELECT employees.name AS employee_name, departments.name AS department_name
FROM employees
CROSS JOIN departments;
```

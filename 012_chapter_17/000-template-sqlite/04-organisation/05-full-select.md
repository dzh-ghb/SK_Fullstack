```sql
SELECT DISTINCT e.id, e.name, e.position, e.salary, e.email, ed.address, ed.phone, ed.age
FROM employees e
JOIN employee_details ed ON e.id = ed.employee_id
WHERE e.salary > 50000 AND ed.age >= 30
GROUP BY e.id, e.name, e.position, e.salary, e.email, ed.address, ed.phone, ed.age
HAVING COUNT(e.id) > 0
ORDER BY e.salary DESC
LIMIT 10 OFFSET 0;
```

В этом запросе:
- `SELECT DISTINCT` выбирает уникальные строки.
- `FROM employees e JOIN employee_details ed ON e.id = ed.employee_id` соединяет две таблицы.
- `WHERE e.salary > 50000 AND ed.age >= 30` фильтрует строки по условиям.
- `GROUP BY e.id, e.name, e.position, e.salary, e.email, ed.address, ed.phone, ed.age` группирует строки.
- `HAVING COUNT(e.id) > 0` фильтрует группы по условию.
- `ORDER BY e.salary DESC` сортирует результат по убыванию зарплаты.
- `LIMIT 10 OFFSET 0` ограничивает количество возвращаемых строк и смещает начальную позицию.

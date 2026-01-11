SELECT DISTINCT e.id, e.name, e.position, e.salary, e.email, ed.address, ed.phone, ed.age
FROM employees e
JOIN employee_details ed ON e.id = ed.employee_id
WHERE e.salary > 50000 AND ed.age >= 30
GROUP BY e.id, e.name, e.position, e.salary, e.email, ed.address, ed.phone, ed.age
HAVING COUNT(e.id) > 0
ORDER BY e.salary DESC
LIMIT 10 OFFSET 0;

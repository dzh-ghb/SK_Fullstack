Этот SQL скрипт состоит из двух частей: создания таблицы `employees` и удаления этой таблицы.

1. Создание таблицы `employees`:

```sql
CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    position TEXT,
    salary REAL,
    email TEXT NOT NULL UNIQUE 
);
```

- `id INTEGER PRIMARY KEY`: Определяет столбец `id` как первичный ключ, что гарантирует уникальность и автоматическую индексацию.
- `name TEXT NOT NULL`: Определяет столбец `name` как текстовый тип, который не может быть пустым (NULL).
- `position TEXT`: Определяет столбец `position` как текстовый тип, который может содержать пустые значения (NULL).
- `salary REAL`: Определяет столбец `salary` как тип данных с плавающей точкой (REAL), который также может содержать пустые значения (NULL).
- `email TEXT NOT NULL UNIQUE`: Определяет столбец `email` как текстовый тип, который не может быть пустым (NOT NULL) и должен быть уникальным (UNIQUE).

2. Удаление таблицы `employees`:

```sql
DROP TABLE employees;
```

Этот запрос просто удаляет таблицу `employees` из базы данных SQLite, если она существует.

[Этот скрипт SQL](./03-query.sql) описывает SQL запросы для создания и удаления таблиц в базе данных, связанных с хранением информации о сотрудниках.

1. Создание таблицы `employees`:

```sql
CREATE TABLE IF NOT EXISTS employees (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    position TEXT,
    salary REAL,
    email TEXT NOT NULL UNIQUE
);
```

Описание:
- `employees` - таблица для хранения информации о сотрудниках.
- `id` - целочисленный первичный ключ, уникальный идентификатор сотрудника.
- `name` - текстовое поле для имени сотрудника, не может быть пустым (`NOT NULL`).
- `position` - текстовое поле для должности сотрудника.
- `salary` - вещественное число для зарплаты сотрудника.
- `email` - текстовое поле для электронной почты сотрудника, должно быть уникальным (`UNIQUE`).

2. Удаление таблицы `employees`, если она существует:

```sql
DROP TABLE IF EXISTS employees;
```

3. Создание таблицы `employee_details`:

```sql
CREATE TABLE IF NOT EXISTS employee_details (
    id INTEGER PRIMARY KEY,
    employee_id INTEGER UNIQUE,
    address TEXT,
    phone TEXT,
    age INTEGER CHECK(age >= 18),
    FOREIGN KEY (employee_id) REFERENCES employees (id)
);
```

Описание:
- `employee_details` - таблица для хранения дополнительной информации о сотрудниках.
- `id` - целочисленный первичный ключ таблицы `employee_details`.
- `employee_id` - целочисленное поле, уникальный идентификатор сотрудника в таблице `employees`.
- `address` - текстовое поле для адреса сотрудника.
- `phone` - текстовое поле для номера телефона сотрудника.
- `age` - целочисленное поле для возраста сотрудника, с проверкой на возраст 18 и старше (`CHECK(age >= 18)`).
- `FOREIGN KEY (employee_id) REFERENCES employees (id)` - внешний ключ, связывающий `employee_id` в таблице `employee_details` с `id` в таблице `employees`, обеспечивает целостность данных между таблицами.

4. Удаление таблицы `employee_details`, если она существует:

```sql
DROP TABLE IF EXISTS employee_details;
```

Эти SQL запросы позволяют создать и удалить структуры таблиц для хранения информации о сотрудниках в базе данных, с учетом связи между основной информацией о сотрудниках и их дополнительными данными.

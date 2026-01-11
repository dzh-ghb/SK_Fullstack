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

CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    position TEXT,    
    salary REAL,
    email TEXT NOT NULL UNIQUE 
);

DROP TABLE employees;

CREATE TABLE IF NOT EXISTS emps (
    id       INTEGER PRIMARY KEY AUTOINCREMENT,
    name     TEXT    NOT NULL default('joe peach'),
    position TEXT,
    salary   REAL,
    email    TEXT    NOT NULL
                     UNIQUE
);

CREATE TABLE IF NOT EXISTS emps_details (
    id      INTEGER PRIMARY KEY AUTOINCREMENT,
    emp_id  INTEGER UNIQUE,
    address TEXT,
    phone   TEXT,
    age     INTEGER CHECK (age >= 18),
    FOREIGN KEY (
        emp_id
    )
    REFERENCES emps (id) 
);

DROP TABLE IF EXISTS contacts;

CREATE TABLE IF NOT EXISTS contacts (
    id    INTEGER PRIMARY KEY AUTOINCREMENT,
    name  TEXT    NOT NULL
                  DEFAULT ('Joe Peach'),
    phone TEXT    NOT NULL
                  DEFAULT ('Номер не указан'),
    email TEXT    NOT NULL
                  DEFAULT ('Email не указан') 
);

SELECT *
  FROM contacts;

INSERT INTO contacts (
                         name,
                         phone,
                         email
                     )
                     VALUES (
                         'Den',
                         '1337',
                         'dzhits@ndbt.ye'
                     ),
                     (
                         'Ben',
                         '52',
                         'ben@za.voz'
                     ),
                     (
                         'Yen',
                         '11',
                         'ye@ze.ee'
                     );


update contacts
set name = 'daa', phone = '123', email = 'daa@'
where id = 19;

select * from contacts where id = 19;
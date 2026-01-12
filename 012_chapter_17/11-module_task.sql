DROP TABLE IF EXISTS authors;

DROP TABLE IF EXISTS books;

CREATE TABLE IF NOT EXISTS authors (
    id         INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name TEXT    NOT NULL
                       DEFAULT ('Joe'),
    last_name  TEXT    NOT NULL
                       DEFAULT ('Peach'),
    birthdate  DATE    DEFAULT ('1970-01-01') 
);

CREATE TABLE IF NOT EXISTS books (
    id        INTEGER PRIMARY KEY AUTOINCREMENT,
    title     TEXT    NOT NULL
                      DEFAULT ('benzo_book'),
    author_id INTEGER NOT NULL,
    year      INTEGER,
    genre     TEXT,
    FOREIGN KEY (
        author_id
    )
    REFERENCES authors (id) 
);

INSERT INTO authors (
                        first_name,
                        last_name,
                        birthdate
                    )
                    VALUES (
                        'Лев',
                        'Толстой',
                        '1828-09-09'
                    ),
                    (
                        'Федор',
                        'Достоевский',
                        '1821-11-11'
                    ),
                    (
                        'Джоан',
                        'Роулинг',
                        '1965-07-31'
                    );

INSERT INTO books (
                      title,
                      author_id,
                      year,
                      genre
                  )
                  VALUES (
                      'Война и мир',
                      1,
                      1869,
                      'Роман'
                  ),
                  (
                      'Анна Каренина',
                      1,
                      1877,
                      'Роман'
                  ),
                  (
                      'Преступление и наказание',
                      2,
                      1866,
                      'Роман'
                  ),
                  (
                      'Братья Карамазовы',
                      2,
                      1880,
                      'Философский'
                  ),
                  (
                      'Гарри Поттер и философский камень',
                      3,
                      1997,
                      'Фэнтези'
                  );

SELECT *
  FROM authors;

SELECT *
  FROM books;

DELETE FROM books
      WHERE id >= 6;

INSERT INTO authors (
                        birthdate
                    )
                    VALUES (
                        NULL
                    );

INSERT INTO authors (
                        first_name,
                        last_name,
                        birthdate
                    )
                    VALUES (
                        'Бензо',
                        'Валет',
                        '1337-07-07'
                    );

SELECT a.first_name || ' ' || a.last_name AS Автор,
       b.title AS [Название произведения],
       b.genre AS Жанр,
       b.year AS [Год публикации]
  FROM authors AS a
       INNER JOIN
       books AS b ON a.id = b.author_id
 WHERE a.last_name LIKE ('Толстой');

SELECT a.first_name || ' ' || a.last_name AS Автор,
       b.title AS [Название произведения],
       b.genre AS Жанр,
       b.year AS [Год публикации]
  FROM authors AS a
       LEFT JOIN
       books AS b ON a.id = b.author_id;

SELECT a.first_name || ' ' || a.last_name AS Автор,
       (
           SELECT count( * ) 
             FROM books
            WHERE author_id = a.id
       )
       AS [Количество произведений]
  FROM authors AS a
 ORDER BY 1;

SELECT a.first_name || ' ' || a.last_name AS Автор,
       count(b.id) AS [Количество произведений]
  FROM authors AS a
       LEFT JOIN
       books AS b ON a.id = b.author_id
 GROUP BY 1
 ORDER BY 1;

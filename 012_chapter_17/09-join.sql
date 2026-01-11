create table users (
    id integer primary key,
    name text not null,
    age integer
    );
    
insert into users (id, name, age)
values (1, 'J', 25),
    (2, 'N', 30),
    (3, 'S', 28);
create table orders (
    id integer primary key,
    user_id integer not null,
    product text not null
/*    foreign key (user_id) references users (id)*/
    );
    
INSERT INTO orders (id, user_id, product) VALUES
(1, 1, 'Ноутбук'),
(2, 1, 'Наушники'),
(3, 2, 'Монитор'),
(4, 3, 'Клавиатура');

select * from users;
select * from orders;

select u.id, u.name, o.product
from users as u
inner join orders as o on u.id = o.user_id;

select u.id, u.name, o.product
from users as u
left join orders as o on u.id = o.user_id;


INSERT INTO users (id, name, age) VALUES
(4, 'Серёжа', 21);
SELECT * FROM users;
DELETE FROM users WHERE id = 5;

INSERT INTO orders (id, user_id, product) VALUES
(5, 5, 'Микрофон1112');
DELETE FROM orders WHERE id = 5;

SELECT users.name, orders.product
FROM users
CROSS JOIN orders;
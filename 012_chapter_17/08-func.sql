SELECT count( * ) 
  FROM emps;

SELECT sum(salary) 
  FROM emps;

SELECT avg(salary) 
  FROM emps;

SELECT min(salary),
       max(salary) 
  FROM emps;

SELECT *
  FROM emps
 WHERE salary > (
                    SELECT avg(salary) 
                      FROM emps
                );

SELECT avg(tmp.salary) 
  FROM (
           SELECT salary
             FROM emps
            WHERE dep_id = 1
       )
       AS tmp;

SELECT name,
       (
           SELECT count( * ) 
             FROM emps
            WHERE dep_id = d.id
       )
       AS emps_count
  FROM deps AS d;


select * from deps;
select * from emps;
select * from emp_dets;

select *
from emps
where id in (select emp_id from emp_dets where join_date > '2022-01-01');


select dep_id, count(id) as emps_count
from emps
group by dep_id;

select dep_id, max(salary) as max_s
from emps
group by dep_id;

select dep_id, avg(salary)
from emps
group by dep_id;

select dep_id, position, max(salary) as m
from emps
group by dep_id, position;

select d.name, count(*) as count
from emps as e
join deps as d on e.dep_id = d.id
where (select id from deps where name="шарага")
group by 1
order by 1 asc;

select name, (select count(*) from emps where dep_id = d.id) as count
from deps as d
order by 1 asc;
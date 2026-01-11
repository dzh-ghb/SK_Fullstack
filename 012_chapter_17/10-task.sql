select * from deps;
select * from emps;
select * from emp_dets;

select e.name as [name], d.name as [dep]
from emps as e
inner join deps as d on e.dep_id = d.id
order by 2, 1 asc;

select e.name as [name], d.name as [dep]
from emps as e
left join deps as d on e.dep_id = d.id
order by 2, 1 asc;

select e.name as [name], d.name as [dep]
from emps as e
cross join deps as d;

select e.name as [name], d.name as [dep]
from emps as e, deps as d;

select name, (select count(id) from emps where dep_id = d.id) as count
from deps as d;
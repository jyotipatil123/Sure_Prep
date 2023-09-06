create database newdatabase

use sureprep

use newdatabase

create table mytable(id int, name varchar(50))

data types : 
   numeric,int,  varchar, nvarchar, date, time, datetime, datetime2.....

insert into mytable(id, name) values(100, 'parimala')

select * from mytable
types : 
1. DDL   Data Definition Language
    create database
	create table
	alter table
	drop table

2. DML   Data Manipulation Language
   insert
   delete 
   update

create table dummytable(id int, name varchar(50))

drop table dummytable

select * from mytable
insert into mytable(id, name) values(101,'pooja'), (102,'lalita')
insert into mytable values(104,'karuna')

update : modification of a record  
   update mytable set name='anil' where id=100

alter table : modifying the table 

alter table mytable add city varchar(50)
alter table mytable alter column city varchar(100)
==========================================================================

operators : 
1. arithemetic operators   +   -   * / %
   
   select 10+2,10-2,10*2,10/2, 10%2

2. logical operators  and   or  not !
   
   select * from mytable where id=100 and name='pooja'

   select * from mytable where id=100 or name='pooja'
   
3. relational operators   <  >   <=  >=  <> != 

   select * from mytable where id >100
     select * from mytable where id <100
	    select * from mytable where id >=100
		  select * from mytable where id <=100
		    select * from mytable where id !=100

4. assignment operator  =
5. ternary operator ?:

   
6. comparison operator ==


where clause : 
   to check the condition 


select id,name,city from mytable

select distinct(id) from mytable

declare @var1 varchar(50)
select @var1='abc'
print @var1

declare @a int, @b int
select @a=10, @b=20
print 'addition result is : '
print (@a+@b)


declare @a int, @b int
select @a=10, @b=20
print 'subtraction result is : '
print (@a-@b)


declare @a int, @b int
select @a=10, @b=20
print 'multiplication result is : '
print (@a*@b)


declare @a int, @b int
select @a=10, @b=20
print 'division result is : '
print (@a/@b)
==================================================================

Set theory : 
union, minus, intersect , union all

create table table1(id int, name varchar(50), city varchar(50))

create table table2(empid int, empname varchar(50), empcity varchar(50))

select * from table1
union
select * from table2
========================================
select id from table1
intersect
select empid from table2
========================================
select * from table1
union all
select * from table2


union, unionall, intersect, minus ??? difference 

==================================================================
SQL Day 2 

1. where clause :

select  * from table1 where id=10
select  * from table1 where id>=10
select  * from table1 where id<=10

2. distinct clause : 

select distinct(id),name ,city from mytable

3. order by clause : 

select * from mytable order by id 
select * from mytable order by id asc
select * from mytable order by id desc

select * from mytable order by id asc,name desc

4. like : _ %
select * from mytable where name like 'a%'
select * from mytable where name like '%l'
select * from mytable where name like 'a___'
select * from mytable where name like 'a__%'
select * from mytable where name like 'a%' and id >100

5. in, any, all

select * from mytable where id in (101, 102, 10)

any, all ---> subqueries

Sub Query : 
Query within a query 
outer query--inner query 

select * from mytable where id in (101, 102, 10)

select * from mytable where id > any (select id from mytable where id >101)
select * from mytable where id < any (select id from mytable where id >101)

select * from mytable where id > all (select id from mytable where id >101)
select * from mytable where id < all (select id from mytable where id >101)
================================================================================

Loops : 

DECLARE @Counter INT 
SET @Counter=1

WHILE ( @Counter <= 10)
BEGIN
    PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
    SET @Counter  = @Counter  + 1
END
=================================================================================

DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 10)
BEGIN
  PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
  IF @Counter >=7
  BEGIN
      BREAK
  END
    SET @Counter  = @Counter  + 1
END
==============================================================================

DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 20)
BEGIN
 
  IF @Counter % 2 =1
  BEGIN
     SET @Counter  = @Counter  + 1
     CONTINUE
  END
    PRINT 'The counter value is = ' + CONVERT(VARCHAR,@Counter)
    SET @Counter  = @Counter  + 1
END
=============================================================================
declare @a int
set @a=100
if(@a=10)
   print 'a value is 10'
else if ( @a>10)
   print 'a value is greater than 10'
else if (@a <10)
   print 'a value is less than 10'
==========================================================================
-- CASE condition with ELSE clause in SQL 
SELECT id, name,
CASE
    WHEN name = 'Pooja' THEN 'Welcome Pooja'
    WHEN name = 'Karuna' THEN 'Welcome Karuna'
    ELSE 'Bye'
END AS names
FROM mytable;

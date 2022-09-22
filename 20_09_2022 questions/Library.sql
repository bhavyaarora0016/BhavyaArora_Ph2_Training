use Shopping;

--add reference column in issue table
alter table Issue add Reference char(30);

--drop the reference column
alter table Issue drop column Reference;

--insert values to member table

insert into Member values(1,'Kanye','2022-06-28',7,420.69);
insert into Member values(2,'Aubrey','2022-07-07',7,420.69);
insert into Member values(3,'Abel','2019-07-16',7,420.69);
insert into Member values(4,'Travis','2020-07-21',7,420.69);
insert into Member values(5,'Arthur','2022-09-23',7,420.69);

select * from Member;

--insert values to Book table

insert into Book values(1,'blockchain evolution','Don Tapscott',499,'blockchain');
insert into Book values(2,'Ikigai','Don Joe',899,'self help');
insert into Book values(3,'Kimetsu no yaiba','Kamado Tanjiro',1299,'manga');
insert into Book values(4,'Shingeki no Kyojin','Hajime Isayama',999,'manga');
insert into Book values(5,'Nanatsu no Taizai','Nakaba Suzuki',1499,'manga');

select * from Book;

--modify the Book table data

update Book set Cost = 899, Category = 'technology'
where Book_No = 1;

--copy data

select * into Member101 from Member;

--insert data to Issue table

insert into Issue values(801,1,1,'12-dec-09',null);
insert into Issue values(802,2,2,'16-jul-09',null);
insert into Issue values(803,4,1,'24-dec-09',null);
insert into Issue values(804,1,1,'06-sep-09',null);
insert into Issue values(805,4,2,'11-may-09',null);
insert into Issue values(806,1,3,'28-feb-09',null);

alter table Issue
drop constraint FK__Issue__Member_Id__5AEE82B9

select * from Issue;

update Issue
set Return_date = DATEADD(DAY,15,Issue_Date)
where Lib_Issue_Id = 804 or Lib_Issue_Id = 805;

--update penalty

update Member
set Penalty_Amount = 100.71
where Member_Name = 'Aubrey'

select * from Member

select * from Issue;

--remove from issue 
delete  from Issue
where Member_Id = 1 and Issue_Date <'12-Dec-09';

--remove from book
delete from Book
where Category != 'technology' AND Category!= 'self help'

alter table Issue
drop constraint "FK__Issue__Book_NO__5BE2A6F2"

drop table Member101;

select * from INFORMATION_SCHEMA.TABLES

select * from Member
WHERE YEAR( Acc_Open_Date) = 2006;

--List all the books that are written by Author Loni and has price  less then 600.
select * from Issue

select Book.Book_Name from Book
where Author = 'Kamado Tanjiro' and Cost<600;

--List the Issue details for the books that are not returned yet
select  distinct Issue.Book_No , Book.Book_Name from Lib_Issue,Book
where Return_date is null

update Issue
set Return_date = '30-Dec-06' 
where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

select * from Issue
where DATEDIFF(day,Issue_Date,Return_date) > 15;

select * from Book
where Cost between 500 and 700  and Category = 'technology'

select * from Book 
where Category in ('manga', 'self help', 'Fiction');

select * from Member
order by Penalty_Amount desc

select * from Book
order by Category , Cost desc

select * from Book
where Book_Name like '%SQL%'

select * from Member
where (Member_Name like 'S%' and Member_Name like '%a%')


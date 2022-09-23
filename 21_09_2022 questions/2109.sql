use Shopping

select Category, count(Book_No) from Book
group by Category

select Book_NO,count(Lib_Issue_Id) IssuedCount from Issue 
group by Book_NO
order by IssuedCount


select max(Penalty_Amount)from Member

select max(Penalty_Amount) Max ,min(penalty_amount) Min,sum(penalty_amount) Sum,avg(penalty_Amount) Average  from Member

select Member_Id, Book_NO,count(Lib_Issue_Id) IssuedCount from Issue 
group by Book_NO,Member_Id
order by IssuedCount desc

select month(Issue_Date) month,count(Book_NO) bookcount from Issue
group by month(Issue_Date)
order by bookcount desc
select Book_NO from issue where Issue_Date is  null

select m.Member_Id,i.Member_Id "dept"
from member m inner join issue i
on m.Member_Id=i.Member_Id

select Member_Id ,max(Lib_Issue_Id) Max,min(Lib_Issue_Id) Min from Issue
group by Member_Id


select b.Book_No,b.book_name,i.Issue_Date,b.Category
from Book b inner join issue i
on b.Book_No=i.Book_No
where month(issue_date)=7 and b.Category='manga'


select m.Member_Id,m.member_name, count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.Member_Id=i.Member_Id
group by rollup( m.Member_Id ,m.member_name)
order by Issuecount desc


select b.Book_No,b.book_name,i.Issue_Date,i.Return_date
from Book b inner join issue i
on b.Book_No=i.Book_No
where b.author='Kamado Tanjiro'


select Category,max(Cost) from Book
group by (Category)

select distinct i.* from Issue i,member m where i.Issue_Date not between m.acc_open_date and i.return_date

select member_id from member intersect select Member_Id from Issue


use Northwind;
select*from Customers
select distinct count(customerid)from customers

select distinct count(customerid)from customers
where ContactName like '%s%'

select distinct count(customerid)from customers
where ContactName like 'b%'

select distinct city,count(customerid)from customers
group by(City)


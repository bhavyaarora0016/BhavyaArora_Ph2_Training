create database Shopping;
use Shopping;

create table Customer(custid int primary key, custname varchar(20), city varchar(20), state varchar(20));
create table Products(prodid int primary key, prodname varchar(20), unitprice int, unitofMeasurement int, qtyinStock int);

create table sales_header(invno int primary key, invdate date, invamt date, disPercent int);
create table sales_details(invno int, custid int, prodid int, qtySold int);

alter table sales_details add foreign key (invno) references sales_header(invno);
alter table sales_details add foreign key (custid) references Customer(custid);
alter table sales_details add foreign key (prodid) references Products(prodid);

alter table sales_details drop column qtySold;

alter table sales_details add qty int;


------------------------------------------

use Shopping;

CREATE TABLE Member(memberid int PRIMARY KEY, membername char(25), acc_opendate date, max_booksallowed int, penalty_amt Decimal(7,2));

create table Book(bookno int primary key, bookname varchar(30), author varchar(30), cost Decimal(7,2), category Char(10));

create table Issue(issueid int primary key, bookno int, memberid int, issue_date date, return_date date);

alter table Issue add  foreign key (bookno) references Book(bookno);
alter table Issue add  foreign key (memberid) references Member(memberid);

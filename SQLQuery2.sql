drop database CustomerssInfo
Create database CustomerssInfo
go 
use CustomerssInfo
Create table Customer
(

  CID int primary key,
  CName varchar(15),
  Addresss varchar(50),

  phone_Number int unique,
  Email varchar(50) unique,

  City varchar(15),
  PinCode varchar(20) ,
  Country varchar (15)


)
go
insert into Customer values (1,'Himel','#8/Shaeal bari',01815648616,'himel8920@gmail.com','Mirpur','1217','Bangladesh')

go
select * from Customer
 go



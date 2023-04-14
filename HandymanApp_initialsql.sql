create database handymandb
GO

use handymandb
GO

create table tblUsers(
	username nvarchar(50) primary key,
	password nvarchar(50) not null
)
GO

create table tblHandyman(
	handyman_id int identity(11111,1) primary key,
	username nvarchar(50) FOREIGN KEY REFERENCES tblUsers(username) NOT NULL,
	firstname nvarchar(50) NOT NULL,
	contactnumber nvarchar(11) not null,
	municipality nvarchar(50) not null,
	city nvarchar(50) not null,
	barangay nvarchar(50) not null,
	street nvarchar(50) not null,
	expertfield nvarchar(50) not null,
	about nvarchar(MAX) not null
)
GO

create table tblHomeowners(
	homeowner_ID int identity(11111, 1) primary key,
	username nvarchar(50) FOREIGN KEY REFERENCES tblUsers(username),
	firstname nvarchar(50) not null,
	lastname nvarchar(50) not null,
	contactnumber nvarchar(11) not null,
	municipality nvarchar(50) not null,
	city nvarchar(50) not null,
	barangay nvarchar(50) not null,
	street nvarchar(50) not null,
)
GO

create table tblCreateJob(
	job_ID int identity(11111, 1) primary key,
	homeowner_ID int FOREIGN KEY REFERENCES tblHomeowners(homeowner_ID),
	job_description nvarchar(MAX) not null,
	basepay decimal(10,2) not null,
	timeframe int,
	dateposted date not null
)
GO

create table tblApplyJob(
	apply_id int identity(11111, 1) primary key not null,
	job_id int FOREIGN KEY REFERENCES tblCreateJob(job_id),
	handyman_ID int FOREIGN KEY REFERENCES tblHandyman(handyman_ID),
	payasked decimal(10,2) not null,
	applydate date not null
)
GO

create table tblJobListing(
	job_id int FOREIGN KEY REFERENCES tblCreateJob(job_id),
	apply_id int FOREIGN KEY REFERENCES tblApplyJob(apply_id)
)
GO

select * from tblUsers
GO
select * from tblHandyman
GO
select * from tblHomeowners
GO
select * from tblCreateJob
GO
select * from tblApplyJob
GO
select * from tblJobListing
GO




Create Database CallOut

Create table E_Numbers
(
	ID int not null IDENTITY(1,1)
	Constraint PK_E_Numbers_ID
	Primary Key(ID),
	Name varchar(100) not null,
	PolNum varchar(20) not null,
	FireNum varchar(20) not null,
	HealthNum varchar(20) not null
)

insert into E_numbers
values('Myanmar','199','191','192')

insert into E_numbers
values('Singapore','1800-255-0000','955','955')

insert into E_numbers
values('Thailand','191','1669','199')

select * from E_Numbers

drop table E_Numbers
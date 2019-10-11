create table Components (
SKU int primary key identity (1001, 1) not null,
Name varchar(100) not null,
Description varchar(100) not null,
Price dec(8, 2) not null,
Category varchar(50) not null,
SubCategory varchar(50) not null,
DateFirstInStock date not null,
Com_Image image not null,
Available bit not null
)


insert into Components values ('Windows 10', 'Windows 10 Operating System',130, 'Software', 'Operating System', '2017-05-21', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\windows_10.png', SINGLE_BLOB) as W10), 1)
insert into Components values ('Windows 8', 'Windows 8 Operating System', 110, 'Software', 'Operating System', '2012-11-08', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\windows_8.jpg', SINGLE_BLOB) as W08), 0)
insert into Components values ('Call of Duty', 'Call of Duty Black Ops 4', 60, 'Software', 'Video Game', '2018-09-30', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\cod_bo4.png', SINGLE_BLOB) as BO4), 1)
insert into Components values ('Microsoft Excel', 'Microsoft Office Excel', 110, 'Software', 'Productivity', '2015-06-04', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\excel.jpg', SINGLE_BLOB) as Exl), 0)
insert into Components values ('Fujitsu Monitor', 'Fujitsu Monitor 27 Inch', 110, 'Hardware', 'PC Hardware', '2016-08-04', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\fujitsu_monitor.jpg', SINGLE_BLOB) as FJM), 1)
insert into Components values ('Logitech Keyboard', 'Logitech Gaming Keyboard', 110, 'Hardware', 'PC Hardware', '2014-09-07', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\logitech_keyboard.jpg', SINGLE_BLOB) as LTK), 1)
insert into Components values ('HP Monitor', 'HP Monitor 32 Inch', 115, 'Hardware', 'PC Hardware', '2011-12-04', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\hp_monitor.jpg', SINGLE_BLOB) as HPM), 1)
insert into Components values ('ASUS Monitor', 'ASUS Monitor 40 Inch', 120, 'Hardware', 'PC Hardware', '2019-04-30', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\asus_monitor.jpg', SINGLE_BLOB) as ASM), 1)
insert into Components values ('Borderlands 3', 'Borderlands 3 PC', 60, 'Software', 'Video Game', '2019-09-13', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\bl3_ps4.png', SINGLE_BLOB) as BL3), 1)
insert into Components values ('Epson Printer', 'Epson Colour Printer', 150, 'Hardware', 'PC Hardware', '2007-05-12', (SELECT * FROM OPENROWSET(BULK N'C:\Users\Trainee\Desktop\Component_Images\epson_printer.jpg', SINGLE_BLOB) as ESP), 1)

drop table Components

select * from Components

create table Users (
UserID int primary key identity (1, 1) not null,
FirstName varchar(50) not null,
LastName varchar(50) not null,
UserName varchar(50) not null,
User_Password varchar(50) not null,
Is_Admin bit not null
)

insert into Users values ('Ivan', 'White', 'admin', '1234', 1)
insert into Users values ('Paddy', 'Murphy', 'employee', 'abcd', 0)

drop table Users

create procedure sp_DeleteComponent @SKU int as delete from Components where SKU = @SKU

drop procedure sp_DeleteComponent

create procedure sp_GetComponents as select * from Components

create procedure sp_AddComponent @Name varchar(100), @Description varchar(100),
@Price smallmoney, @Category varchar(50), @SubCategory varchar(50), @DateFirstInStock date, @Com_Image varbinary(max), @Available bit 
as insert into Components values(@Name, @Description, @Price, @Category, @SubCategory, @DateFirstInStock, @Com_Image, @Available)

drop procedure sp_AddComponent

create procedure sp_GetUsers as select * from Users

create procedure sp_EditComponent @SKU int, @Name varchar(100), @Description varchar(100), @Price smallmoney, @Category varchar(50), @SubCategory varchar(50), @Image image, @DateTime date, @Available bit as update Components 
set Name = @Name, Description = @Description, Price = @Price, Category = @Category, SubCategory = @SubCategory, DateFirstInStock = @DateTime, Com_Image = @Image, Available = @Available where SKU = @SKU -- Edit Component procedure

drop procedure sp_EditComponent
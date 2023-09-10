use _7pm
create table Country
(
cid int identity primary key,
Cname nvarchar(200) not null unique,
CDate Date default getdate(),
MDate date Default getdate()
)
create proc _insertCountry
@Cname nvarchar(200)
as
begin
insert into Country(Cname)Values(@Cname)
end
create proc _DeleteCountry
@Cname nvarchar(200),
@Mdate Date
as
begin
Delete from Country where Cname=@Cname
end
create proc _UpdateCountry
@Cname nvarchar(200),
@MDate Date,
@id int
as
begin
Update Country set Cname=@Cname, MDate=GETDATE() where cid=@id
end
select * from Country



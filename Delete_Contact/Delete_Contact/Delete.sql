create procedure [dbo].[SpDeleteContact]
(
@FirstName varchar(200),
@LastName varchar(100),
@address varchar(150),
@city varchar(255),
@State varchar(150),
@Zip varchar(140),
@PhoneNumber varchar(150),
@Email varchar(255)
)
as
begin
delete from AddressBookTable
where FirstName=@FirstName 
end

select * from AddressBookTable
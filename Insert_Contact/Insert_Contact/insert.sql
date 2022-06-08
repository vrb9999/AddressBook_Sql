create procedure [dbo].[SpAddContacts]
(
@FirstName varchar(255),
@LastName varchar(255),
@address varchar(255),
@city varchar(255),
@State varchar(255),
@Zip varchar(255),
@PhoneNumber varchar(255),
@Email varchar(255)
)
as
begin
insert into AddressBookTable values
(@FirstName,@LastName,@address,@city,@State,@Zip,@PhoneNumber,@Email)
end
go

create procedure [dbo].[SpEditContact]
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
update AddressBookTable set LastName=@LastName,address=@address,city=@city,State=@State,Zip=@Zip,PhoneNumber=@PhoneNumber,Email=@Email
where FirstName=@FirstName 
end

select * from AddressBookTable
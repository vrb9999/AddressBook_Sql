Alter Table AddressBookTable Add ContactType varchar(27);

Update AddressBookTable Set ContactType = 'Family' Where Firstname = 'Darshan';
Update AddressBookTable Set ContactType = 'Friends' Where Firstname = 'Vikram';
Update AddressBookTable Set ContactType = 'Profession' Where Firstname = 'Raj';

select * from AddressBookTable
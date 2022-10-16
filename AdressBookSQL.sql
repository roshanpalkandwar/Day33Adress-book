CREATE DATABASE AddressBookService1

use AddressBookService1

CREATE TABLE Address_Book
(
	FirstName varchar(255),
	LastName varchar(255),
	Address varchar(255),
	City varchar(255),
	State varchar(255),
	Zip int,
	PhoneNumber bigint,
	Email varchar(255)
)

select * from Address_Book

CREATE PROCEDURE SpAddContactDetails
(
	@FirstName varchar(255),
	@LastName varchar(255),
	@Address varchar(255),
	@City varchar(255),
	@State varchar(255),
	@Zip int,
	@PhoneNumber bigint,
	@Email varchar(255)
)
as
begin
	INSERT INTO Address_Book(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
	VALUES (@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email)
end

CREATE PROCEDURE SpUpdateContactDetails
(
	@FirstName varchar(255),
	@Address varchar(255),
	@City varchar(255),
	@Zip int
	
)
as 
begin
	UPDATE Address_Book
	SET Address=@Address, City=@City, zip=@zip WHERE FirstName=@FirstName
end

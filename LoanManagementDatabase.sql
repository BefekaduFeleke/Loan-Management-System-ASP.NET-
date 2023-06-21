Create Database LoanManagementSystem
go

Use LoanManagementSystem
go


CREATE TABLE Customers (
    CustomerID int primary key identity,
	FirstName varchar(255) NOT NULL,
    MiddleName varchar(255) NOT NULL,
   LastName varchar(255) NOT NULL,
   DateOfBirth date NOT NULL,
   Gender varchar(10) NOT NULL,
   PhoneNumberOne varchar(30) NOT NULL,
    PhoneNumberTwo varchar(30) NOT NULL,
	Email varchar(50) NOT NULL ,
	Occupation varchar(100) NOT NULL,
   profile_picture image NOT NULL,
	IdType  varchar(30) NOT NULL,
	IdNumber varchar(30) NOT NULL,
	IdIssuedDate date NOT NULL,
	ExpiryDate date NOT NULL,
	Income money NOT NULL,
	IncomeProofPhoto image NOT NULL,
	Rating float,
	username varchar(30) ,
	password CHAR(20),
	SuretyId int references Surety(SuretyID) on delete set null,
);
drop table Customers
go
ALTER TABLE Customers
ALTER COLUMN  PhoneNumberTwo varchar(30);

ALTER TABLE Customers
ALTER COLUMN   profile_picture image ;

ALTER TABLE Customers
ALTER COLUMN  IncomeProofPhoto image ;

ALTER TABLE Customers
ALTER COLUMN Rating DECIMAL(5,2)  ;

ALTER TABLE Customers
ADD CustomerStatus varchar(20);


CREATE TABLE Surety (
	   SuretyID int primary key  NOT NULL ,
		FirstName varchar(255) NOT NULL,
		MiddleName varchar(255) NOT NULL,
	   LastName varchar(255) NOT NULL,
	   DateOfBirth date NOT NULL,
	   Gender varchar(10) NOT NULL,
	   PhoneNumberOne varchar(30) NOT NULL,
		PhoneNumberTwo varchar(30) ,
		Email varchar(50) NOT NULL ,
		Occupation varchar(100) NOT NULL,
	   profile_picture image ,
		IdType  varchar(30) NOT NULL,
		IdNumber varchar(30) NOT NULL,
		IdIssuedDate date NOT NULL,
		ExpiryDate date NOT NULL,
		Income money NOT NULL,
		IncomeProofPhoto image 
);
go
drop table Surety
SET IDENTITY_INSERT Surety ON;  

ALTER TABLE Surety
ALTER COLUMN SuretyID int   NOT NULL ;

CREATE TABLE LoanType (
LoanTypeId int primary key identity,
MinimunAmount money,
MaximumAmount money,
LoanName varchar(30),
loan_duration varchar(30) NOT NULL,
ServiceCharge decimal,
LoanDescription varchar(400)
);
go
ALTER TABLE LoanType
ALTER COLUMN LoanDescription varchar(400)  ;



CREATE TABLE LoanApplication (
LoanApplicationId int primary key identity NOT NULL,
LoanControlNumber varchar(30) NOT NULL,
loan_amount money NOT NULL,
purpose varchar(100) NOT NULL,
LoanApplicationSubmissionDate date NOT NULL,
LoanApplicationApprovedDate date,
loan_status Varchar(20) Default 'Submitted',
remarks varchar(50) NOT NULL,
CustomerID int references Customers(CustomerID) on delete set null,
LoanTypeId int references LoanType(LoanTypeId) on delete set null,
);
drop table LoanApplication
go

ALTER TABLE LoanApplication
ADD TotalAmount decimal;

ALTER TABLE LoanApplication
ADD Payment_Status varchar(20);

ALTER TABLE LoanApplication
ADD PaymentDate date;

ALTER TABLE LoanApplication
ADD PaymentStatus varchar(20);




Delete LoanTransactions

CREATE TRIGGER Total_Calculator ON LoanApplication AFTER INSERT AS
UPDATE [LoanApplication]
SET [LoanApplication].[TotalAmount] =
    [LoanApplication].loan_amount * 1.1;

CREATE TRIGGER Status ON Customers AFTER INSERT AS
UPDATE Customers
SET Customers.CustomerStatus ='Good'


CREATE TRIGGER Rating ON Customers AFTER INSERT ASs
UPDATE Customers
SET Customers.Rating =5
   

ALTER TABLE LoanApplication 
ALTER COLUMN remarks varchar(50)  ;

ALTER TABLE LoanApplication 
ALTER COLUMN  loan_status Varchar(20) DEFAULT 'Submitted';

ALTER TABLE LoanApplication 
alter column AmountToBePaid decimal ;




drop table LoanTransactions
go

Create Table Admin(
AdminId int primary key,
Username varchar(20),
Pasword char(20));
insert into Admin values(1,'ama','123');

drop table Admin
INSERT INTO Customers VALUES ( 'Abraham', 'Tekeba', 'Abeje', '1999-02-23', 'Male', '0934567833',Null,  'Abtekeba@gmail.com','Waiter', Null, 'Passport', 'ET345562',  '2020-02-23','2025-02-23', 5000,Null,5,NULL,NULL,2),
( 'Tomas', 'Kebede', 'Abebe', '2002-02-03', 'Male', '0933367833',Null,  'Tommy553@gmail.com','Manager', Null, 'Passport', 'ET225562', '2020-07-23','2025-07-23', 35000,Null,5,NULL,NULL,1),
( 'Rahel', 'Solomon', 'Abera', '1990-02-03', 'Female', '0933478833',Null,  'Rich464@gmail.com','Secretary', Null, 'National_ID', 'ET670562', '2020-07-23','2023-07-23', 8000,Null,5,NULL,NULL,3);

INSERT INTO Surety VALUES ( 1,'Tofik', 'Ahmed', 'Mohammed', '1989-02-23', 'Male', '0954565833',Null,  'Tofik333@gmail.com','Journalist', Null, 'Passport', 'ET355562', '2018-09-23','2023-09-23', 11000,Null),
(2, 'Azeb', 'Haile', 'Abebe', '1970-02-03', 'Female', '0911367833',Null,  'Azeb@gmail.com','Shop Owner', Null, 'Passport', 'ET225562','2020-05-05', '2025-05-05', 20000,Null),
(3, 'Enat', 'Emire', 'Tibebu', '1975-02-03', 'Female', '0912101833',Null,  'EnatEmire@gmail.com','Self-Emoployed', Null, 'National_ID', 'ET665662', '2018-09-23','2023-09-23', 16000,Null);

INSERT INTO LoanType VALUES (2000,15000,'1-Month Loan','1 Month',0.10,'This loan type gives debtors to take a loan starting from 2,000 Birr up to 15,000 Birr. We charge 10% service charge when the debtors pays back the loan. The debt should be paid back within a month. If a debt is not paid on time, 0.5% of the loan amount is added every day to the final payment.'), 
(5000,25000,'3-Month Loan','3 Months',0.12,'This loan type gives debtors to take a loan starting from 2,000 Birr up to 25,000 Birr. We charge 12% service charge when the debtors pays back the loan. The debt should be paid back within 3-months. If a debt is not paid on time, 0.5% of the loan amount is added every day to the final payment.'),
(10000,50000,'6-Month Loan','6 Months',0.15,'This loan type gives debtors to take a loan starting from 10,000 Birr up to 50,000 Birr. We charge 15% service charge when the debtors pays back the loan. The debt should be paid back within 6-months. If a debt is not paid on time, 0.5% of the loan amount is added every day to the final payment.');

INSERT INTO LoanApplication  VALUES ('LMS0001',5000,'Emergency','2022-09-12',null,Default,null,2,4),--submitted
('LMS0002',3000,'Emergency','2022-09-12',null,Default,null,3,2),
('LMS0003',10000,'Emergency','2022-09-12',null,'Default',null,2,3);

ALTER TABLE LoanApplication
  ADD CONSTRAINT Def_Status
  DEFAULT 'Submitted' FOR loan_status;

INSERT INTO LoanTransactions VALUES ('Unsettled','2022-09-19','2022-10-19',3),
('Unsettled','2022-09-19','2023-03-19',4),
('Settled','2022-09-19','2023-01-19',2);


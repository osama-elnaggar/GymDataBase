-- Create the database GymSystem
CREATE DATABASE GymSystem;
GO

-- Use the GymSystem database
USE GymSystem;
GO

-- Create Gym Member table
CREATE TABLE GymMember (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
    UserName VARCHAR(50) NOT NULL UNIQUE ,
    Password VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Gender VARCHAR(10) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100),
    PaymentHistory TEXT,
PlanFinishData DATE,
Points INT DEFAULT 0
   );

-- Create User(Trainer,Admin) table
CREATE TABLE "User" (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    Experience VARCHAR(100),
     Role VARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) UNIQUE,
	Password VARCHAR(50) NOT NULL,
     AdminID INT,
    FOREIGN KEY (AdminID) REFERENCES "User"(ID)
);


-- Create Payments table
CREATE TABLE Payments (
    PaymentNu INT IDENTITY(1,1) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    Date DATE NOT NULL,
    GymMemberID INT NOT NULL,
    UserID INT NOT NULL,
 PRIMARY KEY (GymMemberID, PaymentNu), -- Composite primary key
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID),
    FOREIGN KEY (UserID) REFERENCES "User"(ID)
);



-- Create Class table
CREATE TABLE Class (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Capacity INT NOT NULL,
    Duration TIME NOT NULL,
    Schedule TEXT,
    UserID INT NOT NULL,
    Price INT,
    FOREIGN KEY (UserID) REFERENCES "User"(ID) 	ON DELETE CASCADE

);

-- Create Feedback table
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Comments TEXT NOT NULL,
    Date DATE ,
    TrainerID INT,
    GymMemberID INT NOT NULL,
    FOREIGN KEY (TrainerID) REFERENCES "User"(ID),
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID)
);

-- Create Workout Plan table
CREATE TABLE WorkoutPlan (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Description TEXT NOT NULL,
    Goals TEXT,
    Duration TIME,
    TrainerID INT NOT NULL,
    Price INT,
       FOREIGN KEY (TrainerID) REFERENCES "User"(ID)  ON DELETE CASCADE

);

-- Relationships
--RegisterWorkoutPlan(Between Workoutplan And Gymmember)
CREATE TABLE RegisterWorkoutPlan (
    PlanID INT NOT NULL,
    MemberID INT NOT NULL,
    Date DATE,
    PRIMARY KEY (PlanID, MemberID),
    FOREIGN KEY (PlanID) REFERENCES WorkoutPlan(ID),
    FOREIGN KEY (MemberID) REFERENCES GymMember(ID)
);


-- A Gym Member books multiple Classes
CREATE TABLE GymMemberBooksClass (
    MemberID INT  NOT NULL,
    ClassID INT NOT NULL,
    BookDate DATE,
    PRIMARY KEY (MemberID, ClassID),
    FOREIGN KEY (MemberID) REFERENCES GymMember(ID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

-- Admin manages members
CREATE TABLE AdminManagesMembers (
    UserID INT NOT NULL,
    ClassID INT NOT NULL,
    PRIMARY KEY (UserID, ClassID) ,
    FOREIGN KEY (UserID) REFERENCES "User"(ID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

-- Member Attend Class
CREATE TABLE AttendClass (
    ClassID INT NOT NULL,
    MemberID INT NOT NULL,
    AttendDate DATE,
    PRIMARY KEY (ClassID, MemberID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID),
     FOREIGN KEY (MemberID) REFERENCES GymMember(ID)
);
-- Create the table Allcardsintheworld Assumed that we have link with mastercard visa or any cards provider
CREATE TABLE Allcardsintheworld (
    CardNumber CHAR(16) NOT NULL, 
    CVV CHAR(3) NOT NULL,         
    Balance DECIMAL(10, 2) NOT NULL, 
    PRIMARY KEY (CardNumber)
);
-- Inserted About 50 tuples into the table, We have this data from card providers
INSERT INTO Allcardsintheworld (CardNumber, CVV, Balance) VALUES
('1234567812345678', '123', 10000.00),
('8765432187654321', '456', 2000.50),
('1111222233334444', '789', 150.25),
('4444333322221111', '012', 500.75),
('5555666677778888', '345', 3200.00),
('9999888877776666', '678', 0.00),
('1212121212121212', '901', 10.10),
('3434343434343434', '234', 999.99),
('5656565656565656', '567', 250.00),
('7878787878787878', '890', 1500.00),
('1122334455667788', '101', 2200.00),
('8899776655443322', '202', 300.00),
('1234432112344321', '303', 4000.00),
('4321123443211234', '404', 50.00),
('9876543298765432', '505', 0.01),
('2233445566778899', '606', 1999.99),
('5566778899223344', '707', 5.50),
('6677889922334455', '808', 750.75),
('7788992233445566', '909', 1800.00),
('8899223344556677', '112', 3000.00),
('3344556677889922', '223', 120.00),
('4455667788992233', '334', 220.22),
('5566778899223355', '556', 440.44),
('6677889922334466', '667', 550.55),
('7788992233445577', '778', 660.66),
('9900112233445588', '889', 770.77),
('1100223344556699', '990', 880.88),
('2200334455667700', '001', 990.99),
('3300445566778811', '002', 111.11),
('4400556677889922', '003', 222.22),
('5500667788990033', '004', 333.33),
('6600778899001144', '005', 444.44),
('7700889900112255', '006', 555.55),
('8800990011223366', '007', 666.66),
('9900112233445577', '008', 777.77),
('1001223344556688', '009', 888.88),
('2002334455667799', '010', 999.99),
('3003445566778800', '111', 1111.11),
('4004556677889911', '222', 2222.22),
('5005667788990022', '333', 3333.33),
('6006778899001133', '444', 4444.44),
('7007889900112244', '555', 5555.55),
('8008990011223355', '666', 6666.66),
('9009112233445566', '777', 7777.77),
('0112233445566778', '888', 8888.88),
('1223344556678899', '999', 9999.99),
('2334455667789900', '000', 123.45),
('3445566778899011', '111', 678.90);


-- Insert into User table
INSERT INTO "User" (FirstName, LastName, Gender, Experience, Role, Phone, Email, Password, AdminID) VALUES
('Ahmed', 'Ali', 'Male', '5 years as Trainer', 'Trainer', '1234567890', 'ahmed.ali@example.com', 'password123', 9),
('Sara', 'Ibrahim', 'Female', '3 years as Trainer', 'Trainer', '1234567891', 'sara.ibrahim@example.com', 'password123', 9),
('Hassan', 'Omar', 'Male', '2 years as Trainer', 'Trainer', '1234567892', 'hassan.omar@example.com', 'password123', 9),
('Amal', 'Fathy', 'Female', '1 year as Trainer', 'Trainer', '1234567893', 'amal.fathy@example.com', 'password123', 9),
('Khaled', 'Hassan', 'Male', '7 years as Worker', 'Worker', '1234567894', 'khaled.hassan@example.com', 'password123', 10),
('Laila', 'Said', 'Female', '4 years as Worker', 'Worker', '1234567895', 'laila.said@example.com', 'password123', 10),
('Tarek', 'Youssef', 'Male', '6 years as Worker', 'Worker', '1234567896', 'tarek.youssef@example.com', 'password123', 10),
('Nour', 'Hesham', 'Female', '8 years as Worker', 'Worker', '1234567897', 'nour.hesham@example.com', 'password123', 10),
('Omar', 'Kamel', 'Male', '10 years as Admin', 'Admin', '1234567898', 'omar.kamel@example.com', 'password123', NULL),
('Heba', 'Gamal', 'Female', '12 years as Admin', 'Admin', '1234567899', 'heba.gamal@example.com', 'password123', NULL),
('Adel', 'Mounir', 'Male', '15 years as Admin', 'Admin', '1234567800', 'adel.mounir@example.com', 'password123', NULL),
('Rana', 'Mostafa', 'Female', '11 years as Admin', 'Admin', '1234567801', 'rana.mostafa@example.com', 'password123', NULL),
('Ziad', 'Nabil', 'Male', '3 years as Trainer', 'Trainer', '1234567802', 'ziad.nabil@example.com', 'password123', 9),
('Mona', 'Adham', 'Female', '2 years as Worker', 'Worker', '1234567803', 'mona.adham@example.com', 'password123', 10),
('Hadi', 'El-Shamy', 'Male', '1 year as Worker', 'Worker', '1234567804', 'hadi.elshamy@example.com', 'password123', 10),
('Salma', 'Nader', 'Female', '4 years as Worker', 'Worker', '1234567805', 'salma.nader@example.com', 'password123', 10),
('Yasser', 'Fouad', 'Male', '6 years as Admin', 'Admin', '1234567806', 'yasser.fouad@example.com', 'password123', NULL),
('Mariam', 'Sami', 'Female', '7 years as Admin', 'Admin', '1234567807', 'mariam.sami@example.com', 'password123', NULL),
('Kareem', 'Lotfy', 'Male', '8 years as Admin', 'Admin', '1234567808', 'kareem.lotfy@example.com', 'password123', NULL),
('Hana', 'Atef', 'Female', '5 years as Trainer', 'Trainer', '1234567809', 'hana.atef@example.com', 'password123', 9);


-- Add 20 tuples to GymMember table
INSERT INTO GymMember (UserName, Password, BirthDate, Gender, Phone, Email, PaymentHistory, PlanFinishData, Points) VALUES
('User1', 'pass1', '1990-01-01', 'Male', '0111111111', 'user1@example.com', 'Monthly Payment', '2024-12-31', 0),
('User2', 'pass2', '1991-02-02', 'Female', '0111111112', 'user2@example.com', 'Monthly Payment', '2024-12-31', 0),
('User3', 'pass3', '1992-03-03', 'Male', '0111111113', 'user3@example.com', 'Monthly Payment', '2024-12-31', 0),
('User4', 'pass4', '1993-04-04', 'Female', '0111111114', 'user4@example.com', 'Monthly Payment', '2024-12-31', 0),
('User5', 'pass5', '1994-05-05', 'Male', '0111111115', 'user5@example.com', 'Monthly Payment', '2024-12-31', 0),
('User6', 'pass6', '1995-06-06', 'Female', '0111111116', 'user6@example.com', 'Monthly Payment', '2024-12-31', 0),
('User7', 'pass7', '1996-07-07', 'Male', '0111111117', 'user7@example.com', 'Monthly Payment', '2024-12-31', 0),
('User8', 'pass8', '1997-08-08', 'Female', '0111111118', 'user8@example.com', 'Monthly Payment', '2024-12-31', 0),
('User9', 'pass9', '1998-09-09', 'Male', '0111111119', 'user9@example.com', 'Monthly Payment', '2024-12-31', 0),
('User10', 'pass10', '1999-10-10', 'Female', '0111111120', 'user10@example.com', 'Monthly Payment', '2024-12-31', 0),
('User11', 'pass11', '1989-11-11', 'Male', '0111111121', 'user11@example.com', 'Yearly Payment', '2024-12-31', 0),
('User12', 'pass12', '1988-12-12', 'Female', '0111111122', 'user12@example.com', 'Yearly Payment', '2024-12-31', 0),
('User13', 'pass13', '1987-01-13', 'Male', '0111111123', 'user13@example.com', 'Yearly Payment', '2024-12-31', 0),
('User14', 'pass14', '1986-02-14', 'Female', '0111111124', 'user14@example.com', 'Yearly Payment', '2024-12-31', 0),
('User15', 'pass15', '1985-03-15', 'Male', '0111111125', 'user15@example.com', 'Yearly Payment', '2024-12-31', 0),
('User16', 'pass16', '1984-04-16', 'Female', '0111111126', 'user16@example.com', 'Yearly Payment', '2024-12-31', 0),
('User17', 'pass17', '1983-05-17', 'Male', '0111111127', 'user17@example.com', 'Yearly Payment', '2024-12-31', 0),
('User18', 'pass18', '1982-06-18', 'Female', '0111111128', 'user18@example.com', 'Yearly Payment', '2024-12-31', 0),
('User19', 'pass19', '1981-07-19', 'Male', '0111111129', 'user19@example.com', 'Yearly Payment', '2024-12-31', 0),
('User20', 'pass20', '1980-08-20', 'Female', '0111111130', 'user20@example.com', 'Yearly Payment', '2024-12-31', 0);

-- Add 20 tuples to Payments table
INSERT INTO Payments (Amount, Date, GymMemberID, UserID) VALUES
(100.00, '2024-01-01', 1, 9),
(200.00, '2024-01-02', 2, 9),
(300.00, '2024-01-03', 3, 9),
(400.00, '2024-01-04', 4, 9);

INSERT INTO Class (Name, Capacity, Duration, Schedule, UserID, Price) VALUES
('Yoga', 20, '01:00:00', 'MWF 7AM-8AM', 2, 0),
('Cardio', 15, '00:45:00', 'TTh 6PM-6:45PM', 3, 0);

-- Insert into Feedback
INSERT INTO Feedback (Comments, Date, TrainerID, GymMemberID) VALUES
( 'Great session!', '2024-01-22', 2, 1),
('Loved the trainer’s tips!', '2024-01-23', 3, 2);

-- Insert into WorkoutPlan
INSERT INTO WorkoutPlan (Description, Goals, Duration, TrainerID,Price) VALUES
('Basic Weight Loss Plan', 'Lose 5kg in 3 months', '00:30:00', 2,0),
('Strength Training Plan', 'Build muscle', '01:00:00', 3,0);

-- Insert into RegisterWorkoutPlan
INSERT INTO RegisterWorkoutPlan (PlanID, MemberID, Date) VALUES
(1, 1, '2024-01-15'),
(2, 2, '2024-01-20');

-- Insert into GymMemberBooksClass
INSERT INTO GymMemberBooksClass (MemberID, ClassID, BookDate) VALUES
(1, 1, '2024-01-14'),
(2, 2, '2024-01-19');

-- Insert into AdminManagesMembers
INSERT INTO AdminManagesMembers (UserID, ClassID) VALUES
(1, 1),
(1, 2);

-- Insert into AttendClass
INSERT INTO AttendClass (ClassID, MemberID, AttendDate) VALUES
(1, 1, '2024-01-16'),
(2, 2, '2024-01-21');

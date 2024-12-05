-- Create Gym Member table
CREATE TABLE GymMember (
    ID INT PRIMARY KEY NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Gender VARCHAR(10) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100),
    PaymentHistory TEXT,
    MembershipStatus VARCHAR(50) NOT NULL
);

-- Create User(Trainer,Admin) table
CREATE TABLE User (
    ID INT PRIMARY KEY NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    Experience VARCHAR(100),
     Role VARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100)
     AdminID INT,
    FOREIGN KEY (AdminID) REFERENCES User(ID)
);


-- Create Payments table
CREATE TABLE Payments (
    PaymentNu INT NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    Date DATE NOT NULL,
    GymMemberID INT NOT NULL,
    UserID INT NOT NULL,
 PRIMARY KEY (GymMemberID, PaymentNu), -- Composite primary key
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID),
    FOREIGN KEY (UserID) REFERENCES User(ID)
);



-- Create Class table
CREATE TABLE Class (
    ID INT PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Capacity INT NOT NULL,
    Duration TIME NOT NULL,
    Schedule TEXT,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES User(ID)
);

-- Create Feedback table
CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY NOT NULL,
    Comments TEXT NOT NULL,
    Date DATE ,
    TrainerID INT,
    GymMemberID INT NOT NULL,
    FOREIGN KEY (TrainerID) REFERENCES User(ID),
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID)
);

-- Create Workout Plan table
CREATE TABLE WorkoutPlan (
    ID INT PRIMARY KEY NOT NULL,
    Description TEXT NOT NULL,
    Goals TEXT,
    Duration TIME,
    TrainerID INT NOT NULL,
       FOREIGN KEY (TrainerID) REFERENCES User(ID)
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
    MemberID INT NOT NULL,
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
    FOREIGN KEY (UserID) REFERENCES User(ID),
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

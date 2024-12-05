-- Create Gym Member table
CREATE TABLE GymMember (
    ID INT PRIMARY KEY NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Gender VARCHAR(10),
    Phone VARCHAR(15),
    Email VARCHAR(100),
    PaymentHistory TEXT,
    MembershipStatus VARCHAR(50) NOT NULL
);

-- Create Payments table
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY NOT NULL,
    Amount DECIMAL(10, 2),
    Date DATE,
    GymMemberID INT,
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID)
);

-- Create User(Trainer,Admin) table
CREATE TABLE User (
    ID INT PRIMARY KEY NOT NULL,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    Experience VARCHAR(100),
     Role VARCHAR(50),
    Phone VARCHAR(15),
    Email VARCHAR(100)
);


-- Create Class table
CREATE TABLE Class (
    ID INT PRIMARY KEY NOT NULL,
    Name VARCHAR(50),
    Capacity INT,
    Duration TIME,
    Schedule TEXT
);

-- Create Feedback table
CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY NOT NULL,
    Comments TEXT,
    Date DATE,
    ClassID INT,
    GymMemberID INT,
    FOREIGN KEY (ClassID) REFERENCES Class(ID),
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID)
);

-- Create Workout Plan table
CREATE TABLE WorkoutPlan (
    ID INT PRIMARY KEY NOT NULL,
    Description TEXT,
    Goals TEXT,
    Duration TIME
);

-- Relationships
-- A Trainer manages multiple Classes
CREATE TABLE Trainer_Manages_Class (
    TrainerID INT NOT NULL,
    ClassID INT NOT NULL,
    PRIMARY KEY (TrainerID, ClassID) ,
    FOREIGN KEY (TrainerID) REFERENCES Trainer(ID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

-- Administration handles multiple Classes
CREATE TABLE Administration_Handles_Class (
    AdministrationID INT NOT NULL,
    ClassID INT NOT NULL,
    PRIMARY KEY (AdministrationID, ClassID),
    FOREIGN KEY (AdministrationID) REFERENCES Administration(ID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

-- A Gym Member books and attends multiple Classes
CREATE TABLE GymMember_Books_Class (
    GymMemberID INT NOT NULL,
    ClassID INT NOT NULL,
    BookingDate DATE,
    PRIMARY KEY (GymMemberID, ClassID),
    FOREIGN KEY (GymMemberID) REFERENCES GymMember(ID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

-- A Trainer creates multiple Workout Plans
CREATE TABLE Trainer_Creates_WorkoutPlan (
    TrainerID INT NOT NULL,
    WorkoutPlanID INT NOT NULL,
    PRIMARY KEY (TrainerID, WorkoutPlanID),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(ID),
    FOREIGN KEY (WorkoutPlanID) REFERENCES WorkoutPlan(ID)
);

-- A Class is linked to a Workout Plan
CREATE TABLE Class_Has_WorkoutPlan (
    ClassID INT NOT NULL,
    WorkoutPlanID INT NOT NULL,
    PRIMARY KEY (ClassID, WorkoutPlanID),
    FOREIGN KEY (ClassID) REFERENCES Class(ID),
    FOREIGN KEY (WorkoutPlanID) REFERENCES WorkoutPlan(ID)
);

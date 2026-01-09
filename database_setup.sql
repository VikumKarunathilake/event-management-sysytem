CREATE DATABASE EVENTMANAGEMENTSYSTEM;
GO

USE EVENTMANAGEMENTSYSTEM;
GO

-- Table for Event Page
-- Order matches INSERT: EventDate, EventID, EventName, Venue
CREATE TABLE event (
    EventDate VARCHAR(50),
    ID VARCHAR(50) PRIMARY KEY,
    EventName VARCHAR(100),
    Venue VARCHAR(100)
);
GO

-- Table for Result Page
-- Order matches INSERT: CompetitionID, ParticipantID, Place
CREATE TABLE result (
    ID VARCHAR(50) PRIMARY KEY, -- Stores CompetitionID
    ParticipantID VARCHAR(50),
    Place VARCHAR(50)
);
GO

-- Table for Members Page
-- Order matches INSERT: MemberName, MemberID, Grade, Contact, Position
CREATE TABLE members (
    MemberName VARCHAR(100),
    ID VARCHAR(50) PRIMARY KEY,
    Grade VARCHAR(50),
    Contact VARCHAR(50),
    Position VARCHAR(50)
);
GO

-- Table for All Performance
CREATE TABLE all_performance (
    PerformanceID INT IDENTITY(1,1) PRIMARY KEY,
    MemberID VARCHAR(50), -- Links to members.ID
    EventID VARCHAR(50),  -- Links to event.ID
    Score VARCHAR(50),
    Remarks VARCHAR(255)
);
GO

-- Drop the database if it exists to ensure a fresh start
DROP DATABASE IF EXISTS EVENTMANAGEMENTSYSTEM;
CREATE DATABASE EVENTMANAGEMENTSYSTEM;
USE EVENTMANAGEMENTSYSTEM;

-- Table for Event Page (frmEventpage)
-- Used in Eventpage.cs
-- Insert order: EventDate, EventID, EventName, Venue
CREATE TABLE event (
    EventDate VARCHAR(50),
    ID VARCHAR(50) PRIMARY KEY,
    EventName VARCHAR(100),
    Venue VARCHAR(100)
);

-- Table for Result Page (frmResult)
-- Used in Result.cs
-- Insert order: CompetitionID, ParticipantID, Place
CREATE TABLE result (
    ID VARCHAR(50) PRIMARY KEY, -- Stores CompetitionID
    ParticipantID VARCHAR(50),  -- Links to members.ID potentially
    Place VARCHAR(50)
);

-- Table for Members Page (frmMembers)
-- Used in Members.cs
-- Insert order: MemberName, MemberID, Grade, Contact, Position
CREATE TABLE members (
    MemberName VARCHAR(100),
    ID VARCHAR(50) PRIMARY KEY,
    Grade VARCHAR(50),
    Contact VARCHAR(50),
    Position VARCHAR(50)
);

-- Table for Performance Page (frmPerformance in Form1.cs)
-- Used in Form1.cs (referenced as 'records' table)
-- Insert order: PerformanceID, PerformanceName, PerformanceType, SheduleID
CREATE TABLE records (
    ID VARCHAR(50) PRIMARY KEY, -- Stores PerformanceID
    PerformanceName VARCHAR(100),
    PerformanceType VARCHAR(100),
    SheduleID VARCHAR(50)
);

-- Optional: 'all_performance' table was in the previous version but not used in the currently visible C# code.
-- Leaving it out to avoid confusion, or can be added if needed for other hidden modules.

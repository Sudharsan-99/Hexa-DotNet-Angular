
-- Question 1: Create Stored Procedures to INSERT Data


-- Insert UserInfo
CREATE PROCEDURE usp_InsertUserInfo
    @EmailId VARCHAR(30),
    @Username VARCHAR(30),
    @Role VARCHAR(10),
    @Password VARCHAR(20)
AS
BEGIN
    INSERT INTO UserInfo (EmailId, Username, Role, Password)
    VALUES (@EmailId, @Username, @Role, @Password);
END;
GO

-- Insert EventDetails
CREATE PROCEDURE usp_InsertEventDetails
    @EventId INT,
    @EventName VARCHAR(50),
    @EventCategory VARCHAR(50),
    @EventDate DATETIME,
    @Description VARCHAR(MAX),
    @Status VARCHAR(10)
AS
BEGIN
    INSERT INTO EventDetails
    VALUES (@EventId, @EventName, @EventCategory, @EventDate, @Description, @Status);
END;
GO

-- Insert SpeakersDetails
CREATE PROCEDURE usp_InsertSpeaker
    @SpeakerId INT,
    @SpeakerName VARCHAR(50)
AS
BEGIN
    INSERT INTO SpeakersDetails
    VALUES (@SpeakerId, @SpeakerName);
END;
GO

-- Insert SessionInfo
CREATE PROCEDURE usp_InsertSession
    @SessionId INT,
    @EventId INT,
    @SessionTitle VARCHAR(50),
    @SpeakerId INT,
    @Description VARCHAR(100),
    @SessionStart DATETIME,
    @SessionEnd DATETIME,
    @SessionUrl VARCHAR(100)
AS
BEGIN
    INSERT INTO SessionInfo
    VALUES (@SessionId, @EventId, @SessionTitle, @SpeakerId, @Description, @SessionStart, @SessionEnd, @SessionUrl);
END;
GO

-- Insert ParticipantEventDetails
CREATE PROCEDURE usp_InsertParticipantEvent
    @Id INT,
    @ParticipantEmailId VARCHAR(30),
    @EventId INT,
    @SessionId INT,
    @IsAttended BIT
AS
BEGIN
    INSERT INTO ParticipantEventDetails
    VALUES (@Id, @ParticipantEmailId, @EventId, @SessionId, @IsAttended);
END;
GO


-- Question 2: Create Stored Procedures to DELETE Data


-- Delete UserInfo
CREATE PROCEDURE usp_DeleteUserInfo
    @EmailId VARCHAR(30)
AS
BEGIN
    DELETE FROM UserInfo WHERE EmailId = @EmailId;
END;
GO

-- Delete EventDetails
CREATE PROCEDURE usp_DeleteEventDetails
    @EventId INT
AS
BEGIN
    DELETE FROM EventDetails WHERE EventId = @EventId;
END;
GO

-- Delete SpeakersDetails
CREATE PROCEDURE usp_DeleteSpeaker
    @SpeakerId INT
AS
BEGIN
    DELETE FROM SpeakersDetails WHERE SpeakerId = @SpeakerId;
END;
GO

-- Delete SessionInfo
CREATE PROCEDURE usp_DeleteSession
    @SessionId INT
AS
BEGIN
    DELETE FROM SessionInfo WHERE SessionId = @SessionId;
END;
GO

-- Delete ParticipantEventDetails
CREATE PROCEDURE usp_DeleteParticipantEvent
    @Id INT
AS
BEGIN
    DELETE FROM ParticipantEventDetails WHERE Id = @Id;
END;
GO


-- Question 3: Create Stored Procedures to UPDATE Data


-- Update UserInfo
CREATE PROCEDURE usp_UpdateUserInfo
    @EmailId VARCHAR(30),
    @Username VARCHAR(30),
    @Role VARCHAR(10),
    @Password VARCHAR(20)
AS
BEGIN
    UPDATE UserInfo
    SET Username = @Username,
        Role = @Role,
        Password = @Password
    WHERE EmailId = @EmailId;
END;
GO

-- Update EventDetails
CREATE PROCEDURE usp_UpdateEventDetails
    @EventId INT,
    @EventName VARCHAR(50),
    @EventCategory VARCHAR(50),
    @EventDate DATETIME,
    @Description VARCHAR(MAX),
    @Status VARCHAR(10)
AS
BEGIN
    UPDATE EventDetails
    SET EventName = @EventName,
        EventCategory = @EventCategory,
        EventDate = @EventDate,
        Description = @Description,
        Status = @Status
    WHERE EventId = @EventId;
END;
GO

-- Update SpeakersDetails
CREATE PROCEDURE usp_UpdateSpeaker
    @SpeakerId INT,
    @SpeakerName VARCHAR(50)
AS
BEGIN
    UPDATE SpeakersDetails
    SET SpeakerName = @SpeakerName
    WHERE SpeakerId = @SpeakerId;
END;
GO

-- Update SessionInfo
CREATE PROCEDURE usp_UpdateSession
    @SessionId INT,
    @EventId INT,
    @SessionTitle VARCHAR(50),
    @SpeakerId INT,
    @Description VARCHAR(100),
    @SessionStart DATETIME,
    @SessionEnd DATETIME,
    @SessionUrl VARCHAR(100)
AS
BEGIN
    UPDATE SessionInfo
    SET EventId = @EventId,
        SessionTitle = @SessionTitle,
        SpeakerId = @SpeakerId,
        Description = @Description,
        SessionStart = @SessionStart,
        SessionEnd = @SessionEnd,
        SessionUrl = @SessionUrl
    WHERE SessionId = @SessionId;
END;
GO

-- Update ParticipantEventDetails
CREATE PROCEDURE usp_UpdateParticipantEvent
    @Id INT,
    @ParticipantEmailId VARCHAR(30),
    @EventId INT,
    @SessionId INT,
    @IsAttended BIT
AS
BEGIN
    UPDATE ParticipantEventDetails
    SET ParticipantEmailId = @ParticipantEmailId,
        EventId = @EventId,
        SessionId = @SessionId,
        IsAttended = @IsAttended
    WHERE Id = @Id;
END;
GO


-- Question 4: Create a view to show session details of the particular event


CREATE VIEW vw_SessionDetailsByEvent
AS
SELECT s.SessionId, s.SessionTitle, s.SessionStart, s.SessionEnd, s.SessionUrl, s.Description,
       e.EventId, e.EventName, e.EventDate
FROM SessionInfo s
JOIN EventDetails e ON s.EventId = e.EventId;
GO

-- Question 5: Create a view to show speaker detail of particular session


CREATE VIEW vw_SpeakerDetailsBySession
AS
SELECT s.SessionId, s.SessionTitle, sp.SpeakerId, sp.SpeakerName
FROM SessionInfo s
JOIN SpeakersDetails sp ON s.SpeakerId = sp.SpeakerId;
GO


-- Question 6: Create a view to show all details of an event like sessions, speaker details, participant details


CREATE VIEW vw_CompleteEventDetails
AS
SELECT 
    e.EventId, e.EventName, e.EventCategory, e.EventDate, e.Status,
    s.SessionId, s.SessionTitle, s.SessionStart, s.SessionEnd, s.Description AS SessionDesc, s.SessionUrl,
    sp.SpeakerId, sp.SpeakerName,
    p.Id AS ParticipantEventId, p.ParticipantEmailId, u.Username, p.IsAttended
FROM EventDetails e
JOIN SessionInfo s ON e.EventId = s.EventId
JOIN SpeakersDetails sp ON s.SpeakerId = sp.SpeakerId
JOIN ParticipantEventDetails p ON s.SessionId = p.SessionId
JOIN UserInfo u ON p.ParticipantEmailId = u.EmailId;
GO


-- Question 7: Apply non-clustered indexes to tables by choosing appropriate columns


CREATE NONCLUSTERED INDEX IX_UserInfo_EmailId ON UserInfo(EmailId);
CREATE NONCLUSTERED INDEX IX_EventDetails_EventDate ON EventDetails(EventDate);
CREATE NONCLUSTERED INDEX IX_SessionInfo_EventId ON SessionInfo(EventId);
CREATE NONCLUSTERED INDEX IX_ParticipantEventDetails_Email ON ParticipantEventDetails(ParticipantEmailId);
GO


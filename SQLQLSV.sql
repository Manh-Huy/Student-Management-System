create database QLSVDB
use QLSVDB
CREATE TABLE [dbo].[Log_in] (
    [Id]       NVARCHAR (50) NOT NULL,
    [username] NVARCHAR (10) NULL,
    [password] NVARCHAR (10) NULL,
    [email]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Temp_Log_in] (
    [Id]       NVARCHAR (50) NOT NULL,
    [username] NVARCHAR (10) NULL,
    [password] NVARCHAR (10) NULL,
    [email]    NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Temp_HumanResource] (
    [Id]		NVARCHAR (50) NOT NULL,
    [fname]		NVARCHAR (50) NULL,
    [lname]		NVARCHAR (50) NULL,
    [username]	NVARCHAR (50) NULL,
    [password]  NVARCHAR (50) NULL,
    [email]     NVARCHAR (50) NULL,
	[picture]	IMAGE	
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Log_in_Contact] (
    [Id]       NVARCHAR (50) NOT NULL,
    [username] NVARCHAR (10) NULL,
    [password] NVARCHAR (10) NULL,
    [email]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Temp_Log_in_Contact] (
    [Id]       NVARCHAR (50) NOT NULL,
    [username] NVARCHAR (10) NULL,
    [password] NVARCHAR (10) NULL,
    [email]    NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[HumanResource] ( 		
    [id]      NVARCHAR(50)     NOT NULL PRIMARY KEY,
    [fname]   NVARCHAR (50)    NULL,
    [lname]   NVARCHAR (50) NULL,
	[username]	NVARCHAR (50) NULL,
    [password]  NVARCHAR (50) NULL,
    [bdate]   DATE          NULL,
    [gender]  NVARCHAR (10)    NULL,
    [phone]   NVARCHAR (10)    NULL,
    [address] NVARCHAR (50)    NULL,
 	[hometown] NVARCHAR(50)    NULL,
	[email]   NVARCHAR (50)    NULL,
    [picture] IMAGE         NULL,
);
Go

CREATE TABLE [dbo].[Std] (
	[stt]	  INT			IDENTITY (1,1) NOT NULL, 		
    [id]      NVARCHAR(50)     NOT NULL PRIMARY KEY,
    [fname]   NVARCHAR (50)    NULL,
    [lname]   NVARCHAR (50) NULL,
    [bdate]   DATE          NULL,
    [gender]  NVARCHAR (10)    NULL,
    [phone]   NVARCHAR (10)    NULL,
    [address] NVARCHAR (50)    NULL,
	[faculty] NVARCHAR (50)    NULL,	
	[major]   NVARCHAR (50)    NULL,
 	[hometown] NVARCHAR(50)    NULL,
	[acayear] NVARCHAR (50)    NULL,
	[email]   NVARCHAR (50)    NULL,
    [picture] IMAGE         NULL,
	[selected_Course]	NVARCHAR(200) NULL
);
Go

CREATE TABLE [dbo].[Course] (
    [id]      INT           NOT NULL PRIMARY KEY,
    [label]   NVARCHAR (50),
	[group] NVARCHAR (50),
	[contactID] NVARCHAR (50),
    [period]   INT,
	[semester]	NVARCHAR(20),
	[dayOfWeek] NVARCHAR (50),
	[classPeriodStart] INT,
	[classPeriodEnd] INT,
	[timeStart] NVARCHAR(50),
	[timeEnd] NVARCHAR(50),
    [description]   TEXT,
);
Go

CREATE TABLE TimeTableStudent
(
	courseID INT,
	Monday NVARCHAR(1000) NULL,
	Tuesday NVARCHAR(1000) NULL,
	Wednesday NVARCHAR(1000) NULL,
	Thursday NVARCHAR(1000) NULL,
	Friday NVARCHAR(1000) NULL,
	Saturday NVARCHAR(1000) NULL,
	Sunday NVARCHAR(1000) NULL
)
Go

CREATE TABLE TimeTableTeacher
(
	courseID INT,
	Monday NVARCHAR(1000) NULL,
	Tuesday NVARCHAR(1000) NULL,
	Wednesday NVARCHAR(1000) NULL,
	Thursday NVARCHAR(1000) NULL,
	Friday NVARCHAR(1000) NULL,
	Saturday NVARCHAR(1000) NULL,
	Sunday NVARCHAR(1000) NULL
)
Go

CREATE TABLE [dbo].[Score] (		
    [studentId]      NVARCHAR(50)    NOT NULL,
    [courseId]		 INT	NULL,
    [score]			 FLOAT	NULL,
    [description]	 TEXT    NULL,
	[result]		NVARCHAR(50)
);
Go

CREATE TABLE CourseStudent
(
	studentId NVARCHAR(50),
	fname nvarchar(20),
	lname nvarchar(20),
	--courseId int,
    courseName nvarchar(50),
	semester nvarchar(20),

	FOREIGN KEY (studentId)
	REFERENCES Std (id),
)
Go

CREATE TABLE MyContact
(
	[stt]	  INT			IDENTITY (1,1), 
	contactID nvarchar(50) PRIMARY KEY,
	fname nvarchar(20),
	lname nvarchar(20),
	[group] nvarchar(50),
	phone nvarchar(10),
	email nvarchar(50),
	[address] nvarchar(100),
    picture image
)
Go

CREATE TABLE [Group]
(
	id int IDENTITY (1,1),
	hrID nvarchar(50),
	nameGroup nvarchar(50) PRIMARY KEY,
)
Go

CREATE TABLE Notification
(
	id int PRIMARY KEY IDENTITY(1,1),
	contactID nvarchar(50),
	fullName nvarchar(50),   -- fullname contact
	courseName nvarchar(50),
	title nvarchar(50),
	content nvarchar(3000),
	timeSend datetime,
)
Go

 ------------------------------------------Trigger-------------------------------------------------------------------------------------------

 -- trigger có tác dụng add hình mặc định cho student khi được thêm vào (cho chức năng thêm sinh viên từ file excel)
create trigger AutoAddPictureToStd 
ON Std
AFTER insert
As
begin
	UPDATE Std SET picture = (SELECT BulkColumn FROM OPENROWSET(BULK N'F:\Desktop\Windows Programming\images.png', SINGLE_BLOB) AS MyImage) WHERE picture IS NULL
end
Go

-- trigger có tác dụng tính kết quả (result) cho sinh viên sau khi thêm điểm
create trigger AutoCalculateResult 
ON Score
AFTER INSERT
AS
BEGIN
    UPDATE Score
    SET result = 
        CASE 
            WHEN Score.score < 3 THEN 'Kém'
            WHEN Score.score >= 3 AND Score.score < 5 THEN 'Yếu'
            WHEN Score.score >= 5 AND Score.score < 6 THEN 'Trung Bình'
            WHEN Score.score >= 6 AND Score.score < 8 THEN 'Khá'
            ELSE 'Giỏi' 
        END
    FROM inserted
    WHERE Score.studentId = inserted.studentId and Score.courseId = inserted.courseId
END
Go

-- trigger có tác dụng tạo thời khóa biểu khi thêm môn học
create trigger PrintTimeTable
ON Course
AFTER  INSERT, UPDATE
AS
declare @day NVARCHAR(50), @course NVARCHAR(50), @timeStart NVARCHAR(50), @timeEnd NVARCHAR(50), @periodStart NVARCHAR(50), @periodEnd NVARCHAR(50),  @contactID NVARCHAR(50), @courseID INT
select @day = dayOfWeek from inserted
select @course = label from inserted
select @timeStart = timeStart from inserted
select @timeEnd = timeEnd from inserted
select @periodStart = classPeriodStart from inserted
select @periodEnd = classPeriodEnd from inserted
select @contactID = contactID from inserted
select @courseID = id from inserted

declare @name NVARCHAR(100)
SELECT @name = CONCAT(fname, ' ', lname)
FROM MyContact INNER JOIN Course ON MyContact.contactID = Course.contactID 
WHERE Course.contactID = @contactID
BEGIN
	IF EXISTS(SELECT 1 FROM TimeTableStudent WHERE courseID = @courseID)
			BEGIN
				DELETE FROM TimeTableStudent WHERE courseID = @courseID
			END
	IF EXISTS(SELECT 1 FROM TimeTableTeacher WHERE courseID = @courseID)
			BEGIN
				DELETE FROM TimeTableTeacher WHERE courseID = @courseID
			END
	if (@day = 'Monday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Monday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Monday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Tuesday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Tuesday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Tuesday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Wednesday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Wednesday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Wednesday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Thursday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Thursday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Thursday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Friday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Friday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Friday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Saturday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Saturday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Saturday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
	if (@day = 'Sunday')
	BEGIN
		INSERT INTO TimeTableStudent(courseID, Sunday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd + CHAR(13) + 'GV: ' + @name)
		INSERT INTO TimeTableTeacher(courseID, Sunday) VALUES (@courseID, 'Course: ' + @course + CHAR(13) + 'Time: ' + @timeStart + '-->' + @timeEnd + CHAR(13) + 'Period: ' + @periodStart + ' - ' + @periodEnd)
	END
END
Go

-- trigger có tác dụng tính thời gian bắt đầu và kết thúc môn học khi thêm tiết học
create trigger CalculateTimeStartEndLesson
ON Course
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Course
    SET timeStart = 
        CASE 
            WHEN  Course.classPeriodStart = 1 THEN '7h00'
            WHEN  Course.classPeriodStart = 2 THEN '7h50'
            WHEN  Course.classPeriodStart = 3 THEN '8h50'
            WHEN  Course.classPeriodStart = 4 THEN '9h30'
            WHEN  Course.classPeriodStart = 5 THEN '10h40'
			WHEN  Course.classPeriodStart = 6 THEN '11h50'
			WHEN  Course.classPeriodStart = 7 THEN '12h30'
			WHEN  Course.classPeriodStart = 8 THEN '13h20'
			WHEN  Course.classPeriodStart = 9 THEN '14h20'
			WHEN  Course.classPeriodStart = 10 THEN '15h10'
			WHEN  Course.classPeriodStart = 11 THEN '16h10'
			WHEN  Course.classPeriodStart = 12 THEN '17h00'
			WHEN  Course.classPeriodStart = 13 THEN '18h00'
			WHEN  Course.classPeriodStart = 14 THEN '18h50'
			WHEN  Course.classPeriodStart = 15 THEN '19h50'
        END
    FROM inserted
    WHERE course.id = inserted.id

	UPDATE Course
    SET timeEnd = 
        CASE 
            WHEN  Course.classPeriodEnd = 1 THEN '7h50'
            WHEN  Course.classPeriodEnd = 2 THEN '8h40'
            WHEN  Course.classPeriodEnd = 3 THEN '9h40'
            WHEN  Course.classPeriodEnd = 4 THEN '10h30'
            WHEN  Course.classPeriodEnd = 5 THEN '11h30'
			WHEN  Course.classPeriodEnd = 6 THEN '12h20'
			WHEN  Course.classPeriodEnd = 7 THEN '13h20'
			WHEN  Course.classPeriodEnd = 8 THEN '14h10'
			WHEN  Course.classPeriodEnd = 9 THEN '15h10'
			WHEN  Course.classPeriodEnd = 10 THEN '16h00'
			WHEN  Course.classPeriodEnd = 11 THEN '17h00'
			WHEN  Course.classPeriodEnd = 12 THEN '17h50'
			WHEN  Course.classPeriodEnd = 13 THEN '18h50'
			WHEN  Course.classPeriodEnd = 14 THEN '19h40'
			WHEN  Course.classPeriodEnd = 15 THEN '20h40'
        END
    FROM inserted
    WHERE Course.id = inserted.id 
END
Go

-- trigger có tác dụng xóa các dòng dư thừa giống nhau hoặc null ở bảng thời khóa biểu cho sinh viên
	-- Vì điều kiện để bật trigger PrintTineTable là insert hoặc update bảng Course
		-- nên khi thêm môn học thì trigger PrintTineTable sẽ được bật 2 lần 
		 --( lần 1 là insert bảng Course vào môn học, lần 2 là update bảng Course do trigger CalculateTimeStartEndLesson bật để thêm thời gian cho môn học)
		  -- do đó sẽ thêm môn học đó vào thời khóa biểu 2 lần (2 dòng dữ liệu giống nhau)
		   -- nên phải có triiger RemoveDuplicateRowsInTimeTableStudent để xóa các dòng dư thừa.
		   -- tương tự với trigger RemoveDuplicateRowsInTimeTableTeacher.
create trigger RemoveDuplicateRowsInTimeTableStudent
ON TimeTableStudent
AFTER INSERT, UPDATE
AS
BEGIN
    ;WITH CTE AS (
        SELECT *, ROW_NUMBER() OVER (PARTITION BY Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
            ORDER BY (SELECT NULL)) AS RN
        FROM TimeTableStudent
    )
    DELETE FROM CTE WHERE RN > 1 OR (Monday IS NULL AND Tuesday IS NULL AND Wednesday IS NULL AND Thursday IS NULL 
        AND Friday IS NULL AND Saturday IS NULL AND Sunday IS NULL)
END
Go

-- trigger có tác dụng xóa các dòng dư thừa giống nhau hoặc null ở bảng thời khóa biểu cho giáo viên
create trigger RemoveDuplicateRowsInTimeTableTeacher
ON TimeTableTeacher
AFTER INSERT, UPDATE
AS
BEGIN
    ;WITH CTE AS (
        SELECT *, ROW_NUMBER() OVER (PARTITION BY Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
            ORDER BY (SELECT NULL)) AS RN
        FROM TimeTableTeacher
    )
    DELETE FROM CTE WHERE RN > 1 OR (Monday IS NULL AND Tuesday IS NULL AND Wednesday IS NULL AND Thursday IS NULL 
        AND Friday IS NULL AND Saturday IS NULL AND Sunday IS NULL)
END
GO
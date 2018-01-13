/**************************
Create the datebase
***************************/
USE master;
GO

IF  DB_ID('DataBees') IS NOT NULL
DROP DATABASE DataBees;
GO

CREATE DATABASE DataBees;
GO

USE DataBees;

Create Table BeeUserInfo
(
UserID				INT,
UserName			VARCHAR(20),
UserPassword		VARCHAR(20)
);

Create Table UserHistory
(
UserID				INT,
BeesSpotted			INT,
BeeSpeciesSpotted	INT,
LocationsVisited	INT
)

Create Table UserLocation
(
UserID				INT,
LocationID			INT
)

Create Table Bees
(
BeeID				INT,
CommonName			VARCHAR(50),
LatinName			VARCHAR(50),
Fuzzy				BIT		NOT NULL,
Aggressive			BIT		NOT NULL
)

Create Table BeeStatus
(
BeeID		INT,
StatusID	INT
)

Create Table ConservationStatus
(
StatusID	INT,
StatusType	VARCHAR(25)
)

Create Table BeeColor
(
BeeID		INT,
ColorID		INT
)

Create Table Color
(
ColorID		INT,
ColorName	VARCHAR(20)
)

Create Table BeeLocation
(
LocationID			INT,
BeeID				INT
)

Create Table Locations
(
LocaitonID			INT,
LocationName		VARCHAR(25)
)

Insert Into BeeUserInfo values(1, 'TestUser1', 'testpassword1');
Insert Into BeeUserInfo values(2, 'TestUser2', 'testpassword2');
Insert Into BeeUserInfo values(3, 'TestUser3', 'testpassword3');
Insert Into BeeUserInfo values(4, 'TestUser4', 'testpassword4');
Insert Into BeeUserInfo values(5, 'TestUser5', 'testpassword5');

Insert Into UserHistory values(1, 5, 2, 4);
Insert Into UserHistory values(2, 15, 3, 2);
Insert Into UserHistory values(3, 2, 2, 1);
Insert Into UserHistory values(4, 0, 0, 0);
Insert Into UserHistory values(5, 7, 5, 3);

Insert Into UserLocation values(1, 1);
Insert Into UserLocation values(1, 2);
Insert Into UserLocation values(1, 3);
Insert Into UserLocation values(1, 4);
Insert Into UserLocation values(2, 1);
Insert Into UserLocation values(2, 3);
Insert Into UserLocation values(3, 4);
Insert Into UserLocation values(5, 2);
Insert Into UserLocation values(5, 3);
Insert Into UserLocation values(5, 4);

Insert Into Color Values(1, 'Black');
Insert Into Color Values(2, 'White');
Insert Into Color Values(3, 'Brown');
Insert Into Color values(4, 'Yellow');
Insert Into Color Values(5, 'Orange');
Insert Into Color Values(6, 'Blue');
Insert Into Color Values(7, 'Green');
Insert Into Color values(8, 'Red');
Insert Into Color values(9, 'Purple');

Insert Into ConservationStatus Values(1, 'Least Concern');
Insert Into ConservationStatus Values(2, 'Conservation Dependant');
Insert Into ConservationStatus Values(3, 'Near Threatened');
Insert Into ConservationStatus Values(4, 'Vulnerable');
Insert Into ConservationStatus Values(5, 'Endangered');
Insert Into ConservationStatus Values(6, 'Critically Endangered');
Insert Into ConservationStatus Values(7, 'Extinct in the Wild');
Insert Into ConservationStatus Values(8, 'Extinct');
Insert Into ConservationStatus Values(9, 'Data Deficient');
Insert Into ConservationStatus Values(10, 'Not Evaluated');

Insert Into Bees Values(1, 'Bumble Bee', 'Bombus', 1, 0);
Insert Into Bees Values(2, 'Mason Bee', 'Osmia', 1, 0);
Insert Into Bees Values(3, 'Sweat Bee', 'Lasioglossum', 0, 0);
Insert Into Bees Values(4, 'Sweat Bee', 'Halictus', 0, 0);
Insert Into Bees Values(5, 'Mining Bee', 'Andrena', 1, 0);
Insert Into Bees Values(6, 'Leafcutter Bee', 'Megachile', 1, 0);
Insert Into Bees Values(7, 'Cuckoo Bee', 'Sphecodes', 0, 0);
Insert Into Bees Values(8, 'Cuckoo Bee', 'Nomada', 0, 0);
Insert Into Bees Values(9, 'Cuckoo Bee', 'Triepeolus', 0, 0);
Insert Into Bees Values(10, 'Cuckoo Bee', 'Coelioxys', 0, 0);
--Insert Into Bees Values(11, '', '', 0, 0);
--Insert Into Bees Values(12, '', '', 0, null);
--Insert Into Bees Values(13, '', '', null, null);

SELECT  * FROM BeeUserInfo;

SELECT * FROM BeeUserInfo AS USERINFO
INNER JOIN UserHistory AS UH
ON UH.UserID = USERINFO.UserID

SELECT * FROM UserHistory AS UH
INNER JOIN UserLocation AS UL
ON UH.UserID = UL.UserID

SELECT * FROM Bees;
SELECT * FROM ConservationStatus;

SELECT * FROM Color;
Create Database BetAppDb;

Create Table BetDetails(
HorseName nvarchar(100),
RaceCourse nvarchar(100),
Date Date,
Amount money,
Flag bit
);

Create Table Login(
UserName nvarchar(100),
Password nvarchar(100)
);
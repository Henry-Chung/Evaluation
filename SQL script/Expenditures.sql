USE [HenryChung.BudgetTracker]
GO
SET IDENTITY_INSERT  [dbo].[Expenditures] ON 

INSERT [dbo].[Expenditures] ([Id] , [UserId], [Amount], [Description], [ExpDate], [Remarks]) 
VALUES (1, 7,  CAST(6.90 AS Decimal(5, 2)), N'Buger King', CAST(N'1955-08-05T00:00:00.0000000' AS DateTime2), N'Dinning' );
INSERT [dbo].[Expenditures] ([Id] , [UserId], [Amount], [Description], [ExpDate], [Remarks]) 
VALUES (2, 5,  CAST(3.90 AS Decimal(5, 2)), N'LOL', CAST(N'1987-03-05T00:00:00.0000000' AS DateTime2), N'Game' );
INSERT [dbo].[Expenditures] ([Id] , [UserId], [Amount], [Description], [ExpDate], [Remarks]) 
VALUES (3, 5,  CAST(4.90 AS Decimal(5, 2)), N'Tokyo', CAST(N'1933-04-05T00:00:00.0000000' AS DateTime2), N'Travel' );
INSERT [dbo].[Expenditures] ([Id] , [UserId], [Amount], [Description], [ExpDate], [Remarks]) 
VALUES (4, 6,  CAST(5.90 AS Decimal(5, 2)), N'My friend', CAST(N'1999-05-05T00:00:00.0000000' AS DateTime2), N'Party' );
INSERT [dbo].[Expenditures] ([Id] , [UserId], [Amount], [Description], [ExpDate], [Remarks]) 
VALUES (5, 4,  CAST(9.90 AS Decimal(5, 2)), N'AMC', CAST(N'2000-06-05T00:00:00.0000000' AS DateTime2), N'Movie' );


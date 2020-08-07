USE [HenryChung.BudgetTracker]
GO
SET IDENTITY_INSERT  [dbo].[Incomes] ON 


INSERT [dbo].[Incomes] ([Id] , [UserId], [Amount], [Description], [IncomeDate], [Remarks]) 
VALUES (1, 7,  CAST(109.90 AS Decimal(5, 2)), N'Savings', CAST(N'1955-05-08T00:00:00.0000000' AS DateTime2), N'Nothing' );
INSERT [dbo].[Incomes] ([Id] , [UserId], [Amount], [Description], [IncomeDate], [Remarks]) 
VALUES (2, 7,  CAST(200.66 AS Decimal(5, 2)), N'Savings', CAST(N'1988-08-08T00:00:00.0000000' AS DateTime2), N'Gambling' );
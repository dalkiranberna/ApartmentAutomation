USE [DuesManagement]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 8.1.2019 14:13:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] NOT NULL,
	[ExpenseTypeID] [int] NOT NULL,
	[Date] [date] NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incomes]    Script Date: 8.1.2019 14:13:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incomes](
	[FlatNo] [int] NOT NULL,
	[Amount] [decimal](18, 0) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Incomes] PRIMARY KEY CLUSTERED 
(
	[FlatNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Expenses] ([ExpenseID], [ExpenseTypeID], [Date], [Amount]) VALUES (0, 0, CAST(N'2019-01-08' AS Date), CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[Expenses] ([ExpenseID], [ExpenseTypeID], [Date], [Amount]) VALUES (1, 1, CAST(N'2019-01-01' AS Date), CAST(30 AS Decimal(18, 0)))
INSERT [dbo].[Expenses] ([ExpenseID], [ExpenseTypeID], [Date], [Amount]) VALUES (2, 2, CAST(N'2019-01-04' AS Date), CAST(40 AS Decimal(18, 0)))
INSERT [dbo].[Incomes] ([FlatNo], [Amount], [Date]) VALUES (24, CAST(150 AS Decimal(18, 0)), CAST(N'2019-01-07' AS Date))
ALTER TABLE [dbo].[Expenses] ADD  CONSTRAINT [DF_Expenses_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Incomes] ADD  CONSTRAINT [DF_Incomes_Date]  DEFAULT (getdate()) FOR [Date]
GO
/****** Object:  StoredProcedure [dbo].[SaveExpenseData]    Script Date: 8.1.2019 14:13:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SaveExpenseData]
@expenseTypeID int, @date date, @amount decimal, @expenseID int
As
Begin
	Insert Into Expenses (ExpenseTypeID, Date, Amount, ExpenseID) Values (@expenseTypeID, @date, @amount, @expenseID)
End
GO
/****** Object:  StoredProcedure [dbo].[SaveIncomeData]    Script Date: 8.1.2019 14:13:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SaveIncomeData]
@flatNo int, @amount decimal, @date date
As
Begin
	Insert Into Incomes (FlatNo, Amount, Date) Values (@flatNo, @amount, @date)
End
GO

USE [Lathe]
GO
/****** Object:  Table [dbo].[Shift_Previous]    Script Date: 08/20/2021 23:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift_Previous](
	[coll_pack11] [int] NOT NULL,
	[overal_coll_list11] [int] NOT NULL,
	[overal_V_list11] [real] NOT NULL,
	[coll_pack21] [int] NOT NULL,
	[overal_coll_list21] [int] NOT NULL,
	[overal_V_list21] [real] NOT NULL,
	[coll_pack12] [int] NOT NULL,
	[overal_coll_list12] [int] NOT NULL,
	[overal_V_list12] [real] NOT NULL,
	[coll_pack22] [int] NOT NULL,
	[overal_coll_list22] [int] NOT NULL,
	[overal_V_list22] [real] NOT NULL,
	[coll_pack13] [int] NOT NULL,
	[overal_coll_list13] [int] NOT NULL,
	[overal_V_list13] [real] NOT NULL,
	[coll_pack23] [int] NOT NULL,
	[overal_coll_list23] [int] NOT NULL,
	[overal_V_list23] [real] NOT NULL,
	[overal_coll_list1] [int] NOT NULL,
	[overal_V_list1] [real] NOT NULL,
	[overal_coll_list2] [int] NOT NULL,
	[overal_V_list2] [real] NOT NULL,
	[overal_coll_list] [int] NOT NULL,
	[overal_V_list] [real] NOT NULL,
	[Percent_loss_veneer] [real] NOT NULL,
	[rate1] [real] NOT NULL,
	[rate2] [real] NOT NULL,
	[rate_medium] [real] NOT NULL,
	[col_block] [int] NOT NULL,
	[medium_D_block] [int] NOT NULL,
	[V_block] [real] NOT NULL,
	[V_cil] [real] NOT NULL,
	[V_core] [real] NOT NULL,
	[loss_cil] [real] NOT NULL,
	[loss_core] [real] NOT NULL,
	[medium_D_core] [real] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Shift_Previous] ([coll_pack11], [overal_coll_list11], [overal_V_list11], [coll_pack21], [overal_coll_list21], [overal_V_list21], [coll_pack12], [overal_coll_list12], [overal_V_list12], [coll_pack22], [overal_coll_list22], [overal_V_list22], [coll_pack13], [overal_coll_list13], [overal_V_list13], [coll_pack23], [overal_coll_list23], [overal_V_list23], [overal_coll_list1], [overal_V_list1], [overal_coll_list2], [overal_V_list2], [overal_coll_list], [overal_V_list], [Percent_loss_veneer], [rate1], [rate2], [rate_medium], [col_block], [medium_D_block], [V_block], [V_cil], [V_core], [loss_cil], [loss_core], [medium_D_core]) VALUES (28, 12374, 54.75, 0, 0, 0, 11, 4437, 19.63, 0, 0, 0, 5, 1688, 14.6900005, 0, 0, 0, 18499, 89.07, 0, 0, 18499, 89.07, 6.91, 1.46, 0, 1.46, 1543, 254, 129.95, 21.5034, 10.396, 16.55, 8, 72.2)
/****** Object:  Table [dbo].[Shift_Actual]    Script Date: 08/20/2021 23:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift_Actual](
	[coll_pack11] [int] NOT NULL,
	[overal_coll_list11] [int] NOT NULL,
	[overal_V_list11] [real] NOT NULL,
	[coll_pack21] [int] NOT NULL,
	[overal_coll_list21] [int] NOT NULL,
	[overal_V_list21] [real] NOT NULL,
	[coll_pack12] [int] NOT NULL,
	[overal_coll_list12] [int] NOT NULL,
	[overal_V_list12] [real] NOT NULL,
	[coll_pack22] [int] NOT NULL,
	[overal_coll_list22] [int] NOT NULL,
	[overal_V_list22] [real] NOT NULL,
	[coll_pack13] [int] NOT NULL,
	[overal_coll_list13] [int] NOT NULL,
	[overal_V_list13] [real] NOT NULL,
	[coll_pack23] [int] NOT NULL,
	[overal_coll_list23] [int] NOT NULL,
	[overal_V_list23] [real] NOT NULL,
	[overal_coll_list1] [int] NOT NULL,
	[overal_V_list1] [real] NOT NULL,
	[overal_coll_list2] [int] NOT NULL,
	[overal_V_list2] [real] NOT NULL,
	[overal_coll_list] [int] NOT NULL,
	[overal_V_list] [real] NOT NULL,
	[Percent_loss_veneer] [real] NOT NULL,
	[rate1] [real] NOT NULL,
	[rate2] [real] NOT NULL,
	[rate_medium] [real] NOT NULL,
	[col_block] [int] NOT NULL,
	[medium_D_block] [int] NOT NULL,
	[V_block] [real] NOT NULL,
	[V_cil] [real] NOT NULL,
	[V_core] [real] NOT NULL,
	[loss_cil] [real] NOT NULL,
	[loss_core] [real] NOT NULL,
	[medium_D_core] [real] NOT NULL,
	[smena] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Shift_Actual] ([coll_pack11], [overal_coll_list11], [overal_V_list11], [coll_pack21], [overal_coll_list21], [overal_V_list21], [coll_pack12], [overal_coll_list12], [overal_V_list12], [coll_pack22], [overal_coll_list22], [overal_V_list22], [coll_pack13], [overal_coll_list13], [overal_V_list13], [coll_pack23], [overal_coll_list23], [overal_V_list23], [overal_coll_list1], [overal_V_list1], [overal_coll_list2], [overal_V_list2], [overal_coll_list], [overal_V_list], [Percent_loss_veneer], [rate1], [rate2], [rate_medium], [col_block], [medium_D_block], [V_block], [V_cil], [V_core], [loss_cil], [loss_core], [medium_D_core], [smena]) VALUES (9, 3824, 16.92, 0, 0, 0, 5, 1828, 8.09, 0, 0, 0, 2, 539, 4.68, 0, 0, 0, 6693, 32.67, 0, 0, 6693, 32.67, 9.69, 1.6, 0, 1.6, 752, 230, 52.239, 9.6739, 4.8349, 18.52, 9.26, 70.3, 2)
/****** Object:  Table [dbo].[Bins_Actual]    Script Date: 08/20/2021 23:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bins_Actual](
	[Thickness] [real] NOT NULL,
	[BIN1_Sheets] [int] NOT NULL,
	[BIN1_Volume] [real] NOT NULL,
	[BIN2_Sheets] [int] NOT NULL,
	[BIN2_Volume] [real] NOT NULL,
	[BIN3_Sheets] [int] NOT NULL,
	[BIN3_Volume] [real] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Bins_Actual] ([Thickness], [BIN1_Sheets], [BIN1_Volume], [BIN2_Sheets], [BIN2_Volume], [BIN3_Sheets], [BIN3_Volume]) VALUES (1.55000007, 84, 0.371616274, 241, 1.06618142, 177, 1.53924835)

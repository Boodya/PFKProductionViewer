USE [Lathe]
GO
/****** Object:  Table [dbo].[Shift_Previous]    Script Date: 08/20/2021 23:21:21 ******/
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
/****** Object:  Table [dbo].[Shift_Actual]    Script Date: 08/20/2021 23:21:21 ******/
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
/****** Object:  Table [dbo].[Bins_Actual]    Script Date: 08/20/2021 23:21:21 ******/
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

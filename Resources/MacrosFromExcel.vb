cn.ConnectionString = "driver={SQL Server};server=***;uid=**;pwd=***;database=Lathe"
'--------------------------------------------
strSQL = "SELECT * FROM Shift_Actual"
rst.Open strSQL, cn
'-- BIN 1 thick 1 ---
Worksheets(4).Cells(12, 4) = rst(0) coll_pack11
Worksheets(4).Cells(12, 5) = rst(1) overal_coll_list11
Worksheets(4).Cells(12, 6) = rst(2) overal_V_list11
'-- BIN 2 thick 1 ---
Worksheets(4).Cells(12, 7) = rst(6) coll_pack12
Worksheets(4).Cells(12, 8) = rst(7) overal_coll_list12
Worksheets(4).Cells(12, 9) = rst(8) overal_V_list12
'-- BIN 3 thick 1 ---
Worksheets(4).Cells(12, 10) = rst(12) coll_pack13
Worksheets(4).Cells(12, 11) = rst(13) overal_coll_list13
Worksheets(4).Cells(12, 12) = rst(14) overal_V_list13
'-- Total ---
Worksheets(4).Cells(17, 11) = rst(22) overal_coll_list
Worksheets(4).Cells(17, 12) = rst(23) overal_V_list
'---Wast / Consamption---
Worksheets(4).Cells(14, 2) = rst(24) Percent_loss_veneer
Worksheets(4).Cells(15, 2) = rst(27) rate_medium
'--- Blocks data --------
Worksheets(4).Cells(5, 2) = rst(28) col_block
Worksheets(4).Cells(6, 2) = rst(29) medium_D_block
Worksheets(4).Cells(7, 2) = rst(30) V_block
Worksheets(4).Cells(8, 2) = rst(31) V_cil
Worksheets(4).Cells(9, 2) = rst(32) V_core
Worksheets(4).Cells(10, 2) = rst(33) loss_cil
Worksheets(4).Cells(11, 2) = rst(34) loss_core
Worksheets(4).Cells(12, 2) = rst(35) medium_D_core
rst.Close
'--------------------------------------------
strSQL = "SELECT * FROM Bins_Actual"
rst.Open strSQL, cn
'-- Thickness ---
Worksheets(4).Cells(17, 2) = rst(0) Thickness
'-- BIN 1 thick 1 ---
Worksheets(4).Cells(7, 5) = rst(1) BIN1_Sheets
Worksheets(4).Cells(7, 6) = rst(2) BIN1_Volume
'-- BIN 2 thick 1 ---
Worksheets(4).Cells(7, 8) = rst(3) BIN2_Sheets
Worksheets(4).Cells(7, 9) = rst(4) BIN2_Volume
'-- BIN 3 thick 1 ---
Worksheets(4).Cells(7, 11) = rst(5) BIN3_Sheets
Worksheets(4).Cells(7, 12) = rst(6) BIN3_Volume
rst.Close
'--------------------------------------------
strSQL = "SELECT * FROM Shift_Previous"
rst.Open strSQL, cn
'-- BIN 1 thick 1 ---
Worksheets(4).Cells(7, 20) = rst(0) coll_pack11
Worksheets(4).Cells(7, 21) = rst(1) overal_coll_list11
Worksheets(4).Cells(7, 22) = rst(2) overal_V_list11
'-- BIN 2 thick 1 ---
Worksheets(4).Cells(7, 23) = rst(6) coll_pack12
Worksheets(4).Cells(7, 24) = rst(7) overal_coll_list12
Worksheets(4).Cells(7, 25) = rst(8) overal_V_list12
'-- BIN 3 thick 1 ---
Worksheets(4).Cells(7, 26) = rst(12) coll_pack13
Worksheets(4).Cells(7, 27) = rst(13) overal_coll_list13
Worksheets(4).Cells(7, 28) = rst(14) overal_V_list13
'-- Total ---
Worksheets(4).Cells(12, 27) = rst(22) overal_coll_list
Worksheets(4).Cells(12, 28) = rst(23) overal_V_list
'---Wast / Consamption---
Worksheets(4).Cells(14, 18) = rst(24) Percent_loss_veneer
Worksheets(4).Cells(15, 18) = rst(27) rate_medium
'--- Blocks data --------
Worksheets(4).Cells(5, 18) = rst(28) col_block
Worksheets(4).Cells(6, 18) = rst(29) medium_D_block
Worksheets(4).Cells(7, 18) = rst(30) V_block
Worksheets(4).Cells(8, 18) = rst(31) V_cil
Worksheets(4).Cells(9, 18) = rst(32) V_core
Worksheets(4).Cells(10, 18) = rst(33) loss_cil
Worksheets(4).Cells(11, 18) = rst(34) loss_core
Worksheets(4).Cells(12, 18) = rst(35) medium_D_core
rst.Close
'--------------------------------------------
cn.Close

Set rst = Nothing
Set cn = Nothing

End Sub

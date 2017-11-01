VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H00FF8080&
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE (MAIN FORM)"
   ClientHeight    =   10050
   ClientLeft      =   240
   ClientTop       =   555
   ClientWidth     =   15090
   LinkTopic       =   "MDIForm1"
   Picture         =   "MDIForm1.frx":0000
   StartUpPosition =   1  'CenterOwner
   WindowState     =   2  'Maximized
   Begin VB.Menu mset 
      Caption         =   "&STUDENT REG"
      Begin VB.Menu mref 
         Caption         =   "STUDENT REGISTRATION "
      End
      Begin VB.Menu mCourse 
         Caption         =   "COURSES REGISTRATION"
         Visible         =   0   'False
      End
      Begin VB.Menu MGRADE1 
         Caption         =   "STUDENT GRADE"
         Visible         =   0   'False
      End
   End
   Begin VB.Menu MPERFORM11 
      Caption         =   "STUDENT &PERFORMANCE"
      Begin VB.Menu MNUSETPERFMINFO 
         Caption         =   "&SET STUDENT PERFORMANCE INFO."
      End
      Begin VB.Menu MYEARLY1 
         Caption         =   "CLUSTER &1 (2 SESSIONS PERFORMANCE ANALYSIS)"
      End
      Begin VB.Menu mnuCluster2 
         Caption         =   "CLUSTER &2 (1 SESSION PERFORMANCE ANALYSIS)"
      End
      Begin VB.Menu mnuCluster3 
         Caption         =   "CLUSTER &3 (1 Semester PERFORMANCE ANALYSIS)"
      End
   End
   Begin VB.Menu Course 
      Caption         =   "&CHECK STUDENT PERFORMANCE"
      Begin VB.Menu MNUCHECKINDPERF 
         Caption         =   "&CHECK INDIVIDUAL PERFORMANCE"
      End
      Begin VB.Menu MNUCHECKSESSION 
         Caption         =   "CHECK &SESSION PERFORMANCE"
      End
   End
   Begin VB.Menu mrep 
      Caption         =   "&REPORT"
      Begin VB.Menu mCs 
         Caption         =   "GENERATE REGISTRATION REPORT"
         Visible         =   0   'False
      End
      Begin VB.Menu mPrf 
         Caption         =   "GENERATE INDIVIDUAL PROFILE"
      End
      Begin VB.Menu mlay 
         Caption         =   "GENERAL STUDENT REGISTRATION REPORT"
      End
      Begin VB.Menu mCheckl 
         Caption         =   "CHECK GROUP BY LEVEL"
         Enabled         =   0   'False
         Visible         =   0   'False
         Begin VB.Menu MNDI 
            Caption         =   "100 LEVEL"
         End
         Begin VB.Menu MNDII 
            Caption         =   "200 LEVEL"
         End
         Begin VB.Menu MHNDI 
            Caption         =   "300 LEVEL"
         End
         Begin VB.Menu MHNDII 
            Caption         =   "400 LEVEL"
         End
      End
   End
   Begin VB.Menu MQUIT 
      Caption         =   "QUIT"
      Begin VB.Menu mX 
         Caption         =   "EXIT"
      End
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mcomb_Click()
Unload DataEnvironment1
Load DataEnvironment1
Unload DataReport3
Load DataReport3
DataReport3.Show 1
End Sub


Private Sub mCourse_Click()
Form2.Show 1
End Sub

Private Sub mCs_Click()
'With Form3
'Label12 = "": Label13 = "": Label14 = "": Label15 = "": Label16 = "": Label17 = "": Label18 = "": Label19 = "": Label20 = "": Label21 = ""
'LB1 = "": LB2 = "": LB3 = "": LB4 = "": LB5 = "": LB6 = "": LB7 = "": LB8 = "": LB9 = "": LB9 = "": LB10 = ""
'End With
Form3.Show 1
End Sub

Private Sub MGRADE_Click()
Form4.Show 1
End Sub

Private Sub MDIForm_Load()
DataEnvironment1.Connection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb"
End Sub

Private Sub MGRADE1_Click()
Form9.Show
End Sub

Private Sub MHNDI_Click()
Label1 = "100 LEVEL"
Label2 = "200 LEVEL"
Label3 = "300 LEVEL"
Label4 = "400 LEVEL"
On Error Resume Next
Dim MYD As Database
Dim MRS  As Recordset
Set MYD = OpenDatabase(App.Path & "\stdRC.mdb")
Set DB = New ADODB.Connection
 Set rs = New ADODB.Recordset
'Set Dat = DBEGINEOpenDatabase(App.Path & "\GPA.mdb")
'Set cn = New ADODB.Connection
' Set rs = New ADODB.Recordset
DB.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 Set rs = DB.Execute("select * from REGTAB WHERE level = '" & Label3 & "'")
'With MYRS
 Set DataReport5.DataSource = rs
 DataReport5.ReportWidth = 8
 
DataReport5.Sections("rptheader").Controls("label8").Caption = Label3
 
DataReport5.Refresh
DataReport5.Show 1

End Sub

Private Sub MHNDII_Click()
Label1 = "100 LEVEL"
Label2 = "200 LEVEL"
Label3 = "300 LEVEL"
Label4 = "400 LEVEL"
On Error Resume Next
Dim MYD As Database
Dim MRS  As Recordset
Set MYD = OpenDatabase(App.Path & "\stdRC.mdb")
Set DB = New ADODB.Connection
 Set rs = New ADODB.Recordset
'Set Dat = DBEGINEOpenDatabase(App.Path & "\GPA.mdb")
'Set cn = New ADODB.Connection
' Set rs = New ADODB.Recordset
DB.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 Set rs = DB.Execute("select * from REGTAB WHERE level = '" & Label4 & "'")
'With MYRS
 Set DataReport5.DataSource = rs
 DataReport5.ReportWidth = 8
 
 

' DBEngine.OpenDatabase ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 'cn.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\GPA.mdb")

 'With MYRS

 ' Set DataReport4.DataMember = Command1
'
'DataReport4.DataMember =
DataReport5.Sections("rptheader").Controls("label8").Caption = Label4
 
DataReport5.Refresh
DataReport5.Show 1

End Sub

Private Sub mlay_Click()
Unload DataEnvironment1
Load DataEnvironment1
Unload DataReport1
Load DataReport1
DataReport1.Show
End Sub

Private Sub MNDI_Click()
Label1 = "100 LEVEL"
Label2 = "200 LEVEL"
Label3 = "300 LEVEL"
Label4 = "400 LEVEL"
On Error Resume Next
Dim MYD As Database
Dim MRS  As Recordset
Set MYD = OpenDatabase(App.Path & "\stdRC.mdb")
Set DB = New ADODB.Connection
 Set rs = New ADODB.Recordset
'Set Dat = DBEGINEOpenDatabase(App.Path & "\GPA.mdb")
'Set cn = New ADODB.Connection
' Set rs = New ADODB.Recordset
DB.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 Set rs = DB.Execute("select * from REGTAB WHERE level = '" & Label1 & "'")
'With MYRS
 Set DataReport5.DataSource = rs
 DataReport5.ReportWidth = 8
 
 

' DBEngine.OpenDatabase ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 'cn.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\GPA.mdb")

 'With MYRS

 ' Set DataReport4.DataMember = Command1
'
'DataReport4.DataMember =
DataReport5.Sections("rptheader").Controls("label8").Caption = Label1
 
DataReport5.Refresh
DataReport5.Show 1
End Sub

Private Sub MNDII_Click()
Label1 = "100 LEVEL"
Label2 = "200 LEVEL"
Label3 = "300 LEVEL"
Label4 = "400 LEVEL"
On Error Resume Next
Dim MYD As Database
Dim MRS  As Recordset
Set MYD = OpenDatabase(App.Path & "\stdRC.mdb")
Set DB = New ADODB.Connection
 Set rs = New ADODB.Recordset
'Set Dat = DBEGINEOpenDatabase(App.Path & "\GPA.mdb")
'Set cn = New ADODB.Connection
' Set rs = New ADODB.Recordset
DB.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 Set rs = DB.Execute("select * from REGTAB WHERE level = '" & Label2 & "'")
'With MYRS
 Set DataReport5.DataSource = rs
 DataReport5.ReportWidth = 8
 
 

' DBEngine.OpenDatabase ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\stdrc.mdb")
 'cn.Open ("Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & App.Path & "\GPA.mdb")

 'With MYRS

 ' Set DataReport4.DataMember = Command1
'
'DataReport4.DataMember =
DataReport5.Sections("rptheader").Controls("label8").Caption = Label2
 
DataReport5.Refresh
DataReport5.Show 1

End Sub

Private Sub MNUCHECKINDPERF_Click()
Form12.Show 1
End Sub

Private Sub MNUCHECKSESSION_Click()
FORM13.Show 1
End Sub

Private Sub mnuCluster2_Click()
Form10.Show 1
End Sub

Private Sub mnuCluster3_Click()
Form11.Show 1
End Sub

Private Sub MNUSETPERFMINFO_Click()
Form4.Show 1
End Sub

Private Sub mPrf_Click()
Form8.Show 1
End Sub

Private Sub mref_Click()
Form1.Show 1
End Sub

Private Sub mX_Click()
End
End Sub

Private Sub MYEARLY1_Click()
Form7.Show 1
End Sub


VERSION 5.00
Begin VB.Form Form7 
   BackColor       =   &H00800000&
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE - CLUSTER 1 (PERFORMANCE BASED ON 2 SESSIONS AND LEVEL)"
   ClientHeight    =   6615
   ClientLeft      =   300
   ClientTop       =   3135
   ClientWidth     =   13875
   ForeColor       =   &H00800000&
   LinkTopic       =   "Form7"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6615
   ScaleWidth      =   13875
   ShowInTaskbar   =   0   'False
   Begin VB.ComboBox Combo1 
      BeginProperty Font 
         Name            =   "OCR A Extended"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   465
      ItemData        =   "Form7.frx":0000
      Left            =   120
      List            =   "Form7.frx":0002
      Style           =   2  'Dropdown List
      TabIndex        =   29
      Top             =   600
      Width           =   3015
   End
   Begin VB.ListBox List1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2220
      Left            =   6480
      TabIndex        =   28
      Top             =   4200
      Width           =   7095
   End
   Begin VB.CommandButton Command2 
      Caption         =   "ANALYSE PERFORMANCE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3120
      TabIndex        =   27
      Top             =   5760
      Width           =   2775
   End
   Begin VB.ComboBox Combo5 
      BeginProperty Font 
         Name            =   "OCR A Extended"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   465
      ItemData        =   "Form7.frx":0004
      Left            =   3240
      List            =   "Form7.frx":0014
      TabIndex        =   20
      Top             =   1200
      Width           =   2535
   End
   Begin VB.ComboBox Combo2 
      BeginProperty Font 
         Name            =   "OCR A Extended"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   465
      ItemData        =   "Form7.frx":0034
      Left            =   3240
      List            =   "Form7.frx":0036
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   600
      Width           =   2535
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00800000&
      Caption         =   "STUDENT PERFORMANCE ANALYSIS"
      BeginProperty Font 
         Name            =   "OCR A Extended"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   3735
      Left            =   120
      TabIndex        =   2
      Top             =   1920
      Width           =   5775
      Begin VB.Label Label43 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   26
         Top             =   2760
         Width           =   1455
      End
      Begin VB.Label Label42 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "FAIL"
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   120
         TabIndex        =   25
         Top             =   3240
         Width           =   2055
      End
      Begin VB.Label Label41 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   24
         Top             =   3240
         Width           =   1575
      End
      Begin VB.Line Line1 
         BorderColor     =   &H0000FFFF&
         BorderWidth     =   4
         X1              =   120
         X2              =   5520
         Y1              =   1200
         Y2              =   1200
      End
      Begin VB.Label Label17 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   19
         Top             =   2760
         Width           =   1575
      End
      Begin VB.Label Label16 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PASS"
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   120
         TabIndex        =   18
         Top             =   2760
         Width           =   2055
      End
      Begin VB.Label Label15 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   17
         Top             =   3240
         Width           =   1455
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   16
         Top             =   2280
         Width           =   1575
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "LOWER CREDIT"
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   120
         TabIndex        =   15
         Top             =   2280
         Width           =   2055
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   14
         Top             =   2280
         Width           =   1455
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   13
         Top             =   720
         Width           =   1455
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   12
         Top             =   1320
         Width           =   1575
      End
      Begin VB.Label Label13 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "DISTINCTION"
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   120
         TabIndex        =   11
         Top             =   1320
         Width           =   2055
      End
      Begin VB.Label Label12 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   10
         Top             =   1320
         Width           =   1455
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   4080
         TabIndex        =   9
         Top             =   1800
         Width           =   1455
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "UPPER CREDIT"
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   8
         Top             =   1680
         Width           =   2055
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   7
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "SESSION:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   120
         TabIndex        =   6
         Top             =   720
         Width           =   1815
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   2280
         TabIndex        =   4
         Top             =   1800
         Width           =   1575
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "GENERATE RESULT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   1
      Top             =   5760
      Width           =   2895
   End
   Begin VB.Label Label22 
      BackStyle       =   0  'Transparent
      Caption         =   "Date of Visit:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   23
      Top             =   2160
      Width           =   2295
   End
   Begin VB.Label Label21 
      BackStyle       =   0  'Transparent
      Caption         =   "Time check in:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   22
      Top             =   2640
      Width           =   2295
   End
   Begin VB.Label Label20 
      BackStyle       =   0  'Transparent
      Caption         =   "Time check out:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   21
      Top             =   3240
      Width           =   2295
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Level:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   120
      TabIndex        =   5
      Top             =   1200
      Width           =   3015
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Select from two sessions below:"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5655
   End
End
Attribute VB_Name = "Form7"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Combo1_GotFocus()
Label14 = "": Label12 = "": Label8 = "": Label9 = ""
Label11 = "": Label5 = "": Label17 = "": Label15 = "": Label41 = ""
Label43 = ""
End Sub

Private Sub Combo2_Click()
'If Combo2 < Combo1 Then
'MsgBox "Pls, first session must be less than second or equal to it", vbInformation, ""
'Combo1.SetFocus
'Exit Sub
'End If
End Sub

Private Sub Combo2_GotFocus()
Label14 = "": Label12 = "": Label8 = "": Label9 = ""
Label11 = "": Label5 = "": Label17 = "": Label15 = "": Label41 = ""
Label43 = ""
End Sub


Private Sub Command1_Click()
On Error Resume Next
Cluster1(1, 2) = "DISTINCTION"
Cluster1(1, 3) = "UPPER CREDIT"
Cluster1(1, 4) = "LOWER CREDIT"
Cluster1(1, 5) = "PASS"
Cluster1(1, 6) = "FAIL"
'First Session
Cluster1(2, 1) = Combo1.Text & " Session"
Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "DISTINCTION" & "'")
With myrs
DD = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
DD = DD + Val(!Count)
.MoveNext
Loop
Label14 = DD: Cluster1(2, 2) = DD
Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "UPPER CREDIT" & "'")
With myrs
CC = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
CC = CC + Val(!Count)
.MoveNext
Loop
Label8 = CC: Cluster1(2, 3) = CC
'Else
'Exit Sub
End If
End With
Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "LOWER CREDIT" & "'")
With myrs
LW = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
LW = LW + Val(!Count)
.MoveNext
Loop
Label11 = LW: Cluster1(2, 4) = LW
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "PASS" & "'")
With myrs
THIRD = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
THIRD = THIRD + Val(!Count)
.MoveNext
Loop
Label17 = THIRD: Cluster1(2, 5) = THIRD
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "FAIL" & "'")
With myrs
PASS = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
PASS = PASS + Val(!Count)
.MoveNext
Loop
Label41 = PASS: Cluster1(2, 6) = PASS
End If
End With

'Second Session*******************************
 Cluster1(3, 1) = Combo2.Text & " Session"
 Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo2 & "'AND GRADE = '" & "DISTINCTION" & "'")
With myrs
DD1 = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
DD1 = DD1 + Val(!Count)
.MoveNext
Loop
Label12 = DD1: Cluster1(3, 2) = DD1
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo2 & "'AND GRADE = '" & "UPPER CREDIT" & "'")
With myrs
CC1 = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
CC1 = CC1 + Val(!Count)
.MoveNext
Loop
Label9 = CC1: Cluster1(3, 3) = CC1
Else
Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo2 & "'AND GRADE = '" & "LOWER CREDIT" & "'")
With myrs
LW1 = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
LW1 = LW1 + Val(!Count)
.MoveNext
Loop
Label5 = LW1: Cluster1(3, 4) = LW1
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo2 & "'AND GRADE = '" & "PASS" & "'")
With myrs
THIRD1 = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
THIRD1 = THIRD1 + Val(!Count)
.MoveNext
Loop
Label15 = THIRD1: Cluster1(3, 5) = THIRD1
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & "FIRST" & "' OR SEMESTER = '" & "SECOND" & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo2 & "'AND GRADE = '" & "FAIL" & "'")
With myrs
PASS1 = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
PASS1 = PASS1 + Val(!Count)
.MoveNext
Loop
Label15 = PASS1: Cluster1(3, 6) = PASS1
'Else
'Exit Sub
End If
End With
End Sub

Private Sub Command1_GotFocus()
Label2 = Combo1
Label3 = Combo2
End Sub

Private Sub Command2_Click()
ClusterType = "Cluster 1"
chartTitle = "Graph of " & Combo5.Text & " Students Academic Performance for" & Combo1.Text & " and " & Combo2.Text & " Sessions"
FRMCHART.Show 1

If Val(Label14) > Val(Label12) And Val(Label8) >= Val(Label9) Then
Form7.Width = 13995
List1.AddItem "The previous session result was better than this year's "
List1.AddItem "own, let all lecturers put more effort on lecturing performances"
List1.AddItem "on the student part let all textbooks and other related materials needed"
List1.AddItem "to be available."

ElseIf Val(Label14) = Val(Label12) And Val(Label8) = Val(Label9) Then
List1.AddItem "The previous session result was better than this year's "
List1.AddItem "own, let all lecturers put more effort on lecturing performances"
List1.AddItem "on the student part let all textbooks and other related materials needed"
List1.AddItem "to be available."
Form7.Width = 13995
ElseIf (Val(Label12) >= Val(Label14) And Val(Label9) >= Val(Label8)) Then
List1.AddItem "The previous session result was better than this year's "
List1.AddItem ""
List1.AddItem "own, let all lecturers put more effort on lecturing performances"
List1.AddItem ""
List1.AddItem "on the student part let all textbooks and other related materials needed"
List1.AddItem ""
List1.AddItem "to be available."
Form7.Width = 13995
End If

End Sub

Private Sub Form_Load()
Form7.Width = 6190

Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
'Private Sub Form_Load()
For I = 2004 To 2300
Combo1.AddItem I & "/" & (I + 1)
Next I
'End Sub
For K = 2004 To 2300
Combo2.AddItem K & "/" & (K + 1)
Next K
End Sub




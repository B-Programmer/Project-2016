VERSION 5.00
Begin VB.Form Form9 
   BackColor       =   &H00FF0000&
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE"
   ClientHeight    =   8970
   ClientLeft      =   4710
   ClientTop       =   1425
   ClientWidth     =   9510
   LinkTopic       =   "Form9"
   ScaleHeight     =   8970
   ScaleWidth      =   9510
   Begin VB.CheckBox Check1 
      BackColor       =   &H00FF0000&
      Caption         =   "Check to Edit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   240
      TabIndex        =   69
      Top             =   1560
      Width           =   1575
   End
   Begin VB.CommandButton cmdedit 
      Caption         =   "&Edit"
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
      Left            =   7800
      TabIndex        =   68
      Top             =   5760
      Width           =   1815
   End
   Begin VB.CommandButton Cmdrefresh 
      Caption         =   "&Refresh"
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
      Left            =   7800
      TabIndex        =   67
      Top             =   4920
      Width           =   1815
   End
   Begin VB.CommandButton CMDPrint 
      Caption         =   "&Print"
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
      Left            =   7800
      TabIndex        =   66
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CommandButton CmdSave 
      Caption         =   "&Save"
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
      Left            =   7800
      TabIndex        =   65
      Top             =   3240
      Width           =   1815
   End
   Begin VB.ComboBox TxtSemester 
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
      ItemData        =   "Formgrade1.frx":0000
      Left            =   5880
      List            =   "Formgrade1.frx":000A
      Style           =   2  'Dropdown List
      TabIndex        =   64
      Top             =   1080
      Width           =   3255
   End
   Begin VB.ComboBox Combo3 
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
      ItemData        =   "Formgrade1.frx":001D
      Left            =   1920
      List            =   "Formgrade1.frx":001F
      Style           =   2  'Dropdown List
      TabIndex        =   63
      Top             =   120
      Width           =   2775
   End
   Begin VB.CommandButton Cmdcancel 
      Caption         =   "C&ancel"
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
      Left            =   7800
      TabIndex        =   62
      Top             =   6600
      Width           =   1815
   End
   Begin VB.CommandButton CmdCompute 
      Caption         =   "&Compute"
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
      Left            =   7800
      TabIndex        =   61
      Top             =   2400
      Width           =   1815
   End
   Begin VB.TextBox TxtSession 
      Appearance      =   0  'Flat
      BackColor       =   &H008080FF&
      Height          =   375
      Left            =   6840
      TabIndex        =   60
      Top             =   600
      Width           =   2295
   End
   Begin VB.TextBox CGPA 
      Height          =   375
      Left            =   4800
      TabIndex        =   58
      Top             =   8160
      Width           =   1455
   End
   Begin VB.TextBox GPA 
      Height          =   375
      Left            =   2040
      TabIndex        =   56
      Top             =   8160
      Width           =   1455
   End
   Begin VB.TextBox TwgPoint 
      Height          =   375
      Left            =   3960
      TabIndex        =   54
      Top             =   7680
      Width           =   1815
   End
   Begin VB.TextBox TotalUnit 
      Height          =   375
      Left            =   2040
      TabIndex        =   52
      Top             =   7200
      Width           =   1455
   End
   Begin VB.TextBox Scores10 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   50
      Top             =   6720
      Width           =   1335
   End
   Begin VB.TextBox Scores9 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   49
      Top             =   6240
      Width           =   1335
   End
   Begin VB.TextBox Scores8 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   48
      Top             =   5760
      Width           =   1335
   End
   Begin VB.TextBox Scores7 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   47
      Top             =   5280
      Width           =   1335
   End
   Begin VB.TextBox Scores6 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   46
      Top             =   4800
      Width           =   1335
   End
   Begin VB.TextBox Scores5 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   45
      Top             =   4320
      Width           =   1335
   End
   Begin VB.TextBox Scores4 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   44
      Top             =   3840
      Width           =   1335
   End
   Begin VB.TextBox Scores3 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   43
      Top             =   3360
      Width           =   1335
   End
   Begin VB.TextBox Scores2 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   42
      Top             =   2880
      Width           =   1335
   End
   Begin VB.TextBox Scores1 
      Height          =   375
      Left            =   6000
      MaxLength       =   2
      TabIndex        =   41
      Top             =   2400
      Width           =   1335
   End
   Begin VB.TextBox Unit10 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   40
      Top             =   6720
      Width           =   1215
   End
   Begin VB.TextBox Unit9 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   39
      Top             =   6240
      Width           =   1215
   End
   Begin VB.TextBox Unit8 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   38
      Top             =   5760
      Width           =   1215
   End
   Begin VB.TextBox Unit7 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   37
      Top             =   5280
      Width           =   1215
   End
   Begin VB.TextBox Unit6 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   36
      Top             =   4800
      Width           =   1215
   End
   Begin VB.TextBox Unit5 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   35
      Top             =   4320
      Width           =   1215
   End
   Begin VB.TextBox Unit4 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   34
      Top             =   3840
      Width           =   1215
   End
   Begin VB.TextBox Unit3 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   33
      Top             =   3360
      Width           =   1215
   End
   Begin VB.TextBox Unit2 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   32
      Top             =   2880
      Width           =   1215
   End
   Begin VB.TextBox Unit1 
      Height          =   375
      Left            =   4440
      MaxLength       =   2
      TabIndex        =   31
      Top             =   2400
      Width           =   1215
   End
   Begin VB.TextBox Courses10 
      Height          =   375
      Left            =   360
      TabIndex        =   30
      Top             =   6720
      Width           =   3735
   End
   Begin VB.TextBox Courses9 
      Height          =   375
      Left            =   360
      TabIndex        =   29
      Top             =   6240
      Width           =   3735
   End
   Begin VB.TextBox Courses8 
      Height          =   375
      Left            =   360
      TabIndex        =   28
      Top             =   5760
      Width           =   3735
   End
   Begin VB.TextBox Courses7 
      Height          =   375
      Left            =   360
      TabIndex        =   27
      Top             =   5280
      Width           =   3735
   End
   Begin VB.TextBox Courses6 
      Height          =   375
      Left            =   360
      TabIndex        =   26
      Top             =   4800
      Width           =   3735
   End
   Begin VB.TextBox Courses5 
      Height          =   375
      Left            =   360
      TabIndex        =   25
      Top             =   4320
      Width           =   3735
   End
   Begin VB.TextBox Courses4 
      Height          =   375
      Left            =   360
      TabIndex        =   24
      Top             =   3840
      Width           =   3735
   End
   Begin VB.TextBox Courses3 
      Height          =   375
      Left            =   360
      TabIndex        =   23
      Top             =   3360
      Width           =   3735
   End
   Begin VB.TextBox Courses2 
      Height          =   375
      Left            =   360
      TabIndex        =   22
      Top             =   2880
      Width           =   3735
   End
   Begin VB.TextBox Courses1 
      Height          =   405
      Left            =   360
      TabIndex        =   21
      Top             =   2400
      Width           =   3735
   End
   Begin VB.TextBox TxtLevel 
      Appearance      =   0  'Flat
      BackColor       =   &H008080FF&
      Height          =   375
      Left            =   1800
      TabIndex        =   7
      Top             =   1200
      Width           =   1575
   End
   Begin VB.TextBox TxtDepartment 
      Appearance      =   0  'Flat
      BackColor       =   &H008080FF&
      Height          =   375
      Left            =   6240
      TabIndex        =   4
      Top             =   120
      Width           =   2895
   End
   Begin VB.TextBox TxtName 
      Appearance      =   0  'Flat
      BackColor       =   &H008080FF&
      ForeColor       =   &H00000000&
      Height          =   375
      Left            =   1800
      TabIndex        =   2
      Top             =   720
      Width           =   3735
   End
   Begin VB.Label Label23 
      BackStyle       =   0  'Transparent
      Caption         =   "SESSION"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   5640
      TabIndex        =   59
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label Label22 
      BackStyle       =   0  'Transparent
      Caption         =   "CGPA"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      TabIndex        =   57
      Top             =   8160
      Width           =   1215
   End
   Begin VB.Label Label21 
      BackStyle       =   0  'Transparent
      Caption         =   "GPA"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   55
      Top             =   8160
      Width           =   1455
   End
   Begin VB.Label Label20 
      BackStyle       =   0  'Transparent
      Caption         =   "TOTAL WEIGHTED GRADE POINT"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   53
      Top             =   7800
      Width           =   3375
   End
   Begin VB.Label Label19 
      BackStyle       =   0  'Transparent
      Caption         =   "TOTAL UNIT"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   51
      Top             =   7320
      Width           =   1335
   End
   Begin VB.Label Label18 
      BackStyle       =   0  'Transparent
      Caption         =   "10"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   20
      Top             =   6720
      Width           =   375
   End
   Begin VB.Label Label17 
      BackStyle       =   0  'Transparent
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   19
      Top             =   6240
      Width           =   375
   End
   Begin VB.Label Label16 
      BackStyle       =   0  'Transparent
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   18
      Top             =   5760
      Width           =   375
   End
   Begin VB.Label Label15 
      BackStyle       =   0  'Transparent
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   17
      Top             =   5280
      Width           =   375
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   16
      Top             =   4800
      Width           =   375
   End
   Begin VB.Label Label13 
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   15
      Top             =   4320
      Width           =   255
   End
   Begin VB.Label Label12 
      BackStyle       =   0  'Transparent
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   14
      Top             =   3840
      Width           =   375
   End
   Begin VB.Label Label11 
      BackStyle       =   0  'Transparent
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   13
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label Label10 
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   12
      Top             =   2880
      Width           =   375
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   11
      Top             =   2400
      Width           =   375
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "SCORES"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   6240
      TabIndex        =   10
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Label Label7 
      Appearance      =   0  'Flat
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "UNIT"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   4800
      TabIndex        =   9
      Top             =   2040
      Width           =   855
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "COURSES"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   1800
      TabIndex        =   8
      Top             =   2040
      Width           =   1575
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "LEVEL"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "SEMESTER"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   4320
      TabIndex        =   5
      Top             =   1200
      Width           =   1575
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "DEPARTMENT"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   4800
      TabIndex        =   3
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "NAME"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   " MATRIC NUMBER"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   240
      Width           =   2535
   End
End
Attribute VB_Name = "Form9"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim TUnit(1 To 10) As Integer
Dim Points(1 To 10) As Single
Dim REMARK As String

Private Sub Check1_Click()
cmdedit.Enabled = True
Set myrs = mydb.OpenRecordset("SELECT * FROM Semester1 WHERE Matricno = '" & Combo3 & "' AND LEVEL='" & TxtLevel & "' AND SEMESTER='" & TxtSemester & "'")
With myrs
.AddNew
   !MATRICNO = Combo3
   !Name = TxtName
   !dept = TxtDepartment
   !Level = TxtLevel
   !SEMESTER = TxtSemester
   !Session = TxtSession
   !Course1 = Courses1
   !Course2 = Courses2
   !Course3 = Courses3
   !Course4 = Courses4
   !Course5 = Courses5
   !Course6 = Courses6
   !Course7 = Courses7
   !Course8 = Courses8
   !Course9 = Courses9
   !Course10 = Courses10
   !Unit1 = Unit1
   !Unit2 = Unit2
   !Unit3 = Unit3
   !Unit4 = Unit4
   !Unit5 = Unit5
   !Unit6 = Unit6
   !Unit7 = Unit7
   !Unit8 = Unit8
   !Unit9 = Unit9
   !Unit10 = Unit10
   !Score1 = Scores1
   !Score2 = Scores2
   !Score3 = Scores3
   !Score4 = Scores4
   !Score5 = Scores5
   !Score6 = Scores6
   !Score7 = Scores7
   !Score8 = Scores8
   !Score9 = Scores9
   !Score10 = Scores10
   TU = TotalUnit
   !TWGP = TwgPoint
   !GPA = GPA
   !CGPA = CGPA
   !REMARK = REMARK
   .Update
   End With
  
End Sub



Private Sub cmdcancel_Click()
Unload Me
End Sub

Private Sub CmdCompute_Click()
CmdSave.Enabled = True
Dim TWGP As Single, TU As Integer

 Points(1) = generatePoint(Val(Scores1))
 Points(2) = generatePoint(Val(Scores2))
 Points(3) = generatePoint(Val(Scores3))
 Points(4) = generatePoint(Val(Scores4))
 Points(5) = generatePoint(Val(Scores5))
 Points(6) = generatePoint(Val(Scores6))
 Points(7) = generatePoint(Val(Scores7))
 Points(8) = generatePoint(Val(Scores8))
 Points(9) = generatePoint(Val(Scores9))
 Points(10) = generatePoint(Val(Scores10))
 TUnit(1) = Val(Unit1)
 TUnit(2) = Val(Unit2)
 TUnit(3) = Val(Unit3)
 TUnit(4) = Val(Unit4)
 TUnit(5) = Val(Unit5)
 TUnit(6) = Val(Unit6)
 TUnit(7) = Val(Unit7)
 TUnit(8) = Val(Unit8)
 TUnit(9) = Val(Unit9)
 TUnit(10) = Val(Unit10)
  For I = 1 To 10
  TWGP = TWGP + (Points(I) * TUnit(I))
  TU = TU + TUnit(I)
  Next I
  TotalUnit = TU
  TwgPoint = FormatNumber(TWGP, 2)
   If TU > 0 Then
  GPA = FormatNumber(TWGP / TU, 2)
  End If
  CGPA = GPA
   If (4.5 <= CGPA And CGPA <= 5#) Then
    REMARK = "FIRST CLASS UPPER"
   ElseIf (3.5 <= CGPA And CGPA <= 4.49) Then
    REMARK = "SECOND CLASS UPPER"
   ElseIf (3# <= CGPA And CGPA <= 3.49) Then
    REMARK = "SECOND CLASS LOWER"
   ElseIf (2.5 <= CGPA And CGPA <= 2.99) Then
    REMARK = "THIRD CLASS"
   ElseIf (2# <= CGPA And CGPA <= 2.49) Then
    REMARK = "PASS"
   ElseIf (0 <= CGPA And CGPA <= 1.99) Then
    REMARK = "FAIL"
   End If
   
End Sub

Private Function generatePoint(Score As Integer) As Single
If (Score >= 70) Then
 generatePoint = 5#
ElseIf (Score >= 60) Then
 generatePoint = 4#
ElseIf (Score >= 50) Then
 generatePoint = 3#
ElseIf (Score >= 40) Then
 generatePoint = 2#
ElseIf (Score >= 0) Then
 generatePoint = 0#
End If
End Function



Private Sub CMDPrint_Click()
PrintForm
End Sub

Private Sub Cmdrefresh_Click()
Combo3.ListIndex = -1: TxtSemester.ListIndex = -1
TxtName = "":  TxtLevel = "":  TxtSession = "":  TxtDepartment = ""
Courses1 = "":  Courses2 = "": Courses3 = "":  Courses4 = "": Courses5 = ""
Courses6 = "":  Courses7 = "": Courses8 = "":  Courses9 = "":  Courses10 = ""
 Unit1 = "":  Unit2 = "":  Unit3 = "":  Unit4 = "":  Unit5 = "":  Unit6 = ""
  Unit7 = "":  Unit8 = "":  Unit9 = "":  Unit10 = ""
 Scores1 = "": Scores2 = "": Scores3 = "": Scores4 = "": Scores5 = "": Scores6 = ""
 Scores7 = "": Scores8 = "":   Scores9 = "": Scores10 = "": TotalUnit = "": TwgPoint = "": GPA = "": CGPA = ""
End Sub

Private Sub CmdSave_Click()
If (Combo3 <> "" And TxtSemester <> "" And Scores1 <> "" And Scores2 <> "" And Scores3 <> "" _
And Scores4 <> "" And Scores5 <> "" And Scores6 <> "" And Scores7 <> "" And Scores8 <> "" _
And Scores9 <> "" And Scores10 <> "" And TotalUnit <> "" And TwgPoint <> "" And GPA <> "" And CGPA <> "") Then
 '--------------- Remark------------------------------------------------
Set myrs = mydb.OpenRecordset("SELECT * FROM Semester1 WHERE MATRICNO = '" & Combo3 & "' AND LEVEL='" & TxtLevel & "' AND SEMESTER='" & TxtSemester & "'")
With myrs
On Error Resume Next
R = !MATRICNO
S = !Level
T = !SEMESTER
If (R = Combo3) And (S = TxtLevel) And (T = TxtSemester) Then
MsgBox "You have process this result", vbOKOnly, "Information"
ElseIf (R = Combo3 And S = TxtLevel And T <> TxtSemester) Then
Set myrs = mydb.OpenRecordset("Semesterer2")
With myrs
  .AddNew
   !MATRICNO = Combo3
   !Name = TxtName
   !dept = TxtDepartment
   !Level = TxtLevel
   !SEMESTER = TxtSemester
   !Session = TxtSession
   !Course1 = Courses1
   !Course2 = Courses2
   !Course3 = Courses3
   !Course4 = Courses4
   !Course5 = Courses5
   !Course6 = Courses6
   !Course7 = Courses7
   !Course8 = Courses8
   !Course9 = Courses9
   !Course10 = Courses10
   !Unit1 = Unit1
   !Unit2 = Unit2
   !Unit3 = Unit3
   !Unit4 = Unit4
   !Unit5 = Unit5
   !Unit6 = Unit6
   !Unit7 = Unit7
   !Unit8 = Unit8
   !Unit9 = Unit9
   !Unit10 = Unit10
   !Score1 = Scores1
   !Score2 = Scores2
   !Score3 = Scores3
   !Score4 = Scores4
   !Score5 = Scores5
   !Score6 = Scores6
   !Score7 = Scores7
   !Score8 = Scores8
   !Score9 = Scores9
   !Score10 = Scores10
   !TU = TotalUnit
   !TWGP = TwgPoint
   !GPA = GPA
   !CGPA = CGPA
   !REMARK = REMARK
  .Update
  MsgBox "record save successfully"
  .CLOSE
End With
End If
End With
End If
End Sub


Private Sub Combo3_Click()
CmdCompute.Enabled = True
Set myrs = mydb.OpenRecordset("Select * from regtab WHERE matricno = '" & Combo3 & "'")
  With myrs
  If .RecordCount <> 0 Then
  TxtName = !Name
  TxtLevel = !Level
  TxtSession = !Session
  TxtDepartment = !COUS
  End If
  End With
End Sub

Private Sub Combo3_GotFocus()
TxtName = "":  TxtLevel = "":  TxtSession = "":  TxtDepartment = ""
Courses1 = "":  Courses2 = "": Courses3 = "":  Courses4 = "": Courses5 = ""
Courses6 = "":  Courses7 = "": Courses8 = "":  Courses9 = "":  Courses10 = ""
 Unit1 = "":  Unit2 = "":  Unit3 = "":  Unit4 = "":  Unit5 = "":  Unit6 = ""
  Unit7 = "":  Unit8 = "":  Unit9 = "":  Unit10 = ""
Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
    On Error Resume Next
    Set myrs = mydb.OpenRecordset("Select * from regtab order by matricno")
  With myrs
    If myrs.BOF = False Then
        Combo3.clear
      Do While Not myrs.EOF
       Combo3.AddItem myrs!MATRICNO
        myrs.MoveNext
      Loop
    End If
  End With

End Sub

Private Sub Combo3_LostFocus()
On Error Resume Next
If (Combo3 <> "" And TxtSemester <> "") Then
'--------------------- COURSES --------------------------
Set myrs = mydb.OpenRecordset("Select * from Destab WHERE Sem = '" & TxtSemester & "' and lev = '" & TxtLevel.Text & "' and dept = '" & TxtDepartment.Text & "' ")
  With myrs
  If .RecordCount <> 0 Then
  Courses1 = !dt1
  Courses2 = !dt2
  Courses3 = !dt3
  Courses4 = !dt4
  Courses5 = !dt5
  Courses6 = !dt6
  Courses7 = !dt7
  Courses8 = !dt8
  Courses9 = !dt9
  Courses10 = !dt10
  
  End If
  
 .CLOSE
  End With
'-------------------------------UNIT-------------------
Set myrs = mydb.OpenRecordset("Select * from UNIT WHERE Sem = '" & TxtSemester & "' and lev = '" & TxtLevel.Text & "' and dept = '" & TxtDepartment.Text & "' ")
  With myrs
  If .RecordCount <> 0 Then
  Unit1 = !Ut1
  Unit2 = !Ut2
  Unit3 = !Ut3
  Unit4 = !Ut4
  Unit5 = !Ut5
  Unit6 = !ut6
  Unit7 = !ut7
  Unit8 = !Ut8
  Unit9 = !Ut9
  Unit10 = !Ut10
  
  End If
  
 .CLOSE
  End With

End If
End Sub

Private Sub Cmdedit_Click()

On Error Resume Next
    Set myrs = mydb.OpenRecordset("SELECT * FROM grade WHERE MATNO = '" & Combo3 & "' AND LEVEL='" & TxtLevel & "' AND SEMESTER='" & TxtSemester & "'")
    With myrs
        .Edit
       .Fields("Matric no") = Combo3
   !Name = TxtName
   !dept = TxtDepartment
   !Level = TxtLevel
   !SEMESTER = TxtSemester
   !Session = TxtSession
   !Course1 = Courses1
   !Course2 = Courses2
   !Course3 = Courses3
   !Course4 = Courses4
   !Course5 = Courses5
   !Course6 = Courses6
   !Course7 = Courses7
   !Course8 = Courses8
   !Course9 = Courses9
   !Course10 = Courses10
   !Unit1 = Unit1
   !Unit2 = Unit2
   !Unit3 = Unit3
   !Unit4 = Unit4
   !Unit5 = Unit5
   !Unit6 = Unit6
   !Unit7 = Unit7
   !Unit8 = Unit8
   !Unit9 = Unit9
   !Unit10 = Unit10
   !Score1 = Scores1
   !Score2 = Scores2
   !Score3 = Scores3
   !Score4 = Scores4
   !Score5 = Scores5
   !Score6 = Scores6
   !Score7 = Scores7
   !Score8 = Scores8
   !Score9 = Scores9
   !Score10 = Scores10
   !TU = TotalUnit
   !TWGP = TwgPoint
   !GPA = GPA
   !CGPA = CGPA
   !REMARK = REMARK
     .Update
    MsgBox "Update is successfully done", vbInformation
        .CLOSE
    End With
End Sub
  Private Sub Command3_Click()
        MSAVE.Enabled = False
        Frame2.Visible = True
  End Sub

  

Private Sub Form_Activate()
    On Error Resume Next
    Set myrs = mydb.OpenRecordset("Select * from regtab order by matricno")
  With myrs
    If myrs.BOF = False Then
        List1.clear
      Do While Not myrs.EOF
        List1.AddItem myrs!MATRICNO
        myrs.MoveNext
      Loop
    End If
  End With


End Sub

Private Sub Form_Load()
cmdedit.Enabled = False
CmdCompute.Enabled = False
CmdSave.Enabled = False
On Error Resume Next
Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
TotalUnit.Locked = True
 TwgPoint.Locked = True
 GPA.Locked = True
 CGPA.Locked = True

End Sub

Private Sub Scores1_KeyPress(KeyAscii As Integer)
 If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores10_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores2_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores3_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub


Private Sub Scores4_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores5_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores6_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores7_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub Scores8_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub


Private Sub Scores9_KeyPress(KeyAscii As Integer)
If (KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 13) Then Exit Sub
 KeyAscii = 0
End Sub

Private Sub TxtSemester_LostFocus()
On Error Resume Next
If (Combo3 <> "" And TxtSemester <> "") Then
'--------------------- COURSES --------------------------
Set myrs = mydb.OpenRecordset("Select * from Destab WHERE Sem = '" & TxtSemester & "' and lev = '" & TxtLevel.Text & "' and dept = '" & TxtDepartment.Text & "' ")
  With myrs
  If .RecordCount <> 0 Then
  Courses1 = !dt1
  Courses2 = !dt2
  Courses3 = !dt3
  Courses4 = !dt4
  Courses5 = !dt5
  Courses6 = !dt6
  Courses7 = !dt7
  Courses8 = !dt8
  Courses9 = !dt9
  Courses10 = !dt10
  
  End If
  
 .CLOSE
  End With
'-------------------------------UNIT-------------------
Set myrs = mydb.OpenRecordset("Select * from UNIT WHERE Sem = '" & TxtSemester & "' and lev = '" & TxtLevel.Text & "' and dept = '" & TxtDepartment.Text & "' ")
  With myrs
  If .RecordCount <> 0 Then
  Unit1 = !Ut1
  Unit2 = !Ut2
  Unit3 = !Ut3
  Unit4 = !Ut4
  Unit5 = !Ut5
  Unit6 = !ut6
  Unit7 = !ut7
  Unit8 = !Ut8
  Unit9 = !Ut9
  Unit10 = !Ut10
  
  End If
  
 .CLOSE
  End With

End If
End Sub

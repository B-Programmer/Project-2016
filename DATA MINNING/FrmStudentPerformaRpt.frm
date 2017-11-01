VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.1#0"; "mscomctl.ocx"
Begin VB.Form Form12 
   BackColor       =   &H8000000D&
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE"
   ClientHeight    =   9450
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   16140
   LinkTopic       =   "Form12"
   ScaleHeight     =   9450
   ScaleWidth      =   16140
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      BackColor       =   &H00800000&
      Height          =   9015
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   15735
      Begin MSComctlLib.ListView ListView1 
         Height          =   5775
         Left            =   240
         TabIndex        =   5
         Top             =   2520
         Width           =   15135
         _ExtentX        =   26696
         _ExtentY        =   10186
         View            =   3
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   7
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Matric No"
            Object.Width           =   2892
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Student Name"
            Object.Width           =   5009
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Level"
            Object.Width           =   1834
         EndProperty
         BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   3
            Text            =   "Session"
            Object.Width           =   3246
         EndProperty
         BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   4
            Text            =   "Semester"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   5
            Text            =   "GPA"
            Object.Width           =   2542
         EndProperty
         BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   6
            Text            =   "Grade(Letter)"
            Object.Width           =   4304
         EndProperty
      End
      Begin VB.TextBox Text2 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   390
         Left            =   7200
         TabIndex        =   1
         Top             =   480
         Width           =   2295
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "INDIVIDUAL STUDENT ACADEMIC PERFORMANCE REPORT"
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   15.75
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   2640
         TabIndex        =   6
         Top             =   1920
         Width           =   10695
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "&EXIT"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   18
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   7080
         TabIndex        =   4
         Top             =   1080
         Width           =   2175
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Enter Student Matric No:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   3720
         TabIndex        =   3
         Top             =   480
         Width           =   3375
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00C0E0FF&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "&VIEW"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   18
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   5040
         TabIndex        =   2
         Top             =   1080
         Width           =   1935
      End
   End
End
Attribute VB_Name = "Form12"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
End Sub
Private Sub Label1_Click()
Unload Me
End Sub

Private Sub Label4_Click()
On Error Resume Next
 Label7.Caption = "INDIVIDUAL STUDENT ACADEMIC PERFORMANCE REPORT"
Dim LItem As ListItem
'Dim matNo(1 To 7), studName(1 To 7), Level(1 To 7), Session(1 To 7), Semester(1 To 7), GPA(1 To 7), Grade(1 To 7)
ListView1.ListItems.clear
 Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (MATNO = '" & Text2.Text & "')")
With myrs
    If .RecordCount <= 0 Then
        MsgBox "No Data Found in the Student Academic Perfomance Table for the specified student " & Text2.Text, vbCritical
        Exit Sub
    Else
     I = 1
        Do While Not .EOF
            'matNo(I) = !matNo: Debug.Print matNo(I),
            'studName(I) = !Name: Debug.Print studName(I),
            'Level(I) = !Level: Debug.Print Level(I),
            'Session(I) = !Session: Debug.Print Session(I),
            'Semester(I) = !Semester: Debug.Print Semester(I),
            'GPA(I) = !GPA: Debug.Print GPA(I),
            'Grade(I) = !Grade: Debug.Print Grade(I),
            Set LItem = ListView1.ListItems.Add(, , !matNo)
            LItem.SubItems(1) = !Name
            LItem.SubItems(2) = !Level
            LItem.SubItems(3) = !Session
            LItem.SubItems(4) = !Semester
            LItem.SubItems(5) = !GPA
            LItem.SubItems(6) = !Grade
         I = I + 1
         .MoveNext
        Loop
    End If
    .CLOSE
End With
    'For K = 1 To I - 1
       'Set LItem = ListView1.ListItems.Add(, , matNo(K))
        '    LItem.SubItems(1) = studName(K)
         '   LItem.SubItems(2) = Level(K)
          '  LItem.SubItems(3) = Session(K)
           ' LItem.SubItems(4) = Semester(K)
           ' LItem.SubItems(5) = GPA(K)
            'LItem.SubItems(6) = Grade(K)
    'Next K

End Sub

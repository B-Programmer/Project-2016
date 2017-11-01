VERSION 5.00
Begin VB.Form Form4 
   BackColor       =   &H00400000&
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE"
   ClientHeight    =   4815
   ClientLeft      =   60
   ClientTop       =   330
   ClientWidth     =   7185
   LinkTopic       =   "Form4"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4815
   ScaleWidth      =   7185
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      Caption         =   "CLOSE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4440
      TabIndex        =   6
      Top             =   4080
      Width           =   2655
   End
   Begin VB.CommandButton Command1 
      Caption         =   "SAVE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   5
      Top             =   4080
      Width           =   4215
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00400000&
      Caption         =   "Enter Student Performance Info:"
      BeginProperty Font 
         Name            =   "OCR A Extended"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   3975
      Left            =   120
      TabIndex        =   7
      Top             =   0
      Width           =   6975
      Begin VB.TextBox Text1 
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
         Height          =   495
         Left            =   2160
         MaxLength       =   4
         TabIndex        =   16
         Text            =   "0.00"
         Top             =   2640
         Width           =   4695
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
         ItemData        =   "Form4.frx":0000
         Left            =   2160
         List            =   "Form4.frx":0010
         TabIndex        =   2
         Top             =   2160
         Width           =   2055
      End
      Begin VB.ComboBox Combo4 
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
         ItemData        =   "Form4.frx":0030
         Left            =   5400
         List            =   "Form4.frx":003A
         TabIndex        =   3
         Top             =   2160
         Width           =   1455
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
         Left            =   2160
         Style           =   2  'Dropdown List
         TabIndex        =   0
         Top             =   720
         Width           =   4695
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
         ItemData        =   "Form4.frx":004D
         Left            =   2160
         List            =   "Form4.frx":0060
         TabIndex        =   4
         Top             =   3120
         Width           =   4695
      End
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
         ItemData        =   "Form4.frx":0099
         Left            =   2160
         List            =   "Form4.frx":009B
         TabIndex        =   1
         Top             =   1680
         Width           =   4695
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Grade(Letter):"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   15
         Top             =   3120
         Width           =   2055
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Level:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   14
         Top             =   2160
         Width           =   2055
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Semester:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   4200
         TabIndex        =   13
         Top             =   2160
         Width           =   1215
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Grade (GPA):"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   12
         Top             =   2640
         Width           =   2055
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Session:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   11
         Top             =   1680
         Width           =   2055
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "OCR A Extended"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   2160
         TabIndex        =   10
         Top             =   1200
         Width           =   4695
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Student Name:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   120
         TabIndex        =   9
         Top             =   1200
         Width           =   2055
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Matric Number:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
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
         Top             =   720
         Width           =   2055
      End
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Combo3_Click()
Set myrs = mydb.OpenRecordset("Select * from regtab WHERE matricno = '" & Combo3 & "'")
  With myrs
  Label3 = !Name
  End With
End Sub
Private Sub Combo3_GotFocus()
Combo1 = "": Combo2 = "": Combo4 = "": Combo5 = "": Label3 = ""
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

Private Sub Command1_Click()
On Error Resume Next
Set myrs = mydb.OpenRecordset("SELECT * FROM PERTAB WHERE MATNO = '" & Combo3 & "' AND LEVEL='" & Combo5 & "' AND SEMESTER='" & Combo4 & "'")
With myrs
            R = !MATNO
            S = !Level
            T = !SEMESTER
            U = !Session
    If R = UCase(Combo3) And S = UCase(Combo5) And T = UCase(Combo4) Then
            Call MsgBox("You have processed this record before! Process other records")
            Combo3.clear
            Combo3.SetFocus
            Exit Sub
    ElseIf U = UCase(Combo1) Then
            Call MsgBox("You have processed this record before! Process other records")
            Combo3.clear
            Combo1.SetFocus
            Exit Sub
    ElseIf R <> UCase(Combo3) And S <> UCase(Combo5) And T <> UCase(Combo4) Then
  .AddNew
            !Session = Combo1
            !Level = UCase(Combo5)
            !SEMESTER = UCase(Combo4)
            !grade = UCase$(Combo2)
            !MATNO = UCase(Combo3)
            !Name = UCase$(Label3)
            !GPA = UCase$(Text1)
            !Count = 1
  .Update
  .CLOSE
            MsgBox "Record is successfully saved", vbInformation, ""
  End If
End With
ext:
Exit Sub
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Activate()
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
Private Sub Form_Load()
For I = 2005 To 2300
Combo1.AddItem I & "/" & (I + 1)
Next I
End Sub

Private Sub Text1_Change()
If (Text1.Text <> "") Then
    Select Case (Val(Text1.Text))
        Case 3.5 To 4.5
            Combo2.Text = "DISTINCTION"
        Case 3# To 3.49
            Combo2.Text = "UPPER CREDIT"
        Case 2.5 To 2.99
            Combo2.Text = "LOWER CREDIT"
        Case 2# To 2.49
            Combo2.Text = "PASS"
        Case Else
            Combo2.Text = "FAIL"
    End Select
End If
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
    If ((KeyAscii < Asc("0")) Or (KeyAscii > Asc("9"))) Then
            If (KeyAscii <> Asc(".")) Then
            MsgBox "You must enter Digit", vbCritical
            KeyAscii = 0
            End If
    End If
End Sub

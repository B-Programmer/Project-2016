VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   BackColor       =   &H00800000&
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE"
   ClientHeight    =   8865
   ClientLeft      =   2325
   ClientTop       =   1650
   ClientWidth     =   11160
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "RegFrm.frx":0000
   ScaleHeight     =   8865
   ScaleWidth      =   11160
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      BackColor       =   &H00400000&
      Caption         =   "NEXT OF KIN INFORMATION"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF80&
      Height          =   2055
      Left            =   240
      TabIndex        =   37
      Top             =   5760
      Width           =   8055
      Begin VB.ComboBox Combo3 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "RegFrm.frx":3FB70
         Left            =   2280
         List            =   "RegFrm.frx":3FB9B
         TabIndex        =   43
         Top             =   960
         Width           =   3855
      End
      Begin VB.TextBox Text13 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2280
         TabIndex        =   41
         Top             =   1440
         Width           =   5655
      End
      Begin VB.TextBox Text12 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2280
         TabIndex        =   39
         Top             =   480
         Width           =   5655
      End
      Begin VB.Label Label19 
         BackStyle       =   0  'Transparent
         Caption         =   "Relationship"
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
         Height          =   375
         Left            =   240
         TabIndex        =   42
         Top             =   960
         Width           =   2175
      End
      Begin VB.Label Label18 
         BackStyle       =   0  'Transparent
         Caption         =   "Phone Number:"
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
         Height          =   375
         Left            =   240
         TabIndex        =   40
         Top             =   1440
         Width           =   2175
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Next of kin's Name:"
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
         Height          =   375
         Left            =   240
         TabIndex        =   38
         Top             =   480
         Width           =   2175
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&ADD NEW RECORD"
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
      Left            =   8400
      TabIndex        =   36
      Top             =   6240
      Width           =   2655
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   1320
      Top             =   7320
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog CD1 
      Left            =   1320
      Top             =   7320
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00000000&
      Caption         =   "STUDENT PASSPORT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   1935
      Left            =   8880
      TabIndex        =   34
      Top             =   120
      Width           =   2175
      Begin VB.Image Image2 
         BorderStyle     =   1  'Fixed Single
         Height          =   1575
         Left            =   120
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1935
      End
      Begin VB.Label Label17 
         BackStyle       =   0  'Transparent
         Caption         =   "UPLOAD PICTURE"
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   360
         TabIndex        =   35
         Top             =   720
         Width           =   1455
      End
   End
   Begin VB.ListBox List1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000002&
      Height          =   3660
      Left            =   8400
      TabIndex        =   33
      Top             =   2160
      Width           =   2655
   End
   Begin VB.CheckBox Check1 
      BackColor       =   &H00400000&
      Caption         =   "CHECK TO EDIT "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Left            =   240
      TabIndex        =   32
      Top             =   7800
      Width           =   8055
   End
   Begin VB.CommandButton CLOSE 
      Caption         =   "C&LOSE"
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
      Left            =   8400
      TabIndex        =   31
      Top             =   8160
      Width           =   2655
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&EDIT"
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
      Left            =   240
      TabIndex        =   30
      Top             =   8160
      Width           =   8055
   End
   Begin VB.CommandButton MSAVE 
      Caption         =   "&SAVE"
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
      Left            =   8400
      TabIndex        =   29
      Top             =   7200
      Width           =   2655
   End
   Begin VB.TextBox mat 
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0FF&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   24
      Top             =   720
      Width           =   2535
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   240
      TabIndex        =   12
      Top             =   1560
      Width           =   4695
   End
   Begin VB.TextBox Text2 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   2520
      TabIndex        =   11
      Top             =   2400
      Width           =   2535
   End
   Begin VB.TextBox Text3 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   240
      TabIndex        =   10
      Top             =   5280
      Width           =   2655
   End
   Begin VB.TextBox Text4 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   765
      Left            =   240
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   9
      Top             =   4200
      Width           =   4815
   End
   Begin VB.TextBox Text5 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   435
      Left            =   3000
      TabIndex        =   8
      Top             =   5280
      Width           =   2655
   End
   Begin VB.ComboBox Combo1 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   480
      ItemData        =   "RegFrm.frx":3FC04
      Left            =   240
      List            =   "RegFrm.frx":3FC0E
      TabIndex        =   7
      Top             =   2400
      Width           =   2175
   End
   Begin VB.ComboBox Combo2 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   480
      ItemData        =   "RegFrm.frx":3FC20
      Left            =   5160
      List            =   "RegFrm.frx":3FC33
      TabIndex        =   6
      Top             =   3360
      Width           =   3135
   End
   Begin VB.TextBox Text6 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   5760
      TabIndex        =   5
      Top             =   5280
      Width           =   2415
   End
   Begin VB.TextBox Text7 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   5160
      TabIndex        =   4
      Top             =   2400
      Width           =   3135
   End
   Begin VB.TextBox Text8 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   240
      TabIndex        =   3
      Top             =   3360
      Width           =   2175
   End
   Begin VB.TextBox Text9 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   2520
      TabIndex        =   2
      Top             =   3360
      Width           =   2535
   End
   Begin VB.TextBox Text10 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   5160
      TabIndex        =   1
      Top             =   1560
      Width           =   3135
   End
   Begin VB.TextBox Text11 
      BeginProperty Font 
         Name            =   "MS Reference Sans Serif"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   405
      Left            =   5280
      TabIndex        =   0
      Top             =   4320
      Width           =   2895
   End
   Begin VB.Label Label16 
      BackStyle       =   0  'Transparent
      Caption         =   "STUDENT REGISTRATION FORM"
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
      Left            =   3000
      TabIndex        =   28
      Top             =   120
      Width           =   4695
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Nationality"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   240
      TabIndex        =   27
      Top             =   4920
      Width           =   1695
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "Home Town"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   5160
      TabIndex        =   26
      Top             =   1200
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   " MATRIC NUMBER"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H008080FF&
      Height          =   375
      Left            =   120
      TabIndex        =   25
      Top             =   480
      Width           =   2535
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Student Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   240
      TabIndex        =   23
      Top             =   1200
      Width           =   1695
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Date of Birth "
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   2520
      TabIndex        =   22
      Top             =   2040
      Width           =   2175
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Permanent Address"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   240
      TabIndex        =   21
      Top             =   3840
      Width           =   2535
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "LGA"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   3000
      TabIndex        =   20
      Top             =   4920
      Width           =   2295
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Sex"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   240
      TabIndex        =   19
      Top             =   2040
      Width           =   1815
   End
   Begin VB.Label Label9 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Marital Status"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   5160
      TabIndex        =   18
      Top             =   3000
      Width           =   2775
   End
   Begin VB.Label Label10 
      BackStyle       =   0  'Transparent
      Caption         =   "Religion"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   5760
      TabIndex        =   17
      Top             =   4920
      Width           =   1695
   End
   Begin VB.Label Label11 
      BackStyle       =   0  'Transparent
      Caption         =   "Course Of Study"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   5160
      TabIndex        =   16
      Top             =   2040
      Width           =   2415
   End
   Begin VB.Label Label12 
      BackStyle       =   0  'Transparent
      Caption         =   "Level"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   240
      TabIndex        =   15
      Top             =   3000
      Width           =   2175
   End
   Begin VB.Label Label13 
      BackStyle       =   0  'Transparent
      Caption         =   "Session"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   2520
      TabIndex        =   14
      Top             =   3000
      Width           =   2295
   End
   Begin VB.Label Label15 
      BackStyle       =   0  'Transparent
      Caption         =   "State Of Origin"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   5280
      TabIndex        =   13
      Top             =   3960
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Check1_Click()
  On Error Resume Next
     If Check1.Value = 1 Then
        List1.Enabled = True
        MSAVE.Enabled = False
        Command2.Enabled = True
        Call clear
     Else
        Call clear
        MSAVE.Enabled = True
        Command2.Enabled = False
        List1.Enabled = False
     End If
End Sub

Private Sub CLOSE_Click()
Unload Me
End Sub

Private Sub Command2_Click()
        On Error Resume Next
    Set myrs = mydb.OpenRecordset("SELECT * FROM Regtab WHERE MATRICNO = '" & List1.Text & "'")
    With myrs
        .Edit
            !PIE = CommonDialog1.FileName
            !Name = UCase$(Text1)
            !Nat = UCase$(Text3)
            !Peradd = UCase$(Text4)
            !Dob = UCase$(Text2)
            !LGA = UCase$(Text5)
            !sex = UCase$(Combo1)
            !MaSta = UCase$(Combo2)
            !Rel = UCase$(Text6)
            !COUS = UCase$(Text7)
            !Level = UCase$(Text8)
            !Session = UCase$(Text9)
            !Htown = UCase$(Text10)
            !StaO = UCase$(Text11)
            !GNAME = UCase$(Text12)
            !RELAT = UCase$(Combo3)
            !PerAD = UCase$(Text14)
            !PHNO = UCase$(Text13)
            !MATRICNO = UCase$(mat)
            '!GNAME = UCase(Text12)
            !RELAT = UCase$(Combo3)
            '!PHNO = Text13
            MsgBox "Update is successfully done", vbInformation
        .Update
        .CLOSE
    End With
End Sub
  Private Sub Command3_Click()
        MSAVE.Enabled = False
        Frame2.Visible = True
  End Sub

  Private Sub Command1_Click()
    Call clear
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
  On Error Resume Next
    List1.Enabled = False
    Command2.Enabled = False
    Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
End Sub

Private Sub Command4_Click()
    Unload Me
End Sub

Private Sub Image2_Click()
On Error Resume Next
    CommonDialog1.ShowOpen
    Image2.Picture = LoadPicture(CommonDialog1.FileName)
End Sub

Private Sub Label17_Click()
On Error Resume Next
    CommonDialog1.ShowOpen
    Image2.Picture = LoadPicture(CommonDialog1.FileName)
End Sub

Private Sub List1_Click()
        On Error Resume Next
        SD = ""
        Image2.Picture = LoadPicture(SD)
        On Error Resume Next
        Set myrs = mydb.OpenRecordset("SELECT * FROM Regtab WHERE MATRICNO = '" & List1.Text & "' ORDER BY MATRICNO")
        With myrs
        Text1 = !Name
        Text3 = !Nat
        Text4 = !Peradd
        Text2 = !Dob
        Text5 = !LGA
        Combo1 = !sex
        Combo2 = !MaSta
        Text6 = !Rel
        Text7 = !COUS
        Text8 = !Level
        Text9 = !Session
        Text10 = !Htown
        Text11 = !StaO
        Text13 = !PHNO
        Combo3 = !RELAT
        Text14 = !PerAD
        Text12 = !GNAME
        mat = !MATRICNO
        SD = !PIE
        Image2.Picture = LoadPicture(SD)
        End With
End Sub

Private Sub msave_Click()
    On Error Resume Next
    Set myrs = mydb.OpenRecordset("Regtab")
    With myrs
    .AddNew
    !Name = UCase$(Text1)
    !Nat = UCase$(Text3)
    
    !Peradd = UCase$(Text4)
    !Dob = UCase$(Text2)
    
    !LGA = UCase$(Text5)
    !sex = UCase$(Combo1)
    !MaSta = UCase$(Combo2)
    !Rel = UCase$(Text6)
    !COUS = UCase$(Text7)
    !Level = UCase$(Text8)
    !Session = UCase$(Text9)
    !Htown = UCase$(Text10)
    !StaO = UCase$(Text11)
    !GNAME = UCase$(Text12)
    !RELAT = UCase$(Combo3)
    !PerAD = UCase$(Text14)
    !PHNO = UCase$(Text13)
    !MATRICNO = UCase$(mat)
    !GNAME = UCase(Text12)
    !RELAT = UCase$(Combo3)
    !PHNO = Text13
    !PIE = CommonDialog1.FileName
    MsgBox "Record is successfully saved", vbInformation
    .Update
    .CLOSE
    End With
    Set myrs = mydb.OpenRecordset("CounTable")
    With myrs
    .Edit
       !counting = kcount
    .Update
    .CLOSE
    End With
Add:
mAdd:
End Sub

Private Sub MSAVE_GotFocus()
    On Error Resume Next
    If mat = "" Then
    MsgBox "Pls, enter matric number is highly important", vbCritical
    mat.SetFocus
    ElseIf Text1 = "" Then
    MsgBox "Supply the student name!", vbCritical
    Text1.SetFocus
    ElseIf Combo1 = "" Then
    MsgBox "sex Field cannot be empty", vbCritical
    Combo1.SetFocus
    ElseIf Text8 = "" Then
    MsgBox "Enter your the student level", vbCritical
    Text8.SetFocus
    ElseIf Text4 = "" Then
    MsgBox "Permanent home address need to be entered", vbCritical
    Text4.SetFocus
    ElseIf Text3 = "" Then
    MsgBox "Natonality Field should not be empty", vbCritical
    Text3.SetFocus
    ElseIf Text10 = "" Then
    MsgBox "Pls enter the student home town", vbCritical
    Text10.SetFocus
    ElseIf Text2 = "" Then
    MsgBox "Enter your Date of Birth", vbCritical
    Text2.SetFocus
    ElseIf Text7 = "" Then
    MsgBox "Enter the course of study", vbCritical
    Text7.SetFocus
    ElseIf Text9 = "" Then
    MsgBox "enter the session you want to register for", vbCritical
    Text9.SetFocus
    ElseIf Combo2 = "" Then
    MsgBox "Enter your Marital Status", vbCritical
    Combo2.SetFocus
    ElseIf Text11 = "" Then
    MsgBox "Enter your Marital Status", vbCritical
    Text11.SetFocus
    ElseIf Text5 = "" Then
    MsgBox "Local Goverment Field cannot be empty", vbCritical
    Text5.SetFocus
    ElseIf Text6 = "" Then
    MsgBox "Enter the student religion", vbCritical
    Text6.SetFocus
    End If
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub

Private Sub Text10_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub

Private Sub Text11_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub

Private Sub Text13_KeyPress(KeyAscii As Integer)
    If ((KeyAscii < Asc("0")) Or (KeyAscii > Asc("9"))) Then
    MsgBox "You must enter Digit", vbCritical
    KeyAscii = 0
    End If
End Sub

Private Sub Text3_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub

Private Sub Text5_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub

Private Sub Text6_KeyPress(KeyAscii As Integer)
    Dim key As Integer
    key = KeyAscii
    Select Case key
    Case Asc("0") To Asc("9")
    MsgBox "You must enter Alphabet", vbCritical
    KeyAscii = 0
    Case Else
    End Select
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
End Sub



Public Function clear()
    On Error Resume Next
    A = ""
    mat = ""
    Image2.Picture = LoadPicture(A)
    Text1 = "": Text2 = "": Text4 = "": Text5 = "": Text6 = "": Text7 = "": Text8 = "": Text9 = "": Text10 = "": Text11 = "": Text3 = "": Combo1 = "": Combo2 = ""
End Function

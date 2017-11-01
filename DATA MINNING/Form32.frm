VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.1#0"; "mscomctl.ocx"
Begin VB.Form Form5 
   BackColor       =   &H00800000&
   ClientHeight    =   10575
   ClientLeft      =   60
   ClientTop       =   120
   ClientWidth     =   15240
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   ForeColor       =   &H00800000&
   Picture         =   "Form32.frx":0000
   ScaleHeight     =   10575
   ScaleWidth      =   15240
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer5 
      Interval        =   1000
      Left            =   1560
      Top             =   5040
   End
   Begin VB.Timer Timer2 
      Interval        =   300
      Left            =   1800
      Top             =   6720
   End
   Begin VB.Timer Timer3 
      Interval        =   200
      Left            =   840
      Top             =   6720
   End
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   1320
      Top             =   6720
   End
   Begin VB.Timer Timer6 
      Interval        =   100
      Left            =   2280
      Top             =   6720
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00C00000&
      BorderStyle     =   0  'None
      Caption         =   "Frame2"
      Height          =   15
      Left            =   7800
      TabIndex        =   0
      Top             =   7920
      Width           =   15
      Begin VB.Timer Timer4 
         Interval        =   500
         Left            =   0
         Top             =   0
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "DATA MINING"
         BeginProperty Font 
            Name            =   "Trebuchet MS"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   840
         TabIndex        =   2
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label15 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "OSPOLY"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   840
         TabIndex        =   1
         Top             =   1200
         Width           =   1575
      End
      Begin VB.Shape Shape3 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   240
         Shape           =   3  'Circle
         Top             =   1560
         Width           =   255
      End
      Begin VB.Shape Shape12 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   720
         Shape           =   3  'Circle
         Top             =   2040
         Width           =   255
      End
      Begin VB.Shape Shape13 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   1440
         Shape           =   3  'Circle
         Top             =   2160
         Width           =   255
      End
      Begin VB.Shape Shape14 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   2640
         Shape           =   3  'Circle
         Top             =   2280
         Width           =   255
      End
      Begin VB.Shape Shape15 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   3120
         Shape           =   3  'Circle
         Top             =   1800
         Width           =   255
      End
      Begin VB.Shape Shape16 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   3360
         Shape           =   3  'Circle
         Top             =   720
         Width           =   255
      End
      Begin VB.Shape Shape17 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   375
         Left            =   2640
         Shape           =   3  'Circle
         Top             =   0
         Width           =   255
      End
      Begin VB.Shape Shape18 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   255
         Left            =   1560
         Shape           =   3  'Circle
         Top             =   0
         Width           =   375
      End
      Begin VB.Shape Shape19 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   255
         Left            =   600
         Shape           =   3  'Circle
         Top             =   120
         Width           =   255
      End
      Begin VB.Shape Shape20 
         BorderColor     =   &H00FFFFFF&
         FillColor       =   &H00FFFFFF&
         FillStyle       =   0  'Solid
         Height          =   255
         Left            =   240
         Shape           =   3  'Circle
         Top             =   600
         Width           =   255
      End
   End
   Begin MSComctlLib.ProgressBar PogBar 
      Height          =   30
      Left            =   2400
      TabIndex        =   9
      Top             =   5760
      Width           =   135
      _ExtentX        =   238
      _ExtentY        =   53
      _Version        =   393216
      Appearance      =   1
      Orientation     =   1
      Scrolling       =   1
   End
   Begin MSComctlLib.ProgressBar PGR1 
      Height          =   2190
      Left            =   360
      TabIndex        =   10
      Top             =   6240
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   3863
      _Version        =   393216
      Appearance      =   1
      Orientation     =   1
      Scrolling       =   1
   End
   Begin MSComctlLib.ProgressBar PGR2 
      Height          =   30
      Left            =   2160
      TabIndex        =   11
      Top             =   5760
      Width           =   135
      _ExtentX        =   238
      _ExtentY        =   53
      _Version        =   393216
      Appearance      =   1
      Orientation     =   1
      Scrolling       =   1
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   255
      Left            =   840
      Shape           =   3  'Circle
      Top             =   120
      Width           =   255
   End
   Begin VB.Shape Shape2 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   255
      Left            =   1320
      Shape           =   3  'Circle
      Top             =   120
      Width           =   255
   End
   Begin VB.Shape Shape4 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   255
      Left            =   1680
      Shape           =   3  'Circle
      Top             =   360
      Width           =   375
   End
   Begin VB.Shape Shape5 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   1920
      Shape           =   3  'Circle
      Top             =   720
      Width           =   255
   End
   Begin VB.Shape Shape6 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   1800
      Shape           =   3  'Circle
      Top             =   1200
      Width           =   255
   End
   Begin VB.Shape Shape7 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   1440
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   255
   End
   Begin VB.Shape Shape8 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   840
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   255
   End
   Begin VB.Shape Shape9 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   360
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   255
   End
   Begin VB.Shape Shape10 
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   240
      Shape           =   3  'Circle
      Top             =   840
      Width           =   255
   End
   Begin VB.Shape Shape11 
      BorderColor     =   &H00FFFFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   375
      Left            =   360
      Shape           =   3  'Circle
      Top             =   360
      Width           =   255
   End
   Begin VB.Image Image2 
      Appearance      =   0  'Flat
      BorderStyle     =   1  'Fixed Single
      Height          =   1095
      Left            =   13920
      Picture         =   "Form32.frx":4CD51
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1215
   End
   Begin VB.Image Image3 
      Appearance      =   0  'Flat
      BorderStyle     =   1  'Fixed Single
      Height          =   1095
      Left            =   13920
      Picture         =   "Form32.frx":99AA2
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1215
   End
   Begin VB.Image Image4 
      Appearance      =   0  'Flat
      BorderStyle     =   1  'Fixed Single
      Height          =   1095
      Left            =   13920
      Picture         =   "Form32.frx":D9612
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1215
   End
   Begin VB.Image Image5 
      Appearance      =   0  'Flat
      BorderStyle     =   1  'Fixed Single
      Height          =   1095
      Left            =   13920
      Picture         =   "Form32.frx":107D39
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   " (A CASE STUDY OF COMPUTER SCIENCE DEPARTMENT, OSUN STATE POLYTECHNIC, IREE )"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   495
      Left            =   2400
      TabIndex        =   14
      Top             =   1440
      Width           =   12375
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "DESIGN AND IMPLEMENTATION OF DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2520
      TabIndex        =   13
      Top             =   360
      Width           =   10995
   End
   Begin VB.Label Label1 
      BackColor       =   &H00400000&
      Height          =   2295
      Left            =   -120
      TabIndex        =   12
      Top             =   -120
      Width           =   15495
   End
   Begin VB.Label Label12 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "    SUBMITTED TO COMPUTER SCIENCE DEPARTMENT  OSPOLY IREE."
      BeginProperty Font 
         Name            =   "Small Fonts"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   2640
      TabIndex        =   8
      Top             =   9000
      Width           =   9495
      WordWrap        =   -1  'True
   End
   Begin VB.Label Label11 
      BackStyle       =   0  'Transparent
      Caption         =   "SUPERVISED BY:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   375
      Left            =   1080
      TabIndex        =   7
      Top             =   7920
      Width           =   2055
   End
   Begin VB.Label Label10 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "MR O.A. ODUWOLE"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF80&
      Height          =   615
      Left            =   480
      TabIndex        =   6
      Top             =   8280
      Width           =   3135
   End
   Begin VB.Label Label9 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "OLATUNJI AMINAT O. - 14/CSH/0611"
      BeginProperty Font 
         Name            =   "Lucida Sans Unicode"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   495
      Left            =   360
      TabIndex        =   5
      Top             =   3720
      Width           =   7335
   End
   Begin VB.Label Label8 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "OJO TAIWO IBIDAPO - 14/CSH/0608"
      BeginProperty Font 
         Name            =   "Arial Black"
         Size            =   18
         Charset         =   0
         Weight          =   900
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   360
      TabIndex        =   4
      Top             =   3000
      Width           =   7455
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "DESIGNED BY:"
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
      Left            =   2520
      TabIndex        =   3
      Top             =   2400
      Width           =   2895
   End
End
Attribute VB_Name = "Form5"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Timer5.Enabled = False
PGR2.Visible = False
PGR1.Visible = False
PogBar.Visible = False
Image2.Visible = False
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
Shape1.Visible = False
Shape2.Visible = False

Shape4.Visible = False
Shape5.Visible = False
Shape6.Visible = False
Shape7.Visible = False
Shape8.Visible = False
Shape9.Visible = False
Shape10.Visible = False
Shape11.Visible = False

Shape3.Visible = False
Shape12.Visible = False
Shape13.Visible = False
Shape15.Visible = False
Shape16.Visible = False
Shape17.Visible = False
Shape18.Visible = False
Shape19.Visible = False
Shape20.Visible = False
Shape14.Visible = False

End Sub

Private Sub Label2_Click()

End Sub

Private Sub Timer1_Timer()
'PogBar.Visible = False

ade:
Timer1.Enabled = True
PogBar.Value = PogBar.Value + 1

If PogBar.Value = 4 Then
Image2.Visible = True
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 6 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 10 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = True
Image5.Visible = False
ElseIf PogBar.Value = 15 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = False
Image5.Visible = True
ElseIf PogBar.Value = 20 Then
Image2.Visible = True
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 25 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 30 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = True
Image5.Visible = False
ElseIf PogBar.Value = 35 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = False
Image5.Visible = True
ElseIf PogBar.Value = 40 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False

ElseIf PogBar.Value = 42 Then
Image2.Visible = True
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 46 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 50 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = True
Image5.Visible = False
ElseIf PogBar.Value = 53 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = False
Image5.Visible = True
ElseIf PogBar.Value = 59 Then
Image2.Visible = True
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 64 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 68 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = True
Image5.Visible = False
ElseIf PogBar.Value = 73 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = False
Image5.Visible = True
ElseIf PogBar.Value = 80 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False


ElseIf PogBar.Value = 85 Then
Image2.Visible = True
Image3.Visible = False
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 90 Then
Image2.Visible = False
Image3.Visible = True
Image4.Visible = False
Image5.Visible = False
ElseIf PogBar.Value = 94 Then
Image2.Visible = False
Image3.Visible = False
Image4.Visible = True
Image5.Visible = False

A:
For J = 1 To 2000
'Image1.Top = Image1.Top - 10
'Image2.Top = Image2.Top + 8
Next J
ElseIf PogBar.Value = 100 Then
Timer1.Enabled = False
PogBar.Value = 0
GoTo ade
End If
End Sub

Private Sub Timer2_Timer()
Label12.Caption = Mid(Label12.Caption, 2) & Left(Label12.Caption, 1)
End Sub

Private Sub Timer3_Timer()
On Error Resume Next
Dim jcount As Integer
'jcount = 1
PGR1 = PGR1.Value + 1

If PGR1.Value = 10 Then
Shape1.Visible = True
ElseIf PGR1.Value = 20 Then
Shape2.Visible = True
ElseIf PGR1.Value = 30 Then
Shape4.Visible = True
ElseIf PGR1.Value = 40 Then
Shape5.Visible = True
ElseIf PGR1.Value = 50 Then
Shape5.Visible = True
ElseIf PGR1.Value = 60 Then
Shape6.Visible = True
ElseIf PGR1.Value = 70 Then
Shape7.Visible = True
ElseIf PGR1.Value = 80 Then
Shape8.Visible = True
ElseIf PGR1.Value = 90 Then
Shape9.Visible = True
ElseIf PGR1.Value = 95 Then
Shape10.Visible = True
'Shape11.Visible = True
ElseIf PGR1.Value = 100 Then
Shape11.Visible = True
Timer3.Enabled = False
Timer5.Enabled = True
End If

End Sub
Private Sub Timer5_Timer()
Unload Me
Form6.Show 1
End Sub



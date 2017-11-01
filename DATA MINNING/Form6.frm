VERSION 5.00
Begin VB.Form Form6 
   BackColor       =   &H0000C000&
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "Login Window"
   ClientHeight    =   10185
   ClientLeft      =   60
   ClientTop       =   285
   ClientWidth     =   15240
   LinkTopic       =   "Form6"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Form6.frx":0000
   ScaleHeight     =   10185
   ScaleWidth      =   15240
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WindowState     =   2  'Maximized
   Begin VB.Frame Frame1 
      BackColor       =   &H00800000&
      Height          =   825
      Left            =   10680
      TabIndex        =   3
      Top             =   8400
      Width           =   4215
      Begin VB.TextBox Userpassword 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         IMEMode         =   3  'DISABLE
         Left            =   2040
         PasswordChar    =   "*"
         TabIndex        =   4
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label Label2 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Access Code"
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   11.25
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   405
         Left            =   120
         TabIndex        =   5
         Top             =   255
         Width           =   1920
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00800000&
      BorderStyle     =   0  'None
      ForeColor       =   &H00C0C000&
      Height          =   480
      Left            =   10680
      TabIndex        =   0
      Top             =   9240
      Width           =   4200
      Begin VB.CommandButton cmdcontinue 
         Caption         =   "&Continue"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   240
         TabIndex        =   2
         Top             =   840
         Visible         =   0   'False
         Width           =   1065
      End
      Begin VB.CommandButton Cmdcancel 
         Caption         =   "E&xit"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   3000
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   0
         Width           =   1065
      End
      Begin VB.Timer Timer1 
         Interval        =   50
         Left            =   720
         Top             =   720
      End
      Begin VB.Timer Timer2 
         Interval        =   100
         Left            =   840
         Top             =   840
      End
      Begin VB.Line Line4 
         BorderColor     =   &H00C0E0FF&
         BorderWidth     =   4
         X1              =   240
         X2              =   4440
         Y1              =   480
         Y2              =   480
      End
      Begin VB.Image Image1 
         Height          =   480
         Left            =   2880
         Picture         =   "Form6.frx":4D18F
         Top             =   240
         Width           =   480
      End
   End
End
Attribute VB_Name = "Form6"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public nCount As Integer
Private Sub cmdcancel_Click()
    End
End Sub

Private Sub Cmdcontinue_Click()
  
   If Trim(Userpassword) = "" Then
      msg = MsgBox("Password cannot be empty", vbInformation + vbOKOnly, "Invalid Password")
      Userpassword.SetFocus
      Exit Sub
    ElseIf Trim(UCase(Userpassword)) <> "PASSWORD" Then
           msg = MsgBox("Wrong Password! Retry", vbInformation + vbRetryCancel, "Invalid Password")
        If msg = vbRetry Then
          nCount = nCount + 1
            If nCount = 3 Then
            msg = MsgBox("You are an Unathorised User Keep Off! Click Ok to Continue...", vbCritical + vbOKOnly, "Unauthorised User")
            Userpassword = Empty
            
               End
            End If
            Userpassword = Empty
            Userpassword.SetFocus
     Exit Sub
      Else
        Unload Me
      End If
    Else
    ' Call Cmdcontinue_Click '.SetFocus
    End If
    Unload Me
    MDIForm1.Show
End Sub

Private Sub Form_Activate()
Randomize
Userpassword.SetFocus
'    Timer2.Enabled = False
End Sub


Private Sub Timer3_Timer()
Label1.ForeColor = QBColor(Rnd * 12)
End Sub

Private Sub Userpassword_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then
    If Trim(Userpassword) = Empty Then
      msg = MsgBox("Password cannot be empty", vbInformation + vbOKOnly, "Invalid Password")
      Userpassword.SetFocus
    ElseIf Trim(UCase(Userpassword)) <> "PASSWORD" Then
           msg = MsgBox("Wrong Password! Retry", vbInformation + vbRetryCancel, "Invalid Password")
        If msg = vbRetry Then
          nCount = nCount + 1
            If nCount = 3 Then
             msg = MsgBox("You are an Unathorised User Keep Off! Click Ok to Continue...", vbCritical + vbOKOnly, "Unauthorised User")
               End
            End If
            Userpassword = Empty
            Userpassword.SetFocus
     Exit Sub
      Else
        Unload Me
      End If
    Else
     Call Cmdcontinue_Click
    End If
 End If
End Sub




Private Sub Timer1_Timer()
    Image1.Left = Image1.Left + 90
    If Image1.Left >= 3400 Then
     'Timer1.Enabled = False
      'Timer2.Enabled = True
      Image1.Left = -435
    End If
End Sub

Private Sub Timer2_Timer()
Image1.Top = Image1.Top - 15
    If Image1.Top <= 150 Then
      Timer2.Enabled = False
      Timer1.Enabled = True
    End If
End Sub



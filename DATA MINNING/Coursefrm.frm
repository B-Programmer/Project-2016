VERSION 5.00
Begin VB.Form Form2 
   BackColor       =   &H00C00000&
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "REGISTER COURSE"
   ClientHeight    =   5625
   ClientLeft      =   2730
   ClientTop       =   2025
   ClientWidth     =   13800
   ClipControls    =   0   'False
   BeginProperty Font 
      Name            =   "Papyrus"
      Size            =   9.75
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00C00000&
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5625
   ScaleWidth      =   13800
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00C00000&
      Caption         =   "School Info:"
      BeginProperty Font 
         Name            =   "Papyrus"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   2655
      Left            =   120
      TabIndex        =   38
      Top             =   0
      Width           =   6015
      Begin VB.CommandButton Com3 
         BackColor       =   &H00FFFFFF&
         Caption         =   "DEPRESS BUTTON"
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   4320
         Style           =   1  'Graphical
         TabIndex        =   46
         Top             =   1920
         Width           =   1455
      End
      Begin VB.ComboBox C3 
         BackColor       =   &H000000FF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         ItemData        =   "Coursefrm.frx":0000
         Left            =   2400
         List            =   "Coursefrm.frx":000A
         TabIndex        =   41
         Top             =   1320
         Width           =   3495
      End
      Begin VB.ComboBox C1 
         BackColor       =   &H000000FF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         ItemData        =   "Coursefrm.frx":001D
         Left            =   2400
         List            =   "Coursefrm.frx":002D
         TabIndex        =   40
         Top             =   840
         Width           =   3495
      End
      Begin VB.ComboBox C2 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         ItemData        =   "Coursefrm.frx":004D
         Left            =   2400
         List            =   "Coursefrm.frx":0069
         TabIndex        =   39
         Top             =   360
         Width           =   3495
      End
      Begin VB.Label Label3 
         BackColor       =   &H00008000&
         BackStyle       =   0  'Transparent
         Caption         =   "Level"
         BeginProperty Font 
            Name            =   "Papyrus"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   240
         TabIndex        =   44
         Top             =   840
         Width           =   1575
      End
      Begin VB.Label Label5 
         BackColor       =   &H00008000&
         BackStyle       =   0  'Transparent
         Caption         =   "Department"
         BeginProperty Font 
            Name            =   "Papyrus"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   240
         TabIndex        =   43
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label7 
         BackColor       =   &H00008000&
         BackStyle       =   0  'Transparent
         Caption         =   "Semester"
         BeginProperty Font 
            Name            =   "Papyrus"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   495
         Left            =   240
         TabIndex        =   42
         Top             =   1320
         Width           =   1575
      End
   End
   Begin VB.CommandButton Cmd4 
      Caption         =   "&Update"
      BeginProperty Font 
         Name            =   "Perpetua"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   3240
      Width           =   3735
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Clo&se"
      BeginProperty Font 
         Name            =   "Perpetua"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   36
      Top             =   4080
      Width           =   3735
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Sa&ve "
      BeginProperty Font 
         Name            =   "Perpetua"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   35
      Top             =   3240
      Width           =   3735
   End
   Begin VB.CheckBox Check1 
      Appearance      =   0  'Flat
      BackColor       =   &H00C00000&
      Caption         =   "EDIT this module"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   30
      Top             =   2760
      Width           =   3735
   End
   Begin VB.TextBox T1 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   1
      Top             =   720
      Width           =   3495
   End
   Begin VB.TextBox T2 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   4
      Top             =   1200
      Width           =   3495
   End
   Begin VB.TextBox T3 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   7
      Top             =   1680
      Width           =   3495
   End
   Begin VB.TextBox T4 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   10
      Top             =   2160
      Width           =   3495
   End
   Begin VB.TextBox T5 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   13
      Top             =   2640
      Width           =   3495
   End
   Begin VB.TextBox T6 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   16
      Top             =   3120
      Width           =   3495
   End
   Begin VB.TextBox T7 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   19
      Top             =   3600
      Width           =   3495
   End
   Begin VB.TextBox T8 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   22
      Top             =   4080
      Width           =   3495
   End
   Begin VB.TextBox T9 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   25
      Top             =   4560
      Width           =   3495
   End
   Begin VB.TextBox T10 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   8160
      TabIndex        =   28
      Top             =   5040
      Width           =   3495
   End
   Begin VB.TextBox Text20 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   29
      Top             =   5040
      Width           =   1935
   End
   Begin VB.TextBox Text19 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   26
      Top             =   4560
      Width           =   1935
   End
   Begin VB.TextBox Text18 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   23
      Top             =   4080
      Width           =   1935
   End
   Begin VB.TextBox Text17 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   20
      Top             =   3600
      Width           =   1935
   End
   Begin VB.TextBox Text16 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   17
      Top             =   3120
      Width           =   1935
   End
   Begin VB.TextBox Text15 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   14
      Top             =   2640
      Width           =   1935
   End
   Begin VB.TextBox Text14 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   11
      Top             =   2160
      Width           =   1935
   End
   Begin VB.TextBox Text13 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   8
      Top             =   1680
      Width           =   1935
   End
   Begin VB.TextBox Text12 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   5
      Top             =   1200
      Width           =   1935
   End
   Begin VB.TextBox Text11 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   11760
      MaxLength       =   1
      TabIndex        =   2
      Top             =   720
      Width           =   1935
   End
   Begin VB.TextBox Text10 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   27
      Top             =   5040
      Width           =   1815
   End
   Begin VB.TextBox Text9 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   24
      Top             =   4560
      Width           =   1815
   End
   Begin VB.TextBox Text8 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   21
      Top             =   4080
      Width           =   1815
   End
   Begin VB.TextBox Text7 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   18
      Top             =   3600
      Width           =   1815
   End
   Begin VB.TextBox Text6 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   15
      Top             =   3120
      Width           =   1815
   End
   Begin VB.TextBox Text5 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   12
      Top             =   2640
      Width           =   1815
   End
   Begin VB.TextBox Text4 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   9
      Top             =   2160
      Width           =   1815
   End
   Begin VB.TextBox Text3 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   6
      Top             =   1680
      Width           =   1815
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   3
      Top             =   1200
      Width           =   1815
   End
   Begin VB.TextBox Text1 
      BackColor       =   &H00C00000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   405
      Left            =   6240
      TabIndex        =   0
      Top             =   720
      Width           =   1815
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "REGISTER ALL COURSES OFFER AT VARIOUS LEVEL HERE."
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
      Height          =   615
      Left            =   120
      TabIndex        =   45
      Top             =   4920
      Width           =   6015
   End
   Begin VB.Label Label6 
      BackColor       =   &H00008000&
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Course Description"
      BeginProperty Font 
         Name            =   "Papyrus"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF80&
      Height          =   495
      Left            =   8160
      TabIndex        =   34
      Top             =   120
      Width           =   3495
   End
   Begin VB.Label Label4 
      BackColor       =   &H00008000&
      BackStyle       =   0  'Transparent
      Caption         =   "Semester"
      BeginProperty Font 
         Name            =   "Papyrus"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   7920
      TabIndex        =   33
      Top             =   -840
      Width           =   2415
   End
   Begin VB.Label Label2 
      BackColor       =   &H00008000&
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Units"
      BeginProperty Font 
         Name            =   "Papyrus"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF80&
      Height          =   495
      Left            =   11760
      TabIndex        =   32
      Top             =   120
      Width           =   1935
   End
   Begin VB.Label Label1 
      BackColor       =   &H00008000&
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Courses Code"
      BeginProperty Font 
         Name            =   "Papyrus"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF80&
      Height          =   495
      Left            =   6240
      TabIndex        =   31
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
        'COURSE REGISTRATION FORM
        Private Sub Check1_Click()
        If Check1.Value = 1 Then
        Com3.Visible = True
        Cmd4.Visible = True
        Cmd4.Enabled = True
        Command1.Visible = False
        C2.SetFocus
        Else
        C2.SetFocus
        Command1.Visible = True
        Com3.Visible = False
        Cmd4.Visible = False
        Call mclear
        End If
        End Sub
        
        Private Sub Cmd4_Click()
        On Error Resume Next
        Set myrs = mydb.OpenRecordset("Select * from COUStab where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        'Set myrs = mydb.OpenRecordset("cousTAB")
        With myrs
        .Edit
        !CO1 = UCase$(Text1)
        !CO2 = UCase$(Text2)
        !CO3 = UCase$(Text3)
        !CO4 = UCase$(Text4)
        !CO5 = UCase$(Text5)
        !CO6 = UCase$(Text6)
        !CO7 = UCase$(Text7)
        !CO8 = UCase$(Text8)
        !CO9 = UCase$(Text9)
        !CO10 = UCase$(Text10)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        .Update
        .CLOSE
        End With
        Set myrs = mydb.OpenRecordset("Select * from UNIT where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        'Set myrs = mydb.OpenRecordset("unit")
        With myrs
        .Edit
        !Ut1 = UCase$(Text11)
        !Ut2 = UCase$(Text12)
        !Ut3 = UCase$(Text13)
        !Ut4 = UCase$(Text14)
        !Ut5 = UCase$(Text15)
        !ut6 = UCase$(Text16)
        !ut7 = UCase$(Text17)
        !Ut8 = UCase$(Text18)
        !Ut9 = UCase$(Text19)
        !Ut10 = UCase$(Text20)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        
        .Update
        .CLOSE
        End With
        Set myrs = mydb.OpenRecordset("Select * from DESTAB where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        
        'Set myrs = mydb.OpenRecordset("destab")
        With myrs
        .Edit
        !dt1 = UCase$(T1)
        !dt2 = UCase$(T2)
        !dt3 = UCase$(T3)
        !dt4 = UCase$(T4)
        !dt5 = UCase$(T5)
        !dt6 = UCase$(T6)
        !dt7 = UCase$(T7)
        !dt8 = UCase$(T8)
        !dt9 = UCase$(T9)
        !dt10 = UCase$(T10)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        
        .Update
        .CLOSE
        End With
        
        MsgBox "Record successfully Updated"
        
        End Sub
        '
        
        Private Sub Com3_Click()
        Cmd4.Visible = True
        Command1.Visible = False
        Cmd4.Enabled = True
        On Error Resume Next
        Set myrs = mydb.OpenRecordset("Select * from COUStab where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        With myrs
             Text1 = !CO1
             Text2 = !CO2
             Text3 = !CO3
             Text4 = !CO4
             Text5 = !CO5
             Text6 = !CO6
             Text7 = !CO7
             Text8 = !CO8
             Text9 = !CO9
             Text10 = !CO10
             End With
             Set myrs = mydb.OpenRecordset("Select * from unit where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        With myrs
             Text11 = !Ut1
             Text12 = !Ut2
             Text13 = !Ut3
             Text14 = !Ut4
             Text15 = !Ut5
             Text16 = !ut6
             Text17 = !ut7
             Text18 = !Ut8
             Text19 = !Ut9
             Text20 = !Ut10
             End With
             Set myrs = mydb.OpenRecordset("Select * from destab where LEV='" & C1 & "' and sem = '" & C3 & "' ")
        With myrs
          T1 = !dt1
          T2 = !dt2
          T3 = !dt3
          T4 = !dt4
          T5 = !dt5
          T6 = !dt6
          T7 = !dt7
          T8 = !dt8
          T9 = !dt9
          T10 = !dt10
        End With
        End Sub
        
        Private Sub Command1_Click()
        Set myrs = mydb.OpenRecordset("cousTAB")
        With myrs
        .AddNew
        !CO1 = UCase$(Text1)
        !CO2 = UCase$(Text2)
        !CO3 = UCase$(Text3)
        !CO4 = UCase$(Text4)
        !CO5 = UCase$(Text5)
        !CO6 = UCase$(Text6)
        !CO7 = UCase$(Text7)
        !CO8 = UCase$(Text8)
        !CO9 = UCase$(Text9)
        !CO10 = UCase$(Text10)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        .Update
        .CLOSE
        End With
        Set myrs = mydb.OpenRecordset("unit")
        With myrs
        .AddNew
        !Ut1 = UCase$(Text11)
        !Ut2 = UCase$(Text12)
        !Ut3 = UCase$(Text13)
        !Ut4 = UCase$(Text14)
        !Ut5 = UCase$(Text15)
        !ut6 = UCase$(Text16)
        !ut7 = UCase$(Text17)
        !Ut8 = UCase$(Text18)
        !Ut9 = UCase$(Text19)
        !Ut10 = UCase$(Text20)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        
        .Update
        .CLOSE
        End With
        Set myrs = mydb.OpenRecordset("destab")
        With myrs
        .AddNew
        !dt1 = UCase$(T1)
        !dt2 = UCase$(T2)
        !dt3 = UCase$(T3)
        !dt4 = UCase$(T4)
        !dt5 = UCase$(T5)
        !dt6 = UCase$(T6)
        !dt7 = UCase$(T7)
        !dt8 = UCase$(T8)
        !dt9 = UCase$(T9)
        !dt10 = UCase$(T10)
        !lev = UCase$(C1)
        !dept = UCase$(C2)
        !sem = UCase$(C3)
        
        .Update
        .CLOSE
        End With
        
        MsgBox "Record successfully saved"
        
        End Sub
        Private Sub Command3_Click()
        Form3.Show
        A = Text1
        B = Text2
        C = Text3
        D = Text4
        E = Text5
        F = Text6
        G = Text7
        H = Text8
        I = Text9
        J = Text10
        K = Text11
        L = Text12
        M = Text13
        N = Text14
        O = Text15
        P = Text16
        Q = Text17
        R = Text18
        S = Text19
        T = Text20
        U = T1
        V = T2
        W = T3
        X = T4
        Y = T5
        Z = T6
        A1 = T7
        A2 = T8
        A3 = T9
        A4 = T10
        S1 = C1
        S2 = C2
        S3 = C3
        
        
        
        
        
        'Label12 = Text1
        
        End Sub
        
        Private Sub Command2_Click()
        Unload Me
        End Sub
        
        Private Sub Form_Activate()
        C2.SetFocus
        Com3.Visible = False
        Cmd4.Visible = False
        End Sub
        
        Private Sub Form_Load()
        Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")
        End Sub
        
        
        
        Private Sub Text11_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
            Else
         K = 0
           Beep
           End If
        End Sub
        Private Sub Text12_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
            Else
         K = 0
           Beep
           End If
        End Sub
        Private Sub Text13_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
            Else
         K = 0
           Beep
           End If
        End Sub
        Private Sub Text14_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
            Else
         K = 0
           Beep
           End If
        End Sub
    Private Sub Text15_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
            Else
         K = 0
           Beep
           End If
    End Sub
    Private Sub Text16_KeyPress(K As Integer)
       If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
           Exit Sub
       Else
           K = 0
           Beep
       End If
    End Sub
    Private Sub Text17_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
            Exit Sub
        Else
           K = 0
           Beep
        End If
    End Sub
        
    Private Sub Text18_KeyPress(K As Integer)
        If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
         Else
             K = 0
             Beep
        End If
    End Sub
        
    Private Sub Text19_KeyPress(K As Integer)
      If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
             Exit Sub
      Else
             K = 0
             Beep
      End If
    End Sub
        
    Private Sub Text20_KeyPress(K As Integer)
         If K >= vbKey0 And K <= vbKey9 Or K = vbkeydecpt Or K = vbKeyBack Then
               Exit Sub
         Else
              K = 0
           Beep
        End If
    End Sub
        
        
        Public Sub mclear()
             Text1 = "": Text2 = "": Text3 = "": Text4 = "": Text5 = "": Text6 = "": Text7 = "": Text8 = "": Text9 = "": Text10 = "": Text11 = "": Text12 = ""
             Text13 = "": Text14 = "": Text15 = "": Text16 = "": Text17 = "": Text18 = "": Text19 = "": Text20 = ""
             T1 = "": T2 = "": T3 = "": T4 = "": T5 = "": T6 = "": T7 = "": T8 = "": T9 = "": T10 = ""
        End Sub

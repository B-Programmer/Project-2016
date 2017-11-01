VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.1#0"; "mscomctl.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form3 
   BackColor       =   &H00C00000&
   BorderStyle     =   0  'None
   Caption         =   "Form3"
   ClientHeight    =   10665
   ClientLeft      =   2820
   ClientTop       =   690
   ClientWidth     =   9360
   ControlBox      =   0   'False
   FillStyle       =   0  'Solid
   ForeColor       =   &H00C00000&
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   10665
   ScaleWidth      =   9360
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      BackColor       =   &H00C00000&
      Caption         =   "SELECT PROGRAMME:"
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
      Height          =   2055
      Left            =   120
      TabIndex        =   50
      Top             =   0
      Width           =   9135
      Begin VB.ComboBox C2 
         BackColor       =   &H00C00000&
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
         Height          =   420
         ItemData        =   "RegisFrm.frx":0000
         Left            =   2040
         List            =   "RegisFrm.frx":0016
         TabIndex        =   63
         Top             =   1080
         Width           =   3735
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00C00000&
         Caption         =   "CONTROL BUTTON"
         BeginProperty Font 
            Name            =   "MS Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   1215
         Left            =   6720
         TabIndex        =   53
         Top             =   360
         Width           =   1935
         Begin VB.CommandButton Command2 
            Caption         =   "&Close"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   240
            TabIndex        =   55
            Top             =   720
            Width           =   1455
         End
         Begin VB.CommandButton Command1 
            Caption         =   "&Done"
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
            Left            =   240
            Style           =   1  'Graphical
            TabIndex        =   54
            Top             =   240
            Width           =   1455
         End
      End
      Begin VB.ComboBox Combo1 
         BackColor       =   &H00C00000&
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
         Height          =   420
         Left            =   2040
         TabIndex        =   0
         Top             =   360
         Width           =   3735
      End
      Begin VB.ComboBox Combo2 
         BackColor       =   &H00C00000&
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
         Height          =   420
         ItemData        =   "RegisFrm.frx":009D
         Left            =   4440
         List            =   "RegisFrm.frx":00A7
         TabIndex        =   52
         Top             =   720
         Width           =   1335
      End
      Begin VB.ComboBox Combo3 
         BackColor       =   &H00C00000&
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
         Height          =   420
         ItemData        =   "RegisFrm.frx":00BA
         Left            =   2040
         List            =   "RegisFrm.frx":00CA
         TabIndex        =   51
         Top             =   720
         Width           =   1215
      End
      Begin MSComctlLib.ProgressBar PgBar 
         Height          =   255
         Left            =   1800
         TabIndex        =   56
         Top             =   1680
         Width           =   6975
         _ExtentX        =   12303
         _ExtentY        =   450
         _Version        =   393216
         Appearance      =   0
         Scrolling       =   1
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Department"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   255
         Index           =   2
         Left            =   240
         TabIndex        =   62
         Top             =   1200
         Width           =   1095
      End
      Begin VB.Label L4 
         BackStyle       =   0  'Transparent
         ForeColor       =   &H0000FFFF&
         Height          =   255
         Left            =   1200
         TabIndex        =   61
         Top             =   1680
         Width           =   375
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Loading...."
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   60
         Top             =   1680
         Width           =   1215
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Level"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   255
         Index           =   1
         Left            =   240
         TabIndex        =   59
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Semester"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   255
         Index           =   1
         Left            =   3360
         TabIndex        =   58
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   " Matric Number"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   255
         Left            =   240
         TabIndex        =   57
         Top             =   360
         Width           =   1575
      End
   End
   Begin VB.CommandButton Command6 
      Caption         =   "PROCESS ANOTHER STUDENT INFORMATION"
      Height          =   375
      Left            =   2040
      TabIndex        =   48
      Top             =   120
      Width           =   7095
   End
   Begin VB.CommandButton Command5 
      Caption         =   "&Close"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   47
      Top             =   120
      Width           =   1695
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00C00000&
      Height          =   8655
      Left            =   120
      TabIndex        =   1
      Top             =   1920
      Width           =   9135
      Begin VB.CommandButton Command4 
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
         Height          =   495
         Left            =   240
         TabIndex        =   46
         Top             =   7920
         Width           =   1455
      End
      Begin VB.CommandButton Command3 
         Caption         =   "PRINT"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   6000
         TabIndex        =   2
         Top             =   7920
         Width           =   2655
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Name"
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
         Index           =   0
         Left            =   120
         TabIndex        =   45
         Top             =   960
         Width           =   1575
      End
      Begin VB.Label Label4 
         BackColor       =   &H00FFC0FF&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Index           =   0
         Left            =   1800
         TabIndex        =   44
         Top             =   960
         Width           =   4575
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Department"
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
         Left            =   120
         TabIndex        =   43
         Top             =   1320
         Width           =   1575
      End
      Begin VB.Label LA 
         BackColor       =   &H00FFC0FF&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   1800
         TabIndex        =   42
         Top             =   1320
         Width           =   4575
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "Date"
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
         Left            =   6480
         TabIndex        =   41
         Top             =   1560
         Width           =   615
      End
      Begin VB.Line Line4 
         BorderColor     =   &H00FFFFFF&
         BorderWidth     =   2
         X1              =   7080
         X2              =   8760
         Y1              =   2040
         Y2              =   2040
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   7080
         TabIndex        =   40
         Top             =   1560
         Width           =   1695
      End
      Begin VB.Line Line5 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   4
         X1              =   120
         X2              =   9000
         Y1              =   2160
         Y2              =   2160
      End
      Begin VB.Label Label11 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Course Code"
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
         Left            =   120
         TabIndex        =   39
         Top             =   2520
         Width           =   3135
      End
      Begin VB.Line Line6 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   2
         X1              =   3240
         X2              =   3240
         Y1              =   2160
         Y2              =   7680
      End
      Begin VB.Label Label12 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   38
         Top             =   3000
         Width           =   2535
      End
      Begin VB.Label Label13 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   37
         Top             =   3480
         Width           =   2535
      End
      Begin VB.Label Label14 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   36
         Top             =   3960
         Width           =   2535
      End
      Begin VB.Label Label15 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   35
         Top             =   4440
         Width           =   2535
      End
      Begin VB.Label Label16 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   34
         Top             =   4920
         Width           =   2535
      End
      Begin VB.Label Label17 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   33
         Top             =   5400
         Width           =   2535
      End
      Begin VB.Label Label18 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   32
         Top             =   5880
         Width           =   2535
      End
      Begin VB.Label Label19 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   31
         Top             =   6360
         Width           =   2535
      End
      Begin VB.Label Label20 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   30
         Top             =   6840
         Width           =   2535
      End
      Begin VB.Label Label21 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   480
         TabIndex        =   29
         Top             =   7320
         Width           =   2535
      End
      Begin VB.Label LB9 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   28
         Top             =   6840
         Width           =   2055
      End
      Begin VB.Label LB8 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   27
         Top             =   6360
         Width           =   2055
      End
      Begin VB.Label LB7 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   26
         Top             =   5880
         Width           =   2055
      End
      Begin VB.Label LB6 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   25
         Top             =   5400
         Width           =   2055
      End
      Begin VB.Label LB5 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   24
         Top             =   4920
         Width           =   2055
      End
      Begin VB.Label LB4 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   23
         Top             =   4440
         Width           =   2055
      End
      Begin VB.Label LB3 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   22
         Top             =   3960
         Width           =   2055
      End
      Begin VB.Label LB1 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   21
         Top             =   3000
         Width           =   2055
      End
      Begin VB.Label Label32 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Units"
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
         Left            =   3240
         TabIndex        =   20
         Top             =   2520
         Width           =   2415
      End
      Begin VB.Line Line7 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   2
         X1              =   5640
         X2              =   5640
         Y1              =   2160
         Y2              =   7800
      End
      Begin VB.Label LabJ 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Description"
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
         Left            =   5640
         TabIndex        =   19
         Top             =   2520
         Width           =   3255
      End
      Begin VB.Label LB20 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   18
         Top             =   7320
         Width           =   3135
      End
      Begin VB.Label LB19 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   17
         Top             =   6840
         Width           =   3135
      End
      Begin VB.Label LB18 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   16
         Top             =   6360
         Width           =   3135
      End
      Begin VB.Label LB17 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   15
         Top             =   5880
         Width           =   3135
      End
      Begin VB.Label LB16 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   14
         Top             =   5400
         Width           =   3135
      End
      Begin VB.Label LB15 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   13
         Top             =   4920
         Width           =   3135
      End
      Begin VB.Label LB14 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   12
         Top             =   4440
         Width           =   3135
      End
      Begin VB.Label LB13 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   11
         Top             =   3960
         Width           =   3135
      End
      Begin VB.Label LB12 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   10
         Top             =   3480
         Width           =   3135
      End
      Begin VB.Label LB11 
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   5760
         TabIndex        =   9
         Top             =   3000
         Width           =   3135
      End
      Begin VB.Line Line8 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   2
         X1              =   9000
         X2              =   9000
         Y1              =   2160
         Y2              =   8520
      End
      Begin VB.Line Line9 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   4
         X1              =   120
         X2              =   9000
         Y1              =   8520
         Y2              =   8520
      End
      Begin VB.Line Line11 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   4
         X1              =   120
         X2              =   9000
         Y1              =   7800
         Y2              =   7800
      End
      Begin VB.Label Label48 
         BackStyle       =   0  'Transparent
         Caption         =   "Total Units"
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   1800
         TabIndex        =   8
         Top             =   8160
         Width           =   975
      End
      Begin VB.Label RES 
         Alignment       =   2  'Center
         BackColor       =   &H8000000C&
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   3000
         TabIndex        =   7
         Top             =   8040
         Width           =   2775
      End
      Begin VB.Label LB10 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   6
         Top             =   7320
         Width           =   2055
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H00C00000&
         BorderStyle     =   1  'Fixed Single
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
         Left            =   3360
         TabIndex        =   5
         Top             =   3480
         Width           =   2055
      End
      Begin VB.Line Line14 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   4
         X1              =   120
         X2              =   120
         Y1              =   2160
         Y2              =   8520
      End
      Begin VB.Image Image1 
         BorderStyle     =   1  'Fixed Single
         Height          =   1215
         Left            =   7080
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1695
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Matric Number"
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
         Index           =   0
         Left            =   120
         TabIndex        =   4
         Top             =   1680
         Width           =   1575
      End
      Begin VB.Label Lab1 
         BackColor       =   &H00FFC0FF&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Palatino Linotype"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   1800
         TabIndex        =   3
         Top             =   1680
         Width           =   4575
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   0
      Top             =   0
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   11280
      Top             =   9240
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "STUDENT INFORMATION "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   375
      Left            =   2400
      TabIndex        =   49
      Top             =   1560
      Width           =   4815
   End
   Begin VB.Image Image4 
      Height          =   15
      Left            =   120
      Picture         =   "RegisFrm.frx":00EA
      Stretch         =   -1  'True
      Top             =   0
      Width           =   975
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Combo1_Click()
PA = Combo1

End Sub

Private Sub Combo1_GotFocus()
On Error Resume Next
RES = ""
Set myrs = mydb.OpenRecordset("Select * from regtab order by matricno")
With myrs
If myrs.BOF = False Then
 Combo1.clear
Do While Not myrs.EOF
    Combo1.AddItem myrs!MATRICNO
    myrs.MoveNext
    Loop
End If
End With
LA = "": Label4(0) = "": Lab1 = ""
Label12 = "": Label13 = "": Label14 = "": Label15 = "": Label16 = "": Label17 = "": Label18 = "": Label19 = "": Label20 = "": Label21 = ""
LB1 = "": Label6 = "": LB3 = "": LB4 = "": LB5 = "": LB6 = "": LB7 = "": LB8 = "":  LB9 = "": LB10 = ""
LB11 = "": LB12 = "": LB13 = "": LB14 = "": LB15 = "": LB16 = "": LB17 = "": LB18 = "":  LB19 = "": LB20 = ""
End Sub

Private Sub Command1_Click()
On Error Resume Next
Set myrs = mydb.OpenRecordset("Select * from regtab where MATRICNO ='" & Combo1 & "'")
With myrs
  If .RecordCount > 0 Then
     ade = !Name
     LE = !COUS
     SD = !PIE
  PA = !MATRICNO
Form3.Image1.Picture = LoadPicture(SD)
     
  End If
 End With


Set myrs = mydb.OpenRecordset("Select * from COUStab where LEV='" & Combo3 & "' and sem = '" & Combo2 & "'and dept ='" & C2 & "'")
Timer1.Enabled = True
 'On Error Resume Next
With myrs
A = !CO1
B = !CO2
C = !CO3
D = !CO4
E = !CO5
F = !CO6
G = !CO7
H = !CO8
I = !CO9
J = !CO10
 End With
Set myrs = mydb.OpenRecordset("Select * from UNIT where LEV='" & Combo3 & "' and sem = '" & Combo2 & "' and dept ='" & C2 & "'")
 
With myrs
  If .RecordCount > 0 Then
k9 = !Ut1
L = !Ut2
M = !Ut3
N = !Ut4
O = !Ut5
P = !ut6
Q = !ut7
R = !Ut8
S = !Ut9
T = !Ut10
    
    End If
 End With
Set myrs = mydb.OpenRecordset("Select * from DESTAB where LEV='" & Combo3 & "' and sem = '" & Combo2 & "'and dept ='" & C2 & "'")
 
With myrs
  If .RecordCount > 0 Then
U = !dt1
V = !dt2
W = !dt3
X = !dt4
Y = !dt5
Z = !dt6
A1 = !dt7
A2 = !dt8
A3 = !dt9
A4 = !dt10
    
    End If
 End With

Timer1.Enabled = True
End Sub


Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command3_Click()
 'Print the form
 Me.PrintForm
End Sub

Private Sub Command4_Click()
LA = "": Label4(0) = "": Lab1 = ""
Label12 = "": Label13 = "": Label14 = "": Label15 = "": Label16 = "": Label17 = "": Label18 = "": Label19 = "": Label20 = "": Label21 = ""
LB1 = "": Label6 = "": LB3 = "": LB4 = "": LB5 = "": LB6 = "": LB7 = "": LB8 = "":  LB9 = "": LB10 = ""
LB11 = "": LB12 = "": LB13 = "": LB14 = "": LB15 = "": LB16 = "": LB17 = "": LB18 = "":  LB19 = "": LB20 = ""
End Sub

Private Sub Command5_Click()
Unload Me
End Sub

Private Sub Command6_Click()
Frame2.Visible = True
End Sub

Private Sub Form_Activate()
'Frame3.Visible = False
LB1 = ""
Timer1.Enabled = False
PgBar.Visible = False
On Error Resume Next

Label10 = Format(Date, "DD/MM/YYYY")
Label12 = A
Label13 = B
Label14 = C
Label15 = D
Label16 = E
Label17 = F
Label18 = G
Label19 = H
Label20 = I
Label21 = J
LB1 = k9
Label6 = L
LB3 = M
LB4 = N
LB5 = O
LB6 = P
LB7 = Q
LB8 = R
LB9 = S
LB10 = T
LB11 = U
LB12 = V
LB13 = W
LB14 = X
LB15 = Y
LB16 = Z
LB17 = A1
LB18 = A2
LB19 = A3
LB20 = A4
LBBD = S2
Lab1 = PA
Label4(0) = ade
LA = LE
Image1.Picture = LoadPicture(SD)
Label251.Caption = Combo1

RES = Val(LB1) + Val(Label6) + Val(LB3) + Val(LB4) + Val(LB5) + Val(LB6) + Val(LB7) + Val(LB8) + Val(LB9) + Val(LB10)
If Val(RES) > 32 Then

MsgBox "YOU HAVE EXCEDED THE WORK LOAD! "
'Unload Me
End If

 
End Sub

Private Sub Form_Load()

Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")

Label33 = V
Label34 = W
Label35 = X
Label36 = Y
Label37 = Z
Label38 = A1
Label39 = A2
Label40 = A3
Label41 = A4


End Sub

Private Sub Label22_Click()
Unload Me
End Sub

Private Sub Timer1_Timer()
Dim K, J As Long
PgBar.Visible = True
L4.Visible = True
PgBar.Value = PgBar.Value + 1
L4.Caption = CStr(PgBar.Value & "%")
If PgBar.Value = 100 Then
Lab1 = PA
Timer1.Enabled = False
Unload Me
Frame2.Visible = False
'Frame3.Visible = True
  Form3.Show 1
End If
End Sub


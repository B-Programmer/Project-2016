VERSION 5.00
Begin VB.Form Form11 
   BackColor       =   &H00FF0000&
   Caption         =   "Form11"
   ClientHeight    =   8490
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   9645
   LinkTopic       =   "Form11"
   ScaleHeight     =   8490
   ScaleWidth      =   9645
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFC0C0&
      Height          =   7695
      Left            =   360
      TabIndex        =   0
      Top             =   720
      Width           =   8055
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
         ItemData        =   "FrmCluster3.frx":0000
         Left            =   3720
         List            =   "FrmCluster3.frx":000A
         TabIndex        =   22
         Top             =   2040
         Width           =   2775
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
         Left            =   3840
         TabIndex        =   17
         Top             =   6840
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
         ItemData        =   "FrmCluster3.frx":001D
         Left            =   3720
         List            =   "FrmCluster3.frx":002D
         TabIndex        =   16
         Top             =   1440
         Width           =   2775
      End
      Begin VB.Frame Frame2 
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
         Left            =   840
         TabIndex        =   3
         Top             =   3000
         Width           =   5775
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
            TabIndex        =   15
            Top             =   3240
            Width           =   2415
         End
         Begin VB.Label Label41 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            BorderStyle     =   1  'Fixed Single
            BeginProperty Font 
               Name            =   "Arial Narrow"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H0000FFFF&
            Height          =   375
            Left            =   3000
            TabIndex        =   14
            Top             =   3240
            Width           =   1575
         End
         Begin VB.Line Line1 
            BorderColor     =   &H0000FFFF&
            BorderWidth     =   4
            X1              =   120
            X2              =   4680
            Y1              =   1200
            Y2              =   1200
         End
         Begin VB.Label Label17 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            BorderStyle     =   1  'Fixed Single
            BeginProperty Font 
               Name            =   "Arial Narrow"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H0000FFFF&
            Height          =   375
            Left            =   3000
            TabIndex        =   13
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
            TabIndex        =   12
            Top             =   2760
            Width           =   2415
         End
         Begin VB.Label Label11 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            BorderStyle     =   1  'Fixed Single
            BeginProperty Font 
               Name            =   "Arial Narrow"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H0000FFFF&
            Height          =   375
            Left            =   3000
            TabIndex        =   11
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
            TabIndex        =   10
            Top             =   2280
            Width           =   2415
         End
         Begin VB.Label Label14 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            BorderStyle     =   1  'Fixed Single
            BeginProperty Font 
               Name            =   "Arial Narrow"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H0000FFFF&
            Height          =   375
            Left            =   3000
            TabIndex        =   9
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
            TabIndex        =   8
            Top             =   1320
            Width           =   2415
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
            Height          =   375
            Left            =   120
            TabIndex        =   7
            Top             =   1800
            Width           =   2415
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
            Left            =   3000
            TabIndex        =   6
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
            TabIndex        =   5
            Top             =   720
            Width           =   1815
         End
         Begin VB.Label Label8 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            BorderStyle     =   1  'Fixed Single
            BeginProperty Font 
               Name            =   "Arial Narrow"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H0000FFFF&
            Height          =   375
            Left            =   3000
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
         Left            =   840
         TabIndex        =   2
         Top             =   6840
         Width           =   2895
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
         ItemData        =   "FrmCluster3.frx":004D
         Left            =   3720
         List            =   "FrmCluster3.frx":004F
         Style           =   2  'Dropdown List
         TabIndex        =   1
         Top             =   840
         Width           =   2775
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Semester:"
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
         Left            =   840
         TabIndex        =   21
         Top             =   2040
         Width           =   2775
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
         Left            =   840
         TabIndex        =   20
         Top             =   1440
         Width           =   2775
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Select session and level below:"
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
         Left            =   840
         TabIndex        =   19
         Top             =   360
         Width           =   5655
      End
      Begin VB.Label Label18 
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Session:"
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
         Left            =   840
         TabIndex        =   18
         Top             =   840
         Width           =   2775
      End
   End
End
Attribute VB_Name = "Form11"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Combo1_GotFocus()
Label14 = "": Label12 = "": Label8 = "": Label9 = ""
Label11 = "": Label5 = "": Label17 = "": Label15 = "": Label41 = ""
Label43 = ""
End Sub

Private Sub Command1_Click()
On Error Resume Next
Cluster2(1, 2) = "DISTINCTION"
Cluster2(1, 3) = "UPPER CREDIT"
Cluster2(1, 4) = "LOWER CREDIT"
Cluster2(1, 5) = "PASS"
Cluster2(1, 6) = "FAIL"
'First Session
Cluster2(2, 1) = Combo1.Text & " Session"
Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & Combo2 & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "DISTINCTION" & "'")
With myrs
DD = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
DD = DD + Val(!Count)
.MoveNext
Loop
Label14 = DD: Cluster2(2, 2) = DD
Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & Combo2 & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "UPPER CREDIT" & "'")
With myrs
CC = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
CC = CC + Val(!Count)
.MoveNext
Loop
Label8 = CC: Cluster2(2, 3) = CC
'Else
'Exit Sub
End If
End With
Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & Combo2 & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "LOWER CREDIT" & "'")
With myrs
LW = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
LW = LW + Val(!Count)
.MoveNext
Loop
Label11 = LW: Cluster2(2, 4) = LW
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & Combo2 & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "PASS" & "'")
With myrs
THIRD = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
THIRD = THIRD + Val(!Count)
.MoveNext
Loop
Label17 = THIRD: Cluster2(2, 5) = THIRD
'Else
'Exit Sub
End If
End With

Set myrs = mydb.OpenRecordset("Select * from  PERTAB where (SEMESTER = '" & Combo2 & "') AND LEVEL = '" & Combo5 & "'AND SESSION = '" & Combo1 & "'AND GRADE = '" & "FAIL" & "'")
With myrs
PASS = 0
If .BOF = False Then
.MoveFirst
Do Until .EOF
PASS = PASS + Val(!Count)
.MoveNext
Loop
Label41 = PASS: Cluster2(2, 6) = PASS
End If
End With
End Sub
Private Sub Command1_GotFocus()
Label14 = "": Label12 = "": Label8 = "": Label9 = ""
Label11 = "": Label5 = "": Label17 = "": Label15 = "": Label41 = ""
Label43 = ""
Label2 = Combo1
For I = 1 To 6
 Cluster2(2, I) = ""
Next I
'Label3 = Combo2
End Sub

Private Sub Command2_Click()
ClusterType = "Cluster 3"
chartTitle = "Graph of " & Combo5.Text & " Students Academic Performance for the " & Combo2.Text & " Semester"
FRMCHART.Show 1

End Sub

Private Sub Form_Load()

Set mydb = DBEngine.OpenDatabase(App.Path & "\stdRC.mdb")

For I = 2004 To 2300
Combo1.AddItem I & "/" & (I + 1)
Next I

End Sub


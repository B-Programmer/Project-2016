VERSION 5.00
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "mschrt20.ocx"
Begin VB.Form FRMCHART 
   BackColor       =   &H00800000&
   Caption         =   "DATA MINING ANALYSIS OF STUDENTS ACADEMIC PERFORMANCE (CHART FORM)"
   ClientHeight    =   10155
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   15435
   LinkTopic       =   "Form10"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10155
   ScaleWidth      =   15435
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "&OK"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   13200
      TabIndex        =   2
      Top             =   9600
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00800000&
      Caption         =   "Student Academic Performance Evaluation Result"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   9495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   14655
      Begin MSChart20Lib.MSChart MSChart1 
         Height          =   8895
         Left            =   240
         OleObjectBlob   =   "FRMCHART.frx":0000
         TabIndex        =   1
         Top             =   480
         Width           =   14295
      End
   End
End
Attribute VB_Name = "FRMCHART"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command2_Click()
 Unload Me
End Sub


Private Sub Form_Load()
If (ClusterType = "Cluster 1") Then
    MSChart1.ChartData = Cluster1
    MSChart1.TitleText = chartTitle
ElseIf (ClusterType = "Cluster 2") Then
    MSChart1.ChartData = Cluster2
    MSChart1.TitleText = chartTitle
ElseIf (ClusterType = "Cluster 3") Then
    MSChart1.ChartData = Cluster2
    MSChart1.TitleText = chartTitle

End If

End Sub

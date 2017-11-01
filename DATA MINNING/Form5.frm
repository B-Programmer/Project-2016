VERSION 5.00
Begin VB.Form Form5 
   BorderStyle     =   0  'None
   ClientHeight    =   3090
   ClientLeft      =   120
   ClientTop       =   420
   ClientWidth     =   9360
   ControlBox      =   0   'False
   LinkTopic       =   "Form5"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3090
   ScaleWidth      =   9360
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Menu mS 
      Caption         =   "System Setup"
      Begin VB.Menu mStd 
         Caption         =   "Student Registration Form"
      End
      Begin VB.Menu mC 
         Caption         =   "Courses and Units Registration"
      End
      Begin VB.Menu mX 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mop 
      Caption         =   "Operaton"
      Begin VB.Menu mCourse 
         Caption         =   "Course Form"
      End
   End
   Begin VB.Menu mRep 
      Caption         =   "Report"
      Begin VB.Menu mLay 
         Caption         =   "Layout of Student Register"
      End
   End
End
Attribute VB_Name = "Form5"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mC_Click()
Form7.Show 1
End Sub

Private Sub mCourse_Click()
Form4.Show 1
End Sub

Private Sub mlay_Click()
'DataReport1.Show 1
End Sub

Private Sub mStd_Click()
Form1.Show 1
End Sub

Private Sub mX_Click()
End
End Sub

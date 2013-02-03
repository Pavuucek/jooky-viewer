VERSION 4.00
Begin VB.Form frmSplash 
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   4320
   ClientLeft      =   255
   ClientTop       =   1410
   ClientWidth     =   7650
   ControlBox      =   0   'False
   Height          =   4830
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   Left            =   195
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MouseIcon       =   "frmSplash.frx":000C
   MousePointer    =   99  'Custom
   ScaleHeight     =   288
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   510
   ShowInTaskbar   =   0   'False
   Top             =   960
   Width           =   7770
   Begin VB.Frame Frame1 
      Height          =   4050
      Left            =   120
      MousePointer    =   99  'Custom
      TabIndex        =   0
      Top             =   120
      Width           =   7425
      Begin VB.Image Image1 
         Height          =   1350
         Left            =   5520
         Picture         =   "frmSplash.frx":044E
         Stretch         =   -1  'True
         Top             =   2640
         Width           =   1830
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   "Jooky - Viewer"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   238
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   240
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   14
         Top             =   0
         Width           =   1650
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "Toto je náš Maskot"
         Height          =   195
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   13
         Top             =   2400
         Width           =   1365
      End
      Begin VB.Label MK 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Michal ""Spider"" Kuncl"
         Height          =   195
         Left            =   1680
         MousePointer    =   99  'Custom
         TabIndex        =   12
         Top             =   3000
         Width           =   1560
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "PROGRAMMER:"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   238
            Weight          =   700
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1680
         MousePointer    =   99  'Custom
         TabIndex        =   11
         Top             =   2760
         Width           =   1410
      End
      Begin VB.Label LblOS 
         AutoSize        =   -1  'True
         Caption         =   "Oldøich Strachota"
         Height          =   195
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   10
         Top             =   3480
         Width           =   1245
      End
      Begin VB.Label LblJV 
         AutoSize        =   -1  'True
         Caption         =   "Jaromír Víša"
         Height          =   195
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   9
         Top             =   3240
         Width           =   870
      End
      Begin VB.Label lblML 
         AutoSize        =   -1  'True
         Caption         =   "Martin Lux"
         Height          =   195
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   8
         Top             =   3000
         Width           =   735
      End
      Begin VB.Label LblCredits 
         AutoSize        =   -1  'True
         Caption         =   "CREDITS:"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   238
            Weight          =   700
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   7
         Top             =   2760
         Width           =   885
      End
      Begin VB.Label stav 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Formating Hard Drive ..."
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   21.75
            Charset         =   238
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008000&
         Height          =   495
         Left            =   2040
         MousePointer    =   99  'Custom
         TabIndex        =   6
         Top             =   1920
         Width           =   4650
      End
      Begin VB.Image imgLogo 
         Height          =   2250
         Left            =   120
         MousePointer    =   99  'Custom
         Picture         =   "frmSplash.frx":8AB8
         Top             =   360
         Width           =   2250
      End
      Begin VB.Label lblCopyright 
         AutoSize        =   -1  'True
         Caption         =   "Václav ""DarkLogic"" Návrat"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Left            =   120
         MousePointer    =   99  'Custom
         TabIndex        =   2
         Top             =   3720
         Width           =   1920
      End
      Begin VB.Label lblCompany 
         AutoSize        =   -1  'True
         Caption         =   "© Harley Software  Ltd. 1997 - 1999"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Left            =   1680
         MousePointer    =   99  'Custom
         TabIndex        =   1
         Top             =   3240
         Width           =   2640
      End
      Begin VB.Label lblVersion 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "verze 1.0"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   285
         Left            =   6360
         MousePointer    =   99  'Custom
         TabIndex        =   3
         Top             =   960
         Width           =   1020
      End
      Begin VB.Label lblPlatform 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "for Windows 98, 95 nebo NT 4.0"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   15.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   2130
         MousePointer    =   99  'Custom
         TabIndex        =   4
         Top             =   1200
         Width           =   4770
      End
      Begin VB.Label lblProductName 
         AutoSize        =   -1  'True
         Caption         =   "DiskMag ENGINE"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   32.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   765
         Left            =   2040
         MousePointer    =   99  'Custom
         TabIndex        =   5
         Top             =   240
         Width           =   5325
      End
   End
   Begin ComctlLib.ProgressBar ProgressBar1 
      Height          =   615
      Left            =   1320
      TabIndex        =   16
      Top             =   5040
      Width           =   7215
      _ExtentX        =   12726
      _ExtentY        =   1085
      _Version        =   327682
      Appearance      =   1
      MousePointer    =   99
      Max             =   10
   End
   Begin VB.Label StatCon 
      AutoSize        =   -1  'True
      Caption         =   "@@@"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   120
      TabIndex        =   15
      Top             =   4200
      Width           =   555
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    CenterForm Me
    Me.MousePointer = 99
    Me.MouseIcon = Me.MouseIcon
    lblVersion.Caption = "Verze " & App.Major & "." & App.Minor
    StatCon.Caption = ""
End Sub

Private Sub Form_Unload(Cancel As Integer)
Me.MousePointer = vbDefault
End Sub



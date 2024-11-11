<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Panel1 = New Panel()
        btnClose = New Button()
        btnSave = New Button()
        CheckBoxDeactive = New CheckBox()
        CheckBoxActive = New CheckBox()
        txtPtType = New TextBox()
        Label2 = New Label()
        btnUpdate = New Button()
        btnNew = New Button()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 42)
        Label1.TabIndex = 0
        Label1.Text = "Patient Type"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(186), CByte(231), CByte(254))
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(CheckBoxDeactive)
        Panel1.Controls.Add(CheckBoxActive)
        Panel1.Controls.Add(txtPtType)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnNew)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(15, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 632)
        Panel1.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.DarkOrange
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.ForeColor = SystemColors.ButtonHighlight
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(159, 568)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(149, 61)
        btnClose.TabIndex = 13
        btnClose.Text = "Close"
        btnClose.TextAlign = ContentAlignment.MiddleRight
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DarkOrange
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = SystemColors.ButtonHighlight
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(4, 568)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(149, 61)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxDeactive
        ' 
        CheckBoxDeactive.AutoSize = True
        CheckBoxDeactive.BackColor = Color.FromArgb(CByte(186), CByte(231), CByte(254))
        CheckBoxDeactive.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxDeactive.ForeColor = Color.DarkMagenta
        CheckBoxDeactive.Location = New Point(158, 88)
        CheckBoxDeactive.Name = "CheckBoxDeactive"
        CheckBoxDeactive.Size = New Size(95, 23)
        CheckBoxDeactive.TabIndex = 11
        CheckBoxDeactive.Text = "Deactive"
        CheckBoxDeactive.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxActive
        ' 
        CheckBoxActive.AutoSize = True
        CheckBoxActive.BackColor = Color.FromArgb(CByte(186), CByte(231), CByte(254))
        CheckBoxActive.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxActive.ForeColor = Color.DarkMagenta
        CheckBoxActive.Location = New Point(31, 88)
        CheckBoxActive.Name = "CheckBoxActive"
        CheckBoxActive.Size = New Size(78, 23)
        CheckBoxActive.TabIndex = 10
        CheckBoxActive.Text = "Active"
        CheckBoxActive.UseVisualStyleBackColor = False
        ' 
        ' txtPtType
        ' 
        txtPtType.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtPtType.ForeColor = Color.DeepPink
        txtPtType.Location = New Point(4, 34)
        txtPtType.Name = "txtPtType"
        txtPtType.Size = New Size(303, 27)
        txtPtType.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkMagenta
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 8
        Label2.Text = "Patient Type"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.DarkOrange
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = SystemColors.ButtonHighlight
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(158, 501)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(149, 61)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.DarkOrange
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.ForeColor = SystemColors.ButtonHighlight
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageAlign = ContentAlignment.MiddleLeft
        btnNew.Location = New Point(3, 501)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(149, 61)
        btnNew.TabIndex = 6
        btnNew.Text = "New"
        btnNew.TextAlign = ContentAlignment.MiddleRight
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(186), CByte(231), CByte(254))
        Panel2.Controls.Add(DataGridView1)
        Panel2.ForeColor = SystemColors.ControlText
        Panel2.Location = New Point(336, 58)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(824, 632)
        Panel2.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(186), CByte(231), CByte(254))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(824, 545)
        DataGridView1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(102))
        ClientSize = New Size(1172, 715)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        ForeColor = Color.White
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents CheckBoxDeactive As CheckBox
    Friend WithEvents CheckBoxActive As CheckBox
    Friend WithEvents txtPtType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class

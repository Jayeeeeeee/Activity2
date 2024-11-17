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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txt_Text = New TextBox()
        lbl_Text = New Label()
        lbl_Shift = New Label()
        cmb_Actions = New ComboBox()
        lbl_Actions = New Label()
        GroupBox1 = New GroupBox()
        dgv_Results = New DataGridView()
        btn_Process = New Button()
        txt_Secret = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgv_Results, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_Text
        ' 
        txt_Text.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_Text.BackColor = SystemColors.Window
        txt_Text.ForeColor = SystemColors.WindowText
        txt_Text.Location = New Point(111, 31)
        txt_Text.Name = "txt_Text"
        txt_Text.Size = New Size(239, 23)
        txt_Text.TabIndex = 1
        ' 
        ' lbl_Text
        ' 
        lbl_Text.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Text.AutoSize = True
        lbl_Text.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Text.Location = New Point(6, 31)
        lbl_Text.Name = "lbl_Text"
        lbl_Text.Size = New Size(46, 23)
        lbl_Text.TabIndex = 2
        lbl_Text.Text = "Text"
        ' 
        ' lbl_Shift
        ' 
        lbl_Shift.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Shift.AutoSize = True
        lbl_Shift.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Shift.Location = New Point(6, 60)
        lbl_Shift.Name = "lbl_Shift"
        lbl_Shift.Size = New Size(98, 23)
        lbl_Shift.TabIndex = 2
        lbl_Shift.Text = "Secret Key"
        ' 
        ' cmb_Actions
        ' 
        cmb_Actions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmb_Actions.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Actions.Items.AddRange(New Object() {"", "Encrypt", "Decrypt"})
        cmb_Actions.Location = New Point(110, 89)
        cmb_Actions.Name = "cmb_Actions"
        cmb_Actions.Size = New Size(240, 23)
        cmb_Actions.TabIndex = 3
        ' 
        ' lbl_Actions
        ' 
        lbl_Actions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Actions.AutoSize = True
        lbl_Actions.Font = New Font("Berlin Sans FB", 14.5F)
        lbl_Actions.Location = New Point(6, 89)
        lbl_Actions.Name = "lbl_Actions"
        lbl_Actions.Size = New Size(68, 23)
        lbl_Actions.TabIndex = 2
        lbl_Actions.Text = "Actions"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(dgv_Results)
        GroupBox1.Controls.Add(btn_Process)
        GroupBox1.Controls.Add(cmb_Actions)
        GroupBox1.Controls.Add(txt_Secret)
        GroupBox1.Controls.Add(txt_Text)
        GroupBox1.Controls.Add(lbl_Text)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbl_Actions)
        GroupBox1.Controls.Add(lbl_Shift)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(356, 408)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' dgv_Results
        ' 
        dgv_Results.AllowUserToAddRows = False
        dgv_Results.AllowUserToDeleteRows = False
        dgv_Results.AllowUserToResizeColumns = False
        dgv_Results.AllowUserToResizeRows = False
        dgv_Results.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_Results.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Results.Location = New Point(6, 183)
        dgv_Results.Name = "dgv_Results"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv_Results.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv_Results.RowHeadersVisible = False
        dgv_Results.RowHeadersWidth = 51
        dgv_Results.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Results.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgv_Results.Size = New Size(344, 219)
        dgv_Results.TabIndex = 5
        dgv_Results.TabStop = False
        ' 
        ' btn_Process
        ' 
        btn_Process.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_Process.Font = New Font("Berlin Sans FB", 10.0F)
        btn_Process.Location = New Point(6, 118)
        btn_Process.Name = "btn_Process"
        btn_Process.Size = New Size(344, 23)
        btn_Process.TabIndex = 4
        btn_Process.Text = "Process Text"
        btn_Process.UseVisualStyleBackColor = True
        ' 
        ' txt_Secret
        ' 
        txt_Secret.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_Secret.BackColor = SystemColors.Window
        txt_Secret.ForeColor = SystemColors.WindowText
        txt_Secret.Location = New Point(110, 60)
        txt_Secret.Name = "txt_Secret"
        txt_Secret.Size = New Size(239, 23)
        txt_Secret.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB", 12.0F)
        Label1.Location = New Point(1, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 18)
        Label1.TabIndex = 2
        Label1.Text = "Processed Text"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(380, 432)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Encryption & Decryption App"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgv_Results, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_Text As TextBox
    Friend WithEvents lbl_Text As Label
    Friend WithEvents lbl_Shift As Label
    Friend WithEvents cmb_Actions As ComboBox
    Friend WithEvents lbl_Actions As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Process As Button
    Friend WithEvents dgv_Results As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Secret As TextBox

End Class


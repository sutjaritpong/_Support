<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatementRV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStatementRV))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StatementDataSet = New SCANDB.StatementDataSet()
        Me.EXESMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EXESMTableAdapter = New SCANDB.StatementDataSetTableAdapters.EXESMTableAdapter()
        CType(Me.StatementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXESMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "StatementDataSet"
        ReportDataSource1.Value = Me.EXESMBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCANDB.ReportStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 718)
        Me.ReportViewer1.TabIndex = 0
        '
        'StatementDataSet
        '
        Me.StatementDataSet.DataSetName = "StatementDataSet"
        Me.StatementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EXESMBindingSource
        '
        Me.EXESMBindingSource.DataMember = "EXESM"
        Me.EXESMBindingSource.DataSource = Me.StatementDataSet
        '
        'EXESMTableAdapter
        '
        Me.EXESMTableAdapter.ClearBeforeFill = True
        '
        'FrmStatementRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStatementRV"
        Me.Text = "FrmStatementRV"
        CType(Me.StatementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXESMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EXESMBindingSource As BindingSource
    Friend WithEvents StatementDataSet As StatementDataSet
    Friend WithEvents EXESMTableAdapter As StatementDataSetTableAdapters.EXESMTableAdapter
End Class

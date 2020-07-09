<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmlogexeRV
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
        Me.Execution_logfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.logexe_dataset = New SCANDB.logexe_dataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Execution_logfilesTableAdapter = New SCANDB.logexe_datasetTableAdapters.Execution_logfilesTableAdapter()
        CType(Me.Execution_logfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logexe_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Execution_logfilesBindingSource
        '
        Me.Execution_logfilesBindingSource.DataMember = "Execution_logfiles"
        Me.Execution_logfilesBindingSource.DataSource = Me.logexe_dataset
        '
        'logexe_dataset
        '
        Me.logexe_dataset.DataSetName = "logexe_dataset"
        Me.logexe_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetLogexe"
        ReportDataSource1.Value = Me.Execution_logfilesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCANDB.Reportlogexe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1004, 703)
        Me.ReportViewer1.TabIndex = 0
        '
        'Execution_logfilesTableAdapter
        '
        Me.Execution_logfilesTableAdapter.ClearBeforeFill = True
        '
        'FrmlogexeRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmlogexeRV"
        Me.Text = "FrmlogexeRV"
        CType(Me.Execution_logfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logexe_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Execution_logfilesBindingSource As BindingSource
    Friend WithEvents logexe_dataset As logexe_dataset
    Friend WithEvents Execution_logfilesTableAdapter As logexe_datasetTableAdapters.Execution_logfilesTableAdapter
End Class

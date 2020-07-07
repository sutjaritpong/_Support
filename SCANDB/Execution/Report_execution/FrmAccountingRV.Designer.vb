<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccountingRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccountingRV))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SCANPDF = New SCANDB.SCANPDF()
        Me.EXEACCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EXEACCTableAdapter = New SCANDB.SCANPDFTableAdapters.EXEACCTableAdapter()
        CType(Me.SCANPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXEACCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSExecution_Accounting"
        ReportDataSource1.Value = Me.EXEACCBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCANDB.ReportAccounting.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 707)
        Me.ReportViewer1.TabIndex = 0
        '
        'SCANPDF
        '
        Me.SCANPDF.DataSetName = "SCANPDF"
        Me.SCANPDF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EXEACCBindingSource
        '
        Me.EXEACCBindingSource.DataMember = "EXEACC"
        Me.EXEACCBindingSource.DataSource = Me.SCANPDF
        '
        'EXEACCTableAdapter
        '
        Me.EXEACCTableAdapter.ClearBeforeFill = True
        '
        'FrmAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAccounting"
        Me.Text = "FrmAccounting"
        CType(Me.SCANPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXEACCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EXEACCBindingSource As BindingSource
    Friend WithEvents SCANPDF As SCANPDF
    Friend WithEvents EXEACCTableAdapter As SCANPDFTableAdapters.EXEACCTableAdapter
End Class

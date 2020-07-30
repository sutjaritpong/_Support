<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrackRV
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrackRV))
        Me.EXETRACKINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCANPDF = New SCANDB.SCANPDF()
        Me.EXEEMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOINTRACKEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JOINTRACKEMPTableAdapter = New SCANDB.SCANPDFTableAdapters.JOINTRACKEMPTableAdapter()
        Me.EXETRACKINGTableAdapter = New SCANDB.SCANPDFTableAdapters.EXETRACKINGTableAdapter()
        Me.EXEEMPLOYEETableAdapter = New SCANDB.SCANPDFTableAdapters.EXEEMPLOYEETableAdapter()
        CType(Me.EXETRACKINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCANPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXEEMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINTRACKEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EXETRACKINGBindingSource
        '
        Me.EXETRACKINGBindingSource.DataMember = "EXETRACKING"
        Me.EXETRACKINGBindingSource.DataSource = Me.SCANPDF
        '
        'SCANPDF
        '
        Me.SCANPDF.DataSetName = "SCANPDF"
        Me.SCANPDF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EXEEMPLOYEEBindingSource
        '
        Me.EXEEMPLOYEEBindingSource.DataMember = "EXEEMPLOYEE"
        Me.EXEEMPLOYEEBindingSource.DataSource = Me.SCANPDF
        '
        'JOINTRACKEMPBindingSource
        '
        Me.JOINTRACKEMPBindingSource.DataMember = "JOINTRACKEMP"
        Me.JOINTRACKEMPBindingSource.DataSource = Me.SCANPDF
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Datasettracking"
        ReportDataSource1.Value = Me.EXETRACKINGBindingSource
        ReportDataSource2.Name = "DataSetEmployee"
        ReportDataSource2.Value = Me.EXEEMPLOYEEBindingSource
        ReportDataSource3.Name = "DataSetTrackingJOINEmp"
        ReportDataSource3.Value = Me.JOINTRACKEMPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCANDB.Reporttracking.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1005, 708)
        Me.ReportViewer1.TabIndex = 0
        '
        'JOINTRACKEMPTableAdapter
        '
        Me.JOINTRACKEMPTableAdapter.ClearBeforeFill = True
        '
        'EXETRACKINGTableAdapter
        '
        Me.EXETRACKINGTableAdapter.ClearBeforeFill = True
        '
        'EXEEMPLOYEETableAdapter
        '
        Me.EXEEMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'FrmTrackRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTrackRV"
        Me.Text = "FrmTrackRV"
        CType(Me.EXETRACKINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCANPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXEEMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINTRACKEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SCANPDF As SCANPDF
    Friend WithEvents JOINTRACKEMPBindingSource As BindingSource
    Friend WithEvents JOINTRACKEMPTableAdapter As SCANPDFTableAdapters.JOINTRACKEMPTableAdapter
    Friend WithEvents EXETRACKINGBindingSource As BindingSource
    Friend WithEvents EXEEMPLOYEEBindingSource As BindingSource
    Friend WithEvents EXETRACKINGTableAdapter As SCANPDFTableAdapters.EXETRACKINGTableAdapter
    Friend WithEvents EXEEMPLOYEETableAdapter As SCANPDFTableAdapters.EXEEMPLOYEETableAdapter
End Class

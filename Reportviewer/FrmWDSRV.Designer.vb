﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWDSRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWDSRV))
        Me.EXEWDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCANPDFDataSet = New SCANDB.SCANPDFDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EXEWDSTableAdapter = New SCANDB.SCANPDFDataSetTableAdapters.EXEWDSTableAdapter()
        CType(Me.EXEWDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCANPDFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EXEWDSBindingSource
        '
        Me.EXEWDSBindingSource.DataMember = "EXEWDS"
        Me.EXEWDSBindingSource.DataSource = Me.SCANPDFDataSet
        '
        'SCANPDFDataSet
        '
        Me.SCANPDFDataSet.DataSetName = "SCANPDFDataSet"
        Me.SCANPDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Dataset_EXEWDS"
        ReportDataSource1.Value = Me.EXEWDSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCANDB.ReportWDS.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 729)
        Me.ReportViewer1.TabIndex = 0
        '
        'EXEWDSTableAdapter
        '
        Me.EXEWDSTableAdapter.ClearBeforeFill = True
        '
        'FrmWDSRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmWDSRV"
        Me.Text = "Report (รายงานถอนอายัด/ยึด)"
        CType(Me.EXEWDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCANPDFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EXEWDSBindingSource As BindingSource
    Friend WithEvents SCANPDFDataSet As SCANPDFDataSet
    Friend WithEvents EXEWDSTableAdapter As SCANPDFDataSetTableAdapters.EXEWDSTableAdapter
End Class

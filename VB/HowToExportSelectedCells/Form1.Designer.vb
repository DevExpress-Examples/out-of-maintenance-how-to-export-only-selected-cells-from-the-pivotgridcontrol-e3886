Namespace HowToExportSelectedCells
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo11 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo12 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.button1 = New System.Windows.Forms.Button()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 49)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(695, 349)
            Me.pivotGridControl1.TabIndex = 0
            '
            'excelDataSource1
            '
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            FieldInfo1.Name = "CategoryName"
            FieldInfo1.OriginalName = Nothing
            FieldInfo1.Type = GetType(String)
            FieldInfo2.Name = "Country"
            FieldInfo2.OriginalName = Nothing
            FieldInfo2.Type = GetType(String)
            FieldInfo3.Name = "FirstName"
            FieldInfo3.OriginalName = Nothing
            FieldInfo3.Type = GetType(String)
            FieldInfo4.Name = "LastName"
            FieldInfo4.OriginalName = Nothing
            FieldInfo4.Type = GetType(String)
            FieldInfo5.Name = "ProductName"
            FieldInfo5.OriginalName = Nothing
            FieldInfo5.Type = GetType(String)
            FieldInfo6.Name = "Sales Person"
            FieldInfo6.OriginalName = Nothing
            FieldInfo6.Type = GetType(String)
            FieldInfo7.Name = "OrderDate"
            FieldInfo7.OriginalName = Nothing
            FieldInfo7.Type = GetType(Date)
            FieldInfo8.Name = "OrderID"
            FieldInfo8.OriginalName = Nothing
            FieldInfo8.Type = GetType(Double)
            FieldInfo9.Name = "Quantity"
            FieldInfo9.OriginalName = Nothing
            FieldInfo9.Type = GetType(Double)
            FieldInfo10.Name = "Discount"
            FieldInfo10.OriginalName = Nothing
            FieldInfo10.Type = GetType(Double)
            FieldInfo11.Name = "Extended Price"
            FieldInfo11.OriginalName = Nothing
            FieldInfo11.Type = GetType(Double)
            FieldInfo12.Name = "UnitPrice"
            FieldInfo12.OriginalName = Nothing
            FieldInfo12.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10, FieldInfo11, FieldInfo12})
            ExcelWorksheetSettings1.CellRange = Nothing
            ExcelWorksheetSettings1.WorksheetIndex = Nothing
            ExcelWorksheetSettings1.WorksheetName = "Data"
            ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = ExcelSourceOptions1
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            DataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = DataSourceColumnBinding1
            Me.fieldCategoryName.Name = "fieldCategoryName"
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            DataSourceColumnBinding2.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = DataSourceColumnBinding2
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldSalesPerson
            '
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.Caption = "Sales Person"
            DataSourceColumnBinding3.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = DataSourceColumnBinding3
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding4.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding4
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(12, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(166, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Export Selected Cells to .XLSX"
            Me.button1.UseVisualStyleBackColor = True
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.button1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(695, 49)
            Me.panelControl1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(695, 398)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "How to Export Selected Cells"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace


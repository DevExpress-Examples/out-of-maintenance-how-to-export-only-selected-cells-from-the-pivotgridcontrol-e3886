Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace HowToExportSelectedCells
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private fileName As String = "Book1.xlsx"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim pivot As PivotGridControl = pivotGridControl1

			If pivot.Cells.Selection.IsEmpty Then
				pivotGridControl1.ExportToXlsx(fileName)
			Else
				Dim selection As Rectangle = pivot.Cells.Selection
				Dim fCell As Point = pivot.Cells.FocusedCell
				pivot.Tag = selection
				AddHandler pivot.CustomFieldValueCells, AddressOf pivotGridControl1_CustomFieldValueCells
				Try
					pivot.RefreshData()
					pivot.ExportToXlsx(fileName)
				Finally
                    RemoveHandler pivot.CustomFieldValueCells, AddressOf pivotGridControl1_CustomFieldValueCells
                    pivot.RefreshData()
					pivot.Cells.FocusedCell = fCell
					pivot.Cells.Selection = selection
				End Try
			End If

			System.Diagnostics.Process.Start(fileName)
		End Sub

		Private Sub pivotGridControl1_CustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
			Dim pivot As PivotGridControl = DirectCast(sender, PivotGridControl)
			Dim selection As Rectangle = DirectCast(pivot.Tag, Rectangle)
			RemoveUnselectedCells(e, False, selection.Top, selection.Bottom -1)
			RemoveUnselectedCells(e, True, selection.Left, selection.Right - 1)
		End Sub

		Private Sub RemoveUnselectedCells(ByVal e As PivotCustomFieldValueCellsEventArgs, ByVal isColumn As Boolean, ByVal minIndex As Integer, ByVal maxIndex As Integer)
			For i As Integer = e.GetCellCount(isColumn) - 1 To 0 Step -1
				Dim cell As FieldValueCell = e.GetCell(isColumn, i)
				If cell Is Nothing Then
					Continue For
				End If
				If minIndex > cell.MaxIndex OrElse maxIndex < cell.MinIndex Then
					e.Remove(cell)
				End If
			Next i
		End Sub
	End Class
End Namespace

using DevExpress.XtraPivotGrid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string fileName = "Book1.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
            this.customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            PivotGridControl pivot = pivotGridControl1 ;

            if (pivot.Cells.Selection.IsEmpty)
            {
                pivotGridControl1.ExportToXlsx(fileName);
            }
            else
            {
                Rectangle selection = pivot.Cells.Selection;
                Point fCell = pivot.Cells.FocusedCell;
                pivot.Tag = selection ;
                pivot.CustomFieldValueCells += pivotGridControl1_CustomFieldValueCells;
                try
                {
                    pivot.RefreshData();
                    pivot.ExportToXlsx(fileName);
                }
                finally {
                    pivot.CustomFieldValueCells -= pivotGridControl1_CustomFieldValueCells;
                    pivot.RefreshData();
                    pivot.Cells.FocusedCell = fCell;
                    pivot.Cells.Selection = selection;
                }
            }

            System.Diagnostics.Process.Start(fileName);
        }

        void pivotGridControl1_CustomFieldValueCells(object sender, PivotCustomFieldValueCellsEventArgs e)
        {
            PivotGridControl pivot = (PivotGridControl)sender;
            Rectangle selection = (Rectangle)pivot.Tag;
            RemoveUnselectedCells(e, false, selection.Top , selection.Bottom -1 );
            RemoveUnselectedCells(e, true, selection.Left , selection.Right - 1);
        }

        private void RemoveUnselectedCells(PivotCustomFieldValueCellsEventArgs e, bool isColumn, int minIndex, int maxIndex)
        {
            for (int i = e.GetCellCount( isColumn ) - 1; i >= 0; i--)
            {
                FieldValueCell cell = e.GetCell(isColumn, i);
                if (cell == null) continue;
                if (minIndex > cell.MaxIndex || maxIndex < cell.MinIndex)
                    e.Remove(cell);
            }
        }
    }
}

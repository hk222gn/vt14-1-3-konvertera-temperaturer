using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KonverteraTemperaturer.Model;

namespace KonverteraTemperaturer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //Tar värden från boxarna.
                int startTemp = int.Parse(StartTempTextBox.Text);
                int slutTemp = int.Parse(SlutTempTextBox.Text);
                int tempSteg = int.Parse(TempStegTextBox.Text);

                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell1 = new TableHeaderCell();
                TableHeaderCell cell2 = new TableHeaderCell();

                if (CelsiusRadioButton.Checked)
                {
                    cell1.Text = "&degC";
                    cell2.Text = "&degF";

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    TempTable.Rows.Add(row);

                    for (int i = startTemp; i <= slutTemp; i += tempSteg)
                    {
                        //Skapar en rad med två celler, sätter Text till rätt värden.
                        TableRow tableRow = new TableRow();
                        TableCell tableCell1 = new TableCell();
                        TableCell tableCell2 = new TableCell();

                        tableCell1.Text = string.Format("{0}", i);
                        tableCell2.Text = string.Format("{0}", TemperatureConverter.CelsiusToFahrenheit(i));

                        tableRow.Cells.Add(tableCell1);
                        tableRow.Cells.Add(tableCell2);
                        TempTable.Rows.Add(tableRow);
                    }
                }
                else if (FahrenheitRadioButton.Checked)
                {
                    cell1.Text = "&degF";
                    cell2.Text = "&degC";

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    TempTable.Rows.Add(row);

                    for (int i = startTemp; i <= slutTemp; i += tempSteg)
                    {
                        TableRow tableRow = new TableRow();
                        TableCell tableCell1 = new TableCell();
                        TableCell tableCell2 = new TableCell();

                        tableCell1.Text = string.Format("{0}", i);
                        tableCell2.Text = string.Format("{0}", TemperatureConverter.FahrenheitToCelsius(i));

                        tableRow.Cells.Add(tableCell1);
                        tableRow.Cells.Add(tableCell2);
                        TempTable.Rows.Add(tableRow);
                    }
                }
                TempTable.Visible = true;
            }
        }
    }
}
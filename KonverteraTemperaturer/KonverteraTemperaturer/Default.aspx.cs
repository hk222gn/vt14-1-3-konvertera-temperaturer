using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

                if (CelsiusRadioButton.Checked)
                {
                    //Skapar headers.
                    TableHeaderRow celsiusHeaderRow = new TableHeaderRow();
                    TableHeaderCell celsiusHeaderCell= new TableHeaderCell();
                    TableHeaderCell fahrenheitHeaderCell = new TableHeaderCell();

                    celsiusHeaderCell.Text = "&degC";
                    fahrenheitHeaderCell.Text = "&degF";

                    celsiusHeaderRow.Cells.Add(celsiusHeaderCell);
                    celsiusHeaderRow.Cells.Add(fahrenheitHeaderCell);
                    TempTable.Rows.Add(celsiusHeaderRow);

                    for (int i = startTemp; i <= slutTemp; i += tempSteg)
                    {
                        //Skapar en rad med två celler, sätter Text till rätt värden.
                        TableRow tableRow = new TableRow();
                        TableCell tableCell1 = new TableCell();
                        TableCell tableCell2 = new TableCell();

                        tableCell1.Text = string.Format("{0}", i);
                        tableCell2.Text = string.Format("{0}", Model.TemperatureConverter.CelsiusToFahrenheit(i));

                        tableRow.Cells.Add(tableCell1);
                        tableRow.Cells.Add(tableCell2);
                        TempTable.Rows.Add(tableRow);
                    }
                }
                else if (FahrenheitRadioButton.Checked)
                {
                    TableHeaderRow fahrenheitHeaderRow = new TableHeaderRow();
                    TableHeaderCell celsiusHeaderCell = new TableHeaderCell();
                    TableHeaderCell fahrenheitHeaderCell = new TableHeaderCell();

                    fahrenheitHeaderCell.Text = "&degF";
                    celsiusHeaderCell.Text = "&degC";

                    fahrenheitHeaderRow.Cells.Add(fahrenheitHeaderCell);
                    fahrenheitHeaderRow.Cells.Add(celsiusHeaderCell);
                    TempTable.Rows.Add(fahrenheitHeaderRow);

                    for (int i = startTemp; i <= slutTemp; i += tempSteg)
                    {
                        TableRow tableRow = new TableRow();
                        TableCell tableCell1 = new TableCell();
                        TableCell tableCell2 = new TableCell();

                        tableCell1.Text = string.Format("{0}", i);
                        tableCell2.Text = string.Format("{0}", Model.TemperatureConverter.FahrenheitToCelsius(i));

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
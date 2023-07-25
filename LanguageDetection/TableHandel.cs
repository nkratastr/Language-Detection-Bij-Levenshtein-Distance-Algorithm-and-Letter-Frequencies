using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDetection
{
    public class TableHandel
    {
        private DataGridView _dataGridViewLetterTable;
        private TextBox _textBoxInputText;


        public TableHandel(DataGridView dataGridView_LetterTAble, TextBox textBox_InputText)
        {
            _dataGridViewLetterTable = dataGridView_LetterTAble;
            _textBoxInputText = textBox_InputText;


        }

        public void ColorizeCellsByProximityToFrequency()
        {
            if (_dataGridViewLetterTable.Rows.Count < 2)
                return;

            double theFrequenctOfTheLetterInGiventext = 0;

            foreach (DataGridViewRow row in _dataGridViewLetterTable.Rows)
            {

                for (int columnIndex = 2; columnIndex < row.Cells.Count; columnIndex++)
                {
                    DataGridViewCell cell = row.Cells[columnIndex];
                    theFrequenctOfTheLetterInGiventext = Convert.ToDouble(row.Cells[1].Value);

                    double theFrequencyOfTheLetterOfTheLanguageInTheTable = Convert.ToDouble(cell.Value);

                    double percentageDifferenceBetweenGivenTextAndLanguage = Math.Abs((theFrequencyOfTheLetterOfTheLanguageInTheTable - theFrequenctOfTheLetterInGiventext) / theFrequenctOfTheLetterInGiventext);

                    if (columnIndex != 1 && percentageDifferenceBetweenGivenTextAndLanguage <= 0.1)
                    {

                        cell.Style.BackColor = Color.Green;
                        cell.Style.ForeColor = Color.White;
                    }

                    _textBoxInputText.AppendText(theFrequenctOfTheLetterInGiventext.ToString() + "  " + theFrequencyOfTheLetterOfTheLanguageInTheTable.ToString() + "   " + percentageDifferenceBetweenGivenTextAndLanguage.ToString() + "\r\n");


                }
            }

        }

        public void ColorizeCellsByNonUsedLettersInTheText()
            {
                if (_dataGridViewLetterTable.Rows.Count < 2)
                    return;

                double theFrequenctOfTheLetterInTheCell = 0;

                foreach (DataGridViewRow row in _dataGridViewLetterTable.Rows)
                {

                    for (int columnIndex = 1; columnIndex < row.Cells.Count; columnIndex++)
                    {
                        DataGridViewCell cell = row.Cells[columnIndex];


                        theFrequenctOfTheLetterInTheCell = Convert.ToDouble(cell.Value);


                        if ( theFrequenctOfTheLetterInTheCell == 0)
                        {

                            cell.Style.BackColor = Color.LightPink;
                            cell.Style.ForeColor = Color.Black;
                        }

                 

                    }
                }



        }

        



    } 
}

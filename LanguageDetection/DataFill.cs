using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageDetection
{
    public class DataFill
    {
        
        public void FillTheLetterTableTurkishAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
            
            for (int i = 0; i< _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheTurkishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                      _dataGridViewLetterTable.Rows[i].Cells[2].Value = variables.letterFrequenciesOfTheTurkishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
        }

        public void FillTheLetterTableEnglishAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
    
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheEnglishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                       _dataGridViewLetterTable.Rows[i].Cells[3].Value = variables.letterFrequenciesOfTheEnglishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
            
        }

        public void FillTheLetterTableSpanishAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {

            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheSpanishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                      _dataGridViewLetterTable.Rows[i].Cells[4].Value = variables.letterFrequenciesOfTheSpanishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }

        }

        public void FillTheLetterTableItalianAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheItalianAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[5].Value = variables.letterFrequenciesOfTheItalianAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
        }

        public void FillTheLetterTableGermanAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheGermanAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[6].Value = variables.letterFrequenciesOfTheGermanAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
        }

        public void FillTheLetterTableFrenchAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheFrenchAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[7].Value = variables.letterFrequenciesOfTheFrenchAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
        }

        public void FillTheLetterTableDutchAlphabetColumn(Variables variables, DataGridView _dataGridViewLetterTable)
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                // write if statement to prevent the error of out of range
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (variables.letterFrequenciesOfTheDutchAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[8].Value = variables.letterFrequenciesOfTheDutchAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                }
            }
        }






    }
}

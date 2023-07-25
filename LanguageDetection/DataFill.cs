using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LanguageDetection
{
    public class DataFill
    {

        private readonly DataGridView _dataGridViewLetterTable;
        private Variables _variables;

        public  DataFill(Variables variables, DataGridView dataGridView_LetterTable)
        {
            _dataGridViewLetterTable = dataGridView_LetterTable;
            _variables = variables; 
        }

        public void CreateAndWriteTheWholeAlphabetAndTheCountsofLettersToLetterTable()

        {
            _dataGridViewLetterTable.DataSource = _variables.totalFrequenciesofLettersinInputText.ToList();

        }

        public void CreateTheTurkishEnglishGermanSpanishDutchAlphabetColumns()
        {
            _dataGridViewLetterTable.Columns[0].HeaderText = "Letters";
            _dataGridViewLetterTable.Columns[1].HeaderText = "Frequency";
            _dataGridViewLetterTable.Columns.Add("Turkish", "Turkish");
            _dataGridViewLetterTable.Columns.Add("English", "English");
            _dataGridViewLetterTable.Columns.Add("Spanish", "Spanish");
            _dataGridViewLetterTable.Columns.Add("Italian", "Italian");
            _dataGridViewLetterTable.Columns.Add("German", "German");
            _dataGridViewLetterTable.Columns.Add("French", "French");
            _dataGridViewLetterTable.Columns.Add("Dutch", "Dutch");
        }



        public void FillTheLetterTableTurkishAlphabetColumn()
        {
            
            for (int i = 0; i< _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheTurkishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                      _dataGridViewLetterTable.Rows[i].Cells[2].Value = _variables.letterFrequenciesOfTheTurkishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[2].Value = 0;
                    }
                }
            }
        }

        public void FillTheLetterTableEnglishAlphabetColumn()
        {
    
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheEnglishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                       _dataGridViewLetterTable.Rows[i].Cells[3].Value = _variables.letterFrequenciesOfTheEnglishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[3].Value = 0;
                    }
                }
            }
            
        }

        public void FillTheLetterTableSpanishAlphabetColumn()
        {

            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheSpanishAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                      _dataGridViewLetterTable.Rows[i].Cells[4].Value = _variables.letterFrequenciesOfTheSpanishAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[4].Value = 0;
                    }
                }
            }

        }

        public void FillTheLetterTableItalianAlphabetColumn()
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheItalianAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[5].Value = _variables.letterFrequenciesOfTheItalianAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[5].Value = 0;
                    }
                }
            }
        }

        public void FillTheLetterTableGermanAlphabetColumn()
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if ( _variables.letterFrequenciesOfTheGermanAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[6].Value = _variables.letterFrequenciesOfTheGermanAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[6].Value = 0;
                    }
                }
            }
        }

        public void FillTheLetterTableFrenchAlphabetColumn()
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheFrenchAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                     _dataGridViewLetterTable.Rows[i].Cells[7].Value = _variables.letterFrequenciesOfTheFrenchAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[7].Value = 0;
                    }
                }
            }
        }

        public void FillTheLetterTableDutchAlphabetColumn()
        {
            for (int i = 0; i < _dataGridViewLetterTable.Rows.Count; i++)
            {
                
                if (_dataGridViewLetterTable.Rows[i].Cells[0].Value != null)
                {
                    if (_variables.letterFrequenciesOfTheDutchAlphabet.ContainsKey(Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)))
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[8].Value = _variables.letterFrequenciesOfTheDutchAlphabet[Convert.ToChar(_dataGridViewLetterTable.Rows[i].Cells[0].Value)];
                    }
                    else
                    {
                        _dataGridViewLetterTable.Rows[i].Cells[8].Value = 0;
                    }
                }
            }
            _dataGridViewLetterTable.Refresh();
            _dataGridViewLetterTable.AutoResizeColumns();
            _dataGridViewLetterTable.AutoResizeColumnHeadersHeight();

        }





    }
}

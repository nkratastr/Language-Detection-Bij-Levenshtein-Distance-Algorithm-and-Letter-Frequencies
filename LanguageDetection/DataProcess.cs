using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDetection
{
    public class DataProcess
    {
        private TextBox _textBoxInputText;
        private Variables _variables;

        public DataProcess(Variables variables, TextBox textBox_InputText) 
        {
            _textBoxInputText = textBox_InputText;
            this._variables = variables;
            _variables.inputText = _textBoxInputText.Text.ToUpper();
        }    

        public void ReplacetheCharachtersOutOfLettersInTheInputText()
        {
            _variables.inputText = _variables.inputText.Replace(" ", "");
            _variables.inputText = _variables.inputText.Replace("\r", "");
            _variables.inputText = _variables.inputText.Replace("\t", "");
            _variables.inputText = _variables.inputText.Replace("\n", "");
            _variables.inputText = _variables.inputText.Replace(".", "");
        }


        public void FilterAndDisplayValidCharactersOfInputText()
        {
            char[] charArray = _variables.inputText.ToCharArray();
            _variables.inputTextArray.AddRange(charArray);

            _textBoxInputText.Text = "";

            foreach (char c in _variables.inputTextArray)
            {
                if (_variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(c))
                {
                    _textBoxInputText.Text += c;
                }
                Application.DoEvents();
            }
        }

        public void CountAlltheLettersInInputText()
        {
            foreach (var chr in _variables.inputTextArray)
            {
                if (_variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(chr))
                {
                    _variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets[chr]++;
                }

                Application.DoEvents();
            }
        }

        public void CalculateTheFrequenciesOfTheLettersInInputText()
        {
            double frequenciesofTheLettersinInputText = new double();
            _textBoxInputText.Text += "\r\n";
            foreach (var kvp in _variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets)
            {
                frequenciesofTheLettersinInputText = ((double)kvp.Value / _variables.inputTextArray.Count) * 100;
                _variables.totalFrequenciesofLettersinInputText[kvp.Key] = Math.Round(frequenciesofTheLettersinInputText, 2);
                _textBoxInputText.Text += kvp.Key.ToString() + "---->" + _variables.totalFrequenciesofLettersinInputText[kvp.Key] + "\r\n";
                Application.DoEvents();

            }
        }

    }
}

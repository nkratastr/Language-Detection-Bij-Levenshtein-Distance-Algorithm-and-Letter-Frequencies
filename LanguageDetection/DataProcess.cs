using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDetection
{
    public class DataProcess
    {

        public void ReplacetheCharachtersOutOfLettersInTheInputText(Variables variables)
        {
            variables.inputText = variables.inputText.Replace(" ", "");
            variables.inputText = variables.inputText.Replace("\r", "");
            variables.inputText = variables.inputText.Replace("\t", "");
            variables.inputText = variables.inputText.Replace("\n", "");
            variables.inputText = variables.inputText.Replace(".", "");
        }

        public void CountAlltheLettersInInputText(Variables variables)
        {
            foreach (var chr in variables.inputTextArray)
            {
                if (variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(chr))
                {
                    variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets[chr]++;
                }

                Application.DoEvents();
            }
        }

        public void CalculateTheFrequenciesOfTheLettersInInputText(Variables variables)
        {
            double frequenciesofTheLettersinInputText = new double();
            //textBox_InputText.Text += "\r\n";
            foreach (var kvp in variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets)
            {
                frequenciesofTheLettersinInputText = ((double)kvp.Value / variables.inputTextArray.Count) * 100;
                variables.totalFrequenciesofLettersinInputText[kvp.Key] = Math.Round(frequenciesofTheLettersinInputText, 2);
                //textBox_InputText.Text += kvp.Key.ToString() + "---->" + variables.totalFrequenciesofLettersinInputText[kvp.Key] + "\r\n";
                Application.DoEvents();

            }
        }










    }
}

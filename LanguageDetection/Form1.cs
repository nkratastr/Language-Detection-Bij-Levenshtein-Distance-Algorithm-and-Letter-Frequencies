using System.Drawing.Text;
using System.Linq;

namespace LanguageDetection
{


    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button_StarttheProcess_Click(object sender, EventArgs e)
        {

            Variables variables = new();
            DataProcess dataProcess = new DataProcess(variables, textBox_InputText);
            DataFill dataFill = new DataFill(variables, dataGridView_LetterTable);
           

            dataProcess.ReplacetheCharachtersOutOfLettersInTheInputText();

            dataProcess.FilterAndDisplayValidCharactersOfInputText();

            dataProcess.CountAlltheLettersInInputText();

            dataProcess.CalculateTheFrequenciesOfTheLettersInInputText();


            dataFill.CreateAndWriteTheWholeAlphabetAndTheCountsofLettersToLetterTable();

            dataFill.CreateTheTurkishEnglishGermanSpanishDutchAlphabetColumns();

            dataFill.FillTheLetterTableTurkishAlphabetColumn();

            dataFill.FillTheLetterTableEnglishAlphabetColumn();

            dataFill.FillTheLetterTableSpanishAlphabetColumn();

            dataFill.FillTheLetterTableItalianAlphabetColumn();

            dataFill.FillTheLetterTableGermanAlphabetColumn();

            dataFill.FillTheLetterTableFrenchAlphabetColumn();

            dataFill.FillTheLetterTableDutchAlphabetColumn();



        }

    }
}
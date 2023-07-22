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
            DataProcess dataProcess = new();
            DataFill dataFill = new DataFill();
            
           

            variables.inputText = textBox_InputText.Text.ToUpper();

            dataProcess.ReplacetheCharachtersOutOfLettersInTheInputText(variables);

            FilterAndDisplayValidCharactersOfInputText(variables);

            dataProcess.CountAlltheLettersInInputText(variables);

            dataProcess.CalculateTheFrequenciesOfTheLettersInInputText(variables);

            CreateAndWriteTheWholeAlphabetAndTheCountsofLettersToLetterTable(variables);
            CreateTheTurkishEnglishGermanSpanishDutchAlphabetColumns();


            
            //refresh the datagridview
            dataGridView_LetterTable.Refresh();



            dataFill.FillTheLetterTableTurkishAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableEnglishAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableSpanishAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableItalianAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableGermanAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableFrenchAlphabetColumn(variables, dataGridView_LetterTable);

            dataFill.FillTheLetterTableDutchAlphabetColumn(variables, dataGridView_LetterTable);

            dataGridView_LetterTable.AutoResizeColumns();


            void CreateAndWriteTheWholeAlphabetAndTheCountsofLettersToLetterTable(Variables variables)

            {
                dataGridView_LetterTable.DataSource = variables.totalFrequenciesofLettersinInputText.ToList();

            }

            void CreateTheTurkishEnglishGermanSpanishDutchAlphabetColumns()
            {
                dataGridView_LetterTable.Columns[0].HeaderText = "Letters";
                dataGridView_LetterTable.Columns[1].HeaderText = "Frequency";
                dataGridView_LetterTable.Columns.Add("Turkish", "Turkish");
                dataGridView_LetterTable.Columns.Add("English", "English");
                dataGridView_LetterTable.Columns.Add("Spanish", "Spanish");
                dataGridView_LetterTable.Columns.Add("Italian", "Italian");
                dataGridView_LetterTable.Columns.Add("German", "German");
                dataGridView_LetterTable.Columns.Add("French", "French");
                dataGridView_LetterTable.Columns.Add("Dutch", "Dutch");
            }


        }

        private void FilterAndDisplayValidCharactersOfInputText(Variables variables)
        {
            char[] charArray = variables.inputText.ToCharArray();
            variables.inputTextArray.AddRange(charArray);

            textBox_InputText.Text = "";

            foreach (char c in variables.inputTextArray)
            {
                if (variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(c))
                {
                    textBox_InputText.Text += c;
                }
                Application.DoEvents();
            }
        }







    }
}
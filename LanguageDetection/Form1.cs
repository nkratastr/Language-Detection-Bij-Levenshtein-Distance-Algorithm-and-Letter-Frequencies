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

            Variables variables= new Variables();

            variables.inputText = textBox_InputText.Text.ToUpper();
            
            variables.inputText = variables.inputText.Replace(" ", "");
            variables.inputText = variables.inputText.Replace("\r", "");
            variables.inputText = variables.inputText.Replace("\t", "");
            variables.inputText = variables.inputText.Replace("\n", "");
            variables.inputText = variables.inputText.Replace(".", "");

            

            char[] charArray = variables.inputText.ToCharArray();
            variables.inputTextArray.AddRange(charArray);

            textBox_InputText.Text = "";

            foreach (char c in variables.inputTextArray)
            {
                if (variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(c))
                {
                    textBox_InputText.Text += c;
                }
                
            }

            foreach (char chr in variables.inputTextArray)
            {

                if (variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets.ContainsKey(chr))
                {

                    variables.totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets[chr]++;

                }




            }

           



        }
   
    
    
    
    
    }
}
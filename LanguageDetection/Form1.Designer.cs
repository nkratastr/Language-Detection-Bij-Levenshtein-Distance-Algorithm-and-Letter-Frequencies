namespace LanguageDetection
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_InputText = new TextBox();
            dataGridView_LetterTable = new DataGridView();
            button_StarttheProcess = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LetterTable).BeginInit();
            SuspendLayout();
            // 
            // textBox_InputText
            // 
            textBox_InputText.Location = new Point(27, 16);
            textBox_InputText.Margin = new Padding(3, 4, 3, 4);
            textBox_InputText.Multiline = true;
            textBox_InputText.Name = "textBox_InputText";
            textBox_InputText.ScrollBars = ScrollBars.Vertical;
            textBox_InputText.Size = new Size(533, 369);
            textBox_InputText.TabIndex = 0;
            // 
            // dataGridView_LetterTable
            // 
            dataGridView_LetterTable.AllowUserToOrderColumns = true;
            dataGridView_LetterTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LetterTable.Location = new Point(589, 16);
            dataGridView_LetterTable.Margin = new Padding(3, 4, 3, 4);
            dataGridView_LetterTable.Name = "dataGridView_LetterTable";
            dataGridView_LetterTable.RowHeadersWidth = 51;
            dataGridView_LetterTable.RowTemplate.Height = 25;
            dataGridView_LetterTable.Size = new Size(841, 371);
            dataGridView_LetterTable.TabIndex = 1;
            // 
            // button_StarttheProcess
            // 
            button_StarttheProcess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_StarttheProcess.Location = new Point(27, 412);
            button_StarttheProcess.Margin = new Padding(3, 4, 3, 4);
            button_StarttheProcess.Name = "button_StarttheProcess";
            button_StarttheProcess.Size = new Size(157, 81);
            button_StarttheProcess.TabIndex = 2;
            button_StarttheProcess.Text = "Start Process";
            button_StarttheProcess.UseVisualStyleBackColor = true;
            button_StarttheProcess.Click += button_StarttheProcess_Click;
            // 
            // main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 741);
            Controls.Add(button_StarttheProcess);
            Controls.Add(dataGridView_LetterTable);
            Controls.Add(textBox_InputText);
            Name = "main_form";
            Text = "Language Detector";
            ((System.ComponentModel.ISupportInitialize)dataGridView_LetterTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_InputText;
        private DataGridView dataGridView_LetterTable;
        private Button button_StarttheProcess;
    }
}
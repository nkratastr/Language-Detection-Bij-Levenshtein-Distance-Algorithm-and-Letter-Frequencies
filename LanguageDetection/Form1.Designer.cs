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
            this.textBox_InputText = new System.Windows.Forms.TextBox();
            this.dataGridView_LetterTable = new System.Windows.Forms.DataGridView();
            this.button_StarttheProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LetterTable)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_InputText
            // 
            this.textBox_InputText.Location = new System.Drawing.Point(27, 16);
            this.textBox_InputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_InputText.Multiline = true;
            this.textBox_InputText.Name = "textBox_InputText";
            this.textBox_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_InputText.Size = new System.Drawing.Size(533, 369);
            this.textBox_InputText.TabIndex = 0;
            // 
            // dataGridView_LetterTable
            // 
            this.dataGridView_LetterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LetterTable.Location = new System.Drawing.Point(589, 16);
            this.dataGridView_LetterTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_LetterTable.Name = "dataGridView_LetterTable";
            this.dataGridView_LetterTable.RowHeadersWidth = 51;
            this.dataGridView_LetterTable.RowTemplate.Height = 25;
            this.dataGridView_LetterTable.Size = new System.Drawing.Size(639, 371);
            this.dataGridView_LetterTable.TabIndex = 1;
            // 
            // button_StarttheProcess
            // 
            this.button_StarttheProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_StarttheProcess.Location = new System.Drawing.Point(27, 412);
            this.button_StarttheProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_StarttheProcess.Name = "button_StarttheProcess";
            this.button_StarttheProcess.Size = new System.Drawing.Size(157, 81);
            this.button_StarttheProcess.TabIndex = 2;
            this.button_StarttheProcess.Text = "Start Process";
            this.button_StarttheProcess.UseVisualStyleBackColor = true;
            this.button_StarttheProcess.Click += new System.EventHandler(this.button_StarttheProcess_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 741);
            this.Controls.Add(this.button_StarttheProcess);
            this.Controls.Add(this.dataGridView_LetterTable);
            this.Controls.Add(this.textBox_InputText);
            this.Name = "main_form";
            this.Text = "Language Detector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LetterTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_InputText;
        private DataGridView dataGridView_LetterTable;
        private Button button_StarttheProcess;
    }
}
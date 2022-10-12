namespace Oefening
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_String = new System.Windows.Forms.TextBox();
            this.button_Toevoegen = new System.Windows.Forms.Button();
            this.button_Verwijderen = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_aanwezigheid = new System.Windows.Forms.Button();
            this.button_Leegmaken = new System.Windows.Forms.Button();
            this.label_stringText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox_String
            // 
            this.textBox_String.Location = new System.Drawing.Point(89, 69);
            this.textBox_String.Name = "textBox_String";
            this.textBox_String.Size = new System.Drawing.Size(100, 23);
            this.textBox_String.TabIndex = 6;
            // 
            // button_Toevoegen
            // 
            this.button_Toevoegen.Location = new System.Drawing.Point(89, 98);
            this.button_Toevoegen.Name = "button_Toevoegen";
            this.button_Toevoegen.Size = new System.Drawing.Size(75, 23);
            this.button_Toevoegen.TabIndex = 7;
            this.button_Toevoegen.Text = "Toevoegen ";
            this.button_Toevoegen.UseVisualStyleBackColor = true;
            this.button_Toevoegen.Click += new System.EventHandler(this.button_Toevoegen_Click);
            // 
            // button_Verwijderen
            // 
            this.button_Verwijderen.Location = new System.Drawing.Point(89, 122);
            this.button_Verwijderen.Name = "button_Verwijderen";
            this.button_Verwijderen.Size = new System.Drawing.Size(75, 23);
            this.button_Verwijderen.TabIndex = 8;
            this.button_Verwijderen.Text = "Verwijderen";
            this.button_Verwijderen.UseVisualStyleBackColor = true;
            // 
            // button_Copy
            // 
            this.button_Copy.Location = new System.Drawing.Point(89, 209);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 23);
            this.button_Copy.TabIndex = 9;
            this.button_Copy.Text = "Copy ";
            this.button_Copy.UseVisualStyleBackColor = true;
            // 
            // button_aanwezigheid
            // 
            this.button_aanwezigheid.Location = new System.Drawing.Point(89, 180);
            this.button_aanwezigheid.Name = "button_aanwezigheid";
            this.button_aanwezigheid.Size = new System.Drawing.Size(75, 23);
            this.button_aanwezigheid.TabIndex = 10;
            this.button_aanwezigheid.Text = "aanwezigheid ";
            this.button_aanwezigheid.UseVisualStyleBackColor = true;
            // 
            // button_Leegmaken
            // 
            this.button_Leegmaken.Location = new System.Drawing.Point(89, 151);
            this.button_Leegmaken.Name = "button_Leegmaken";
            this.button_Leegmaken.Size = new System.Drawing.Size(75, 23);
            this.button_Leegmaken.TabIndex = 11;
            this.button_Leegmaken.Text = "Leegmaken";
            this.button_Leegmaken.UseVisualStyleBackColor = true;
            // 
            // label_stringText
            // 
            this.label_stringText.AutoSize = true;
            this.label_stringText.Location = new System.Drawing.Point(89, 310);
            this.label_stringText.Name = "label_stringText";
            this.label_stringText.Size = new System.Drawing.Size(38, 15);
            this.label_stringText.TabIndex = 13;
            this.label_stringText.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_stringText);
            this.Controls.Add(this.button_Leegmaken);
            this.Controls.Add(this.button_aanwezigheid);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Verwijderen);
            this.Controls.Add(this.button_Toevoegen);
            this.Controls.Add(this.textBox_String);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_String;
        private Button button_Toevoegen;
        private Button button_Verwijderen;
        private Button button_Copy;
        private Button button_aanwezigheid;
        private Button button_Leegmaken;
        private Label label_stringText;
    }
}
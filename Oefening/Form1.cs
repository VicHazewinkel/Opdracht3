namespace Oefening
{
    public partial class Form1 : Form
    {
        // stapels
        private Stapel<string> stapel_String = new  Stapel<string>();
        private Stapel<int> stapel_Int = new Stapel<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_StapelString_Toevoegen_Click(object sender, EventArgs e)
        {
            stapel_String.Toevoegen(textBox_String.Text); 
            label_stringText.Text = stapel_String.ToString();   
        }

        private void button_StapelString_Verwijderen_Click(object sender, EventArgs e)
        {
            if(stapel_String.ToString() != String.Empty)
            {
                stapel_String.Verwijderen(); 
            } 
        }

        private void button_StapelString_leegmaken_Click(object sender, EventArgs e)
        {
            
        }

        private void button_StapelString_aanwezigheid_Click(object sender, EventArgs e)
        {

        }

        private void button_StapelString_copy_Click(object sender, EventArgs e)
        {

        }
    }
}
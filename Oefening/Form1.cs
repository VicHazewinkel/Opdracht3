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
            stapel_String.Leegmaken(); 
        }

        private bool isHetCijfer(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
                        
            }
            return true; 
        }

        private void button_StapelString_aanwezigheid_Click(object sender, EventArgs e)
        {
            string toon = "Fout!, verkeerde input"; 
            if (string.IsNullOrEmpty(label_aanwezig_recponce.Text) == false)
            {
                toon = textBox_String.Text + "Bestaat Niet"; 
                if (stapel_String.IsAanwezig(textBox_String.Text))
                {
                    toon = textBox_String.Text+ " bestaat al ";
                }
            }
            MessageBox.Show(toon);
        }

        private void button_StapelString_copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("werkt niet"); 

        }
    }
}
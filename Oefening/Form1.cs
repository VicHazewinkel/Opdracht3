namespace Oefening
{
    public partial class Form1 : Form
    {
        // stapels
        private Stapel<string> stapel_String = new  Stapel<string>();
        private Stapel<int> stapel_Int = new Stapel<int>();
        // Stapel<Dier> stapel_Dier = new Stapel<Dier>();
        public Form1()
        {
            InitializeComponent();
        }

        // _________________________ STRING _________________________

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
                MessageBox.Show("Item is verwijdert");
            } 
        }

        private void button_StapelString_leegmaken_Click(object sender, EventArgs e)
        {
            stapel_String.Leegmaken();
            MessageBox.Show("lijst is leeg gemaakt"); 
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
                toon = textBox_String.Text + " Bestaat Niet"; 
                if (stapel_String.IsAanwezig(textBox_String.Text))
                {
                    toon = textBox_String.Text+ " bestaat al ";
                }
            }
            MessageBox.Show(toon);
        }

        private void button_StapelString_copy_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("werkt niet");
            Stapel<string> newStapel_string = new Stapel<string>();
            newStapel_string = stapel_String.Copy();
            MessageBox.Show("er is een copy gemaakt van: " + stapel_String.ToString()); 

        }
        private void button_StapelString_ToString_Click(object sender, EventArgs e)
        {
            label_stringText.Text = stapel_String.ToString();
        }

        // _________________________ INT _________________________

        private void button_Stapel_INT_Toevoegen_Click(object sender, EventArgs e)
        {
            // stapel_String.Toevoegen(textBox_INT.Text);
            // label_INT_Text.Text = Convert.ToString(textBox_INT.Text);


            stapel_Int.Toevoegen(int.Parse(textBox_INT.Text));

            textBox_INT.Text = stapel_Int.ToString();
        }

        private void button_Stapel_INT_Verwijderen_Click(object sender, EventArgs e)
        {
            stapel_Int.Verwijderen();
            MessageBox.Show("Item is verwijdert");
        }

        private void button_Stapel_INT_leegmaken_Click(object sender, EventArgs e)
        {
            stapel_Int.Leegmaken();
            MessageBox.Show("lijst is leeg gemaakt");
        }

        private void button_Stapel_INT_aanwezigheid_Click(object sender, EventArgs e)
        {
            string toon = "Fout!, verkeerde input";
            if (string.IsNullOrWhiteSpace(textBox_INT.Text) == false && isHetCijfer(textBox_INT.Text)) ;
            {
                toon = int.Parse(textBox_INT.Text) + " Bestaat Niet";
                if (stapel_Int.IsAanwezig(int.Parse(textBox_INT.Text)))
                {
                   //  toon = int.Parse(textBox_INT.Text + " bestaat al ");
                }

            }
            // textBox_INT.Text = stapel_Int.IsAanwezig(int.Parse(textBox_INT.Text)).ToString();

        }

        private void button_Stapel_INT_copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("er is een copy gemaakt van: " + stapel_Int.ToString); 

        }

        private void button_Stapel_Int_ToString_Click(object sender, EventArgs e)
        {
            label_INT_Text.Text = Convert.ToString(textBox_INT.Text);
        }



        // _________________________ PERSOON _________________________
    }
}
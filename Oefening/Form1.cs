namespace Oefening
{
    public partial class Form1 : Form
    {
        private Stapel<string> stapel_String = new  Stapel<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button_Toevoegen_Click(object sender, EventArgs e)
        {
            stapel_String.Toevoegen(textBox_String.Text); 
            label_stringText.Text = stapel_String.ToString();   
        }
    }
}
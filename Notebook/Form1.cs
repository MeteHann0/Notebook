namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        string file = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                file = textBox1.Text + ".txt";
            else 
                file = "note.txt";

            if (richTextBox1.Text != "")
            {
                File.WriteAllText(file, richTextBox1.Text);
                MessageBox.Show("Your file has been saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is nothing to save!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                string saved_note = File.ReadAllText(file);
                richTextBox2.Text += "\n" + saved_note;
            }
            else
            {
                MessageBox.Show("You have no saved notes!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        
    }
}

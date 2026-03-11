namespace Modul3_103022400081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan Terlebih dahulu");
                return;
            }
            double nilai = Convert.ToDouble(textBox1.Text);
            string awal = comboBox1.SelectedItem.ToString();
            string akhir = comboBox2.SelectedItem.ToString();

            double celcius = 0;

            switch (awal)
            {
                case "Celcius":
                    celcius = nilai;
                    break;
                case "Fahrenheit":
                    celcius = (nilai = 32) * 5 / 9;
                    break;
                case "Kelvin":
                    celcius = nilai - 273.15;
                    break;
                case "Reamur":
                    celcius = nilai * 5 / 4;
                    break;
            }

            double hasil = 0;

            switch (akhir)
            {
                case "Celcius":
                    hasil = celcius;
                    break;
                case "Fahrenheit":
                    hasil = (celcius * 9 / 5) + 32;
                    break;
                case "Kelvin":
                    hasil = celcius + 273.15;
                    break;
                case "Reamur":
                    hasil = celcius * 4 / 5;
                    break;
            }

            textBox2.Text = hasil.ToString();
        }
    }
}

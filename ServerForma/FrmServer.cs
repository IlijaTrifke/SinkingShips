using Common.Domain;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServerForma
{
    public partial class FrmServer : Form
    {
        Server server;
        List<int> cifre;
        private int brojPraznih = 0;
        public FrmServer()
        {
            InitializeComponent();
        }

        public FrmServer(Administrator admin)
        {
            InitializeComponent();
            this.Text = $"Welcome {Controller.Instance.Prijavljeni.Ime} {Controller.Instance.Prijavljeni.Prezime}";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            brojPraznih = 0;
            cifre = new List<int>();
            if (IsValid())
            {
                Controller.Instance.SetujCifre(cifre);
                if (server == null)
                {
                    server = new Server();
                    server.Start();
                }
                server.Listen();
            }
            else
            {
                MessageBox.Show("Niste uneli pravilno cifre!");
            }
        }

        private bool IsValid()
        {
            if (richTextBox1.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox1.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox1.Text));
            }
            if (richTextBox2.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox2.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox2.Text));
            }
            if (richTextBox3.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox3.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox3.Text));
            }
            if (richTextBox4.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox4.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox4.Text));
            }
            if (richTextBox5.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox5.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox5.Text));
            }
            if (richTextBox6.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox6.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox6.Text));
            }
            if (richTextBox7.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox7.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox7.Text));
            }
            if (richTextBox8.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox8.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox8.Text));
            }
            if (richTextBox9.Text == "")
            {
                brojPraznih++;
                cifre.Add(-1);
            }
            else
            {
                if (cifre.Contains(int.Parse(richTextBox9.Text)))
                {
                    return false;
                }
                cifre.Add(int.Parse(richTextBox9.Text));
            }
            if (brojPraznih != 6)
            {
                return false;
            }
            return true;
        }
    }
}

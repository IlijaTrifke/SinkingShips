using Common.Communication;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForma
{
    public partial class FrmClient : Form
    {
        int brojPokusaja = 0;
        int brojPogodjenih = 0;
        List<int> cifre;
        public FrmClient()
        {
            InitializeComponent();
            cifre = new List<int>();
            Communication.Instance.Connect();
        }

        private void btn1_Click(object sender, System.EventArgs e)
        {
            btn1.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 1
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn1.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            btn2.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 2
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn2.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            btn3.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 3
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn3.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            btn4.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 4
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn4.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            btn5.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 5
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn5.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            btn6.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 6
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn6.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            btn7.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 7
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn7.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            btn8.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 8
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn8.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            btn9.Enabled = false;
            Request request;
            brojPokusaja++;
            request = new Request()
            {
                Operacija = Operation.ProveriPoziciju,
                Pozicija = 9
            };
            Communication.Instance.PosaljiPoruku(request);
            Response response = (Response)Communication.Instance.PrimiPoruku();
            btn9.Text = response.Vrednost.ToString();
            if (response.Vrednost != -1)
            {
                brojPogodjenih++;
                cifre.Add(response.Vrednost);
            }
            if (brojPogodjenih == 3)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                cifre.Sort();
                int sifra = cifre[0] * 100 + cifre[1] * 10 + cifre[2];
                MessageBox.Show($"Vasa sifra je {sifra}!");
                Dispose();
            }
            if (brojPokusaja == 5)
            {
                request = new Request()
                {
                    Operacija = Operation.Kraj,
                };
                Communication.Instance.PosaljiPoruku(request);
                MessageBox.Show("Izgubili ste!");
                Dispose();
            }
        }
    }
}

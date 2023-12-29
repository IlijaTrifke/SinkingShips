using Common.Domain;
using System.Collections.Generic;

namespace ServerForma
{
    public class Controller
    {
        private List<Administrator> admins = new List<Administrator>()
        {
            new Administrator()
            {
                Ime="Pera",
                Prezime="Peric",
                Email="123",
                Password="123"
            }
        };
        private static Controller instance;
        public Administrator Prijavljeni { get; set; }
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { }
        private List<int> cifre;
        public Administrator Login(Administrator admin)
        {
            foreach (Administrator item in admins)
            {
                if (item.Email == admin.Email && item.Password == admin.Password)
                {
                    Prijavljeni = item;
                    return Prijavljeni;
                }
            }
            return null;
        }

        public int VratiVrednost(int pozicija)
        {
            return cifre[pozicija - 1];
        }

        public void SetujCifre(List<int> cifre)
        {
            this.cifre = cifre;
        }
    }
}

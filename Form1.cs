using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WazneKody2
{



    public partial class Form1 : Form
    {
        public class Infos
        {
            private string info1;
            private string info2;


            public Infos(string s1, string s2)
            {
                info1 = s1;
                info2 = s2;
            }
            public string Info1
            {
                get { return this.info1; }
                set { this.info1 = value; }
            }

            public string Info2
            {
                get { return this.info2; }
                set { this.info2 = value; }
            }

            public override string ToString()
            {
                return this.info2;
            }
        }

        List<Infos> test = new List<Infos>();
        Infos inf1 = new Infos("solo s", "Kod aktywacji: *111*572*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 20zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf2 = new Infos("solo m", "Kod aktywacji: *111*978*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 25zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf3 = new Infos("solo l", "Kod aktywacji: *111*571*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 30zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf4 = new Infos("solo xl", "Kod aktywacji: *111*203*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf5 = new Infos("solo xxl", "Kod aktywacji: *111*223*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 40zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf6 = new Infos("play na karte", "Kod aktywacji: *163*6#");
        Infos inf7 = new Infos("formuła play na karte", "Kod aktywacji: *163*10#");
        Infos inf8 = new Infos("play na karte lubię to", "Kod aktywacji: *163*7#");
        Infos inf9 = new Infos("sprawdzenie aktualnej taryfy", "Kod aktywacji: *111*49*1#");
        Infos inf10 = new Infos("play na karte odnowa", "Kod aktywacji: *163*20#");
        Infos inf11 = new Infos("internet na karte 2.0", "Kod aktywacji: *163*21#");
        Infos inf12 = new Infos("rbm siema na kartę", "Kod aktywacji: *163*21#");
        Infos inf13 = new Infos("rbm siema na kartę pl", "Kod aktywacji: *163*21#");
        Infos inf14 = new Infos("stan nielimitowany i 10 GB w RBM", "Kod aktywacji: *111*964*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 30zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf15 = new Infos("1000 minut UA + 15GB DATA", "Kod aktywacji cykliczny: *111*1198*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1197*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł");
        Infos inf16 = new Infos("1000 minut UA + 15GB", "Kod aktywacji cykliczny: *111*2000*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1199*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł");
        Infos inf17 = new Infos("1000 minut UA + 10GB viber", "Kod aktywacji 1-razowy: *111*331*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 30zł");
        Infos inf18 = new Infos("1000 minut UA", "Kod aktywacji 1-razowy: *111*969*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 25ł");
        Infos inf19 = new Infos("tańsze połączenia ua", "Kod aktywacji: *111*201*1#" + Environment.NewLine + "Cena: 0zł");
        Infos inf20 = new Infos("dzien bez limtu GB DATA", "Kod aktywacji 1-razowy: *111*1191*1#" + Environment.NewLine + "Czas trwania 1 dzień" + Environment.NewLine + "Cena: 5zł");
        Infos inf21 = new Infos("tydzien bez limtu GB DATA", "Kod aktywacji 1-razowy: *111*1192*1#" + Environment.NewLine + "Czas trwania 7 dni" + Environment.NewLine + "Cena: 20zł");
        Infos inf22 = new Infos("miesiąc bez limtu GB DATA", "Kod aktywacji cykliczny:  *111*1194*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 50zł" + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf23 = new Infos("stan gb viber", "Kod aktywacji: *633#");
        Infos inf24 = new Infos("stan darmowy", "Kod aktywacji: *188#");
        Infos inf25 = new Infos("1000 minut UA RBM", "Kod aktywacji 1-razowy: *111*981*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 25zł");
        Infos inf26 = new Infos("stan konta pre-paid", "Kod aktywacji: *101#");
        Infos inf27 = new Infos("stan gb w MIX", "Kod aktywacji: *102#");
        Infos inf28 = new Infos("stan minut do wszystkich", "Kod aktywacji: *104#");
        Infos inf29 = new Infos("stan gb w postpaid", "Kod aktywacji: *107#");
        Infos inf30 = new Infos("stan gb w prepaid", "Kod aktywacji: *108#");
        Infos inf31 = new Infos("zarządzanie kontem", "Kod aktywacji: *111#");
        Infos inf32 = new Infos("sprawdź swoj numer", "Kod aktywacji: *121#");
        Infos inf33 = new Infos("prośba o doładowanie", "Kod aktywacji: *122#");
        Infos inf34 = new Infos("info. o płatnościach", "Kod aktywacji: *125#");
        Infos inf35 = new Infos("muzka na czekanie", "Kod aktywacji: *123#");
        Infos inf36 = new Infos("strefa stacjonarna", "Kod aktywacji: *313#" + Environment.NewLine + "Kod aktywacji: 790 313 313");
        Infos inf37 = new Infos("stan gb w UE", "Kod aktywacji: *575#" + Environment.NewLine + "Kod aktywacji: *800#");
        Infos inf38 = new Infos("stan doładowań mix", "Kod aktywacji: *111*357*5#");
        Infos inf39 = new Infos("poczta głosowa", "Kod aktywacji: *111*56*1#" + Environment.NewLine + "Numer poczty:790 200 200" + Environment.NewLine + "Numer pro: 790 200 300");
        Infos inf40 = new Infos("wydłużenie kontraktu mix", "Kod aktywacji: *111*888*1#");
        Infos inf41 = new Infos("autokonfiguracja", "Kod aktywacji: sms o treści PLAY na 9999" + Environment.NewLine + "Strona: https://konfiguracja.play.pl/");
        Infos inf42 = new Infos("stan 100GB na lato", "Kod aktywacji: *107#" + Environment.NewLine + "Dla 'play na karte lubie to' użyj: *108#");
        Infos inf43 = new Infos("stan 1000 minut ua", "Kod aktywacji: *111*996#");
        Infos inf44 = new Infos("pewny telefon", "Numer: 48 791 100 310");
        Infos inf45 = new Infos("pakiet medyczny", "Numer: 22 529 17 62");
        Infos inf46 = new Infos("play360", "Numer: 732 666 360" + Environment.NewLine + "Strona: https://www.naprawaplay.pl/");
        Infos inf47 = new Infos("bezpieczny telefon", "Numer: 791 100 310");
        Infos inf48 = new Infos("ochrona wyswietlacza", "Numer: 799 599 900");
        Infos inf49 = new Infos("plan na zdrowie prudential", "Numer: 801 386 000");
        Infos inf50 = new Infos("sony", "Numer: 801 382 462");
        Infos inf51 = new Infos("alcatel", "22 58 30 081");
        Infos inf52 = new Infos("lenovo", "Numer: 22 273 97 77");
        Infos inf53 = new Infos("garmin", "Numer: 800 441 24 54 ");
        Infos inf54 = new Infos("samsung", "Numer: 801 672 678");
        Infos inf55 = new Infos("lg", "Numer: 801 545 454");
        Infos inf56 = new Infos("htc", "Numer: 800 702 680");
        Infos inf57 = new Infos("motorola", "Numer: 22 307 03 60");
        Infos inf58 = new Infos("myphone", "Numer: 71 717 74 00");
        Infos inf59 = new Infos("huawei", "Numer: 800 811 810");
        Infos inf60 = new Infos("zte", "Numer: 22 726 38 10");
        Infos inf61 = new Infos("acer", "Numer: 22 471 07 77");
        Infos inf62 = new Infos("kiano", "Numer: 12 383 31 30");
        Infos inf63 = new Infos("hp", "Numer: 22 583 43 71");
        Infos inf64 = new Infos("prestigio", "Numer: 22 337 15 48");
        Infos inf65 = new Infos("asus", "Numer: 22 571 80 40");



        private void SetupList()
        {
            test.Add(inf1);
            test.Add(inf2);
            test.Add(inf3);
            test.Add(inf4);
            test.Add(inf5);
            test.Add(inf6);
            test.Add(inf7);
            test.Add(inf8);
            test.Add(inf9);
            test.Add(inf42);
            test.Add(inf10);
            test.Add(inf11);
            test.Add(inf12);
            test.Add(inf13);
            test.Add(inf14);
            test.Add(inf15);
            test.Add(inf16);
            test.Add(inf17);
            test.Add(inf18);
            test.Add(inf19);
            test.Add(inf20);
            test.Add(inf21);
            test.Add(inf22);
            test.Add(inf23);
            test.Add(inf24);
            test.Add(inf25);
            test.Add(inf26);
            test.Add(inf27);
            test.Add(inf28);
            test.Add(inf29);
            test.Add(inf30);
            test.Add(inf31);
            test.Add(inf32);
            test.Add(inf33);
            test.Add(inf34);
            test.Add(inf35);
            test.Add(inf36);
            test.Add(inf37);
            test.Add(inf38);
            test.Add(inf39);
            test.Add(inf40);
            test.Add(inf41);
            test.Add(inf42);
            test.Add(inf43);
            test.Add(inf44);
            test.Add(inf45);
            test.Add(inf46);
            test.Add(inf47);
            test.Add(inf48);
            test.Add(inf49);
            test.Add(inf50);
            test.Add(inf51);
            test.Add(inf52);
            test.Add(inf53);
            test.Add(inf54);
            test.Add(inf55);
            test.Add(inf56);
            test.Add(inf57);
            test.Add(inf58);
            test.Add(inf59);
            test.Add(inf60);
            test.Add(inf61);
            test.Add(inf62);
            test.Add(inf63);
            test.Add(inf64);
            test.Add(inf65);

        }
        public Form1()
        {
            InitializeComponent();
            listcollection.Clear();
            SetupList();




            foreach (var p in test)
            {
                listBox1.Items.Add(p.Info1);
            }

            foreach (string str in listBox1.Items)
            {
                listcollection.Add(str);
                textBox1.CharacterCasing = CharacterCasing.Lower;
            }
        }
        List<string> listcollection = new List<string>();

        int licznik = 0;
        public void listBox1_Click(object sender, EventArgs e)
        {

            var curItem = test.FirstOrDefault(x => x.Info1 == listBox1.SelectedItem.ToString());
            licznik = licznik + 1;
            licznik_VjuS.Text = "Aplikacja pomogła Ci " + licznik.ToString() + " razy";
            licznik_VjuS.Visible = true;
            Pole_Kodu.Visible = true;
            Pole_Kodu.Text = (curItem.ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                listBox1.Visible = true;
                label1.Visible = true;
                search_Result.Visible = true;
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(textBox1.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (textBox1.Text == "")
            {
                Pole_Kodu.Visible = false;
                label1.Visible = false;
                search_Result.Visible = false;
                listBox1.Visible = false;
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBox1.Items.Add(str);
                }
            }
        }


    }
}

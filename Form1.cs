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
        List<Infos> test = new List<Infos>();
        Infos inf1 = new Infos("solo s", "Pakiet: SOLO S" + Environment.NewLine + "Kod aktywacji: *111*572*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 20zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni", "cyrylia");
        /*Infos inf2 = new Infos("solo m", "Pakiet: SOLO M" + Environment.NewLine + "Kod aktywacji: *111*978*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 25zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf3 = new Infos("solo l", "Pakiet: SOLO L" + Environment.NewLine + "Kod aktywacji: *111*571*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 30zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf4 = new Infos("solo xl", "Pakiet: SOLO XL" + Environment.NewLine + "Kod aktywacji: *111*203*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf5 = new Infos("solo xxl", "Pakiet: SOLO XXL" + Environment.NewLine + "Kod aktywacji: *111*223*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 40zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf6 = new Infos("play na karte", "Taryfa: Play na kartę" + Environment.NewLine + "Kod aktywacji: *163*6#" + Environment.NewLine + "Dokumenty: www.play.pl/resources/pdf/2021/Cennik-Oferty-Play-na-Karte-obowiazuje-od-1.04.2020-zmieniony-23.03.2021.pdf");
        Infos inf7 = new Infos("formuła play na karte", "Taryfa: formuła Play na kartę" + Environment.NewLine + "Kod aktywacji: *163*10#" + Environment.NewLine + "Dokumenty: www.play.pl/resources/pdf/2021/Cennik-Oferty-Formula-Play-na-Karte-obowiazuje-od-1.04.2020-zmieniony-23.03.2021.pdf");
        Infos inf8 = new Infos("play na karte lubię to", "Taryfa: Play na kartę lubię to" + Environment.NewLine + "Kod aktywacji: *163*7#" + Environment.NewLine + "Dokumenty: www.play.pl/resources/pdf/2021/Cennik-Oferty-Play-na-Karte-Lubie-to-obowiazuje-od-1.04.2020-zmieniony-23.03.2021.pdf");
        Infos inf9 = new Infos("sprawdzenie aktualnej taryfy", "Sprawdź swoją taryfe" + Environment.NewLine + "Kod aktywacji: *111*49*1#");
        Infos inf10 = new Infos("play na karte odnowa", "Taryfa: Play na karte ODNowa" + Environment.NewLine + "Kod aktywacji: *163*20#" + Environment.NewLine + "www.play.pl/resources/pdf/2021/Cennik-Oferty-Play-na-Karte-odNOWA-obowiazuje-od-1.04.2020-zmieniony-23.03.2021.pdf");
        Infos inf11 = new Infos("internet na karte 2.0", "Taryfa: Internet na kartę 2.0" + Environment.NewLine + "Kod aktywacji: *163*21#" + Environment.NewLine + "Dokumenty: www.play.pl/resources/pdf/2021/Cennik-oferty-Internet-na-Karte-2.0-obowiazuje-od-25.06.2020-zmieniony-23.03.2021.pdf");
        Infos inf12 = new Infos("rbm siema na kartę", "Taryfa: rbm siema na kartę" + Environment.NewLine + "Kod aktywacji: *163*99#" + Environment.NewLine + "Dokumenty: www.redbullmobile.pl/sites/default/files/pdf/cenniki/Cennik_Oferty_RBM_SieMa_na_Karte_obowiazuje_od_22-02-2018_r_(Zmieniony_23-03-2021).pdf");
        Infos inf13 = new Infos("rbm siema na kartę pl", "Taryfa: rbm siema na kartę PL" + Environment.NewLine + "Kod aktywacji: *163*66#" + Environment.NewLine + "Dokumenty: www.redbullmobile.pl/sites/default/files/pdf/cenniki/Cennik%20Oferty%20RBM%20SieMa%20na%20Kart%C4%99%20PL%20obowi%C4%85zuje%20od%2022.02.2018%20%28zmieniony%2015.08.2020%29.pdf");
        Infos inf14 = new Infos("stan nielimitowany i 10 GB w RBM", "Pakiet: stan nielimitowany i 10 GB w RBM" + Environment.NewLine + "Kod aktywacji: *111*964*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 30zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf15 = new Infos("1000 minut UA + 15GB DATA", "Pakiet:1000 minut UA + 15GB DATA " + Environment.NewLine + "Kod aktywacji cykliczny: *111*1198*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1197*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł");
        Infos inf16 = new Infos("1000 minut UA + 15GB", "Pakiet:1000 minut UA + 15GB " + Environment.NewLine + "Kod aktywacji cykliczny: *111*1200*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1199*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł");
        Infos inf17 = new Infos("1000 minut UA + 10GB viber", "Pakiet:1000 minut UA + 10GB viber " + Environment.NewLine + "Kod aktywacji 1-razowy: *111*331*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 30zł");
        Infos inf18 = new Infos("1000 minut UA", "Pakiet:1000 minut UA " + Environment.NewLine + "Kod aktywacji 1-razowy: *111*969*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 25ł");
        Infos inf19 = new Infos("tańsze połączenia ua", "Pakiet:Tańsze połączenia UA " + Environment.NewLine + "Kod aktywacji: *111*201*1#" + Environment.NewLine + "Cena: 0zł");
        Infos inf20 = new Infos("dzien bez limtu GB DATA", "Pakiet:Dzien bez limtu GB DATA" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1191*1#" + Environment.NewLine + "Ad" + Environment.NewLine + "Cena: 5zł");
        Infos inf21 = new Infos("tydzien bez limtu GB DATA", "Pakiet:Tydzien bez limtu GB DATA" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*1192*1#" + Environment.NewLine + "Czas trwania 7 dni" + Environment.NewLine + "Cena: 20zł");
        Infos inf22 = new Infos("miesiąc bez limtu GB DATA", "Pakiet:tydzien bez limtu GB DATA" + Environment.NewLine + "Kod aktywacji cykliczny:  *111*1194*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 50zł" + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf23 = new Infos("stan gb viber", "Stan gb viber" + Environment.NewLine + "Kod aktywacji: *633#");
        Infos inf24 = new Infos("stan darmowy", "Pakiet:stan darmowy" + Environment.NewLine + "Kod aktywacji: *188#");
        Infos inf25 = new Infos("1000 minut UA RBM", "Pakiet:1000 minut UA RBM" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*981*1#" + Environment.NewLine + "Czas trwania 30 dni" + Environment.NewLine + "Cena: 25zł");
        Infos inf26 = new Infos("stan konta pre-paid", "Stan konta pre-paid" + Environment.NewLine + "Kod aktywacji: *101#");
        Infos inf27 = new Infos("stan gb w MIX", "Stan gb w MIX" + Environment.NewLine + "Kod aktywacji: *102#");
        Infos inf28 = new Infos("stan minut do wszystkich", "Stan minut do wszystkich" + Environment.NewLine + "Kod aktywacji: *104#");
        Infos inf29 = new Infos("stan gb w postpaid", "Stan gb w postpaid" + Environment.NewLine + "Kod aktywacji: *107#");
        Infos inf30 = new Infos("stan gb w prepaid", "Stan gb w prepaid" + Environment.NewLine + "Kod aktywacji: *108#");
        Infos inf31 = new Infos("zarządzanie kontem", "Zarządzanie kontem" + Environment.NewLine + "Kod aktywacji: *111#");
        Infos inf32 = new Infos("sprawdź swoj numer", "Sprawdź swoj numer" + Environment.NewLine + "Kod aktywacji: *121#");
        Infos inf33 = new Infos("prośba o doładowanie", "Prośba o doładowanie" + Environment.NewLine + "Kod aktywacji: *122#");
        Infos inf34 = new Infos("info. o płatnościach", "Informacje o płatnościach" + Environment.NewLine + "Kod aktywacji: *125#");
        Infos inf35 = new Infos("muzka na czekanie", "Pakiet:muzka na czekanie" + Environment.NewLine + "Kod aktywacji: *123#");
        Infos inf36 = new Infos("strefa stacjonarna", "Ustelenie strefy stacjonarnej" + Environment.NewLine + "Kod aktywacji: *313#" + Environment.NewLine + "Kod aktywacji: 790 313 313");
        Infos inf37 = new Infos("stan gb w roamingu UE", "Stan gb w UE" + Environment.NewLine + "Kod aktywacji: *575#" + Environment.NewLine + "Kod aktywacji: *800#");
        Infos inf38 = new Infos("stan doładowań mix", "Stan doładowań mix" + Environment.NewLine + "Kod aktywacji: *111*357*5#");
        Infos inf39 = new Infos("poczta głosowa", "Pakiet: poczta głosowa" + Environment.NewLine + "Kod aktywacji: *111*56*1#" + Environment.NewLine + "Numer poczty:790 200 200" + Environment.NewLine + "Numer poczty pro: 790 200 300");
        Infos inf40 = new Infos("wydłużenie kontraktu mix", "wydłużenie kontraktu mix" + Environment.NewLine + "Kod aktywacji: *111*888*1#");
        Infos inf41 = new Infos("auto-konfiguracja", "Auto-konfiguracja" + Environment.NewLine + "Kod aktywacji: sms o treści PLAY - 9999" + Environment.NewLine + "Strona: konfiguracja.play.pl/");
        Infos inf42 = new Infos("stan 100GB na lato", "Pakiet:stan 100GB na lato" + Environment.NewLine + "Kod aktywacji: *107#" + Environment.NewLine + "Dla 'play na karte lubie to' użyj: *108#");
        Infos inf43 = new Infos("stan 1000 minut ua", "Pakiet:stan 1000 minut ua" + Environment.NewLine + "Kod aktywacji: *111*996#");
        Infos inf45 = new Infos("pakiet medyczny", "Pakiet medyczny" + Environment.NewLine + "Numer: 22 529 17 62" + Environment.NewLine + "Czynna: 9-17 pon-pt");
        Infos inf46 = new Infos("play360", "Pakiet:play360" + Environment.NewLine + "Numer: 732 666 360" + Environment.NewLine + "Strona: www.naprawaplay.pl/" + Environment.NewLine + "Czynna: 8-18 pon-pt");
        Infos inf47 = new Infos("bezpieczny telefon", "Pakiet:bezpieczny telefon" + Environment.NewLine + "Numer: 791 100 310" + Environment.NewLine + "Czynna: 8-18 pon-pt");
        Infos inf48 = new Infos("ochrona wyswietlacza", "Pakiet:ochrona wyswietlacza" + Environment.NewLine + "Numer: 799 599 900");
        Infos inf49 = new Infos("plan na zdrowie prudential", "Pakiet:plan na zdrowie prudential" + Environment.NewLine + "Numer: 801 386 000" + Environment.NewLine + "Czynna: 9-18 pon-pt");
        Infos inf50 = new Infos("sony", "Producent: Sony" + Environment.NewLine + "Numer: 22 703 41 00");
        Infos inf51 = new Infos("alcatel", "Producent: Sony" + Environment.NewLine + "Numer: 22 58 30 081" + Environment.NewLine + "Strona: www.alcatelmobile.com/pl/contact-us/");
        Infos inf52 = new Infos("lenovo", "Producent: Lenovo" + Environment.NewLine + "Numer: +48 22 583 43 82" + Environment.NewLine + "Czynna: 9-18 pon-pt");
        Infos inf53 = new Infos("garmin", "Producent: Garmin" + Environment.NewLine + "Numer: +48 22 300 31 55" + Environment.NewLine + "Czynna: 8.30-17.30 pon-pt");
        Infos inf54 = new Infos("samsung", "Producent: Samsung" + Environment.NewLine + "Numer: 801-172-678" + Environment.NewLine + "Czynna: Całodobowo");
        Infos inf55 = new Infos("lg", "Producent: LG" + Environment.NewLine + "Numer: 801 54 54 54" + Environment.NewLine + "Czynna: 8-20 pon-pt" + Environment.NewLine + "Czynna: 10-18 sob");
        Infos inf56 = new Infos("htc", "Producent: HTC" + Environment.NewLine + "strona: www.htc.com/pl/support");
        Infos inf57 = new Infos("motorola", "Producent: Motorola" + Environment.NewLine + "Numer: 800-734-5870" + Environment.NewLine + "Czynna: 7-22 pon - pt" + Environment.NewLine + "Czynna: 9-18 sob-niedz");
        Infos inf58 = new Infos("myphone", "Producent: " + Environment.NewLine + "Strona: www.myphone.pl/kontakt");
        Infos inf59 = new Infos("huawei", "Producent: " + Environment.NewLine + "Numer: 800 811 110" + Environment.NewLine + "Czynna: 8-20 pon-pt" + Environment.NewLine + "Czynna: 10-18 sob-niedz");
        Infos inf60 = new Infos("zte", "Producent: ZTE" + Environment.NewLine + "E-mail: warsawoffice@zte.com.cn");
        Infos inf61 = new Infos("acer", "Producent: Acer" + Environment.NewLine + "Numer: 22 209 89 88" + Environment.NewLine + "Czynna: 8.30-17.30 pon-pt");
        Infos inf62 = new Infos("kiano", "Producent: Kiano " + Environment.NewLine + "Numer: 41 306 70 71" + Environment.NewLine + "Czynna: 9-16 pon-pt");
        Infos inf63 = new Infos("hp", "Producent: HP" + Environment.NewLine + "Numer: 22 583 43 73" + Environment.NewLine + "Czynna: 8.30-18 pon-pt");
        Infos inf65 = new Infos("asus", "Producent: Asus" + Environment.NewLine + "Numer: 22 571 80 40" + Environment.NewLine + "Czynna: 8.30-17.10 pon-pt");
        Infos inf66 = new Infos("solo l odnowa", "Pakiet: Solo L odnowa" + Environment.NewLine + "Kod aktywacji: *111*571*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 30zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf67 = new Infos("solo mini odnowa", "Pakiet: solo mini odnowa" + Environment.NewLine + "Kod aktywacji: *111*209*1#" + Environment.NewLine + "Czas trwania: 10 dni" + Environment.NewLine + "Cena: 15zł");
        Infos inf68 = new Infos("solo xl odnowa", "Pakiet: solo mini odnowa" + Environment.NewLine + "Kod aktywacji: *111*229*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 35zł " + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf69 = new Infos("2gb mix","Pakiet: 2GB Mix" + Environment.NewLine + "Kod aktywacji cykliczny: *111*184*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*186*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 5zł");
        Infos inf70 = new Infos("5gb mix", "Pakiet: 5GB Mix" + Environment.NewLine + "Kod aktywacji cykliczny: *111*185*1#" + Environment.NewLine + "Kod aktywacji 1-razowy: *111*183*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 10zł");
        Infos inf71 = new Infos("Nilimitowane GB", "Pakiet: Nilimitowane GB" + Environment.NewLine + "Kod aktywacji cykliczny: *111*134*1#" + Environment.NewLine + "Czas trwania: 30 dni" + Environment.NewLine + "Cena: 20zł" + Environment.NewLine + "Pakiet odnowi się za 30 dni");
        Infos inf72 = new Infos("blokada wszystkich usług premium", "Blokada wszystkich usług premium" + Environment.NewLine + "Kod aktywacji: *111*96*1#");
        Infos inf73 = new Infos("blokada zakupów mobilnych", "Blokada zakupów mobilnych" + Environment.NewLine + "Kod aktywacji: *111*99*1#");
        Infos inf74 = new Infos("blokada polaczen z zastrzezonych", "Blokada polaczen z zastrzezonych" + Environment.NewLine + "Kod aktywacji: *111*114*1#");
        Infos inf75 = new Infos("blokada polaczen miedzynarodowych", "Blokada polaczen miedzynarodowych" + Environment.NewLine + "Kod aktywacji: *111*69*1#");
        Infos inf76 = new Infos("blokada bezplatnych przych. wiad. prem.", "Blokada bezplatnych przych. wiad. prem." + Environment.NewLine + "Kod aktywacji: *111*48*1#");
        Infos inf77 = new Infos("xiaomi", "Producent: Xiaomi" + Environment.NewLine + "Numer:48 363 63 66");
        Infos inf78 = new Infos("telmor", "Monter: Telmor" + Environment.NewLine + "Numer: (58) 739 51 01" + Environment.NewLine + "Czynna: 10-18 pon-pt");
        Infos inf79 = new Infos("apple", "Producent: Apple" + Environment.NewLine + "Numer: 22 703 41 00" + Environment.NewLine + "Czynna: 10-18 pon-pt");
        Infos inf80 = new Infos("vivo", "Producent: Vivo" + Environment.NewLine + "Numer: 800909608" + Environment.NewLine + "Czynna: 10-17 pon-pt");
        Infos inf81 = new Infos("oppo", "Producent: Oppo" + Environment.NewLine + "Numer: 00800 112 4439" + Environment.NewLine + "Czynna: 9-18 pon-pt");
        Infos inf82 = new Infos("nokia", "Producent: Nokia" + Environment.NewLine + "Strona: www.nokia.com/phones/pl_pl/support" + Environment.NewLine + "Cza† na żywo na stronie");
        Infos inf83 = new Infos("realme", "Producent: Realme" + Environment.NewLine + "Numer: 00 800 321 1483" + Environment.NewLine + "Czynna: 9-18 pon-pt");
        Infos inf84 = new Infos("hammer", "Producent: Hammer" + Environment.NewLine + "Strona: www.myphone.pl/kontakt" );
        Infos inf85 = new Infos("maxcom", "Producent: Maxcom" + Environment.NewLine + "Numer: 32 325 07 00");
        Infos inf86 = new Infos("oneplus", "Producent: Oneplus" + Environment.NewLine + "Strona: www.oneplus.com/pl/support");
        Infos inf87 = new Infos("stop spam", "Stop spam" + Environment.NewLine + "Aktywacja: sms o treści stop spam - 252");
        Infos inf88 = new Infos("polaczenia oczekujace", "Połączenia oczekujące" + Environment.NewLine + "Kod aktywacji: *43#" + Environment.NewLine + "Kod dezaktywacji: #43#");
        Infos inf89 = new Infos("imei", "Sprawdzenie imei urządzenia" + Environment.NewLine + "Kod aktywacji: *#06#");
        Infos inf90 = new Infos("seti", "seti.p4.org");
        Infos inf91 = new Infos("centrum sms", "Centrum sms Play" + Environment.NewLine + "Numer: *790 998 250");
        Infos inf92 = new Infos("stan nielimitowany 5 dni rbm", "Pakiet: Stan nielimitowany RBM 5 dni" + Environment.NewLine + "Kod aktywacji: *111*960*1#" + Environment.NewLine + "Czas trwania 5 dni" + Environment.NewLine + "Cena: 5zł ");
        Infos inf93 = new Infos("stan nielimitowany 10 dni rbm", "Pakiet: Stan nielimitowany RBM 10 dni" + Environment.NewLine + "Kod aktywacji: *111*961*1#" + Environment.NewLine + "Czas trwania 10 dni" + Environment.NewLine + "Cena: 10zł ");
        Infos inf94 = new Infos("stan nielimitowany 15 dni rbm", "Pakiet: Stan nielimitowany RBM 15 dni" + Environment.NewLine + "Kod aktywacji: *111*962*1#" + Environment.NewLine + "Czas trwania 15 dni" + Environment.NewLine + "Cena: 15zł ");
        Infos inf95 = new Infos("infolinia play", "Infolinia dla klienta ind. Play" + Environment.NewLine + "Numer: 790 500 500" + Environment.NewLine + "Numer: *500 z numeru play" + Environment.NewLine + "Cena: 0,29zł/m ");
        Infos inf96 = new Infos("infolinia play biz", "Infolinia dla klienta biz. Play" + Environment.NewLine + "Numer: 790 600 600" + Environment.NewLine + "Numer: *600 z numeru play" + Environment.NewLine + "Cena: 0,29zł/m ");
        Infos inf97 = new Infos("infolinia rbm", "Infolinia dla klienta RBM" + Environment.NewLine + "Numer: 790 666 666" + Environment.NewLine + "Numer: *666 z numeru rbm" + Environment.NewLine + "Cena: 0,29zł/m ");
        Infos inf98 = new Infos("infolinia vip", "Infolinia dla klienta VIP" + Environment.NewLine + "Numer: 790 555 555");
        Infos inf99 = new Infos("infolinia sprzedazowa", "Infolinia sprzedażowa" + Environment.NewLine + "Numer: 730 300 400");
        Infos inf100 = new Infos("blue media", "Infolinia BlueMedia" + Environment.NewLine + "Numer: 58 760 48 44");
        Infos inf101 = new Infos("urów", "Biuro numerów" + Environment.NewLine + "Numer dla stacjonarki: 118 913" + Environment.NewLine + "Numer: *72913");
        Infos inf102 = new Infos("windykacja INFOS", "Windykacja INFOS" + Environment.NewLine + "Numer: 58 550 94 00" + Environment.NewLine + "Email: infos@infos.org.pl");
        Infos inf103 = new Infos("windykacja koksztys", "Windykacja Koksztys" + Environment.NewLine + "Numer: 71 786 63 76" + Environment.NewLine + "Email: infos@infos.org.pl");
        Infos inf104 = new Infos("windykacja arvato", "Windykacja Arvato" + Environment.NewLine + "Numer: 61 664 05 43 " + Environment.NewLine + "Email: play@arvato-windykacja.pl");
        Infos inf105 = new Infos("windykacja kaczmarski", "Windykacja Kaczmarski" + Environment.NewLine + "Numer: 71 827 06 92 " + Environment.NewLine + "Email: biuro@kaczmarski.pl");
        Infos inf106 = new Infos("windykacja panfil", "Windykacja Panfil" + Environment.NewLine + "Numer: 22 489 34 33 " + Environment.NewLine + "Email: kancelaria@panfil.pl");
        Infos inf107 = new Infos("windykacja kruk", "Windykacja Kruk" + Environment.NewLine + "Numer: 71 79 02 182 " + Environment.NewLine + "Email: play@infokruk.pl");
        Infos inf108 = new Infos("windykacja inkasso plus", "Windykacja Inkasso plus" + Environment.NewLine + "Numer: 32 728 77 78" + Environment.NewLine + "Email: a.podemska@inkasso-plus.pl");
        Infos inf109 = new Infos("kurier dpd", "Kurier: DPD" + Environment.NewLine + "Numer: +48 22 577 55 55" + Environment.NewLine + "Numer: 801 400 373" + Environment.NewLine + "Czynna: 8-18 pon-pt" + Environment.NewLine + "Czynna: 8-14 sob" + Environment.NewLine + "Lokalizacja paczki: hmojapaczka.dpd.com.pl/login");
        Infos inf110 = new Infos("kurier dhl", "Kurier: DHL" + Environment.NewLine + "Numer: +48 42 6 345 345." + Environment.NewLine + "Czynna: 7-20 pon-pt" + Environment.NewLine + "Czynna: 8-16 sob" + Environment.NewLine + "Lokalizacja paczki: sprawdz.dhl.com.pl/");
        Infos inf111 = new Infos("infolinia faktmobile", "Infolinia dla klienta FaktMobile" + Environment.NewLine + "Numer: 799 599 999");
        Infos inf112 = new Infos("adres korespondencyjny", "Adres korespondencyjny dla klientów Play" + Environment.NewLine + "Adres: Skrytka pocztowa 43, 02-671 Warszawa");
        Infos inf113 = new Infos("Ochrona danych osobowych", "Ochrona danych osobowych" + Environment.NewLine + "Email: iod@pomocplay.pl" + Environment.NewLine + "Adres: Wynalazek 1, 02-677 Warszawa");
        */


        //List<infossUA> ukraina = new List<infossUA>();
        // infossUA ukraina1 = new infossUA("ukraintatest", "Ochrona danych osobowych" + Environment.NewLine + "Email: iod@pomocplay.pl" + Environment.NewLine + "Adres: Wynalazek 1, 02-677 Warszawa");
        private void SetupList()
        {
            
            test.Add(inf1);
            /*test.Add(inf2);
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
            test.Add(inf65);
            test.Add(inf66);
            test.Add(inf67);
            test.Add(inf68);
            test.Add(inf69);
            test.Add(inf70);
            test.Add(inf71);
            test.Add(inf72);
            test.Add(inf73);
            test.Add(inf74);
            test.Add(inf75);
            test.Add(inf76);
            test.Add(inf77);
            test.Add(inf78);
            test.Add(inf79);
            test.Add(inf80);
            test.Add(inf81);
            test.Add(inf82);
            test.Add(inf83);
            test.Add(inf84);
            test.Add(inf85);
            test.Add(inf86);
            test.Add(inf87);
            test.Add(inf88);
            test.Add(inf89);
            test.Add(inf90);
            test.Add(inf91);
            test.Add(inf92);
            test.Add(inf93);
            test.Add(inf94);
            test.Add(inf95);
            test.Add(inf96);
            test.Add(inf97);
            test.Add(inf98);
            test.Add(inf99);
            test.Add(inf100);
            test.Add(inf101);
            test.Add(inf102);
            test.Add(inf103);
            test.Add(inf104);
            test.Add(inf105);
            test.Add(inf106);
            test.Add(inf107);
            test.Add(inf108);
            test.Add(inf109);
            test.Add(inf110);
            test.Add(inf111);
            test.Add(inf112);
            test.Add(inf113);
            
            */
        }
        public Form1()
        {
            InitializeComponent();
            listcollection.Clear();
            SetupList();




            foreach (var p in test )
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
            Pole_Kodu.BackColor = Color.FromArgb(0, 1, 2, 3);

        }
        public void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.U) == Keys.U)
            {
                var curItem2 =test.FirstOrDefault(x => x.Info1 == listBox1.SelectedItem.ToString());
                licznik = licznik + 1;
                licznik_VjuS.Text = "Aplikacja pomogła Ci " + licznik.ToString() + " razy";
                licznik_VjuS.Visible = true;
                Pole_Kodu.Visible = true;
                Pole_Kodu.Text = (curItem2.info3);
                Pole_Kodu.BackColor = Color.FromArgb(0, 1, 2, 3);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                listBox1.Visible = true;
                label1.Visible = true;
                search_Result.Visible = true;
                listBox1.Items.Clear();
                Pole_Kodu.BackColor = Color.FromArgb(0, 1, 2, 3);
                foreach (string str in listcollection)
                {
                    if (str.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (textBox1.Text == "")
            {
                Pole_Kodu.Visible = false;
                Pole_Kodu.BackColor = Color.FromArgb(0, 1, 2, 3);
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

        private void Pole_Kodu_DoubleClick(object sender, EventArgs e)
        {
            Pole_Kodu.BackColor = Color.FromArgb(80, 24, 30, 54);

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektZaliczenie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();


            var pies = new List<Offers>
            {
                new Offers
                {
                    Model = "Skoda Octavia", Price = "9990zł",
                    Description =
                       @"Witam,
Do sprzedania Skoda Octavia I w dość bogatej wersji Laurin & Klement. Posiadam ją od około 3 lat. Auto z polskiego salonu, ze 110-cio konnym bocianem pod maską. Stan ogólny dobry, po wymianie maglownicy, przednich tarcz hamulcowych i klocków, klocków tylnych, nowe sprężyny przednie, nowe końcówki drążków, tuleje wahaczy przednich( pełne od Audi TT) , świeży olej, turbo po regeneracji. Auto na teraz bez jakiegokolwiek wkładu ze strony kupującego. OC do 24.04.20, PT. 08.12.19.W cenie auta są 2 kpl.kół - lato alufelgi 16 widoczne na zdj, zima stal 16.
Wyposażenie :
-xenon
- skórzana tapicerka z alcantarą
- podgrzewane fotele przód
-ASR
- komputer pokładowy
- regulacja kierownicy w dwóch płaszczyznach
-system isofix
- alufelgi
- skórzana kierownica
- 6x airbag
-szyberdach
- climatronik(sprawny)
- 4x el. szyby
- podwójna podłoga bagażnika
-2x podłokietnik(przód i tył)
-2 komplety kluczy

Zachęcam do obejrzenia na żywo oraz do kupna;)",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/5d9ddac1583a0f6ee53fe558/skoda-octavia-i.jpg",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Renault Scenic", Price = "9000zł", Description =
                        @"Witam,
                          na sprzedaż mam nietuzinkowy samochód jakim jest renault scenic z 2008 roku. Nietuzinkowy to idealne określenie tego auta ponieważ jako jeden z nielicznych posiada automatyczną skrzynię biegów co jest rzadkością na naszym rynku , ale jak doskonale wiemy wygodą w dniu codziennym. Druga ogromna zaleta jest spalanie , które waha się w granicy 5-6 l na 100 km. Renault pochodzi z salonu polskiego. Samochód mimo swojego przebiegu jest doinwestowany przede wszystkim miał w ostatnim czasie wymiany akumulator na gwarancji, tarcze klocki , olej i filtry. W niedalekiej przeszłości regenerowane turbo, a także wtryski czyli wszystko to co diesel powinien mieć zrobione na czas. Jestem przekonany, że przejedzie drugie tyle bez większych problemów. Opony w dobrym stanie . Oc przegląd ważne. Nigdy mnie nie zawiódł. ",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/5d9e56fa583a0f6ee54bcadf/renault-scenic-ii.jpg",
                    InStock = false,
                },
                new Offers
                {
                    Model = "Strawberry Pie", Price = "3000zł",
                    Description =
                        @"Witam sprzedam Fiata 126,100% sprawny zarejestrowany opłacony.
Jeden wlasciciel od Nowości.
Wszystkie szyby oryginalne.",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/5d9e5651583a0f6ee54bb888/fiat-126p-maluch.jpg",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Ferrari 456", Price = "299000zł", Description =
                       @"WItam, mam do sprzedania niezwykle rzadkie Ferrari 456 GT z 1995 roku, wyprodukowano tylko 3298 szt. Jedynym oferowanym silnikiem był widlasty dwunastocylindrowiec o pojemności 5474 cm³ osiągający 442 KM. Nazwa 456 wzięła się od pojemności pojedynczego cylindra, który wynosi 456,16 cm³.
Jestem jego drugim właścicielem w Polsce, a 3 w ogóle, od marca 2013 roku, a sprowadził go do Polski mój znajomy w marcu 2010 roku.
Od momentu zakupu wymieniłem bardzo dużo elementów na NOWE ORYGINALNE FERRARI !! (posiadam faktury VAT) tj.: kable wysokiego napięcia (koszt 5500 zł), świece (500 zł), termostat (2000 zł), olej plus filtry (1100 zł), uszczelki wokół okien (oryginalne zmatowiały - 10 tyś zł), opony (5000 zł) oraz akumulator Bosch (październik 2018 - 500 zł), oryginalny komplet amortyzatorów tył (grudzień 2018), świeżo nabita klimatyzacja (wrzesień 2019-600zł)
Samochód ma ważny przegląd do 24.11.2019 r., zakupiłem go w celach inwestycyjnych, cały czas garażowany, praktycznie niejeżdżony. Regularnie odpalany i ruszany z miejsca w celu konserwacji.
Jestem osobą prywatną, nie handlarzem. Możliwość wystawienia faktury VAT, zainteresowani proszę o kontakt ze w mną w tej sprawie.
Idealna lokata kapitału, co roku wartość tych aut rośnie średnio 10%- tańsze już nie będzie! Sprzedaję, gdyż zakupiłem okazyjnie nieruchomość w centrum Krakowa",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/5d9e3122583a0f6ee5482ef7/ferrari-456-gta.jpg",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Mercedes w211", Price = "24999zł",
                    Description =
                        @"Mercedes w211 Stan bardzo dobry, oryginalny pakiet EVO, Nowe opony CONTINENTAL. Nowy komplet 4 tarcz ATE. Opony zimowe w komplecie. Wszystkie części eksploatacyjne wymieniane na bieżąco.",
                    ImageUrl = "https://a.allegroimg.com/s1440/03a241/2a956788450ca7df5c9e06ab96ee",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Mercedes CL500", Price = "49000zł", Description =
                        @"Sprzedam Mercedesa cl500 w bardzo dobrym stanie, auto jest po pełnym detalingu lakieru (ceramika) i wnętrza , wymienione wszystkie płyny i oleje (silnik , skrzynia), prawie nowe opony, tapicerka w idealnym stanie. Piękne 18 felgi które przyciągają wzrok. Wszystko działa : dociągi drzwi, bagażnika, podwójne szyby, elektryczne zagłówki, podajniki pasów i inne.KOLOR CIEMNY GRANAT - AKRYL.Od 1996 roku auto jest w kraju , podobno ma ciekawa historię związaną z koronnym :)",
                    ImageUrl = "https://a.allegroimg.com/s1440/03bf17/3e4974014bd0a84471d49646bc9b",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Bmw x5", Price = "18999zł", Description =
                        @"Sprzedam BMW X5 3.0d. Auto nie wymaga żadnego wkładu finansowego . Sprowadzone w 2013r . W Polsce jeden właściciel . Po remoncie zawieszenia . Automat bardzo ładnie pracuje . Napęd 4x4
WYPOSAŻENIE-

- elektryczne szyby x4

- klimatronik 2-strefowy
- reflektory ksenonowe
- elektryczne lusterka
- podgrzewane lusterka
- nawigacja
- kierownica wielofunkcyjna
- czujniki parkowania przód / tył
- tempomat
- skórzana tapicerka
- alufelgi
- ABS
- komputer pokładowy
- immobiliser
- poduszki powietrzne
- radio CD/DVD
- centralny zamek+pilot
- światła przeciwmgielne
- wspomaganie kierownicy
- podłokietnik
- przyciemniane szyby
- regulacja kolumny kierownicy
- dzielona / składana tylna kanapa
- blokada drzwi
-El.regulacja siedzeń
- komplet kluczyków
-hak",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/589322b3582c7df5d5a207fb/bmw-x5-03.jpg",
                    InStock = true,
                },
                new Offers
                {
                    Model = "Citroen Jumper", Price = "26500zł", Description =
                        @"Witam,mam do sprzedania Citroen Jumper L2H1,131KM,rok 2013,
nawigacja , kamera cofania ,klimatyzacja. Samochód kupiłem od pierwszego właściciela w 2016 roku, przez cały okres użytkowania byłem bardzo z niego zadowolony. Auto było użytkowane w Niemczech i tam przechodziło wszystkie przeglądy.",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/58946b5d592c7d8328917d07/citroen-jumper.jpg",
                    InStock = true
                },
                new Offers
                {
                    Model = "Fiat Panda", Price = "9500zł", Description =
                       @"Sprzedam śliczną bielutką Pandę .

Auto jest bardzo zadbane i nie zniszczone.

Przebieg autostradowy, więc auto wygląda i jeździ perfekcyjnie.

Nowe opony

Fiat Panda jest bezwypadkowa oraz całe nadwozie w oryginalnym lakierze ( nic nie lakierowane) !",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/58947f70592c7d832894b206/fiat-panda.jpg",
                    InStock = true
                },
                new Offers
                {
                    Model = "Suzuki sx4", Price = "12500zł ", Description =
                       @"Sprzedam Suzuki SX4 1.9 DDIS z 2006r, skrzynia manualna, sześcio biegowa. Auto w pełni sprawne. Posiada normalne ślady użytkowania.",
                    ImageUrl = "https://www.autocentrum.pl/ac-file/gallery-photo/58949e45592c7d49138f0f18/suzuki-sx4.jpg",
                    InStock = false,
                },
                new Offers
                {
                    Model = "Bmw 3", Price = "20000zł", Description =
                       @"Witam. Auto ma zwiększoną moc do 290km,seryjnie 231 najlepszy silnik diesla od BMW. Wszystko jest sprawne nie wymaga inwestycji.Nowe klocki i tarcze przód, koła 225/50/17 przód 245/45/17 tył stan bdb. Koła na zimę 16 nowe opony i nowe felgi.Zawieszenie M pakiet. Olej motul, paliwo schell v-power. Komputer w języku polskim, panoramiczny dach, 3 kluczyki+pilot do ogrzewania postojowego. Więcej na telefon. AUTO JEŹDZI TAK JAK POWINNO.",
                    ImageUrl = "https://a.allegroimg.com/s360/11697a/6336ad0e4482b2a76514852b55e5",
                    InStock = true,
                }
            };

            PiesListView.ItemsSource = pies;
        }

        private async void PiesListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPie = e.SelectedItem as Offers;
            await Navigation.PushAsync(new DetailView(selectedPie));
        }

    }
}

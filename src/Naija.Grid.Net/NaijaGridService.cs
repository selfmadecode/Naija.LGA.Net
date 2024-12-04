using Naija.Grid.Net.Model;
using System.Collections.Generic;

namespace Naija.Grid.Net
{
    internal class NaijaGridService
    {
        public static List<State> GetAllStates()
        {
            return States;
        }

        private static readonly List<State> States = new List<State>
        {
            new State
            {
                Id = 1,
                Name = "Abia",
                Capital = "Umuahia",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Aba North"},
                    new LGA { Id = 2, Name = "Aba South"},
                    new LGA { Id = 3, Name = "Arochukwu"},
                    new LGA { Id = 4, Name = "Bende"},
                    new LGA { Id = 5, Name = "Ikwuano"},
                    new LGA { Id = 6, Name = "Isiala Ngwa North"},
                    new LGA { Id = 7, Name = "Isiala Ngwa South"},
                    new LGA { Id = 8, Name = "Isiukwuato"},
                    new LGA { Id = 9, Name = "Obingwa"},
                    new LGA { Id = 10, Name = "Ohafia"},
                    new LGA { Id = 11, Name = "Osisioma Ngwa"},
                    new LGA { Id = 12, Name = "Ugwunagbo"},
                    new LGA { Id = 13, Name = "Ukwa East"},
                    new LGA { Id = 14, Name = "Ukwa West"},
                    new LGA { Id = 15, Name = "Umuahia North"},
                    new LGA { Id = 16, Name = "Umuahia South"},
                    new LGA { Id = 17, Name = "Umu Nneochi"}
                }
            },
            new State
            {
                Id = 2,
                Name = "Adamawa",
                Capital = "Yola",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Demsa" },
                    new LGA { Id = 2, Name = "Fufure" },
                    new LGA { Id = 3, Name = "Ganye" },
                    new LGA { Id = 4, Name = "Gayuk" },
                    new LGA { Id = 5, Name = "Gombi" },
                    new LGA { Id = 6, Name = "Grie" },
                    new LGA { Id = 7, Name = "Hong" },
                    new LGA { Id = 8, Name = "Jada" },
                    new LGA { Id = 9, Name = "Larmurde" },
                    new LGA { Id = 10, Name = "Madagali" },
                    new LGA { Id = 11, Name = "Maiha" },
                    new LGA { Id = 12, Name = "Mayo Belwa" },
                    new LGA { Id = 13, Name = "Michika" },
                    new LGA { Id = 14, Name = "Mubi North" },
                    new LGA { Id = 15, Name = "Mubi South" },
                    new LGA { Id = 16, Name = "Numan" },
                    new LGA { Id = 17, Name = "Shelleng" },
                    new LGA { Id = 18, Name = "Song" },
                    new LGA { Id = 19, Name = "Toungo" },
                    new LGA { Id = 20, Name = "Yola North" },
                    new LGA { Id = 21, Name = "Yola South" }
                }
            },
            new State
            {
                Id = 3,
                Name = "Akwa Ibom",
                Capital = "Uyo",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Abak"},
                    new LGA { Id = 2, Name = "Eastern Obolo"},
                    new LGA { Id = 3, Name = "Eket"},
                    new LGA { Id = 4, Name = "Esit Eket"},
                    new LGA { Id = 5, Name = "Essien Udim"},
                    new LGA { Id = 6, Name = "Etim Ekpo"},
                    new LGA { Id = 7, Name = "Etinan"},
                    new LGA { Id = 8, Name = "Ibeno"},
                    new LGA { Id = 9, Name = "Ibesikpo Asutan"},
                    new LGA { Id = 10, Name = "Ibiono-Ibom"},
                    new LGA { Id = 11, Name = "Ikot Abasi"},
                    new LGA { Id = 12, Name = "Ika"},
                    new LGA { Id = 13, Name = "Ikono"},
                    new LGA { Id = 14, Name = "Ikot Ekpene"},
                    new LGA { Id = 15, Name = "Ini"},
                    new LGA { Id = 16, Name = "Mkpat-Enin"},
                    new LGA { Id = 17, Name = "Itu"},
                    new LGA { Id = 18, Name = "Mbo"},
                    new LGA { Id = 19, Name = "Nsit-Atai"},
                    new LGA { Id = 20, Name = "Nsit-Ibom"},
                    new LGA { Id = 21, Name = "Nsit-Ubium"},
                    new LGA { Id = 22, Name = "Obot Akara"},
                    new LGA { Id = 23, Name = "Okobo"},
                    new LGA { Id = 24, Name = "Onna"},
                    new LGA { Id = 25, Name = "Oron"},
                    new LGA { Id = 26, Name = "Udung-Uko"},
                    new LGA { Id = 27, Name = "Ukanafun"},
                    new LGA { Id = 28, Name = "Oruk Anam"},
                    new LGA { Id = 29, Name = "Uruan"},
                    new LGA { Id = 30, Name = "Urue-Offong/Oruko"},
                    new LGA { Id = 31, Name = "Uyo"},
                }
            },
            new State
            {
                Id = 4,
                Name = "Anambra",
                Capital = "Awka",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Aguata" },
                    new LGA { Id = 2, Name = "Anambra East" },
                    new LGA { Id = 3, Name = "Anaocha" },
                    new LGA { Id = 4, Name = "Awka North" },
                    new LGA { Id = 5, Name = "Anambra West" },
                    new LGA { Id = 6, Name = "Awka South" },
                    new LGA { Id = 7, Name = "Ayamelum" },
                    new LGA { Id = 8, Name = "Dunukofia" },
                    new LGA { Id = 9, Name = "Ekwusigo" },
                    new LGA { Id = 10, Name = "Idemili North" },
                    new LGA { Id = 11, Name = "Idemili South" },
                    new LGA { Id = 12, Name = "Ihiala" },
                    new LGA { Id = 13, Name = "Njikoka" },
                    new LGA { Id = 14, Name = "Nnewi North" },
                    new LGA { Id = 15, Name = "Nnewi South" },
                    new LGA { Id = 16, Name = "Ogbaru" },
                    new LGA { Id = 17, Name = "Onitsha North" },
                    new LGA { Id = 18, Name = "Onitsha South" },
                    new LGA { Id = 19, Name = "Orumba North" },
                    new LGA { Id = 20, Name = "Orumba South" },
                    new LGA { Id = 21, Name = "Oyi" },
                }
            },
            new State
            {
                Id = 5,
                Name = "Bauchi",
                Capital = "Bauchi",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Alkaleri" },
                    new LGA { Id = 2, Name = "Bauchi" },
                    new LGA { Id = 3, Name = "Bogoro" },
                    new LGA { Id = 4, Name = "Damban" },
                    new LGA { Id = 5, Name = "Darazo" },
                    new LGA { Id = 6, Name = "Dass" },
                    new LGA { Id = 7, Name = "Gamawa" },
                    new LGA { Id = 8, Name = "Ganjuwa" },
                    new LGA { Id = 9, Name = "Giade" },
                    new LGA { Id = 10, Name = "Itas/Gadau" },
                    new LGA { Id = 11, Name = "Jama'are" },
                    new LGA { Id = 12, Name = "Katagum" },
                    new LGA { Id = 13, Name = "Kirfi" },
                    new LGA { Id = 14, Name = "Misau" },
                    new LGA { Id = 15, Name = "Ningi" },
                    new LGA { Id = 16, Name = "Shira" },
                    new LGA { Id = 17, Name = "Tafawa Balewa" },
                    new LGA { Id = 18, Name = "Toro" },
                    new LGA { Id = 19, Name = "Warji" },
                    new LGA { Id = 20, Name = "Zaki" },
                }
            },
            new State
            {
                Id = 6,
                Name = "Bayelsa",
                Capital = "Yenagoa",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Brass" },
                    new LGA { Id = 2, Name = "Ekeremor" },
                    new LGA { Id = 3, Name = "Kolokuma/Opokuma" },
                    new LGA { Id = 4, Name = "Nembe" },
                    new LGA { Id = 5, Name = "Ogbia" },
                    new LGA { Id = 6, Name = "Sagbama" },
                    new LGA { Id = 7, Name = "Southern Ijaw" },
                    new LGA { Id = 8, Name = "Yenagoa" },
                }
            },
            new State
            {
                Id = 7,
                Name = "Benue",
                Capital = "Yenagoa",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Agatu" },
                    new LGA { Id = 2, Name = "Apa" },
                    new LGA { Id = 3, Name = "Ado" },
                    new LGA { Id = 4, Name = "Buruku" },
                    new LGA { Id = 5, Name = "Gboko" },
                    new LGA { Id = 6, Name = "Guma" },
                    new LGA { Id = 7, Name = "Gwer East" },
                    new LGA { Id = 8, Name = "Gwer West" },
                    new LGA { Id = 9, Name = "Katsina-Ala" },
                    new LGA { Id = 10, Name = "Konshisha" },
                    new LGA { Id = 11, Name = "Kwande" },
                    new LGA { Id = 12, Name = "Logo" },
                    new LGA { Id = 13, Name = "Makurdi" },
                    new LGA { Id = 14, Name = "Obi" },
                    new LGA { Id = 15, Name = "Ogbadibo" },
                    new LGA { Id = 16, Name = "Ohimini" },
                    new LGA { Id = 17, Name = "Oju" },
                    new LGA { Id = 18, Name = "Okpokwu" },
                    new LGA { Id = 19, Name = "Oturkpo" },
                    new LGA { Id = 20, Name = "Tarka" },
                    new LGA { Id = 21, Name = "Ukum" },
                    new LGA { Id = 22, Name = "Ushongo" },
                    new LGA { Id = 23, Name = "Vandeikya" },
                }
            },
            new State
            {
                Id = 8,
                Name = "Borno",
                Capital = "Maiduguri",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Abadam" },
                    new LGA { Id = 2, Name = "Askira/Uba" },
                    new LGA { Id = 3, Name = "Bama" },
                    new LGA { Id = 4, Name = "Bayo" },
                    new LGA { Id = 5, Name = "Biu" },
                    new LGA { Id = 6, Name = "Chibok" },
                    new LGA { Id = 7, Name = "Damboa" },
                    new LGA { Id = 8, Name = "Dikwa" },
                    new LGA { Id = 9, Name = "Guzamala" },
                    new LGA { Id = 10, Name = "Gubio" },
                    new LGA { Id = 11, Name = "Hawul" },
                    new LGA { Id = 12, Name = "Gwoza" },
                    new LGA { Id = 13, Name = "Jere" },
                    new LGA { Id = 14, Name = "Kaga" },
                    new LGA { Id = 15, Name = "Kala/Balge" },
                    new LGA { Id = 16, Name = "Konduga" },
                    new LGA { Id = 17, Name = "Kukawa" },
                    new LGA { Id = 18, Name = "Kwaya Kusar" },
                    new LGA { Id = 19, Name = "Mafa" },
                    new LGA { Id = 20, Name = "Magumeri" },
                    new LGA { Id = 21, Name = "Maiduguri" },
                    new LGA { Id = 22, Name = "Mobbar" },
                    new LGA { Id = 23, Name = "Marte" },
                    new LGA { Id = 24, Name = "Monguno" },
                    new LGA { Id = 25, Name = "Ngala" },
                    new LGA { Id = 26, Name = "Nganzai" },
                    new LGA { Id = 27, Name = "Shani" },
                }
            },
            new State
            {
                Id = 9,
                Name = "Cross River",
                Capital = "Calabar",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Abi" },
                    new LGA { Id = 2, Name = "Akamkpa" },
                    new LGA { Id = 3, Name = "Akpabuyo" },
                    new LGA { Id = 4, Name = "Bakassi" },
                    new LGA { Id = 5, Name = "Bekwarra" },
                    new LGA { Id = 6, Name = "Biase" },
                    new LGA { Id = 7, Name = "Boki" },
                    new LGA { Id = 8, Name = "Calabar Municipal" },
                    new LGA { Id = 9, Name = "Calabar South" },
                    new LGA { Id = 10, Name = "Etung" },
                    new LGA { Id = 11, Name = "Ikom" },
                    new LGA { Id = 12, Name = "Obanliku" },
                    new LGA { Id = 13, Name = "Obubra" },
                    new LGA { Id = 14, Name = "Obudu" },
                    new LGA { Id = 15, Name = "Odukpani" },
                    new LGA { Id = 16, Name = "Ogoja" },
                    new LGA { Id = 17, Name = "Yakuur" },
                    new LGA { Id = 18, Name = "Yala" },
                }
            },
            new State
            {
                Id = 10,
                Name = "Delta",
                Capital = "Asaba",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Aniocha North" },
                    new LGA { Id = 2, Name = "Aniocha South" },
                    new LGA { Id = 3, Name = "Bomadi" },
                    new LGA { Id = 4, Name = "Burutu" },
                    new LGA { Id = 5, Name = "Ethiope West" },
                    new LGA { Id = 6, Name = "Ethiope East" },
                    new LGA { Id = 7, Name = "Ika North East" },
                    new LGA { Id = 8, Name = "Ika South" },
                    new LGA { Id = 9, Name = "Isoko North" },
                    new LGA { Id = 10, Name = "Isoko South" },
                    new LGA { Id = 11, Name = "Ndokwa East" },
                    new LGA { Id = 12, Name = "Ndokwa West" },
                    new LGA { Id = 13, Name = "Okpe" },
                    new LGA { Id = 14, Name = "Oshimili North" },
                    new LGA { Id = 15, Name = "Oshimili South" },
                    new LGA { Id = 16, Name = "Patani" },
                    new LGA { Id = 17, Name = "Sapele" },
                    new LGA { Id = 18, Name = "Udu" },
                    new LGA { Id = 19, Name = "Ughelli North" },
                    new LGA { Id = 20, Name = "Ukwuani" },
                    new LGA { Id = 21, Name = "Ughelli South" },
                    new LGA { Id = 22, Name = "Uvwie" },
                    new LGA { Id = 23, Name = "Warri North" },
                    new LGA { Id = 24, Name = "Warri South" },
                    new LGA { Id = 25, Name = "Warri South West" },
                }
            },
            new State
            {
                Id = 11,
                Name = "Ebonyi",
                Capital = "Abakaliki",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Abakaliki" },
                    new LGA { Id = 2, Name = "Afikpo North" },
                    new LGA { Id = 3, Name = "Ebonyi" },
                    new LGA { Id = 4, Name = "Afikpo South" },
                    new LGA { Id = 5, Name = "Ezza North" },
                    new LGA { Id = 6, Name = "Ikwo" },
                    new LGA { Id = 7, Name = "Ezza South" },
                    new LGA { Id = 8, Name = "Ivo" },
                    new LGA { Id = 9, Name = "Ishielu" },
                    new LGA { Id = 10, Name = "Izzi" },
                    new LGA { Id = 11, Name = "Ohaozara" },
                    new LGA { Id = 12, Name = "Ohaukwu" },
                    new LGA { Id = 13, Name = "Onicha" },
                }
            },
            new State
            {
                Id = 12,
                Name = "Edo",
                Capital = "Benin City",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Akoko-Edo" },
                    new LGA { Id = 2, Name = "Egor" },
                    new LGA { Id = 3, Name = "Esan Central" },
                    new LGA { Id = 4, Name = "Esan North-East" },
                    new LGA { Id = 5, Name = "Esan South-East" },
                    new LGA { Id = 6, Name = "Esan West" },
                    new LGA { Id = 7, Name = "Etsako Central" },
                    new LGA { Id = 8, Name = "Etsako East" },
                    new LGA { Id = 9, Name = "Etsako West" },
                    new LGA { Id = 10, Name = "Igueben" },
                    new LGA { Id = 11, Name = "Ikpoba Okha" },
                    new LGA { Id = 12, Name = "Orhionmwon" },
                    new LGA { Id = 13, Name = "Oredo" },
                    new LGA { Id = 14, Name = "Ovia North-East" },
                    new LGA { Id = 15, Name = "Ovia South-West" },
                    new LGA { Id = 16, Name = "Owan East" },
                    new LGA { Id = 17, Name = "Owan West" },
                    new LGA { Id = 18, Name = "Uhunmwonde" },
                }
            },
            new State
            {
                Id = 13,
                Name = "Ekiti",
                Capital = "Ado Ekiti",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Ado Ekiti" },
                    new LGA { Id = 2, Name = "Efon" },
                    new LGA { Id = 3, Name = "Ekiti East" },
                    new LGA { Id = 4, Name = "Ekiti South-West" },
                    new LGA { Id = 5, Name = "Ekiti West" },
                    new LGA { Id = 6, Name = "Emure" },
                    new LGA { Id = 7, Name = "Gbonyin" },
                    new LGA { Id = 8, Name = "Ido Osi" },
                    new LGA { Id = 9, Name = "Ijero" },
                    new LGA { Id = 10, Name = "Ikere" },
                    new LGA { Id = 11, Name = "Ilejemeje" },
                    new LGA { Id = 12, Name = "Irepodun/Ifelodun" },
                    new LGA { Id = 13, Name = "Ikole" },
                    new LGA { Id = 14, Name = "Ise/Orun" },
                    new LGA { Id = 15, Name = "Moba" },
                    new LGA { Id = 16, Name = "Oye" },
                }
            },
            new State
            {
                Id = 14,
                Name = "Enugu",
                Capital = "Enugu",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Awgu" },
                    new LGA { Id = 2, Name = "Aninri" },
                    new LGA { Id = 3, Name = "Enugu East" },
                    new LGA { Id = 4, Name = "Enugu North" },
                    new LGA { Id = 5, Name = "Ezeagu" },
                    new LGA { Id = 6, Name = "Enugu South" },
                    new LGA { Id = 7, Name = "Igbo Etiti" },
                    new LGA { Id = 8, Name = "Igbo Eze North" },
                    new LGA { Id = 9, Name = "Igbo Eze South" },
                    new LGA { Id = 10, Name = "Isi Uzo" },
                    new LGA { Id = 11, Name = "Nkanu East" },
                    new LGA { Id = 12, Name = "Nkanu West" },
                    new LGA { Id = 13, Name = "Nsukka" },
                    new LGA { Id = 14, Name = "Udenu" },
                    new LGA { Id = 15, Name = "Oji River" },
                    new LGA { Id = 16, Name = "Uzo Uwani" },
                    new LGA { Id = 17, Name = "Udi" },
                }
            },
            new State
            {
                Id = 15,
                Name = "Gombe",
                Capital ="Gombe",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Akko" },
                    new LGA { Id = 2, Name = "Balanga" },
                    new LGA { Id = 3, Name = "Billiri" },
                    new LGA { Id = 4, Name = "Dukku" },
                    new LGA { Id = 5, Name = "Funakaye" },
                    new LGA { Id = 6, Name = "Gombe" },
                    new LGA { Id = 7, Name = "Kaltungo" },
                    new LGA { Id = 8, Name = "Kwami" },
                    new LGA { Id = 9, Name = "Nafada" },
                    new LGA { Id = 10, Name = "Shongom" },
                    new LGA { Id = 11, Name = "Yamaltu/Deba" },
                }
            },
            new State
            {
                Id = 16,
                Name = "Imo",
                Capital = "Owerri",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Aboh Mbaise" },
                    new LGA { Id = 2, Name = "Ahiazu Mbaise" },
                    new LGA { Id = 3, Name = "Ehime Mbano" },
                    new LGA { Id = 4, Name = "Ezinihitte" },
                    new LGA { Id = 5, Name = "Ideato North" },
                    new LGA { Id = 6, Name = "Ideato South" },
                    new LGA { Id = 7, Name = "Ihitte/Uboma" },
                    new LGA { Id = 8, Name = "Ikeduru" },
                    new LGA { Id = 9, Name = "Isiala Mbano" },
                    new LGA { Id = 10, Name = "Mbaitoli" },
                    new LGA { Id = 11, Name = "Isu" },
                    new LGA { Id = 12, Name = "Ngor Okpala" },
                    new LGA { Id = 13, Name = "Njaba" },
                    new LGA { Id = 14, Name = "Nkwerre" },
                    new LGA { Id = 15, Name = "Nwangele" },
                    new LGA { Id = 16, Name = "Obowo" },
                    new LGA { Id = 17, Name = "Oguta" },
                    new LGA { Id = 18, Name = "Ohaji/Egbema" },
                    new LGA { Id = 19, Name = "Okigwe" },
                    new LGA { Id = 20, Name = "Orlu" },
                    new LGA { Id = 21, Name = "Orsu" },
                    new LGA { Id = 22, Name = "Oru East" },
                    new LGA { Id = 23, Name = "Oru West" },
                    new LGA { Id = 24, Name = "Owerri Municipal" },
                    new LGA { Id = 25, Name = "Owerri North" },
                    new LGA { Id = 26, Name = "Unuimo" },
                    new LGA { Id = 27, Name = "Owerri West" },
                }
            },
            new State
            {
                Id = 17,
                Name = "Jigawa",
                Capital = "Dutse",
                LGAs = new List<LGA>
                {
                    new LGA { Id = 1, Name = "Auyo" },
                    new LGA { Id = 2, Name = "Babura" },
                    new LGA { Id = 3, Name = "Buji" },
                    new LGA { Id = 4, Name = "Biriniwa" },
                    new LGA { Id = 5, Name = "Birnin Kudu" },
                    new LGA { Id = 6, Name = "Dutse" },
                    new LGA { Id = 7, Name = "Gagarawa" },
                    new LGA { Id = 8, Name = "Garki" },
                    new LGA { Id = 9, Name = "Gumel" },
                    new LGA { Id = 10, Name = "Guri" },
                    new LGA { Id = 11, Name = "Gwaram" },
                    new LGA { Id = 12, Name = "Gwiwa" },
                    new LGA { Id = 13, Name = "Hadejia" },
                    new LGA { Id = 14, Name = "Jahun" },
                    new LGA { Id = 15, Name = "Kafin Hausa" },
                    new LGA { Id = 16, Name = "Kazaure" },
                    new LGA { Id = 17, Name = "Kiri Kasama" },
                    new LGA { Id = 18, Name = "Kiyawa" },
                    new LGA { Id = 19, Name = "Kaugama" },
                    new LGA { Id = 20, Name = "Maigatari" },
                    new LGA { Id = 21, Name = "Malam Madori" },
                    new LGA { Id = 22, Name = "Miga" },
                    new LGA { Id = 23, Name = "Sule Tankarkar" },
                    new LGA { Id = 24, Name = "Roni" },
                    new LGA { Id = 25, Name = "Ringim" },
                    new LGA { Id = 26, Name = "Yankwashi" },
                    new LGA { Id = 27, Name = "Taura" },
                }
            }

        };
    }
}

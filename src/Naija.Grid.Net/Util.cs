﻿using System.Collections.Generic;
using Naija.LGA.Net.Model;
using Naija.Model;

namespace Naija.Utilities
{
    public static class Util
    {
        public static List<State> InitializeStates()
        {
            return new List<State>
            {
                new State
                {
                    Id = 1,
                    Name = "Abia",
                    Capital = "Umuahia",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aba North"},
                        new Lga { Id = 2, Name = "Aba South"},
                        new Lga { Id = 3, Name = "Arochukwu"},
                        new Lga { Id = 4, Name = "Bende"},
                        new Lga { Id = 5, Name = "Ikwuano"},
                        new Lga { Id = 6, Name = "Isiala Ngwa North"},
                        new Lga { Id = 7, Name = "Isiala Ngwa South"},
                        new Lga { Id = 8, Name = "Isiukwuato"},
                        new Lga { Id = 9, Name = "Obingwa"},
                        new Lga { Id = 10, Name = "Ohafia"},
                        new Lga { Id = 11, Name = "Osisioma Ngwa"},
                        new Lga { Id = 12, Name = "Ugwunagbo"},
                        new Lga { Id = 13, Name = "Ukwa East"},
                        new Lga { Id = 14, Name = "Ukwa West"},
                        new Lga { Id = 15, Name = "Umuahia North"},
                        new Lga { Id = 16, Name = "Umuahia South"},
                        new Lga { Id = 17, Name = "Umu Nneochi"}
                    }
                },
                new State
                {
                    Id = 2,
                    Name = "Adamawa",
                    Capital = "Yola",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Demsa" },
                        new Lga { Id = 2, Name = "Fufure" },
                        new Lga { Id = 3, Name = "Ganye" },
                        new Lga { Id = 4, Name = "Gayuk" },
                        new Lga { Id = 5, Name = "Gombi" },
                        new Lga { Id = 6, Name = "Grie" },
                        new Lga { Id = 7, Name = "Hong" },
                        new Lga { Id = 8, Name = "Jada" },
                        new Lga { Id = 9, Name = "Larmurde" },
                        new Lga { Id = 10, Name = "Madagali" },
                        new Lga { Id = 11, Name = "Maiha" },
                        new Lga { Id = 12, Name = "Mayo Belwa" },
                        new Lga { Id = 13, Name = "Michika" },
                        new Lga { Id = 14, Name = "Mubi North" },
                        new Lga { Id = 15, Name = "Mubi South" },
                        new Lga { Id = 16, Name = "Numan" },
                        new Lga { Id = 17, Name = "Shelleng" },
                        new Lga { Id = 18, Name = "Song" },
                        new Lga { Id = 19, Name = "Toungo" },
                        new Lga { Id = 20, Name = "Yola North" },
                        new Lga { Id = 21, Name = "Yola South" }
                    }
                },
                new State
                {
                    Id = 3,
                    Name = "Akwa Ibom",
                    Capital = "Uyo",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abak"},
                        new Lga { Id = 2, Name = "Eastern Obolo"},
                        new Lga { Id = 3, Name = "Eket"},
                        new Lga { Id = 4, Name = "Esit Eket"},
                        new Lga { Id = 5, Name = "Essien Udim"},
                        new Lga { Id = 6, Name = "Etim Ekpo"},
                        new Lga { Id = 7, Name = "Etinan"},
                        new Lga { Id = 8, Name = "Ibeno"},
                        new Lga { Id = 9, Name = "Ibesikpo Asutan"},
                        new Lga { Id = 10, Name = "Ibiono-Ibom"},
                        new Lga { Id = 11, Name = "Ikot Abasi"},
                        new Lga { Id = 12, Name = "Ika"},
                        new Lga { Id = 13, Name = "Ikono"},
                        new Lga { Id = 14, Name = "Ikot Ekpene"},
                        new Lga { Id = 15, Name = "Ini"},
                        new Lga { Id = 16, Name = "Mkpat-Enin"},
                        new Lga { Id = 17, Name = "Itu"},
                        new Lga { Id = 18, Name = "Mbo"},
                        new Lga { Id = 19, Name = "Nsit-Atai"},
                        new Lga { Id = 20, Name = "Nsit-Ibom"},
                        new Lga { Id = 21, Name = "Nsit-Ubium"},
                        new Lga { Id = 22, Name = "Obot Akara"},
                        new Lga { Id = 23, Name = "Okobo"},
                        new Lga { Id = 24, Name = "Onna"},
                        new Lga { Id = 25, Name = "Oron"},
                        new Lga { Id = 26, Name = "Udung-Uko"},
                        new Lga { Id = 27, Name = "Ukanafun"},
                        new Lga { Id = 28, Name = "Oruk Anam"},
                        new Lga { Id = 29, Name = "Uruan"},
                        new Lga { Id = 30, Name = "Urue-Offong/Oruko"},
                        new Lga { Id = 31, Name = "Uyo"},
                    }
                },
                new State
                {
                    Id = 4,
                    Name = "Anambra",
                    Capital = "Awka",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aguata" },
                        new Lga { Id = 2, Name = "Anambra East" },
                        new Lga { Id = 3, Name = "Anaocha" },
                        new Lga { Id = 4, Name = "Awka North" },
                        new Lga { Id = 5, Name = "Anambra West" },
                        new Lga { Id = 6, Name = "Awka South" },
                        new Lga { Id = 7, Name = "Ayamelum" },
                        new Lga { Id = 8, Name = "Dunukofia" },
                        new Lga { Id = 9, Name = "Ekwusigo" },
                        new Lga { Id = 10, Name = "Idemili North" },
                        new Lga { Id = 11, Name = "Idemili South" },
                        new Lga { Id = 12, Name = "Ihiala" },
                        new Lga { Id = 13, Name = "Njikoka" },
                        new Lga { Id = 14, Name = "Nnewi North" },
                        new Lga { Id = 15, Name = "Nnewi South" },
                        new Lga { Id = 16, Name = "Ogbaru" },
                        new Lga { Id = 17, Name = "Onitsha North" },
                        new Lga { Id = 18, Name = "Onitsha South" },
                        new Lga { Id = 19, Name = "Orumba North" },
                        new Lga { Id = 20, Name = "Orumba South" },
                        new Lga { Id = 21, Name = "Oyi" },
                    }
                },
                new State
                {
                    Id = 5,
                    Name = "Bauchi",
                    Capital = "Bauchi",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Alkaleri" },
                        new Lga { Id = 2, Name = "Bauchi" },
                        new Lga { Id = 3, Name = "Bogoro" },
                        new Lga { Id = 4, Name = "Damban" },
                        new Lga { Id = 5, Name = "Darazo" },
                        new Lga { Id = 6, Name = "Dass" },
                        new Lga { Id = 7, Name = "Gamawa" },
                        new Lga { Id = 8, Name = "Ganjuwa" },
                        new Lga { Id = 9, Name = "Giade" },
                        new Lga { Id = 10, Name = "Itas/Gadau" },
                        new Lga { Id = 11, Name = "Jama'are" },
                        new Lga { Id = 12, Name = "Katagum" },
                        new Lga { Id = 13, Name = "Kirfi" },
                        new Lga { Id = 14, Name = "Misau" },
                        new Lga { Id = 15, Name = "Ningi" },
                        new Lga { Id = 16, Name = "Shira" },
                        new Lga { Id = 17, Name = "Tafawa Balewa" },
                        new Lga { Id = 18, Name = "Toro" },
                        new Lga { Id = 19, Name = "Warji" },
                        new Lga { Id = 20, Name = "Zaki" },
                    }
                },
                new State
                {
                    Id = 6,
                    Name = "Bayelsa",
                    Capital = "Yenagoa",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Brass" },
                        new Lga { Id = 2, Name = "Ekeremor" },
                        new Lga { Id = 3, Name = "Kolokuma/Opokuma" },
                        new Lga { Id = 4, Name = "Nembe" },
                        new Lga { Id = 5, Name = "Ogbia" },
                        new Lga { Id = 6, Name = "Sagbama" },
                        new Lga { Id = 7, Name = "Southern Ijaw" },
                        new Lga { Id = 8, Name = "Yenagoa" },
                    }
                },
                new State
                {
                    Id = 7,
                    Name = "Benue",
                    Capital = "Yenagoa",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Agatu" },
                        new Lga { Id = 2, Name = "Apa" },
                        new Lga { Id = 3, Name = "Ado" },
                        new Lga { Id = 4, Name = "Buruku" },
                        new Lga { Id = 5, Name = "Gboko" },
                        new Lga { Id = 6, Name = "Guma" },
                        new Lga { Id = 7, Name = "Gwer East" },
                        new Lga { Id = 8, Name = "Gwer West" },
                        new Lga { Id = 9, Name = "Katsina-Ala" },
                        new Lga { Id = 10, Name = "Konshisha" },
                        new Lga { Id = 11, Name = "Kwande" },
                        new Lga { Id = 12, Name = "Logo" },
                        new Lga { Id = 13, Name = "Makurdi" },
                        new Lga { Id = 14, Name = "Obi" },
                        new Lga { Id = 15, Name = "Ogbadibo" },
                        new Lga { Id = 16, Name = "Ohimini" },
                        new Lga { Id = 17, Name = "Oju" },
                        new Lga { Id = 18, Name = "Okpokwu" },
                        new Lga { Id = 19, Name = "Oturkpo" },
                        new Lga { Id = 20, Name = "Tarka" },
                        new Lga { Id = 21, Name = "Ukum" },
                        new Lga { Id = 22, Name = "Ushongo" },
                        new Lga { Id = 23, Name = "Vandeikya" },
                    }
                },
                new State
                {
                    Id = 8,
                    Name = "Borno",
                    Capital = "Maiduguri",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abadam" },
                        new Lga { Id = 2, Name = "Askira/Uba" },
                        new Lga { Id = 3, Name = "Bama" },
                        new Lga { Id = 4, Name = "Bayo" },
                        new Lga { Id = 5, Name = "Biu" },
                        new Lga { Id = 6, Name = "Chibok" },
                        new Lga { Id = 7, Name = "Damboa" },
                        new Lga { Id = 8, Name = "Dikwa" },
                        new Lga { Id = 9, Name = "Guzamala" },
                        new Lga { Id = 10, Name = "Gubio" },
                        new Lga { Id = 11, Name = "Hawul" },
                        new Lga { Id = 12, Name = "Gwoza" },
                        new Lga { Id = 13, Name = "Jere" },
                        new Lga { Id = 14, Name = "Kaga" },
                        new Lga { Id = 15, Name = "Kala/Balge" },
                        new Lga { Id = 16, Name = "Konduga" },
                        new Lga { Id = 17, Name = "Kukawa" },
                        new Lga { Id = 18, Name = "Kwaya Kusar" },
                        new Lga { Id = 19, Name = "Mafa" },
                        new Lga { Id = 20, Name = "Magumeri" },
                        new Lga { Id = 21, Name = "Maiduguri" },
                        new Lga { Id = 22, Name = "Mobbar" },
                        new Lga { Id = 23, Name = "Marte" },
                        new Lga { Id = 24, Name = "Monguno" },
                        new Lga { Id = 25, Name = "Ngala" },
                        new Lga { Id = 26, Name = "Nganzai" },
                        new Lga { Id = 27, Name = "Shani" },
                    }
                },
                new State
                {
                    Id = 9,
                    Name = "Cross River",
                    Capital = "Calabar",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abi" },
                        new Lga { Id = 2, Name = "Akamkpa" },
                        new Lga { Id = 3, Name = "Akpabuyo" },
                        new Lga { Id = 4, Name = "Bakassi" },
                        new Lga { Id = 5, Name = "Bekwarra" },
                        new Lga { Id = 6, Name = "Biase" },
                        new Lga { Id = 7, Name = "Boki" },
                        new Lga { Id = 8, Name = "Calabar Municipal" },
                        new Lga { Id = 9, Name = "Calabar South" },
                        new Lga { Id = 10, Name = "Etung" },
                        new Lga { Id = 11, Name = "Ikom" },
                        new Lga { Id = 12, Name = "Obanliku" },
                        new Lga { Id = 13, Name = "Obubra" },
                        new Lga { Id = 14, Name = "Obudu" },
                        new Lga { Id = 15, Name = "Odukpani" },
                        new Lga { Id = 16, Name = "Ogoja" },
                        new Lga { Id = 17, Name = "Yakuur" },
                        new Lga { Id = 18, Name = "Yala" },
                    }
                },
                new State
                {
                    Id = 10,
                    Name = "Delta",
                    Capital = "Asaba",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aniocha North" },
                        new Lga { Id = 2, Name = "Aniocha South" },
                        new Lga { Id = 3, Name = "Bomadi" },
                        new Lga { Id = 4, Name = "Burutu" },
                        new Lga { Id = 5, Name = "Ethiope West" },
                        new Lga { Id = 6, Name = "Ethiope East" },
                        new Lga { Id = 7, Name = "Ika North East" },
                        new Lga { Id = 8, Name = "Ika South" },
                        new Lga { Id = 9, Name = "Isoko North" },
                        new Lga { Id = 10, Name = "Isoko South" },
                        new Lga { Id = 11, Name = "Ndokwa East" },
                        new Lga { Id = 12, Name = "Ndokwa West" },
                        new Lga { Id = 13, Name = "Okpe" },
                        new Lga { Id = 14, Name = "Oshimili North" },
                        new Lga { Id = 15, Name = "Oshimili South" },
                        new Lga { Id = 16, Name = "Patani" },
                        new Lga { Id = 17, Name = "Sapele" },
                        new Lga { Id = 18, Name = "Udu" },
                        new Lga { Id = 19, Name = "Ughelli North" },
                        new Lga { Id = 20, Name = "Ukwuani" },
                        new Lga { Id = 21, Name = "Ughelli South" },
                        new Lga { Id = 22, Name = "Uvwie" },
                        new Lga { Id = 23, Name = "Warri North" },
                        new Lga { Id = 24, Name = "Warri South" },
                        new Lga { Id = 25, Name = "Warri South West" },
                    }
                },
                new State
                {
                    Id = 11,
                    Name = "Ebonyi",
                    Capital = "Abakaliki",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abakaliki" },
                        new Lga { Id = 2, Name = "Afikpo North" },
                        new Lga { Id = 3, Name = "Ebonyi" },
                        new Lga { Id = 4, Name = "Afikpo South" },
                        new Lga { Id = 5, Name = "Ezza North" },
                        new Lga { Id = 6, Name = "Ikwo" },
                        new Lga { Id = 7, Name = "Ezza South" },
                        new Lga { Id = 8, Name = "Ivo" },
                        new Lga { Id = 9, Name = "Ishielu" },
                        new Lga { Id = 10, Name = "Izzi" },
                        new Lga { Id = 11, Name = "Ohaozara" },
                        new Lga { Id = 12, Name = "Ohaukwu" },
                        new Lga { Id = 13, Name = "Onicha" },
                    }
                },
                new State
                {
                    Id = 12,
                    Name = "Edo",
                    Capital = "Benin City",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Akoko-Edo" },
                        new Lga { Id = 2, Name = "Egor" },
                        new Lga { Id = 3, Name = "Esan Central" },
                        new Lga { Id = 4, Name = "Esan North-East" },
                        new Lga { Id = 5, Name = "Esan South-East" },
                        new Lga { Id = 6, Name = "Esan West" },
                        new Lga { Id = 7, Name = "Etsako Central" },
                        new Lga { Id = 8, Name = "Etsako East" },
                        new Lga { Id = 9, Name = "Etsako West" },
                        new Lga { Id = 10, Name = "Igueben" },
                        new Lga { Id = 11, Name = "Ikpoba Okha" },
                        new Lga { Id = 12, Name = "Orhionmwon" },
                        new Lga { Id = 13, Name = "Oredo" },
                        new Lga { Id = 14, Name = "Ovia North-East" },
                        new Lga { Id = 15, Name = "Ovia South-West" },
                        new Lga { Id = 16, Name = "Owan East" },
                        new Lga { Id = 17, Name = "Owan West" },
                        new Lga { Id = 18, Name = "Uhunmwonde" },
                    }
                },
                new State
                {
                    Id = 13,
                    Name = "Ekiti",
                    Capital = "Ado Ekiti",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Ado Ekiti" },
                        new Lga { Id = 2, Name = "Efon" },
                        new Lga { Id = 3, Name = "Ekiti East" },
                        new Lga { Id = 4, Name = "Ekiti South-West" },
                        new Lga { Id = 5, Name = "Ekiti West" },
                        new Lga { Id = 6, Name = "Emure" },
                        new Lga { Id = 7, Name = "Gbonyin" },
                        new Lga { Id = 8, Name = "Ido Osi" },
                        new Lga { Id = 9, Name = "Ijero" },
                        new Lga { Id = 10, Name = "Ikere" },
                        new Lga { Id = 11, Name = "Ilejemeje" },
                        new Lga { Id = 12, Name = "Irepodun/Ifelodun" },
                        new Lga { Id = 13, Name = "Ikole" },
                        new Lga { Id = 14, Name = "Ise/Orun" },
                        new Lga { Id = 15, Name = "Moba" },
                        new Lga { Id = 16, Name = "Oye" },
                    }
                },
                new State
                {
                    Id = 14,
                    Name = "Enugu",
                    Capital = "Enugu",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Awgu" },
                        new Lga { Id = 2, Name = "Aninri" },
                        new Lga { Id = 3, Name = "Enugu East" },
                        new Lga { Id = 4, Name = "Enugu North" },
                        new Lga { Id = 5, Name = "Ezeagu" },
                        new Lga { Id = 6, Name = "Enugu South" },
                        new Lga { Id = 7, Name = "Igbo Etiti" },
                        new Lga { Id = 8, Name = "Igbo Eze North" },
                        new Lga { Id = 9, Name = "Igbo Eze South" },
                        new Lga { Id = 10, Name = "Isi Uzo" },
                        new Lga { Id = 11, Name = "Nkanu East" },
                        new Lga { Id = 12, Name = "Nkanu West" },
                        new Lga { Id = 13, Name = "Nsukka" },
                        new Lga { Id = 14, Name = "Udenu" },
                        new Lga { Id = 15, Name = "Oji River" },
                        new Lga { Id = 16, Name = "Uzo Uwani" },
                        new Lga { Id = 17, Name = "Udi" },
                    }
                },
                new State
                {
                    Id = 15,
                    Name = "Gombe",
                    Capital ="Gombe",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Akko" },
                        new Lga { Id = 2, Name = "Balanga" },
                        new Lga { Id = 3, Name = "Billiri" },
                        new Lga { Id = 4, Name = "Dukku" },
                        new Lga { Id = 5, Name = "Funakaye" },
                        new Lga { Id = 6, Name = "Gombe" },
                        new Lga { Id = 7, Name = "Kaltungo" },
                        new Lga { Id = 8, Name = "Kwami" },
                        new Lga { Id = 9, Name = "Nafada" },
                        new Lga { Id = 10, Name = "Shongom" },
                        new Lga { Id = 11, Name = "Yamaltu/Deba" },
                    }
                },
                new State
                {
                    Id = 16,
                    Name = "Imo",
                    Capital = "Owerri",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aboh Mbaise" },
                        new Lga { Id = 2, Name = "Ahiazu Mbaise" },
                        new Lga { Id = 3, Name = "Ehime Mbano" },
                        new Lga { Id = 4, Name = "Ezinihitte" },
                        new Lga { Id = 5, Name = "Ideato North" },
                        new Lga { Id = 6, Name = "Ideato South" },
                        new Lga { Id = 7, Name = "Ihitte/Uboma" },
                        new Lga { Id = 8, Name = "Ikeduru" },
                        new Lga { Id = 9, Name = "Isiala Mbano" },
                        new Lga { Id = 10, Name = "Mbaitoli" },
                        new Lga { Id = 11, Name = "Isu" },
                        new Lga { Id = 12, Name = "Ngor Okpala" },
                        new Lga { Id = 13, Name = "Njaba" },
                        new Lga { Id = 14, Name = "Nkwerre" },
                        new Lga { Id = 15, Name = "Nwangele" },
                        new Lga { Id = 16, Name = "Obowo" },
                        new Lga { Id = 17, Name = "Oguta" },
                        new Lga { Id = 18, Name = "Ohaji/Egbema" },
                        new Lga { Id = 19, Name = "Okigwe" },
                        new Lga { Id = 20, Name = "Orlu" },
                        new Lga { Id = 21, Name = "Orsu" },
                        new Lga { Id = 22, Name = "Oru East" },
                        new Lga { Id = 23, Name = "Oru West" },
                        new Lga { Id = 24, Name = "Owerri Municipal" },
                        new Lga { Id = 25, Name = "Owerri North" },
                        new Lga { Id = 26, Name = "Unuimo" },
                        new Lga { Id = 27, Name = "Owerri West" },
                    }
                },
                new State
                {
                    Id = 17,
                    Name = "Jigawa",
                    Capital = "Dutse",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Auyo" },
                        new Lga { Id = 2, Name = "Babura" },
                        new Lga { Id = 3, Name = "Buji" },
                        new Lga { Id = 4, Name = "Biriniwa" },
                        new Lga { Id = 5, Name = "Birnin Kudu" },
                        new Lga { Id = 6, Name = "Dutse" },
                        new Lga { Id = 7, Name = "Gagarawa" },
                        new Lga { Id = 8, Name = "Garki" },
                        new Lga { Id = 9, Name = "Gumel" },
                        new Lga { Id = 10, Name = "Guri" },
                        new Lga { Id = 11, Name = "Gwaram" },
                        new Lga { Id = 12, Name = "Gwiwa" },
                        new Lga { Id = 13, Name = "Hadejia" },
                        new Lga { Id = 14, Name = "Jahun" },
                        new Lga { Id = 15, Name = "Kafin Hausa" },
                        new Lga { Id = 16, Name = "Kazaure" },
                        new Lga { Id = 17, Name = "Kiri Kasama" },
                        new Lga { Id = 18, Name = "Kiyawa" },
                        new Lga { Id = 19, Name = "Kaugama" },
                        new Lga { Id = 20, Name = "Maigatari" },
                        new Lga { Id = 21, Name = "Malam Madori" },
                        new Lga { Id = 22, Name = "Miga" },
                        new Lga { Id = 23, Name = "Sule Tankarkar" },
                        new Lga { Id = 24, Name = "Roni" },
                        new Lga { Id = 25, Name = "Ringim" },
                        new Lga { Id = 26, Name = "Yankwashi" },
                        new Lga { Id = 27, Name = "Taura" },
                    }
                },
                new State
                {
                    Id = 18,
                    Name = "Kaduna",
                    Capital = "Kaduna",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Birnin Gwari" },
                        new Lga { Id = 2, Name = "Chikun" },
                        new Lga { Id = 3, Name = "Giwa" },
                        new Lga { Id = 4, Name = "Ikara" },
                        new Lga { Id = 5, Name = "Igabi" },
                        new Lga { Id = 6, Name = "Jaba" },
                        new Lga { Id = 7, Name = "Jema'a" },
                        new Lga { Id = 8, Name = "Kachia" },
                        new Lga { Id = 9, Name = "Kaduna North" },
                        new Lga { Id = 10, Name = "Kaduna South" },
                        new Lga { Id = 11, Name = "Kagarko" },
                        new Lga { Id = 12, Name = "Kajuru" },
                        new Lga { Id = 13, Name = "Kaura" },
                        new Lga { Id = 14, Name = "Kauru" },
                        new Lga { Id = 15, Name = "Kubau" },
                        new Lga { Id = 16, Name = "Kudan" },
                        new Lga { Id = 17, Name = "Lere" },
                        new Lga { Id = 18, Name = "Makarfi" },
                        new Lga { Id = 19, Name = "Sabon Gari" },
                        new Lga { Id = 20, Name = "Sanga" },
                        new Lga { Id = 21, Name = "Soba" },
                        new Lga { Id = 22, Name = "Zangon Kataf" },
                        new Lga { Id = 23, Name = "Zaria" },
                    }
                },
                new State
                {
                    Id = 19,
                    Name = "Kano",
                    Capital = "Kano",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Ajingi" },
                        new Lga { Id = 2, Name = "Albasu" },
                        new Lga { Id = 3, Name = "Bagwai" },
                        new Lga { Id = 4, Name = "Bebeji" },
                        new Lga { Id = 5, Name = "Bichi" },
                        new Lga { Id = 6, Name = "Bunkure" },
                        new Lga { Id = 7, Name = "Dala" },
                        new Lga { Id = 8, Name = "Dambatta" },
                        new Lga { Id = 9, Name = "Dawakin Kudu" },
                        new Lga { Id = 10, Name = "Dawakin Tofa" },
                        new Lga { Id = 11, Name = "Doguwa" },
                        new Lga { Id = 12, Name = "Fagge" },
                        new Lga { Id = 13, Name = "Gabasawa" },
                        new Lga { Id = 14, Name = "Garko" },
                        new Lga { Id = 15, Name = "Garun Mallam" },
                        new Lga { Id = 16, Name = "Gezawa" },
                        new Lga { Id = 17, Name = "Gaya" },
                        new Lga { Id = 18, Name = "Gwale" },
                        new Lga { Id = 19, Name = "Gwarzo" },
                        new Lga { Id = 20, Name = "Kabo" },
                        new Lga { Id = 21, Name = "Kano Municipal" },
                        new Lga { Id = 22, Name = "Karaye" },
                        new Lga { Id = 23, Name = "Kibiya" },
                        new Lga { Id = 24, Name = "Kiru" },
                        new Lga { Id = 25, Name = "Kumbotso" },
                        new Lga { Id = 26, Name = "Kunchi" },
                        new Lga { Id = 27, Name = "Kura" },
                        new Lga { Id = 28, Name = "Madobi" },
                        new Lga { Id = 29, Name = "Makoda" },
                        new Lga { Id = 30, Name = "Minjibir" },
                        new Lga { Id = 31, Name = "Nasarawa" },
                        new Lga { Id = 32, Name = "Rano" },
                        new Lga { Id = 33, Name = "Rimin Gado" },
                        new Lga { Id = 34, Name = "Rogo" },
                        new Lga { Id = 35, Name = "Shanono" },
                        new Lga { Id = 36, Name = "Takai" },
                        new Lga { Id = 37, Name = "Sumaila" },
                        new Lga { Id = 38, Name = "Tarauni" },
                        new Lga { Id = 39, Name = "Tofa" },
                        new Lga { Id = 40, Name = "Tsanyawa" },
                        new Lga { Id = 41, Name = "Tudun Wada" },
                        new Lga { Id = 42, Name = "Ungogo" },
                        new Lga { Id = 43, Name = "Warawa" },
                        new Lga { Id = 44, Name = "Wudil" },
                    }
                },
                new State
                {
                    Id = 20,
                    Name = "Katsina",
                    Capital = "Katsina",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Bakori" },
                        new Lga { Id = 2, Name = "Batagarawa" },
                        new Lga { Id = 3, Name = "Batsari" },
                        new Lga { Id = 4, Name = "Baure" },
                        new Lga { Id = 5, Name = "Bindawa" },
                        new Lga { Id = 6, Name = "Charanchi" },
                        new Lga { Id = 7, Name = "Danja" },
                        new Lga { Id = 8, Name = "Dandume" },
                        new Lga { Id = 9, Name = "Dan Musa" },
                        new Lga { Id = 10, Name = "Daura" },
                        new Lga { Id = 11, Name = "Dutsi" },
                        new Lga { Id = 12, Name = "Dutsin Ma" },
                        new Lga { Id = 13, Name = "Faskari" },
                        new Lga { Id = 14, Name = "Funtua" },
                        new Lga { Id = 15, Name = "Ingawa" },
                        new Lga { Id = 16, Name = "Jibia" },
                        new Lga { Id = 17, Name = "Kafur" },
                        new Lga { Id = 18, Name = "Kaita" },
                        new Lga { Id = 19, Name = "Kankara" },
                        new Lga { Id = 20, Name = "Kankia" },
                        new Lga { Id = 21, Name = "Katsina" },
                        new Lga { Id = 22, Name = "Kurfi" },
                        new Lga { Id = 23, Name = "Kusada" },
                        new Lga { Id = 24, Name = "Mai'Adua" },
                        new Lga { Id = 25, Name = "Malumfashi" },
                        new Lga { Id = 26, Name = "Mani" },
                        new Lga { Id = 27, Name = "Mashi" },
                        new Lga { Id = 28, Name = "Matazu" },
                        new Lga { Id = 29, Name = "Musawa" },
                        new Lga { Id = 30, Name = "Rimi" },
                        new Lga { Id = 31, Name = "Sabuwa" },
                        new Lga { Id = 32, Name = "Safana" },
                        new Lga { Id = 33, Name = "Sandamu" },
                        new Lga { Id = 34, Name = "Zango" },
                    }
                },
                new State
                {
                    Id = 21,
                    Name = "Kebbi",
                    Capital = "Birnin Kebbi",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aleiro" },
                        new Lga { Id = 2, Name = "Argungu" },
                        new Lga { Id = 3, Name = "Arewa Dandi" },
                        new Lga { Id = 4, Name = "Augie" },
                        new Lga { Id = 5, Name = "Bagudo" },
                        new Lga { Id = 6, Name = "Birnin Kebbi" },
                        new Lga { Id = 7, Name = "Bunza" },
                        new Lga { Id = 8, Name = "Dandi" },
                        new Lga { Id = 9, Name = "Fakai" },
                        new Lga { Id = 10, Name = "Gwandu" },
                        new Lga { Id = 11, Name = "Jega" },
                        new Lga { Id = 12, Name = "Kalgo" },
                        new Lga { Id = 13, Name = "Koko/Besse" },
                        new Lga { Id = 14, Name = "Maiyama" },
                        new Lga { Id = 15, Name = "Ngaski" },
                        new Lga { Id = 16, Name = "Shanga" },
                        new Lga { Id = 17, Name = "Suru" },
                        new Lga { Id = 18, Name = "Sakaba" },
                        new Lga { Id = 19, Name = "Wasagu/Danko" },
                        new Lga { Id = 20, Name = "Yauri" },
                        new Lga { Id = 21, Name = "Zuru" },
                    }
                },
                new State
                {
                    Id = 22,
                    Name = "Kogi",
                    Capital = "Lokoja",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Ajaokuta" },
                        new Lga { Id = 2, Name = "Adavi" },
                        new Lga { Id = 3, Name = "Ankpa" },
                        new Lga { Id = 4, Name = "Bassa" },
                        new Lga { Id = 5, Name = "Dekina" },
                        new Lga { Id = 6, Name = "Ibaji" },
                        new Lga { Id = 7, Name = "Idah" },
                        new Lga { Id = 8, Name = "Igalamela Odolu" },
                        new Lga { Id = 9, Name = "Ijumu" },
                        new Lga { Id = 10, Name = "Kogi" },
                        new Lga { Id = 11, Name = "Kabba/Bunu" },
                        new Lga { Id = 12, Name = "Lokoja" },
                        new Lga { Id = 13, Name = "Ofu" },
                        new Lga { Id = 14, Name = "Mopa Muro" },
                        new Lga { Id = 15, Name = "Ogori/Magongo" },
                        new Lga { Id = 16, Name = "Okehi" },
                        new Lga { Id = 17, Name = "Okene" },
                        new Lga { Id = 18, Name = "Olamaboro" },
                        new Lga { Id = 19, Name = "Omala" },
                        new Lga { Id = 20, Name = "Yagba East" },
                        new Lga { Id = 21, Name = "Yagba West" },
                    }
                },
                new State
                {
                    Id = 23,
                    Name = "Kwara",
                    Capital = "Ilorin",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Asa" },
                        new Lga { Id = 2, Name = "Baruten" },
                        new Lga { Id = 3, Name = "Edu" },
                        new Lga { Id = 4, Name = "Ilorin East" },
                        new Lga { Id = 5, Name = "Ifelodun" },
                        new Lga { Id = 6, Name = "Ilorin South" },
                        new Lga { Id = 7, Name = "Ekiti Kwara State" },
                        new Lga { Id = 8, Name = "Ilorin West" },
                        new Lga { Id = 9, Name = "Irepodun" },
                        new Lga { Id = 10, Name = "Isin" },
                        new Lga { Id = 11, Name = "Kaiama" },
                        new Lga { Id = 12, Name = "Moro" },
                        new Lga { Id = 13, Name = "Offa" },
                        new Lga { Id = 14, Name = "Oke Ero" },
                        new Lga { Id = 15, Name = "Oyun" },
                        new Lga { Id = 16, Name = "Pategi" },
                    }
                },
                new State
                {
                    Id = 24,
                    Name = "Lagos",
                    Capital = "Ikeja",
                    Lgas = new List<Lga>
                    {
                        new Lga 
                        { 
                            Id = 1, 
                            Name = "Agege",
                            Cities = new List<City>
                            {
                                new City { Id = 1, Name = "Oko-Oba" },
                                new City { Id = 2, Name = "Dopemu" },
                                new City { Id = 3, Name = "Capitol" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 2,
                            Name = "Ajeromi-Ifelodun",
                            Cities = new List<City>
                            {
                                new City { Id = 4, Name = "Ajegunle" },
                                new City { Id = 5, Name = "Amukoko" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 3, 
                            Name = "Alimosho",
                            Cities = new List<City>
                            {
                                new City { Id = 6, Name = "Egbeda" },
                                new City { Id = 7, Name = "Ikotun" },
                                new City { Id = 8, Name = "Ipaja" },
                                new City { Id = 9, Name = "Iyana-Ipaja" },
                                new City { Id = 10, Name = "Akowonjo" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 4, 
                            Name = "Amuwo-Odofin",
                            Cities = new List<City>
                            {
                                new City { Id = 11, Name = "Festac Town" },
                                new City { Id = 12, Name = "Satellite Town" },
                                new City { Id = 13, Name = "Trade Fair Complex" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 5, 
                            Name = "Badagry",
                            Cities = new List<City>
                            {
                                new City { Id = 14, Name = "Badagry Town" },
                                new City { Id = 15, Name = "Ajara" },
                                new City { Id = 16, Name = "Seme Border" },
                                new City { Id = 17, Name = "Ibereko" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 6, 
                            Name = "Apapa",
                            Cities = new List<City>
                            {
                                new City { Id = 18, Name = "Apapa Wharf" },
                                new City { Id = 19, Name = "Ajegunle" },
                                new City { Id = 20, Name = "Iganmu" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 7, 
                            Name = "Epe",
                            Cities = new List<City>
                            {
                                new City { Id = 21, Name = "Epe Town" },
                                new City { Id = 22, Name = "Igbogbo" },
                                new City { Id = 23, Name = "Ilara" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 8, 
                            Name = "Eti Osa",
                            Cities = new List<City>
                            {
                                new City { Id = 24, Name = "Victoria Island" },
                                new City { Id = 25, Name = "Lekki" },
                                new City { Id = 26, Name = "Ikoyi" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 9, 
                            Name = "Ibeju-Lekki",
                            Cities = new List<City>
                            {
                                new City { Id = 27, Name = "Ibeju Town" },
                                new City { Id = 28, Name = "Lekki Free Trade Zone" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 10, 
                            Name = "Ifako-Ijaiye",
                            Cities = new List<City>
                            {
                                new City { Id = 29, Name = "Iju" },
                                new City { Id = 30, Name = "Ishaga" },
                                new City { Id = 31, Name = "Ojokoro" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 11,
                            Name = "Ikeja",
                            Cities = new List<City>
                            {
                                new City { Id = 32, Name = "Alausa" },
                                new City { Id = 33, Name = "Ojodu" },
                                new City { Id = 34, Name = "Ogba" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 12, 
                            Name = "Ikorodu",
                            Cities = new List<City>
                            {
                                new City { Id = 35, Name = "Ikorodu Town" },
                                new City { Id = 36, Name = "Imota" },
                                new City { Id = 37, Name = "Igbogbo-Baiyeku" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 13, 
                            Name = "Kosofe",
                            Cities = new List<City>
                            {
                                new City { Id = 38, Name = "Ogudu" },
                                new City { Id = 39, Name = "Magodo" },
                                new City { Id = 40, Name = "Ketu" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 14, 
                            Name = "Lagos Island",
                            Cities = new List<City>
                            {
                                new City { Id = 41, Name = "Obalende" },
                                new City { Id = 42, Name = "Marina" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 15, 
                            Name = "Mushin",
                            Cities = new List<City>
                            {
                                new City { Id = 43, Name = "Idi-Araba" },
                                new City { Id = 44, Name = "Olorunsogo" }
                            }
                        },
                        new Lga 
                        {
                            Id = 16, 
                            Name = "Lagos Mainland",
                            Cities = new List<City>
                            {
                                new City { Id = 45, Name = "Ebute-Metta" },
                                new City { Id = 46, Name = "Yaba" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 17, 
                            Name = "Ojo",
                            Cities = new List<City>
                            {
                                new City { Id = 47, Name = "Alaba" },
                                new City { Id = 48, Name = "Ijanikin" },
                                new City { Id = 49, Name = "Ojo Town" }
                            }
                        },
                        new Lga 
                        { 
                            Id = 18, 
                            Name = "Oshodi-Isolo",
                            Cities = new List<City>
                            {
                                new City { Id = 50, Name = "Oshodi" },
                                new City { Id = 51, Name = "Isolo" },
                                new City { Id = 52, Name = "Mafoluku" }
                            }
                        },
                        new Lga { 
                            Id = 19, 
                            Name = "Shomolu", 
                            Cities = new List<City>
                            {
                                new City { Id = 53, Name = "Bariga" },
                                new City { Id = 54, Name = "Shomolu Town" }
                            } 
                        },
                        new Lga 
                        { 
                            Id = 20, 
                            Name = "Surulere Lagos State",  
                            Cities = new List<City>
                            {
                                new City { Id = 55, Name = "Ojuelegba" },
                                new City { Id = 56, Name = "Aguda" }
                            } 
                        },
                    }
                },
                new State
                {
                    Id = 25,
                    Name = "Nasarawa",
                    Capital = "Lafia",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Akwanga" },
                        new Lga { Id = 2, Name = "Awe" },
                        new Lga { Id = 3, Name = "Doma" },
                        new Lga { Id = 4, Name = "Karu" },
                        new Lga { Id = 5, Name = "Keana" },
                        new Lga { Id = 6, Name = "Keffi" },
                        new Lga { Id = 7, Name = "Lafia" },
                        new Lga { Id = 8, Name = "Kokona" },
                        new Lga { Id = 9, Name = "Nasarawa Egon" },
                        new Lga { Id = 10, Name = "Nasarawa" },
                        new Lga { Id = 11, Name = "Obi" },
                        new Lga { Id = 12, Name = "Toto" },
                        new Lga { Id = 13, Name = "Wamba" },
                    }
                },
                new State
                {
                    Id= 26,
                    Name = "Niger",
                    Capital = "Minna",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Agaie" },
                        new Lga { Id = 2, Name = "Agwara" },
                        new Lga { Id = 3, Name = "Bida" },
                        new Lga { Id = 4, Name = "Borgu" },
                        new Lga { Id = 5, Name = "Bosso" },
                        new Lga { Id = 6, Name = "Chanchaga" },
                        new Lga { Id = 7, Name = "Edati" },
                        new Lga { Id = 8, Name = "Gbako" },
                        new Lga { Id = 9, Name = "Gurara" },
                        new Lga { Id = 10, Name = "Katcha" },
                        new Lga { Id = 11, Name = "Kontagora" },
                        new Lga { Id = 12, Name = "Lapai" },
                        new Lga { Id = 13, Name = "Lavun" },
                        new Lga { Id = 14, Name = "Mariga" },
                        new Lga { Id = 15, Name = "Magama" },
                        new Lga { Id = 16, Name = "Mokwa" },
                        new Lga { Id = 17, Name = "Mashegu" },
                        new Lga { Id = 18, Name = "Moya" },
                        new Lga { Id = 19, Name = "Paikoro" },
                        new Lga { Id = 20, Name = "Rafi" },
                        new Lga { Id = 21, Name = "Rijau" },
                        new Lga { Id = 22, Name = "Shiroro" },
                        new Lga { Id = 23, Name = "Suleja" },
                        new Lga { Id = 24, Name = "Tafa" },
                        new Lga { Id = 25, Name = "Wushishi" },
                    }
                },
                new State
                {
                    Id = 27,
                    Name = "Ogun",
                    Capital = "Abeokuta",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abeokuta North" },
                        new Lga { Id = 2, Name = "Abeokuta South" },
                        new Lga { Id = 3, Name = "Ado-Odo/Ota" },
                        new Lga { Id = 4, Name = "Egbado North" },
                        new Lga { Id = 5, Name = "Ewekoro" },
                        new Lga { Id = 6, Name = "Egbado South" },
                        new Lga { Id = 7, Name = "Ijebu North" },
                        new Lga { Id = 8, Name = "Ijebu East" },
                        new Lga { Id = 9, Name = "Ifo" },
                        new Lga { Id = 10, Name = "Ijebu Ode" },
                        new Lga { Id = 11, Name = "Ijebu North East" },
                        new Lga { Id = 12, Name = "Imeko Afon" },
                        new Lga { Id = 13, Name = "Ikenne" },
                        new Lga { Id = 14, Name = "Ipokia" },
                        new Lga { Id = 15, Name = "Odeda" },
                        new Lga { Id = 16, Name = "Obafemi Owode" },
                        new Lga { Id = 17, Name = "Odogbolu" },
                        new Lga { Id = 18, Name = "Remo North" },
                        new Lga { Id = 19, Name = "Ogun Waterside" },
                        new Lga { Id = 20, Name = "Shagamu" },
                    }
                },
                new State
                {
                    Id = 28,
                    Name = "Ondo",
                    Capital = "Akure",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Akoko North-East" },
                        new Lga { Id = 2, Name = "Akoko North-West" },
                        new Lga { Id = 3, Name = "Akoko South-West" },
                        new Lga { Id = 4, Name = "Akoko South-East" },
                        new Lga { Id = 5, Name = "Akure North" },
                        new Lga { Id = 6, Name = "Akure South" },
                        new Lga { Id = 7, Name = "Ese Odo" },
                        new Lga { Id = 8, Name = "Idanre" },
                        new Lga { Id = 9, Name = "Ifedore" },
                        new Lga { Id = 10, Name = "Ilaje" },
                        new Lga { Id = 11, Name = "Irele" },
                        new Lga { Id = 12, Name = "Ile Oluji/Okeigbo" },
                        new Lga { Id = 13, Name = "Odigbo" },
                        new Lga { Id = 14, Name = "Okitipupa" },
                        new Lga { Id = 15, Name = "Ondo West" },
                        new Lga { Id = 16, Name = "Ose" },
                        new Lga { Id = 17, Name = "Ondo East" },
                        new Lga { Id = 18, Name = "Owo" },
                    }
                },
                new State
                {
                    Id = 29,
                    Name = "Osun",
                    Capital = "Oshogbo",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Aiyedire" },
                        new Lga { Id = 2, Name = "Atakunmosa West" },
                        new Lga { Id = 3, Name = "Atakunmosa East" },
                        new Lga { Id = 4, Name = "Aiyedaade" },
                        new Lga { Id = 5, Name = "Boluwaduro" },
                        new Lga { Id = 6, Name = "Boripe" },
                        new Lga { Id = 7, Name = "Ife East" },
                        new Lga { Id = 8, Name = "Ede South" },
                        new Lga { Id = 9, Name = "Ife North" },
                        new Lga { Id = 10, Name = "Ede North" },
                        new Lga { Id = 11, Name = "Ife South" },
                        new Lga { Id = 12, Name = "Ejigbo" },
                        new Lga { Id = 13, Name = "Ife Central" },
                        new Lga { Id = 14, Name = "Ifedayo" },
                        new Lga { Id = 15, Name = "Egbedore" },
                        new Lga { Id = 16, Name = "Ila" },
                        new Lga { Id = 17, Name = "Ifelodun" },
                        new Lga { Id = 18, Name = "Ilesa East" },
                        new Lga { Id = 19, Name = "Ilesa West" },
                        new Lga { Id = 20, Name = "Irepodun" },
                        new Lga { Id = 21, Name = "Irewole" },
                        new Lga { Id = 22, Name = "Isokan" },
                        new Lga { Id = 23, Name = "Iwo" },
                        new Lga { Id = 24, Name = "Obokun" },
                        new Lga { Id = 25, Name = "Odo Otin" },
                        new Lga { Id = 26, Name = "Ola Oluwa" },
                        new Lga { Id = 27, Name = "Olorunda" },
                        new Lga { Id = 28, Name = "Oriade" },
                        new Lga { Id = 29, Name = "Orolu" },
                        new Lga { Id = 30, Name = "Osogbo" },
                    }
                },
                new State
                {
                    Id = 30,
                    Name = "Oyo",
                    Capital = "Ibadan",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Afijio" },
                        new Lga { Id = 2, Name = "Akinyele" },
                        new Lga { Id = 3, Name = "Atiba" },
                        new Lga { Id = 4, Name = "Atisbo" },
                        new Lga { Id = 5, Name = "Egbeda" },
                        new Lga { Id = 6, Name = "Ibadan North" },
                        new Lga { Id = 7, Name = "Ibadan North-East" },
                        new Lga { Id = 8, Name = "Ibadan North-West" },
                        new Lga { Id = 9, Name = "Ibadan South-East" },
                        new Lga { Id = 10, Name = "Ibarapa Central" },
                        new Lga { Id = 11, Name = "Ibadan South-West" },
                        new Lga { Id = 12, Name = "Ibarapa East" },
                        new Lga { Id = 13, Name = "Ido" },
                        new Lga { Id = 14, Name = "Ibarapa North" },
                        new Lga { Id = 15, Name = "Irepo" },
                        new Lga { Id = 16, Name = "Iseyin" },
                        new Lga { Id = 17, Name = "Itesiwaju" },
                        new Lga { Id = 18, Name = "Iwajowa" },
                        new Lga { Id = 19, Name = "Kajola" },
                        new Lga { Id = 20, Name = "Lagelu" },
                        new Lga { Id = 21, Name = "Ogbomosho North" },
                        new Lga { Id = 22, Name = "Ogbomosho South" },
                        new Lga { Id = 23, Name = "Ogo Oluwa" },
                        new Lga { Id = 24, Name = "Olorunsogo" },
                        new Lga { Id = 25, Name = "Oluyole" },
                        new Lga { Id = 26, Name = "Ona Ara" },
                        new Lga { Id = 27, Name = "Orelope" },
                        new Lga { Id = 28, Name = "Ori Ire" },
                        new Lga { Id = 29, Name = "Oyo" },
                        new Lga { Id = 30, Name = "Oyo East" },
                        new Lga { Id = 31, Name = "Saki East" },
                        new Lga { Id = 32, Name = "Saki West" },
                        new Lga { Id = 33, Name = "Surulere Oyo State" },
                    }
                },
                new State
                {
                    Id = 31,
                    Name = "Plateau",
                    Capital = "Jos",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Bokkos" },
                        new Lga { Id = 2, Name = "Barkin Ladi" },
                        new Lga { Id = 3, Name = "Bassa" },
                        new Lga { Id = 4, Name = "Jos East" },
                        new Lga { Id = 5, Name = "Jos North" },
                        new Lga { Id = 6, Name = "Jos South" },
                        new Lga { Id = 7, Name = "Kanam" },
                        new Lga { Id = 8, Name = "Kanke" },
                        new Lga { Id = 9, Name = "Langtang South" },
                        new Lga { Id = 10, Name = "Langtang North" },
                        new Lga { Id = 11, Name = "Mangu" },
                        new Lga { Id = 12, Name = "Mikang" },
                        new Lga { Id = 13, Name = "Pankshin" },
                        new Lga { Id = 14, Name = "Qua'an Pan" },
                        new Lga { Id = 15, Name = "Riyom" },
                        new Lga { Id = 16, Name = "Shendam" },
                        new Lga { Id = 17, Name = "Wase" },
                    }
                },
                new State
                {
                    Id = 32,
                    Name = "Rivers",
                    Capital = "Port Harcourt",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Abua/Odual" },
                        new Lga { Id = 2, Name = "Ahoada East" },
                        new Lga { Id = 3, Name = "Ahoada West" },
                        new Lga { Id = 4, Name = "Andoni" },
                        new Lga { Id = 5, Name = "Akuku-Toru" },
                        new Lga { Id = 6, Name = "Asari-Toru" },
                        new Lga { Id = 7, Name = "Bonny" },
                        new Lga { Id = 8, Name = "Degema" },
                        new Lga { Id = 9, Name = "Emuoha" },
                        new Lga { Id = 10, Name = "Eleme" },
                        new Lga { Id = 11, Name = "Ikwerre" },
                        new Lga { Id = 12, Name = "Etche" },
                        new Lga { Id = 13, Name = "Gokana" },
                        new Lga { Id = 14, Name = "Khana" },
                        new Lga { Id = 15, Name = "Obio/Akpor" },
                        new Lga { Id = 16, Name = "Ogba/Egbema/Ndoni" },
                        new Lga { Id = 17, Name = "Ogu/Bolo" },
                        new Lga { Id = 18, Name = "Okrika" },
                        new Lga { Id = 19, Name = "Omuma" },
                        new Lga { Id = 20, Name = "Opobo/Nkoro" },
                        new Lga { Id = 21, Name = "Oyigbo" },
                        new Lga { Id = 22, Name = "Port Harcourt" },
                        new Lga { Id = 23, Name = "Tai" },
                    }
                },
                new State
                {
                    Id = 33,
                    Name = "Sokoto",
                    Capital = "Sokoto",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Gudu" },
                        new Lga { Id = 2, Name = "Gwadabawa" },
                        new Lga { Id = 3, Name = "Illela" },
                        new Lga { Id = 4, Name = "Isa" },
                        new Lga { Id = 5, Name = "Kebbe" },
                        new Lga { Id = 6, Name = "Kware" },
                        new Lga { Id = 7, Name = "Rabah" },
                        new Lga { Id = 8, Name = "Sabon Birni" },
                        new Lga { Id = 9, Name = "Shagari" },
                        new Lga { Id = 10, Name = "Silame" },
                        new Lga { Id = 11, Name = "Sokoto North" },
                        new Lga { Id = 12, Name = "Sokoto South" },
                        new Lga { Id = 13, Name = "Tambuwal" },
                        new Lga { Id = 14, Name = "Tangaza" },
                        new Lga { Id = 15, Name = "Tureta" },
                        new Lga { Id = 16, Name = "Wamako" },
                        new Lga { Id = 17, Name = "Wurno" },
                        new Lga { Id = 18, Name = "Yabo" },
                        new Lga { Id = 19, Name = "Binji" },
                        new Lga { Id = 20, Name = "Bodinga" },
                        new Lga { Id = 21, Name = "Dange Shuni" },
                        new Lga { Id = 22, Name = "Goronyo" },
                        new Lga { Id = 23, Name = "Gada" },
                    }
                },
                new State
                {
                    Id = 34,
                    Name = "Taraba",
                    Capital = "Jalingo",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Ardo Kola" },
                        new Lga { Id = 2, Name = "Bali" },
                        new Lga { Id = 3, Name = "Donga" },
                        new Lga { Id = 4, Name = "Gashaka" },
                        new Lga { Id = 5, Name = "Gassol" },
                        new Lga { Id = 6, Name = "Ibi" },
                        new Lga { Id = 7, Name = "Jalingo" },
                        new Lga { Id = 8, Name = "Karim Lamido" },
                        new Lga { Id = 9, Name = "Kumi" },
                        new Lga { Id = 10, Name = "Lau" },
                        new Lga { Id = 11, Name = "Sardauna" },
                        new Lga { Id = 12, Name = "Takum" },
                        new Lga { Id = 13, Name = "Ussa" },
                        new Lga { Id = 14, Name = "Wukari" },
                        new Lga { Id = 15, Name = "Yorro" },
                        new Lga { Id = 16, Name = "Zing" },
                    }
                },
                new State
                {
                    Id = 35,
                    Name = "Yobe",
                    Capital = "Damaturu",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Bade" },
                        new Lga { Id = 2, Name = "Bursari" },
                        new Lga { Id = 3, Name = "Damaturu" },
                        new Lga { Id = 4, Name = "Fika" },
                        new Lga { Id = 5, Name = "Fune" },
                        new Lga { Id = 6, Name = "Geidam" },
                        new Lga { Id = 7, Name = "Gujba" },
                        new Lga { Id = 8, Name = "Gulani" },
                        new Lga { Id = 9, Name = "Jakusko" },
                        new Lga { Id = 10, Name = "Karasuwa" },
                        new Lga { Id = 11, Name = "Machina" },
                        new Lga { Id = 12, Name = "Nangere" },
                        new Lga { Id = 13, Name = "Nguru" },
                        new Lga { Id = 14, Name = "Potiskum" },
                        new Lga { Id = 15, Name = "Tarmuwa" },
                        new Lga { Id = 16, Name = "Yunusari" },
                        new Lga { Id = 17, Name = "Yusufari" },
                    }
                },
                new State
                {
                    Id = 36,
                    Name = "Zamfara",
                    Capital = "Gusau",
                    Lgas = new List<Lga>
                    {
                        new Lga { Id = 1, Name = "Anka" },
                        new Lga { Id = 2, Name = "Birnin Magaji/Kiyaw" },
                        new Lga { Id = 3, Name = "Bakura" },
                        new Lga { Id = 4, Name = "Bukkuyum" },
                        new Lga { Id = 5, Name = "Bungudu" },
                        new Lga { Id = 6, Name = "Gummi" },
                        new Lga { Id = 7, Name = "Gusau" },
                        new Lga { Id = 8, Name = "Kaura Namoda" },
                        new Lga { Id = 9, Name = "Maradun" },
                        new Lga { Id = 10, Name = "Shinkafi" },
                        new Lga { Id = 11, Name = "Maru" },
                        new Lga { Id = 12, Name = "Talata Mafara" },
                        new Lga { Id = 13, Name = "Tsafe" },
                        new Lga { Id = 14, Name = "Zurmi" },
                    }
                }
            };
        }
    }
}

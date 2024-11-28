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
            }
        };
    }
}

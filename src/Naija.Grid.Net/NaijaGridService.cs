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
            }
        };
    }
}

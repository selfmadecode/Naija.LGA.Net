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
                LocalGovernments = new List<LocalGovernment>
                {
                    new LocalGovernment { Id = 1, Name = "Aba North", Population = 0 },
                    new LocalGovernment { Id = 2, Name = "Aba South", Population = 0 },
                    new LocalGovernment { Id = 3, Name = "Arochukwu", Population = 0 },
                    new LocalGovernment { Id = 4, Name = "Bende", Population = 0 },
                    new LocalGovernment { Id = 5, Name = "Ikwuano", Population = 0 },
                    new LocalGovernment { Id = 6, Name = "Isiala Ngwa North", Population = 0 },
                    new LocalGovernment { Id = 7, Name = "Isiala Ngwa South", Population = 0 },
                    new LocalGovernment { Id = 8, Name = "Isiukwuato", Population = 0 },
                    new LocalGovernment { Id = 9, Name = "Obingwa", Population = 0 },
                    new LocalGovernment { Id = 10, Name = "Ohafia", Population = 0 },
                    new LocalGovernment { Id = 11, Name = "Osisioma Ngwa", Population = 0 },
                    new LocalGovernment { Id = 12, Name = "Ugwunagbo", Population = 0 },
                    new LocalGovernment { Id = 13, Name = "Ukwa East", Population = 0 },
                    new LocalGovernment { Id = 14, Name = "Ukwa West", Population = 0 },
                    new LocalGovernment { Id = 15, Name = "Umuahia North", Population = 0 },
                    new LocalGovernment { Id = 16, Name = "Umuahia South", Population = 0 },

                }
            }
        };
    }
}

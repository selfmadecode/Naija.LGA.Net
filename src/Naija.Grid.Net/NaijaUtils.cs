using Naija.Grid.Net.Model;
using System.Collections.Generic;

namespace Naija.Grid.Net
{
    internal class NaijaUtils
    {
        public static IEnumerable<State> GetAllStates()
        {
            return NaijaGridService.GetStates();
        }
    }
}

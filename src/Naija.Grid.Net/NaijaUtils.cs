using System.Collections.Generic;

namespace Naija.LGA.Net
{
    internal class NaijaUtils
    {
        public static IEnumerable<State> GetAllStates()
        {
            return NaijaLGA.GetStates();
        }
    }
}

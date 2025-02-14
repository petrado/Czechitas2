using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas8
{
    interface ITancujiciBytost
    {
        // oproti abstraktni tride nejsou klicova slova, modifikatory, pristupy, override,...
        // kazdy objekt odsud defibuje vic
        // zvyk - psat nazev s velkym I na zacatku
        void ZacniTancovat();
        void PrestanTancovat();


    }
}

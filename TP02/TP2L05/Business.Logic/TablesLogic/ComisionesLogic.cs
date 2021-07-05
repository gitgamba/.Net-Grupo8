using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionesLogic:BusinessLogic
    {
       
        public ComisionesLogic()
        {
            this._ComisionData = new ComisionesAdapter();
        }
        private ComisionesAdapter _ComisionData;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionesLogic : BusinessLogic
    {
       public ComisionesLogic()
        {
            
        }

        private ComisionesAdapter _ComisionesData;
public ComisionesAdapter ComisionesData { get => _ComisionesData; set => _ComisionesData = value; }
    }
}

<<<<<<< HEAD
﻿using System;
=======
﻿using Data.Database;
using System;
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
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
=======

namespace Business.Logic
{
    public class ComisionesLogic:BusinessLogic
    {
       
        public ComisionesLogic()
        {
            this._ComisionData = new ComisionesAdapter();
        }
        private ComisionesAdapter _ComisionData;
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
    }
}

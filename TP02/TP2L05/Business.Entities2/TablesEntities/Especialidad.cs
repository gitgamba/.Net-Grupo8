﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity 
    {
        private string _desc_Especialidad;

        public string Desc_Especialidad { get => _desc_Especialidad; set => _desc_Especialidad = value; }
    }
}

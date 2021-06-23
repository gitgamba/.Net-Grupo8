﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
   public class Usuario
    {
        private string _NombreUsuario; 
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        
        
        
        
        private string _Clave;
        private string _Nombre;
        private string _Apellido;
        private string _Email;
        private bool _Habilitado;
       
        //Autogenerated code
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Email { get => _Email; set => _Email = value; }
        public bool Habilitado { get => _Habilitado; set => _Habilitado = value; }

        
        
    
    
    
    
    }
}

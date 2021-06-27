using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {
        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }
        private UsuarioAdapter _UsuarioData;

        public UsuarioAdapter UsuarioData { get => _UsuarioData; set => _UsuarioData = value; }

       public Usuario getOne(int ID)
        {
            return UsuarioData.GetOne(ID);
        }

        public List<Usuario> getAll()
        {
            return UsuarioData.GetAll();
        }

        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }

        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }
    }
}

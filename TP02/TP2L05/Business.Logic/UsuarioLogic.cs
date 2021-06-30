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

       public Usuario GetOneId(int ID)
        {
            try { 
                return UsuarioData.GetOneId(ID);
                }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Usuario> getAll()
        {
            try { 
                return UsuarioData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Delete(int ID)
        {
            try
            { 
                UsuarioData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Usuario user)
        {
            try
            {
                UsuarioData.Save(user);
            }
            catch (Exception Ex) { throw Ex; }
         }
    }
}

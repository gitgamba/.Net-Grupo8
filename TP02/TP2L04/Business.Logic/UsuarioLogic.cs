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

            try
            {
                return UsuarioData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }   
          

        public List<Usuario> getAll()
        {
            
            {
                return UsuarioData.GetAll();
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
            catch (Exception Ex)
            {
                throw Ex;
            }
        } 
    }
}

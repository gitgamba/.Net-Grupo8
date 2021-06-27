using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
             new Usuarios().Menu(); 
        }
 
    
    }
    public class Usuarios
    {
        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }
        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio
        { get; set; }
        public void Menu()
        {
            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine(" 1 – Listado General");
                    Console.WriteLine(" 2 – Consulta");
                    Console.WriteLine(" 3 – Agregar");
                    Console.WriteLine(" 4 - Modificar");
                    Console.WriteLine(" 5 - Eliminar");
                    Console.WriteLine(" 6 - Salir");
                    Console.Write("\n Ingrese una opcion: ");
                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc < 1 || opc > 6) throw new ArgumentOutOfRangeException();
                        break;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Debes ingresar un numero.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El numero ingresado no esta dentro del rango permitido.");
                    }

                } while (true);

                switch (opc)
                {
                    case 1:
                        ListadoGeneral();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Eliminar();
                        break;
                    default:
                        break;
                }
            } while (opc != 6);
        }
        public void ListadoGeneral()
        { Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.getAll()) { MostrarDatos(usr); }
        }
        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario : {0}", usr.ID);
            Console.WriteLine("\t \tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t \t Apellido: {0}", usr.Apellido);
            Console.WriteLine("\t \tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t \tEmail: { 0}", usr.Email);
            Console.WriteLine("\t \tHabilitado: { 0}", usr.Habilitado);
            Console.WriteLine();
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.getOne(id));
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }

        }
        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.Write("\nIngrese Apellido: ");
            usuario.Apellido = Console.ReadLine();

            Console.Write("\nIngrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();

            Console.Write("\nIngrese Clave: ");
            usuario.Clave = Console.ReadLine();

            Console.Write("\nIngrese Email: ");
            usuario.Email = Console.ReadLine();

            Console.Write("\nIngrese Habilitacion de Usuario (1 = Si / Otro = No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");

            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine($"\nID: {usuario.ID}");

            Console.Write("\nPresione una tecla para volver al menu.");
            Console.ReadKey();
        }
        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del Usuario a modificar: ");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.getOne(id);

                Console.Write("\nIngrese Nombre: ");
                usuario.Nombre = Console.ReadLine();

                Console.Write("\nIngrese Apellido: ");
                usuario.Apellido = Console.ReadLine();

                Console.Write("\nIngrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();

                Console.Write("\nIngrese Clave: ");
                usuario.Clave = Console.ReadLine();

                Console.Write("\nIngrese Email: ");
                usuario.Email = Console.ReadLine();

                Console.Write("\nIngrese Habilitacion de Usuario (1 = Si / Otro = No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");

                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);

            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }

        }
        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }
        }

    }
    
       



}


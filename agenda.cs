using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda.taller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<contacto> C1 = new List<contacto>();//Creo la agenda
            C1.Add(new contacto()  {nombre="Jaimito", apellido="Perez",direccion="El fin del mundo", telefono="qUETI" });

            C1.Add(new contacto() { nombre = "Jaime", apellido = "dasd", direccion = "123", telefono = "ETI" });
            //C1.mostrarcontacto();
            C1.ForEach(x => x.mostrarcontacto());
            Console.ReadLine();
        }

        public struct contacto
        {
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;

            public contacto(string _nombre,string _apellido, string _direccion, string _telefono)
            {
                nombre = _nombre;
                apellido = _apellido;
                direccion = _direccion;
                telefono = _telefono;

            }
            public void mostrarcontacto()
            {
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(direccion);
            Console.WriteLine(telefono);
            Console.WriteLine("--------------");
            }

            public void crearcontacto()
            {


            }

            public void eliminarcontacto();
            {

            }
            public void buscarcontacto();
       }

    }


}

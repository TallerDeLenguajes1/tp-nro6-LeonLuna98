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
            C1.Add(new contacto() { nombre = "Jaimito", apellido = "Lopez", direccion = "El fin del mundo", telefono = "080022" });

            C1.Add(new contacto() { nombre = "Jaime", apellido = "Lanister", direccion = "Kigslanding", telefono = "1234234823" });

            
           // C1.Contains(new contacto() { nombre="Jaime"});
            //C1.ForEach(y => y.Crearcontacto(C1));
          /*
            foreach (contacto elcontacto in C1){
                if (C1.nombre == 'Jaime') ;

            }*/
            C1.ForEach(x => x.Mostrarcontacto());
            C1.ForEach(y => y.Buscarcontacto());
            Console.ReadLine();
        }

        public struct contacto
        {
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;

            public contacto(string _nombre, string _apellido, string _direccion, string _telefono)
            {
                nombre = _nombre;
                apellido = _apellido;
                direccion = _direccion;
                telefono = _telefono;

            }
            public void Mostrarcontacto()
            {
                Console.WriteLine(nombre);
                Console.WriteLine(apellido);
                Console.WriteLine(direccion);
                Console.WriteLine(telefono);
                Console.WriteLine("--------------");
            }

            public void Crearcontacto(List<contacto> contactito)
            {
                Console.WriteLine("Quiere ingresar un contacto? s/n");
                char opcion = char.Parse(Console.ReadLine());
                if (opcion == 's' || opcion == 'S')
                {
                    Console.WriteLine("Ingrese nuevo nombre");
                    string nuevonombre = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo apellido");
                    string nuevoapellido = Console.ReadLine();
                    Console.WriteLine("Ingrese nueva direccion");
                    string nuevadireccion = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo telefono");
                    string nuevotelefono = Console.ReadLine();

                    contactito.Add(new contacto() { nombre = nuevonombre, apellido = nuevoapellido, direccion = nuevadireccion, telefono = nuevotelefono });

                }
                else
                {
                    if (opcion == 'n' || opcion == 'N')
                    {
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("ERROR, caracterno valido");
                        Console.ReadLine();
                    }
                }
            }

            public void eliminarcontacto(List<contacto> contactito)
            {
                Console.WriteLine("Quiere borrar un contacto? s/n");
                char opcion = char.Parse(Console.ReadLine());
                if (opcion == 's' || opcion == 'S')
                {
                   


                }
                else
                {
                    if (opcion == 'n' || opcion == 'N')
                    {
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("ERROR, caracterno valido");
                        Console.ReadLine();
                    }
                }
            }
        
            public void buscarcontacto()
            {
                Console.WriteLine("Ingrese como quiere buscar su contacto: Nombre(n), Apellido(a), direccion(d), telefono(t)");
                char buscador = char.Parse(Console.ReadLine());
                if (buscador == 'n')
                {
                Console.WriteLine("Ingrese el nombre a buscar: ");
                string nombrebuscado = Console.ReadLine();
                bool resultado=  contacto.Equals(nombrebuscado, nombre );
                    if(resultado== true)
                    {
                        Console.WriteLine(contacto.Mostarcontacto());
                    }
                    else
                    {
                        Console.WriteLine("No hay ningun contacto con ese nombre");
                    }
                }

            }
        }

    }


}

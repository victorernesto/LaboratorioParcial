using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorioN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            informacionProducto[] pro = new informacionProducto[1];
            string[] area = new string[3];
            string[] Categorias = new string[3];
            string nivelUsuario;

            string NOMBRE;
            string PROVEEDOR;
            string fCaducida;
            string fEntrada;
            double PRECIO;
            int UNIDADES;
            string Area;
            string Categoria;

            area[0] = "frescos";
            area[1] = "despensa";
            Categorias[0] = "lacteos";
            Categorias[1] = "agua";

            Console.WriteLine("**************************************************BIENBENIDO USUARIO************************************************");
            Console.WriteLine("QEU NIVEL DE USUARIO ES?");
            nivelUsuario = Console.ReadLine();
                if (nivelUsuario == "administrador")
                {
                int opcion;
                Console.WriteLine("QUE DESEA AGREGAR?");
                Console.WriteLine("area");
                Console.WriteLine("Categoria");
                Console.WriteLine("producto");
                opcion=int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        

                        for (int i = 0; i < area.Length; i++)
                        {
                            Console.WriteLine($" areas disponibles { area[i]} {area[i]}");
                        }

                        Console.WriteLine("ESCRIBA LA NUEVA AREA");
                        area[2]= Console.ReadLine();

                        for (int i = 0; i < area.Length; i++)
                        {
                            Console.WriteLine($" areas disponibles {area[i]} {area[i]} {area[i]}");
                        }
                        break;

                    case 2:
                       
                        for (int i = 0; i < Categorias.Length; i++)
                        {
                            Console.WriteLine($" categorias disponibles {Categorias[i]} {Categorias[i]}");
                        }

                        Console.WriteLine("ESCRIBA LA NUEVA AREA");
                        Categorias[2] = Console.ReadLine();

                        for (int i = 0; i < Categorias.Length; i++)
                        {
                            Console.WriteLine($" categorias disponibles {Categorias[i]} {Categorias[i]} {Categorias[i]}");
                        }
                        break;

                    case 3:
                        for (int i = 0; i < area.Length; i++)
                        {
                            Console.WriteLine($" areas disponibles {area[i]} {area[i]}");
                        }

                        for (int i = 0; i < Categorias.Length; i++)
                        {
                            Console.WriteLine($" categorias disponibles {Categorias[i]} {Categorias[i]}");
                        }
                        Console.WriteLine("Area");
                        Area = Console.ReadLine();
                        Console.WriteLine("Categoria");
                        Categoria = Console.ReadLine();
                        Console.WriteLine("Nombre");
                        NOMBRE= Console.ReadLine();
                        Console.WriteLine("Proveedor");
                        PROVEEDOR= Console.ReadLine();
                        Console.WriteLine("Fecha de caducidad");
                        fCaducida= Console.ReadLine();
                        Console.WriteLine("Fecha de entrada");
                        fEntrada= Console.ReadLine();
                        //Console.WriteLine("Detalles");
                        //Console.ReadLine();
                        Console.WriteLine("Precio");
                        PRECIO=double.Parse( Console.ReadLine());
                        Console.WriteLine("Unidades");
                        UNIDADES = int.Parse(Console.ReadLine());

                        pro[0] = new Producto(Area,Categoria, NOMBRE, PROVEEDOR, fCaducida, fEntrada, PRECIO, UNIDADES);

                        for (int i = 0; i < pro.Length; i++)
                        {
                            Console.WriteLine(pro[i].informacionP());
                        }
                        break;
                }


                }else if(nivelUsuario=="vendedor")



            Console.ReadKey();
           
        }
    }

    public abstract class informacionProducto
    {
        public string area { get; set; }
        public string categoria { get; set; }
        public  string Nombre { get; set; }
        public  string Proveedor { get; set; }
        public  string FechaCaducacion { get; set; }
        public  string FechaDeEntrada { get; set; }
        //public  string Detalles { get; set; }
        public  double Precio { get; set; }
        public  int Unidades { get; set; }

        public abstract string informacion();
        public abstract string informacionP();
    }

    public class Producto : informacionProducto
    {
       public Producto(string area,string categoria, string nombre, string proeevedor,string fechaCaducidad,string fechaDeEntrada,double precio,int unidades)
        {
            this.area = area;  
            this.categoria = categoria;
            this.Nombre = nombre;
            this.Proveedor = proeevedor;
            this.FechaCaducacion = fechaCaducidad;
            this.FechaDeEntrada= fechaDeEntrada;
            //this.Detalles = detalles;
            this.Precio = precio;
            this.Unidades = unidades;

        }

        public override string informacion()
        {
            string info = $"producto {this.Nombre} {this.Proveedor} {this.FechaCaducacion} {FechaDeEntrada}  {this.Precio} {this.Unidades} ";
            return info;
        }

        public override string informacionP()
        {
            string infor = $"producto:  AREA {this.area} CATEGORIA {this.categoria} NOMBRE {this.Nombre} PROVEEDOR {this.Proveedor} FECHA CADUCIDAD {this.FechaCaducacion} FECHA ENTRADA {FechaDeEntrada}  PRECIO {this.Precio} UNIDADES {this.Unidades} ";
            return infor;
        }
    }

}

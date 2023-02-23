using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario[] user = new Usuario[1];

            //variables
            string nombreU;
            int edadU;
            string departamentoU;
            string municipioU;
            int salir = 0;

            Console.WriteLine("nombre");
            nombreU = Console.ReadLine();
            Console.WriteLine("edad");
            edadU = int.Parse(Console.ReadLine());
            Console.WriteLine("departamento");
            departamentoU = Console.ReadLine();


            switch (departamentoU)
            {
                case "chalatenamgo":
                    Console.WriteLine("de que municipio es, 1-El paraiso 2-La palma 3-Cabañas");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
                case "la paz":
                    Console.WriteLine("de que municipio es, 1-Olocuilta 2-El rosario 3-Zacatecoluca 4-Tapalhuaca");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
                case "santa ana":
                    Console.WriteLine("de que municipio es, 1-El congo 2-Coatepeque 3-El porbenir 4-Metapan");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
                case "ahuachapan":
                    Console.WriteLine("de que municipio es, 1-El refugio 2-Jujutla 3-San francisco menendes 4-Apaneka");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
                case "cabañas":
                    Console.WriteLine("de que municipio es, 1-Cinquera 2-Jutiapa 3-Victoria 4-San isidro");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
                case "san vicente":
                    Console.WriteLine("de que municipio es, 1-Apastepeque 2-Guadalupe 3-Santaclara 4-Tepetitan");
                    municipioU = Console.ReadLine();
                    user[0] = new Usuario(nombreU, edadU, departamentoU, municipioU);
                    break;
            }

            for(int i = 0;i< user.Length;i++)
            {
                Console.WriteLine(user[i].informacion());
            }

            Console.ReadKey();
        
        }
    }        
            
           
            
                
            

            
      
    
}

public abstract class datos
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string departamento { get; set; }
    public string municipio { get; set; }

    public abstract string informacion();

}

public class Usuario : datos
{
   public  Usuario(string nombre,int edad, string departamento,string municipio)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.departamento = departamento;
        this.municipio= municipio;
    }

    public override string informacion()
    {
        string informacionU = $"informacion de usuario {this.nombre} {this.edad} {this.departamento} {this.municipio}";
        return informacionU;
    }
}


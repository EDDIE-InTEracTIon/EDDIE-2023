using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModuloBusquedaWeb
{
    public class BuscarEnciclopedia
    {
        public List<string> buscarEnciclopedia(string textoBuscar, string apiSeleccionada)
        {
            string path = Directory.GetCurrentDirectory() + "/Apis/";
            string extensionsPath = path + apiSeleccionada + ".dll";
            //string extensionsPath = @"C:\Users\Dania\source\repos\1IntegrandoModuloConSoftware2\Apis\" + apiSeleccionada+".dll";
            var assembly = Assembly.LoadFile(extensionsPath);
            Type type = assembly.GetTypes()[0];
            object obj = Activator.CreateInstance(type);
            var result = type.GetMethod("buscarEnciclopedia");
            
            if(VerifyInternetConnection()==false)
            {
                List<string> errors = new List<string>();
                errors.Add("Problema detectado: Fallo en la conexiòn.\nVerifique su conexiòn a internet.");
                return errors;
            }
            //ERROR: Si no se encuentra la palabra en wikipedia, la aplicacion falla.
            
                var respuesta = result.Invoke(obj, new object[] { textoBuscar });
                List<string> resultadoWikipedia = new List<string>();
                resultadoWikipedia = (List<string>)respuesta;
                return resultadoWikipedia;
        }
        //Funcion dedicada a verificar si el computador cuenta con conexion a internet.
        //Codigo obtenido de: https://gist.github.com/yemrekeskin/df052c9a464cb0c9a4e2
        public static bool VerifyInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    
}

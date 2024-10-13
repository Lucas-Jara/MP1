using System;
using System.IO;
using MetodologíasDeProgramaciónI;

namespace MP1
{
	class LectorDeArchivos : Manejador {
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\lucas\Documents\MP1\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		private StreamReader lector_de_archivos;

        private LectorDeArchivos(Manejador m) :base(m){
			lector_de_archivos = new StreamReader(ruta_archivo);
		}
        private static LectorDeArchivos lectorDeArchivos;
        public static LectorDeArchivos getInstance(Manejador m)
        {
            if (lectorDeArchivos == null)
            {
                lectorDeArchivos = new LectorDeArchivos(m);
            }
            return lectorDeArchivos;
        }
        public override double numeroDesdeArchivo(double max){
			string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public override string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_datos;

namespace capa_negocio
{
    public class NegocioBackup
    {
        DatosBackup datosBackup = new DatosBackup();

        public void crearBackup(string directorio, string nombreArchivo)
        {
            string directorioArchivo = directorio + @"\" + nombreArchivo + ".bak";

            datosBackup.backupDB(directorioArchivo);
        }
    }
}

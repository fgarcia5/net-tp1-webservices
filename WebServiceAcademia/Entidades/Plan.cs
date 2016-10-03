using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Entidades
{
    public class Plan : Entidades
    {
        string _descripcion;
        int _idEspecialidad;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        public int IdEspecialidad
        {
            get
            {
                return _idEspecialidad;
            }
            set
            {
                _idEspecialidad = value;
            }
        }
    }
}

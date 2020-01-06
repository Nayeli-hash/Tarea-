using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Calificacion
    {
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //Campos y propiedades
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        private byte _Codigo;
        public byte Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        
        private DateTime _FechaHoraRegistro;
        public DateTime FechaHoraRegistro
        {
            get { return _FechaHoraRegistro; }
            set { _FechaHoraRegistro = value; }
        }

        private bool _Habilitado;
        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        private string _NombreBreve;
        public string NombreBreve
        {
            get { return _NombreBreve; }
            set { _NombreBreve = value; }
        }

        private string _NombreCompleto;
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //Métodos (Acciones)
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        public void Insertar()
        { 
        
        }

        public void Inhabilitar()
        { 
        
        }

        public void Editar(Calificacion argDatos)
        { 
            
        }

        public static Calificacion Buscar_PorCodigo()
        {
            Calificacion x = null;

            return x;
        }

        public static List<Calificacion> Listar()
        {
            List<Calificacion> x = new List<Calificacion>();

            return x;
        }

                
    }
}

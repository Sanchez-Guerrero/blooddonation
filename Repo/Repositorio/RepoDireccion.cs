using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoDireccion
    {
        public List<Ctl_Estados> CargarEstados()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Estados> estados = db.Database.SqlQuery<Ctl_Estados>("st_ConsultarEstados").ToList();

                    return estados;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_Municipio> CargarMunicipios()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Municipio> municipios = db.Database.SqlQuery<Ctl_Municipio>("st_ConsultarMunicipios").ToList();

                    return municipios;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_Colonia> CargarColonias()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Colonia> colonias = db.Database.SqlQuery<Ctl_Colonia>("st_ConsultarColonia").ToList();

                    return colonias;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_CodigoPostal> CargarCP()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_CodigoPostal> cp = db.Database.SqlQuery<Ctl_CodigoPostal>("st_ConsultarCodigosPostal").ToList();

                    return cp;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

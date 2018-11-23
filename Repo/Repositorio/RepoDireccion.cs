using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<Ctl_Municipio> CargarMunicipios(int idEstado)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Municipio> municipios = db.Database.SqlQuery<Ctl_Municipio>("st_ConsultarMunicipios @Id_Estado",
                         new SqlParameter("@Id_Estado", idEstado)).ToList();

                    return municipios;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_Colonia> CargarColonias(int idMunicipio)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Colonia> colonias = db.Database.SqlQuery<Ctl_Colonia>("st_ConsultarColonia @Id_Municipio",
                        new SqlParameter("@Id_Municipio", idMunicipio)).ToList();

                    return colonias;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_CodigoPostal> CargarCP(int Id_Colonia)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_CodigoPostal> cp = db.Database.SqlQuery<Ctl_CodigoPostal>("st_ConsultarCodigosPostal @Id_Colonia",
                        new SqlParameter("@Id_Colonia",Id_Colonia)).ToList();

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

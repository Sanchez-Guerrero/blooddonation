using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoClinica
    {
       
        public List<Ctl_Clinica> ConsultarClinica()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Clinica> clinica = db.Database.SqlQuery<Ctl_Clinica>("st_ConsultarClinica").ToList();

                    return clinica;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_DireccionClinica> ConsultarDireccionClinica(int Id_Clinica)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_DireccionClinica> direClinica = db.Database.SqlQuery<Ctl_DireccionClinica>("st_ConsultarDireccionClinica @Id_Clinica",
                        new SqlParameter("@Id_Clinica", Id_Clinica)).ToList();

                    return direClinica;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Tbl_Persona> ConsultarPaciente()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Tbl_Persona> paciente = db.Database.SqlQuery<Tbl_Persona>("st_ConsultarPacientePorPerfil").ToList();

                    return paciente;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Tbl_Persona> ConsultarDonante()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Tbl_Persona> donante = db.Database.SqlQuery<Tbl_Persona>("st_ConsultarDonantePorPerfil").ToList();

                    return donante;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string ObtenerNombre(int id)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    string donante = db.Database.SqlQuery<string>("st_ConsultarPacienteParaObtenerNombre @id",
                        new SqlParameter("@id", id)).FirstOrDefault();

                    return donante;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string ObtenerNombrePaciente(int id)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    string donante = db.Database.SqlQuery<string>("st_ConsultarDonanteParaObtenerNombre @id",
                        new SqlParameter("@id", id)).FirstOrDefault();

                    return donante;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

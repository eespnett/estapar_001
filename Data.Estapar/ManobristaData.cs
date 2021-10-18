using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationEstapar.Business.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Data.Estapar
{
    public class ManobristaData : BaseDatacs
    {
        internal List<ManobristaEntity> ListarManobrista()
        {

            List<ManobristaEntity> returnListManobristaBusiness = new List<ManobristaEntity>();

            ManobristaEntity oManobristaEntity = new ManobristaEntity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[tbManobrista]", connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oManobristaEntity = new ManobristaEntity();
                            oManobristaEntity.Nome = retorno["Nome"].ToString();
                            oManobristaEntity.CPF = retorno["CPF"].ToString();
                            if (retorno["DtNascimento"]!=null)
                            {
                                oManobristaEntity.DtNascicmento = DateTime.Parse(retorno["DtNascimento"].ToString());
                            }
                           
                            oManobristaEntity.id = int.Parse(retorno["Id"].ToString());
                            returnListManobristaBusiness.Add(oManobristaEntity);

                        }



                    }
                    catch
                    {
                        returnListManobristaBusiness = new List<ManobristaEntity>();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


            return returnListManobristaBusiness;

             
        }

        internal int ExcluirManobrista(int idManobrista)
        {
            int returnAltararManobrista = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("delete [dbo].[tbManobrista]  ");
 
            sb.Append(string.Format("  where  id='{0}' ", idManobrista.ToString()));

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(sb.ToString(), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno > 0)
                        {
                            returnAltararManobrista = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAltararManobrista = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAltararManobrista;
        }

        internal int IncluirManobrista(ManobristaEntity manobristaEntity)
        {
            int returnIncluirManobrista = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("insert into [dbo].[tbManobrista](Id,Nome, CPF, DtNascimento)");
            sb.Append(string.Format(" values('{0}','{1}', '{2}','{3}')", manobristaEntity.id, manobristaEntity.Nome.ToString(), manobristaEntity.CPF.ToString(), manobristaEntity.DtNascicmento.ToString()));

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(sb.ToString(), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno > 0)
                        {
                            returnIncluirManobrista = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirManobrista = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnIncluirManobrista;
        }

        internal int AltararManobrista(ManobristaEntity manobristaEntity)
        {
            int returnAltararManobrista = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("update [dbo].[tbManobrista]  ");
            sb.Append(string.Format("  set Nome='{0}', ", manobristaEntity.Nome.ToString()));
            sb.Append(string.Format("   CPF='{0}', ", manobristaEntity.CPF.ToString()));
            sb.Append(string.Format("  DtNascimento='{0}' ", manobristaEntity.DtNascicmento.ToString()));
            sb.Append(string.Format("  where  id='{0}' ", manobristaEntity.id.ToString()));
 
            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(sb.ToString(), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno > 0)
                        {
                            returnAltararManobrista = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAltararManobrista = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAltararManobrista;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select max(id)+1 as 'ProximoID' from [dbo].[tbManobrista] "), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {

                            returnProximoID = int.Parse(retorno["ProximoID"].ToString());



                        }



                    }
                    catch
                    {
                        returnProximoID = 0;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return returnProximoID;
                }
            }

        }

        internal ManobristaEntity SelecionarManobrista(ManobristaEntity oManobrista)
        {

            ManobristaEntity oManobristaEntity = new ManobristaEntity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select * from [dbo].[tbManobrista] where id={0}",oManobrista.id.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oManobristaEntity = new ManobristaEntity();
                            oManobristaEntity.Nome = retorno["Nome"].ToString();
                            oManobristaEntity.CPF = retorno["CPF"].ToString();
                            if (retorno["DtNascimento"] != null)
                            {
                                oManobristaEntity.DtNascicmento = DateTime.Parse(retorno["DtNascimento"].ToString());
                            }

                            oManobristaEntity.id = int.Parse(retorno["Id"].ToString());
                         

                        }



                    }
                    catch
                    {
                        oManobristaEntity = new ManobristaEntity();
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return oManobristaEntity;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Data.Estapar
{
    public class ManobraData : BaseDatacs
    {
        internal List<ManobaEnity> ListarManobras()
        {

            List<ManobaEnity> returnListManobaEnity = new List<ManobaEnity>();

            ManobaEnity oManobaEnity = new ManobaEnity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[tbManobra]", connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oManobaEnity = new ManobaEnity();
                            oManobaEnity.oCarro = new EntityCarro();
                            oManobaEnity.oManobrista = new ManobristaEntity();
                            oManobaEnity.oTipoManobra = new TipoManobra();
                            oManobaEnity.oClassificacao = new ClassificacaoEntity();
                            oManobaEnity.Id = int.Parse(retorno["Id"].ToString());
                            oManobaEnity.oCarro.id = int.Parse(retorno["idCarro"].ToString());
                            oManobaEnity.oManobrista.id = int.Parse(retorno["idManobrista"].ToString());
                            oManobaEnity.oTipoManobra.id = int.Parse(retorno["idTipoManobra"].ToString());
                            oManobaEnity.dtManobraInicio = DateTime.Parse(retorno["dtManobraInicio"].ToString());
                            oManobaEnity.dtManobraFim = DateTime.Parse(retorno["dtManobraFim"].ToString());
                            oManobaEnity.Concluido = bool.Parse(retorno["Concluido"].ToString());
                            oManobaEnity.oClassificacao.id = int.Parse(retorno["idClassaticacao"].ToString());

                            returnListManobaEnity.Add(oManobaEnity);


                        }



                    }
                    catch
                    {
                        returnListManobaEnity = new List<ManobaEnity>();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


            return returnListManobaEnity;


        }

        internal int ExcluirManobra(int idManobrista)
        {
            int returnExcluirManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("delete [dbo].[tbManobra] ");
          
            sb.Append(string.Format(" where Id ='{0}' ", idManobrista.ToString()));


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
                            returnExcluirManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnExcluirManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnExcluirManobra;
        }

        internal int AtualizarManobra(ManobaEnity myManobra)
        {
            int returnAtualizarManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();

           
            sb.Append("update [dbo].[tbManobra] ");
  
            sb.Append(string.Format(" set idCarro='{0}', ", myManobra.oCarro.id.ToString()));
            sb.Append(string.Format(" idManobrista='{0}', ", myManobra.oManobrista.id.ToString()));
            sb.Append(string.Format(" idTipoManobra='{0}', ", myManobra.oTipoManobra.id));
            sb.Append(string.Format(" DtManobraInicio='{0}', ", myManobra.dtManobraInicio.ToString("yyyy-MM-dd hh:mm:ss")));
            sb.Append(string.Format(" DtManobraFim='{0}', ", myManobra.dtManobraFim.ToString("yyyy-MM-dd hh:mm:ss")));
            sb.Append(string.Format(" Concluido='{0}', ", myManobra.Concluido.ToString()));
            sb.Append(string.Format(" idClassaticacao='{0}' ", myManobra.oClassificacao.id.ToString()));
            sb.Append(string.Format(" where Id ='{0}' ", myManobra.Id));

       
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
                            returnAtualizarManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAtualizarManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAtualizarManobra;
        }

        internal int IncluirManobra(ManobaEnity myManobra)
        {
            int returnIncluirManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("insert into [dbo].[tbManobra](Id,idCarro, idManobrista, idTipoManobra, DtManobraInicio, DtManobraFim, Concluido, idClassaticacao)");
            sb.Append(string.Format(" values('{0}','{1}', '{2}','{3}','{4}','{5}','{6}','{7}')", myManobra.Id, myManobra.oCarro.id.ToString(),
                myManobra.oManobrista.id.ToString(), myManobra.oTipoManobra.id,  myManobra.dtManobraInicio.ToString("yyyy-MM-dd hh:mm:ss"), myManobra.dtManobraFim.ToString("yyyy-MM-dd hh:mm:ss"),
                myManobra.Concluido.ToString(), myManobra.oClassificacao.id.ToString()));

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
                            returnIncluirManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnIncluirManobra;
        }

        internal ManobaEnity SelecionarManbra(int idManobra)
        {
            
            ManobaEnity oManobaEnity = new ManobaEnity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand( string.Format("select * from [dbo].[tbManobra] where id='{0}'", idManobra.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oManobaEnity = new ManobaEnity();
                            oManobaEnity.oCarro = new EntityCarro();
                            oManobaEnity.oManobrista = new ManobristaEntity();
                            oManobaEnity.oTipoManobra = new TipoManobra();
                            oManobaEnity.oClassificacao = new ClassificacaoEntity();
                            oManobaEnity.Id = int.Parse(retorno["Id"].ToString());
                            oManobaEnity.oCarro.id = int.Parse(retorno["idCarro"].ToString());
                            oManobaEnity.oManobrista.id = int.Parse(retorno["idManobrista"].ToString());
                            oManobaEnity.oTipoManobra.id = int.Parse(retorno["idTipoManobra"].ToString());
                            oManobaEnity.dtManobraInicio = DateTime.Parse(retorno["dtManobraInicio"].ToString());
                            oManobaEnity.dtManobraFim = DateTime.Parse(retorno["dtManobraFim"].ToString());
                            oManobaEnity.Concluido = bool.Parse(retorno["Concluido"].ToString());
                            oManobaEnity.oClassificacao.id = int.Parse(retorno["idClassaticacao"].ToString());

                         


                        }



                    }
                    catch
                    {
                        oManobaEnity = new ManobaEnity();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


            return oManobaEnity;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select max(id)+1 as 'ProximoID' from [dbo].[tbManobra] "), connection))
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
    }
}

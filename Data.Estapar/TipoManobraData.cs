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
    public class TipoManobraData : BaseDatacs
    {
        internal List<TipoManobra> ListarTipoManobras()
        {
            List<TipoManobra> returnListTipoManobra = new List<TipoManobra>();

            TipoManobra oTipoManobra = new TipoManobra();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[tbTipoManobra]", connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oTipoManobra = new TipoManobra();
                            oTipoManobra._TipoManobra = retorno["TipoManobra"].ToString();
                            oTipoManobra.id = int.Parse(retorno["Id"].ToString());
                            returnListTipoManobra.Add(oTipoManobra);

                        }



                    }
                    catch
                    {
                        returnListTipoManobra = new List<TipoManobra>();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return returnListTipoManobra;

        }

        internal int AlterarTipoManobra(TipoManobra tipoManobra)
        {
            int returnIncluirTipoManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("update [dbo].[tbTipoManobra] ");
            sb.Append(string.Format(" set TipoManobra='{0}' where ID='{1}'", tipoManobra._TipoManobra.ToString(), tipoManobra.id )); ;

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
                            returnIncluirTipoManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirTipoManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnIncluirTipoManobra;
        }

        internal int ExcuirTipoManobra(int idTipoManobra)
        {
            int returnExcluirTipoManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("delete [dbo].[tbTipoManobra] ");
            sb.Append(string.Format(" where id='{0}' ", idTipoManobra.ToString())); ;

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
                            returnExcluirTipoManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnExcluirTipoManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnExcluirTipoManobra;
        }

        internal int IncluirTipoManobra(TipoManobra tipoManobra)
        {
            int returnIncluirTipoManobra = int.MinValue;
            StringBuilder sb = new StringBuilder();

         
            sb.Append("insert into [dbo].[tbTipoManobra](Id,TipoManobra)");
            sb.Append(string.Format(" values('{0}','{1}')", tipoManobra.id, tipoManobra._TipoManobra.ToString()));;

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
                            returnIncluirTipoManobra = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirTipoManobra = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnIncluirTipoManobra;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select max(id)+1 as 'ProximoID' from [dbo].[tbTipoManobra] "), connection))
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

        internal TipoManobra SelecionarTipoManobra(TipoManobra oTipoManobra)
        {
            TipoManobra returnoTipoManobra = new TipoManobra();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select * from [dbo].[tbTipoManobra] where id={0}", oTipoManobra.id.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            returnoTipoManobra = new TipoManobra();
                            returnoTipoManobra._TipoManobra = retorno["TipoManobra"].ToString();
                            returnoTipoManobra.id = int.Parse(retorno["Id"].ToString());


                        }



                    }
                    catch
                    {
                        returnoTipoManobra = new TipoManobra();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return returnoTipoManobra;
        }

        internal TipoManobra SelecionarManobrista(TipoManobra oTipoManobra)
        {
            TipoManobra returnoTipoManobra = new TipoManobra();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select * from [dbo].[tbTipoManobra] where id={0}", oTipoManobra.id.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            returnoTipoManobra = new TipoManobra();
                            returnoTipoManobra._TipoManobra = retorno["TipoManobra"].ToString();
                            returnoTipoManobra.id = int.Parse(retorno["Id"].ToString());
                       

                        }



                    }
                    catch
                    {
                        returnoTipoManobra = new TipoManobra();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return returnoTipoManobra;
        }
    }
}

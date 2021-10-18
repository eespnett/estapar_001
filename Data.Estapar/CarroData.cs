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
    public class CarroData : BaseDatacs
    {
        internal List<EntityCarro> ListarCarros()
        {
            List<EntityCarro> returnListEntityCarro = new List<EntityCarro>();

            EntityCarro oEntityCarro = new EntityCarro();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[tbCarro]", connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oEntityCarro = new EntityCarro();
                            oEntityCarro.MarcaCarro = retorno["MarcaCarro"].ToString();
                            oEntityCarro.ModeloCarro = retorno["ModeloCarro"].ToString();
                            oEntityCarro.PlacaCarro = retorno["PlacaCarro"].ToString();


                            oEntityCarro.id = int.Parse(retorno["Id"].ToString());
                            returnListEntityCarro.Add(oEntityCarro);

                        }



                    }
                    catch
                    {
                        returnListEntityCarro = new List<EntityCarro>();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


            return returnListEntityCarro;
        }

        internal int ExcluirCarro(EntityCarro myCarro)
        {
            int returnAlterarCarro = int.MinValue;
            StringBuilder sb = new StringBuilder();

            //string.Format("select * from [dbo].[tbCarro] where id={0}", item.id.ToString())
            sb.Append("delete [dbo].[tbCarro] ");
 
            sb.Append("  where id='{0}'");
            string command = string.Format(sb.ToString(), myCarro.id);


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno > 0)
                        {
                            returnAlterarCarro = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAlterarCarro = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAlterarCarro;
        }

        internal int AlterarCarro(EntityCarro entityCarro)
        {
            int returnAlterarCarro = int.MinValue;
            StringBuilder sb = new StringBuilder();

            //string.Format("select * from [dbo].[tbCarro] where id={0}", item.id.ToString())
            sb.Append("update [dbo].[tbCarro] ");
            sb.Append(" set MarcaCarro='{0}',  ");
            sb.Append("   ModeloCarro='{1}', ");
            sb.Append("   PlacaCarro='{2}'");
            sb.Append("  where id='{3}'");
            string command = string.Format(sb.ToString(), entityCarro.MarcaCarro, entityCarro.ModeloCarro, entityCarro.PlacaCarro, entityCarro.id);


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno > 0)
                        {
                            returnAlterarCarro = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAlterarCarro = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAlterarCarro;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;
            

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select max(id)+1 as 'ProximoID' from [dbo].[tbCarro] "), connection))
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

        internal int IncluirCarro(EntityCarro entityCarro)
        {
            int returnIncluirCarro = int.MinValue;
            StringBuilder sb = new StringBuilder();

         
            sb.Append("insert into [dbo].[tbCarro](Id,MarcaCarro, ModeloCarro, PlacaCarro)");
            sb.Append(string.Format(" values('{0}','{1}', '{2}','{3}')", entityCarro.id, entityCarro.MarcaCarro.ToString(), entityCarro.ModeloCarro.ToString(), entityCarro.PlacaCarro.ToString()));

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(sb.ToString(), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteNonQuery();


                        if (retorno>0)
                        {
                            returnIncluirCarro = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirCarro = 0; throw ex;
                       
                    }
                    finally
                    {
                        connection.Close();
                    }
                    
                }
            }

            return returnIncluirCarro;
        }

        internal EntityCarro SelecionarCarro(EntityCarro item)
        {
            EntityCarro oEntityCarro = new EntityCarro();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select * from [dbo].[tbCarro] where id={0}",item.id.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oEntityCarro = new EntityCarro();
                            oEntityCarro.MarcaCarro = retorno["MarcaCarro"].ToString();
                            oEntityCarro.ModeloCarro = retorno["ModeloCarro"].ToString();
                            oEntityCarro.PlacaCarro = retorno["PlacaCarro"].ToString();


                            oEntityCarro.id = int.Parse(retorno["Id"].ToString());
                             

                        }



                    }
                    catch
                    {
                        oEntityCarro = new EntityCarro();
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return oEntityCarro;
                }
            }

        }
    }
}

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
    public class ClassificacaoData:BaseDatacs
    {
  
        internal List<ClassificacaoEntity> ListarClassificacoes()
        {
            List<ClassificacaoEntity> returnListClassificacaoEntity = new List<ClassificacaoEntity>();

            ClassificacaoEntity oClassificacaoEntity = new ClassificacaoEntity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {
                

                using (SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[Classificacao]", connection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    
                    try
                    {
                        connection.Open();                     

                       var retorno= sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        { 
                            oClassificacaoEntity = new ClassificacaoEntity();
                            oClassificacaoEntity.Descricao = retorno["Descricao"].ToString();
                            oClassificacaoEntity.id = int.Parse(retorno["Id"].ToString());
                            returnListClassificacaoEntity.Add(oClassificacaoEntity);

                        }
                      
                        

                    }
                    catch
                    {
                        returnListClassificacaoEntity = new List<ClassificacaoEntity>();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


            return returnListClassificacaoEntity;
        }

        internal int ExcluirClassificacao(int id)
        {
            int returnAltararClassificacao = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("delete [dbo].[Classificacao]  ");
            sb.Append(string.Format("   where Id='{0}' ", id.ToString()));

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
                            returnAltararClassificacao = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAltararClassificacao = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAltararClassificacao;
        }

        internal int AlterarClassificacao(ClassificacaoEntity myClassificacaoEntity)
        {
            int returnAltararClassificacao = int.MinValue;
            StringBuilder sb = new StringBuilder();


            sb.Append("update [dbo].[Classificacao]  ");
            sb.Append(string.Format(" set Descricao='{0}' where Id='{1}' ", myClassificacaoEntity.Descricao, myClassificacaoEntity.id));

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
                            returnAltararClassificacao = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnAltararClassificacao = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnAltararClassificacao;
        }

        internal int IncluirClassificacao(ClassificacaoEntity myClassificacaoEntity)
        {
            int returnIncluirClassificacao = int.MinValue;
            StringBuilder sb = new StringBuilder();

       
            sb.Append("insert into [dbo].[Classificacao](Id,Descricao)");
            sb.Append(string.Format(" values('{0}','{1}')", myClassificacaoEntity.id, myClassificacaoEntity.Descricao));

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
                            returnIncluirClassificacao = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        returnIncluirClassificacao = 0; throw ex;

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return returnIncluirClassificacao;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;


            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select max(id)+1 as 'ProximoID' from [dbo].[Classificacao] "), connection))
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
                    catch(Exception ex)
                    {
                        returnProximoID = 0;
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return returnProximoID;
                }
            }

        }

        internal ClassificacaoEntity SelecionarClassificacao(ClassificacaoEntity oClassificacao)
        {
            ClassificacaoEntity oClassificacaoEntity = new ClassificacaoEntity();

            using (SqlConnection connection = new SqlConnection(base.strConnection))
            {


                using (SqlCommand sqlCommand = new SqlCommand(string.Format("select * from [dbo].[Classificacao] where id={0}", oClassificacao.id.ToString()), connection))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    try
                    {
                        connection.Open();

                        var retorno = sqlCommand.ExecuteReader();


                        while (retorno.Read())
                        {
                            oClassificacaoEntity = new ClassificacaoEntity();
                            oClassificacaoEntity.Descricao = retorno["Descricao"].ToString();
                            oClassificacaoEntity.id = int.Parse(retorno["Id"].ToString());
                     

                        }



                    }
                    catch
                    {
                        oClassificacaoEntity = new ClassificacaoEntity();
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return oClassificacaoEntity;
                }
            }

        }
    }
}

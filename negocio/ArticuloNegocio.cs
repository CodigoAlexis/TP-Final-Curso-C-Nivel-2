using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion as Marca,A.IdMarca,C.Descripcion as Categoria,A.IdCategoria,A.Id from ARTICULOS A, MARCAS M,CATEGORIAS C Where M.Id=A.IdMarca And C.Id=A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("ImagenUrl"))))
                    //{
                    //    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    //}

                    if (!(lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    }

                    aux.Precio = lector.GetDecimal(4);
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];


                    lista.Add(aux);



                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public void Agregar(Articulo nuevo)
        {
            AccesoBaseDeDatos datos = new AccesoBaseDeDatos();


            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "',@idMarca,@idCategoria,@imagen,@precio)");

                datos.SetearParametro("@idMarca", nuevo.Marca.Id);
                datos.SetearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.SetearParametro("@precio", nuevo.Precio);
                datos.SetearParametro("@imagen", nuevo.ImagenUrl);


                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public void Modificar(Articulo modificar)
        {
            AccesoBaseDeDatos datos = new AccesoBaseDeDatos();

            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@idMarca,IdCategoria=@idCategoria,ImagenUrl=@imagenUrl,Precio=@precio where Id=@id");
                datos.SetearParametro("@codigo", modificar.Codigo);
                datos.SetearParametro("@nombre", modificar.Nombre);
                datos.SetearParametro("@descripcion", modificar.Descripcion);
                datos.SetearParametro("@idMarca", modificar.Marca.Id);
                datos.SetearParametro("@idCategoria", modificar.Categoria.Id);
                datos.SetearParametro("@imagenUrl", modificar.ImagenUrl);
                datos.SetearParametro("@precio", modificar.Precio);
                datos.SetearParametro("@id", modificar.Id);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EliminarFisica(int id)
        {

            try
            {

                AccesoBaseDeDatos datos = new AccesoBaseDeDatos();

                datos.SetearConsulta("Delete From ARTICULOS where Id=@id ");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista=new List<Articulo>();
            AccesoBaseDeDatos datos = new AccesoBaseDeDatos();

            try
            {
                string consulta = "Select Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion as Marca,A.IdMarca,C.Descripcion as Categoria,A.IdCategoria,A.Id from ARTICULOS A, MARCAS M,CATEGORIAS C Where M.Id=A.IdMarca And C.Id=A.IdCategoria And ";
                
                if(campo=="Nombre")
                {
                    switch(criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro+"%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro+"'";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro+"%' ";
                            break;
                    }
                }else
                {
                    if(campo=="Descripcion")
                    {
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;

                            default:
                                consulta += "A.Descripcion like '%" + filtro + "%' ";
                                break;
                        }
                    }
                }

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("ImagenUrl"))))
                    //{
                    //    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    //}

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.Precio = datos.Lector.GetDecimal(4);
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];


                    lista.Add(aux);



                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

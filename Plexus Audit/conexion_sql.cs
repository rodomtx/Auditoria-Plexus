using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Plexus_Audit
{
    class conexion_sql
    {
        string conexion_string;/*nombre o ip del servidor , */
        string servidor, instancia, db;
        SqlConnection sql_conexion;

        public conexion_sql(string _servidor,string _instancia,string _db)
        {
            servidor = _servidor;
            instancia = _instancia;
            db = _db;


            conexion_string = "Data Source=" + _servidor + @"\" + _instancia + ";Initial Catalog=" + db + "; Integrated Security=SSPI;";
            /*conexion_string = @"Data Source=mxcopnapps01\sqlexpress ;Initial Catalog=plexus_audit;Integrated Security=True";*/
            sql_conexion = new SqlConnection(conexion_string);

        }

        public Boolean status()
        {
            Boolean _status = false;

            
            try
            {
                sql_conexion.Open();
                _status = true;
                sql_conexion.Close();
            }
            catch (Exception ex)
            {
                 
                _status = false;
            }

            return _status;
        }


        public Boolean validar_gafete(string _gafete)
        {
            SqlDataReader rdr = null;
            Boolean seguridad = false;
            int valor = 0;
            try
            {
                
                SqlCommand command = new SqlCommand("plexus_audit.dbo.seguridad", sql_conexion);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@gafete", _gafete));

                sql_conexion.Open();
                rdr = command.ExecuteReader();
                rdr.Read();
                valor = Convert.ToInt16(rdr["existe"]);

                if (valor>0)
                {
                    seguridad = true;
                 }
            }
            catch (Exception ex)
            {
                
                seguridad = false;
            }
            if (sql_conexion != null)
            {
                sql_conexion.Close();
            }
            return seguridad;
        }

        public Boolean auditar_embarque(string _producto,string _serie1, string _serie2,string _serie3,string _serie4 , string _serie5 , string _serie6)
        {
            SqlDataReader rdr = null;
            Boolean resultado = false;
            int valor = 0;
             try
             {

            SqlCommand command = new SqlCommand("plexus_audit.dbo.auditar_series", sql_conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@producto", _producto));
            command.Parameters.Add(new SqlParameter("@serie1", _serie1));
            command.Parameters.Add(new SqlParameter("@serie2", _serie2));
            command.Parameters.Add(new SqlParameter("@serie3", _serie3));
            command.Parameters.Add(new SqlParameter("@serie4", _serie4));
            command.Parameters.Add(new SqlParameter("@serie5", _serie5));
            command.Parameters.Add(new SqlParameter("@serie6", _serie6));

            sql_conexion.Open();
            rdr = command.ExecuteReader();
            rdr.Read();
            valor = Convert.ToInt16(rdr["total"]);

            if (valor == 0)
            {
                resultado = true;
            }
             }
             catch (Exception ex)
             {

                 resultado = false;
             }
            if (sql_conexion != null)
            {
                sql_conexion.Close();
            }
            return resultado;
        }


        public void agregar_auditoria(string _contenedor, string _descripcion, string _operador, string _auditor, string _serie1, string _serie2, string _serie3, string _serie4, string _serie5, string _serie6)
        {
            
            /*try
            {*/

                SqlCommand command = new SqlCommand("plexus_audit.dbo.guardar_auditoria", sql_conexion);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@contenedor", _contenedor));
                command.Parameters.Add(new SqlParameter("@descripcion", _descripcion));
                command.Parameters.Add(new SqlParameter("@auditor", _auditor));
                command.Parameters.Add(new SqlParameter("@operador", _operador));

                command.Parameters.Add(new SqlParameter("@serie1", _serie1));
                command.Parameters.Add(new SqlParameter("@serie2", _serie2));
                command.Parameters.Add(new SqlParameter("@serie3", _serie3));
                command.Parameters.Add(new SqlParameter("@serie4", _serie4));
                command.Parameters.Add(new SqlParameter("@serie5", _serie5));
                command.Parameters.Add(new SqlParameter("@serie6", _serie6));

                sql_conexion.Open();
                command.ExecuteNonQuery();
                
                

                
            /*}
            catch (Exception ex)
            {

                
            }*/
            if (sql_conexion != null)
            {
                sql_conexion.Close();
            }
            
        }

    }
}

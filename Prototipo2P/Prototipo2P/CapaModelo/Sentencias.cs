using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insercion(int e, int b, int p, int c, String f) {
            int v = 4;
            //cadena a insertar
            string cadena = "INSERT INTO tbl_pedido (id_pedido, cantidad_pedido, fecha_pedido, fk_id_bodega, fk_id_empleado, fk_id_producto) " +
                "VALUES('" + c + "','" + f + "','"+ b +"', '"+ e +"', '"+ p +"');";
            OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
            consulta.ExecuteNonQuery();
        }

    }
}

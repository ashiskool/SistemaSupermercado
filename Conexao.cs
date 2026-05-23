using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

public class Conexao
{
    public static MySqlConnection Abrir()
    {
        string str = "server=localhost;database=supermercado;uid=root;pwd=root123";

        MySqlConnection conn = new MySqlConnection(str);

        conn.Open();

        return conn;
    }
}

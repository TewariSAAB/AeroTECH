using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DBHelper
{
    private static string connectionString = "Server=database-1.ckvwwmvanacd.us-east-1.rds.amazonaws.com;Database=AeroTech;User ID=admin;Password=Dhruv0204;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
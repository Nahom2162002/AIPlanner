using System;
using System.Data.SqlClient;

namespace AppDbContext
{
    class DBConn
    {
        static void Main()
        {
            Connect();
            Console.ReadKey();
        }

        static void Connect()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=LAPTOP-8L8OVN57;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            conn.Open();

            Console.WriteLine("Connection Open!");

            conn.Close();
        }
    }

    class SelectStatement
    {
        static void Main()
        {
            Read();
            Console.ReadKey();
        }

        static void Read()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=LAPTOP-8L8OVN57;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            conn.Open();

            SqlCommand cmd;

            SqlDataReader dreader;

            string sql, output = "";

            sql = "Select title from demo";

            cmd = new SqlCommand(sql, conn);

            dreader = cmd.ExecuteReader();

            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " + dreader.GetValue(1) + "\n";
            }

            Console.Write(output);

            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }

    class InsertStatement
    {
        static void Main()
        {
            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=LAPTOP-8L8OVN57;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            conn.Open();

            SqlCommand cmd;

            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            sql = "insert into demo values('Clean', 'Clean the house, room, bathroom, etc.', 05/08/2025, true)";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);

            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
    }

    class UpdateStatment
    {
        static void Main()
        {
            Update();
            Console.ReadKey();
        }

        static void Update()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=LAPTOP-8L8OVN57;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            conn.Open();

            SqlCommand cmd;

            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            sql = "update demo set title= title + '(Complete)' where isComplete=true";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);

            adap.InsertCommand.ExecuteNonQuery(); 

            cmd.Dispose();
            conn.Close();
        }
    }

    class DeleteStatement
    {
        static void Main()
        {
            Delete();
            Console.ReadKey();
        }

        static void Delete()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=LAPTOP-8L8OVN57;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            conn.Open();

            SqlCommand cmd;

            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            sql = "delete from demo where isComplete=true";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);

            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
    }
}
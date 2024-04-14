using System.Data;
using System.Data.SqlClient;
Console.WriteLine("Hello, World!");
SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "DESKTOP-UH1PE82";//server name
stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sasa@123";
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open");

string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);
connection.Close();
Console.WriteLine("Connection close");
foreach(DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id =>"+dr["BlogId"]);
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
}
Console.ReadKey();
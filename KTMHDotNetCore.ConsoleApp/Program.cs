/*using System.Data;
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
    Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
    Console.WriteLine("______________________________________");
}
Console.ReadKey();*/

/*using KTMHDotNetCore.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        AdoDotNetExanple adoDotNetExample = new AdoDotNetExanple();
        //adoDotNetExample.Read();
        //adoDotNetExample.Create("title", "author", "content");
        //adoDotNetExample.Update(13, "title 1", "author 1", "content 1");
        adoDotNetExample.Edit(13);
        adoDotNetExample.Edit(1);
        Console.ReadLine();
    }
}*/
using KTMHDotNetCore.ConsoleApp;

DapperExample dapperExample = new DapperExample();
dapperExample.Run();
Console.ReadLine();
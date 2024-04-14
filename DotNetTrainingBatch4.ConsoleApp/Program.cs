using System.Data.SqlClient;
Console.WriteLine("Hello, World!");




SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "HR";
stringBuilder.InitialCatalog = "DotNetTrainingBatch4";//database name
stringBuilder.UserID = "sa";//username
stringBuilder.Password = "sa@123";//password
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open");
string query = "select * from tbl_blog";
SqlCommand cmd= new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

connection.Close();
Console.WriteLine("Connection Close");

Console.ReadKey();


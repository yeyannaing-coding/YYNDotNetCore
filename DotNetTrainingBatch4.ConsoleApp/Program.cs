using DotNetTrainingBatch4.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World");

// npm
// pub.dev
// nuget
// SqlConnection

// Ctrl + .
// C# => Db
AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(3, "test title", "test author", "test content");
//adoDotNetExample.Delete(3);
adoDotNetExample.Edit(2);
// Ado.net 
// CRUD

Console.ReadKey();
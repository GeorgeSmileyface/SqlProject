using SqlProject;
using System.Data.SqlClient;

string connectionString = "Server = localhost;" +
    "Database = SqlTeachingDb;" +
    "User Id = sa;" +
    "Password = 1234;" +
    "Trusted_Connection = True;" +
    "TrustServerCertificate = True;";

var person = new Person(1, "John", "Doe", "1234 Elm St", "Springfield); DROP TABLE Persons;");

SqlConnection connection = new SqlConnection(connectionString);

SqlCommand command = connection.CreateCommand();
string sql = "INSERT INTO Persons (PersonID, FirstName, LastName, Address, City)" +
    " VALUES (@PersonID, @FirstName, @LastName, @Address, @City)";

command.CommandText = sql;
command.Parameters.AddWithValue("@PersonID", person.Id);
command.Parameters.AddWithValue("@FirstName", person.FirstName);
command.Parameters.AddWithValue("@LastName", person.LastName);
command.Parameters.AddWithValue("@Address", person.Adress);
command.Parameters.AddWithValue("@City", person.City);

connection.Open();

command.ExecuteNonQuery();

connection.Close();

Console.ReadKey();

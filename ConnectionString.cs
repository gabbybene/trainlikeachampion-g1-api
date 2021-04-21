namespace api
{
    public class ConnectionString
    {
        public string cs{get; set;}

        public ConnectionString()
        {
            string server = "us-cdbr-east-03.cleardb.com";
            string database = "heroku_000524d39fc1c75";
            string user = "bdad55eb85c47c";
            string password = "f1b4bad2";
            string port = "3306";

            cs = $@"Server={server};Uid={user};Database={database};Port={port};Pwd={password}";
        }
    }
}
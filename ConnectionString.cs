namespace api
{
    public class ConnectionString
    {
        public string cs{get; set;}

        public ConnectionString()
        {
            string server = "cis9cbtgerlk68wl.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ikmvdl6i7su2hvr7";
            string port = "3306";
            string userName = "y4t80adbo02rm95h";
            string password = "xhzboysti8qmj02e";

            cs = $@"server = {server}; user={userName}; database={database}; port={port}; password={password};";   
        }
    }
}
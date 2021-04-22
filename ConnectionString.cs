namespace api
{
    public class ConnectionString
    {
        public string cs;
        public ConnectionString(){
            string server = "cis9cbtgerlk68wl.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ikmvdl6i7su2hvr7";
            string user = "y4t80adbo02rm95h";
            string password = "xhzboysti8qmj02e";
            string port = "3306";
 
            cs = $@"server={server};user={user};database={database};port={port};password={password};convert zero datetime=True";
        }
    }
}
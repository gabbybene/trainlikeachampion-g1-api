namespace api
{
    public class ConnectionString
    {
        //for ClearDB 
        // public string cs;
        // public ConnectionString(){
        //     string server = "us-cdbr-east-03.cleardb.com";
        //     string database = "heroku_000524d39fc1c75";
        //     string user = "bdad55eb85c47c";
        //     string password = "f1b4bad2";
        //     string port = "3306";
 
        //     cs = $@"server={server};user={user};database={database};port={port};password={password};convert zero datetime=True";
        // }
        //for JawsDB
        public string cs;
        public ConnectionString(){
            string server = "cis9cbtgerlk68wl.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ikmvdl6i7su2hvr7";
            string user = "y4t80adbo02rm95h";
            string password = "xhzboysti8qmj02e";
            string port = "3306";
 
            cs = $@"server={server};user={user};database={database};port={port};password={password};convert zero datetime=True";
        }

        //OLD connectionstring for cleardb
    //     string server = "us-cdbr-east-03.cleardb.com";
    //         string database = "heroku_000524d39fc1c75";
    //         string user = "bdad55eb85c47c";
    //         string password = "f1b4bad2";
    //         string port = "3306";

    //         cs = $@"Server={server};Uid={user};Database={database};Port={port};Pwd={password}";
    // }
    }
}
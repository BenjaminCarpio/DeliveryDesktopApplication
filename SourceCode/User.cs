﻿namespace SourceCode
{
    public class User
    {
        public int iduser{ get; set;}
        public string fullname{ get; set;}
        public string username{ get; set;}
        public string password{ get; set;}
        public bool usertype{ get; set;}

        public User()
        {
            iduser = 0;
            fullname = "";
            username = "";
            password = "";
            usertype = false;
        }

    }
}
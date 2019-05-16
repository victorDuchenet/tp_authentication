﻿namespace TP_API
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public override string ToString()
        {
            return string.Concat(Id, " - ", Username, " - ", HashedPassword, " - ", Salt);
        }
    }
}

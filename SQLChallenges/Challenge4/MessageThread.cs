using System;
using System.Collections.Generic;

namespace SQLChallenges.Challenge4
{
    public class MessageThread
    {
        public int MessageThreadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<User> Users { get; set; }
    }
}
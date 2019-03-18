using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyProblems
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Input
    {
        public IList<User> Users { get; set; }
    }

    [JsonObject(MemberSerialization.OptOut)]
    public class User
    {
        public Guid Id { get; set; }
        public Guid ManagerId { get; set; }
        //future
        public IList<User> Children { get; set; }
    }
}

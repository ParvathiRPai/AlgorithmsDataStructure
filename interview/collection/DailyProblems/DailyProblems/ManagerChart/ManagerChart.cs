using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyProblems
{
    public class ManagerChart
    {
        public ManagerChart()
        {
        }

        public void Run(Input input)
        {
            var inputWithChildren = AssignChildren(input);
            var roots = FindRoots(inputWithChildren);
            foreach(var root in roots)
            {
                Bfs(root);
            }
        }

        public IList<User> AssignChildren(Input input)
        {
            var userList = input.Users;
            //list to dictionary, cool way
            var userMap = userList
                .Select(x => new KeyValuePair<Guid, User>(x.Id, x))
                .ToDictionary(x => x.Key, x => x.Value);
            foreach(var user in input.Users)
            {
                if(!userMap.ContainsKey(user.ManagerId))
                {
                    userMap[user.ManagerId] = new User
                    {
                        Id = user.ManagerId,
                        Children = new List<User>
                        {
                            user
                        }
                    };
                }
                else
                {
                    userMap[user.ManagerId].Children.Add(user);
                }
            }

            return userMap.Select(x => x.Value).ToList();
        }

        public IList<User> FindRoots(IList<User> users)
        {
            var topNodes = new List<User>();
            foreach(var user in users)
            {
                var temp = user;
                while(temp.ManagerId != null && temp.ManagerId != Guid.Empty)
                {
                    temp = users.Where(x => x.Id == user.ManagerId).First();
                }
                topNodes.Add(temp);
            }

            return topNodes;       
        }

       
        public void Bfs(Input input)
        {
            Queue<Input> q = new Queue<Input>();
            q.Enqueue(input);
            while(q.Count >0)
            {
                input = q.Dequeue();
                Console.WriteLine(input.Users);
                if (input.ManagerId != null)
                q.Enqueue(input.ManagerID)

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> followersBook = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "Log out")
                {
                    break;
                }

                string[] command = inputCommand.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string username = command[1];

                switch (command[0])
                {
                    case "New follower":

                        if (!followersBook.ContainsKey(username))
                        {
                            followersBook.Add(username, new Dictionary<string, int>
                            {
                                { "likes", 0 },
                                { "comments", 0 }
                            });
                        }

                        break;

                    case "Like":

                        int likesCount = int.Parse(command[2]);

                        if (!followersBook.ContainsKey(username))
                        {
                            followersBook.Add(username, new Dictionary<string, int>
                            {
                                { "likes", likesCount },
                                {"comments", 0 }
                            });
                        }
                        else
                        {
                            followersBook[username]["likes"] += likesCount;
                        }

                        break;

                    case "Comment":

                        if (!followersBook.ContainsKey(username))
                        {
                            followersBook.Add(username, new Dictionary<string, int>
                            {
                                { "likes", 0 },
                                { "comments", 1 }
                            });
                        }
                        else
                        {
                            followersBook[username]["comments"]++;
                        }

                        break;

                    case "Blocked":

                        if (followersBook.ContainsKey(username))
                        {
                            followersBook.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }

                        break;
                }
            }

            Console.WriteLine($"{followersBook.Count} followers");

            foreach (var follower in followersBook.OrderByDescending(x => x.Value["likes"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value["likes"] + follower.Value["comments"]}");
            }

        }
    }
}

using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class FriendServices
    {
        static List<ListOfFriend> Friends { get; }
        static int nextId = 3;
        static FriendServices()
        {
            Friends = new List<ListOfFriend>
                {
                    new ListOfFriend { Id =1, FName="Dhanush", Fplace="Bangalore" },
                    new ListOfFriend { Id =2, FName="Rahul", Fplace="Bangalore" }
                };
        }

        public static List<ListOfFriend> GetAll() => Friends;

        public static ListOfFriend? Get(int id) => Friends.FirstOrDefault(f => f.Id == id);
        
        public static void Add(ListOfFriend friendCircle)
        {
            friendCircle.Id = nextId++;
            Friends.Add(friendCircle);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }

        public static void Update(ListOfFriend friends)
        {
            var index = Friends.FindIndex(f => f.Id == friends.Id);
            if (index == -1)
                return;

            Friends[index] = friends;
        }
    }
}

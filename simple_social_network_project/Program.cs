using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_social_network_project
{
    class Program
    {
        public struct User
        {
            

        };

        public struct Account
        {

        };

        public struct Post
        {
            public String Text;
            public List<User> Likes;
            public List<Comment> Comments;
        };

        public struct Comment
        {

        };

        public static class SocialNetwork
        {
            public static List<User> Users;
            public static User current_user;
            public static void Create_Account(Account account,String name,DateTime date_of_birth,Boolean gender,String city)
            {

               

            }
            public static void Delete_Post(Post post)
            {
                current_user.Posts.Remove(post);
                
            }
            public static void Delete_Post(Post post,User user)
            {
                if (current_user.Admin_Flag==true)
                {
                    user.Posts.Remove(post);
                }
                else if (current_user.Equals(user)) {
                    current_user.Posts.Remove(post);
                }
            }



        };
        

        public static void Main(string[] args)
        {
            
        }
    }
}

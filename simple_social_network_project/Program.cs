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
            string userName;
            int userPassword;
            bool userGender; // true-->male, false-->female
            DateTime userBirthDate; // y,m,d
            bool adminFlag=false; // true-->admin
            string userCountry;

            public List<Post> userPostsList = new List<Post>();
            public List<User> userFriendsList = new List<User>();

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
            User CommentingUser;
            string TheComment;
        };

        public static class SocialNetwork
        {
            public static List<User> Users;
            public static User current_user = NULL;
            public static void Create_Account(Account account,String name,DateTime date_of_birth,Boolean gender,String city)
            {

               

            }
            
            void login (Account account)
            {
                for(int i=0; i<Users.Count(); i++)
                {
                    if(account.name==Users[i].userName && account.password==Users[i].userPassword)
                        current_user=Users[i];
                }
                if(current_user==NULL)
                    Console.WriteLine("Invalid username or password, please check them again.");
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

            void likePost(Post post)
            {
                post.Likes.push_back(current_user);
            }

            public static void WritePost(Post newPost)
            {
                current_user.userPostsList.Add(newPost);
            }

            public static void DeleteComment(Comment commentToBeDeleted)
            {
             
            }

            public static void DeleteAccount(Account accountToBeDeleted)
            {
                //there should be an adjacency list of accounts from which the account is deleted
            }

        };
        

        public static void Main(string[] args)
        {
            
        }
    }
}

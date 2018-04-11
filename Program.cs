using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_social_network_project
{
    class Program
    {
        public class User
        {
            string userFisrtName;
            string userLastName;
            public string userEmail;
            public string userPassword;
            long userPhoneNumber;
            bool userGender; // true-->male, false-->female
            DateTime userBirthDate; // y,m,d
            string userCountry;
            public  bool adminFlag; // true-->admin

            public List<Post> userPostsList ;
            public List<User> userFriendsList ;

        };

        public class Account
        {
            public string accountEmail;
            public string accountPassword;
        };

        public class Post
        {
            public String Text;
            public List<User> Likes;
            public List<Comment> Comments;
        };

        public class Comment
        {
           public User CommentingUser;
            public string TheComment;
        };

        public static class SocialNetwork
        {
            public static List<User> Users;
            public static User current_user ;
            public static void Create_Account(Account account, String name, DateTime date_of_birth, Boolean gender, String city)
            {



            }

           public static void Login(Account account)
            {
                for (int i = 0; i < Users.Count(); i++)
                {
                    if (account.accountEmail == Users[i].userEmail && account.accountPassword == Users[i].userPassword)
                    {
                        current_user = Users[i];
                        break;
                    }
                }
                if (current_user == null)
                    Console.WriteLine("Invalid username or password, please check them again.\n If you don't have an account, you can sign up now!");
                
            }

            public static void Delete_Post(Post post)
            {
                current_user.userPostsList.Remove(post);

            }
            public static void Delete_Post(Post post, User user)
            {
                if (current_user.adminFlag == true)
                {
                    user.userPostsList.Remove(post);
                }
                else if (current_user.Equals(user))
                {
                    current_user.userPostsList.Remove(post);
                }
            }

           static void LikePost(Post post)
            {
                post.Likes.Add(current_user);
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
            public static void CommentPost(string comment, Post postCommentedOn)
            {
                Comment newcomment=new Comment();
                newcomment.CommentingUser=current_user;
                newcomment.TheComment = comment;
                postCommentedOn.Comments.Add(newcomment);
            }
            public static void logout()
            {
                current_user = null;
                //go to login form and exit this form
            }
            public static void AddFriend(User friend)
            {
                current_user.userFriendsList.Add(friend);
            }


        };


        public static void Main(string[] args)
        {

        }
    }
}
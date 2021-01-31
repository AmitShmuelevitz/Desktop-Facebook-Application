using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktop
{
    public class FriendAgeGuessingGame
    {
        public IGuessingGameBuilder Builder { get; set; }

        public User LoggedInUser { get; set; }

        public Collection<User> Friends { get; set;  }

        public object Construct()
        {
            Builder.Title = "Friend Guessing Game";
            Builder.QuestionText = "How old is this friend?";

            Collection<object> allFriends = new Collection<object>();
            allFriends.Add(LoggedInUser);
            foreach (User friend in Friends)
            {
                allFriends.Add(friend);
            }

            Builder.Objects = allFriends;
            Builder.PictureFetcher = new FriendGuessingGamePictureFetcher();
            Builder.AnswerFetcher = new FriendAgeGuessingGameAnswerFetcher();

            return Builder.GetComplexObject();
        }
    }

    public class FriendHometownGuessingGame
    {
        public IGuessingGameBuilder Builder { get; set; }

        public User LoggedInUser { get; set; }

        public Collection<User> Friends { get; set; }

        public object Construct()
        {
            Builder.Title = "Friend Guessing Game";
            Builder.QuestionText = "What is the hometown of this friend?";

            Collection<object> allFriends = new Collection<object>();
            allFriends.Add(LoggedInUser);
            foreach (User friend in Friends)
            {
                allFriends.Add(friend);
            }

            Builder.Objects = allFriends;
            Builder.PictureFetcher = new FriendGuessingGamePictureFetcher();
            Builder.AnswerFetcher = new FriendHometownGuessingGameAnswerFetcher();

            return Builder.GetComplexObject();
        }
    }

    public class FriendGuessingGamePictureFetcher : IGuessingGameBuilderPictureFetcher
    {
        public string GetPictureUrl(object i_Object)
        {
            User friend = (User)i_Object;
            return friend.PictureNormalURL;
        }
    }

    public class FriendAgeGuessingGameAnswerFetcher : IGuessingGameBuilderAnswerFetcher
    {
        public string GetCorrectAnswer(object i_Object)
        {
            User friend = (User)i_Object;

            DateTime birthday = DateTime.Parse(friend.Birthday);
            TimeSpan ageTimeSpan = DateTime.Now.Subtract(birthday);
            int age = (int)(ageTimeSpan.TotalDays / 365);

            return age.ToString();
        }
    }

    public class FriendHometownGuessingGameAnswerFetcher : IGuessingGameBuilderAnswerFetcher
    {
        public string GetCorrectAnswer(object i_Object)
        {
            User friend = (User)i_Object;

            if (friend.Hometown == null)
            {
                return "none";
            }

            return friend.Hometown.ToString();
        }
    }
}

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
    public class PhotoGuessingGame
    {
        public IGuessingGameBuilder Builder { get; set; }
        
        public Collection<Album> Albums { get; set; }

        public object Construct()
        {
            Builder.Title = "Photo Guessing Game";
            Builder.QuestionText = "What year is this photo from?";

            Collection<object> allPhotos = new Collection<object>();
            foreach (Album album in Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    allPhotos.Add(photo);
                }
            }

            Builder.Objects = allPhotos;
            Builder.PictureFetcher = new PhotoGuessingGamePictureFetcher();
            Builder.AnswerFetcher = new PhotoGuessingGameAnswerFetcher();

            return Builder.GetComplexObject();
        }
    }

    public class PhotoGuessingGamePictureFetcher : IGuessingGameBuilderPictureFetcher
    {
        public string GetPictureUrl(object i_Object)
        {
            Photo photo = (Photo)i_Object;
            return photo.PictureNormalURL;
        }
    }

    public class PhotoGuessingGameAnswerFetcher : IGuessingGameBuilderAnswerFetcher
    {
        public string GetCorrectAnswer(object i_Object)
        {
            Photo photo = (Photo)i_Object;
            return photo.CreatedTime.Value.Year.ToString();
        }
    }
}

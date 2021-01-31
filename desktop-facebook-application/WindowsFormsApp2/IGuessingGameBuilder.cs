using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace FacebookDesktop
{
    public interface IGuessingGameBuilder
    {
        string Title { get; set; }

        string QuestionText { get; set; }

        Collection<object> Objects { get; set; }

        IGuessingGameBuilderPictureFetcher PictureFetcher { get; set; }

        IGuessingGameBuilderAnswerFetcher AnswerFetcher { get; set; }

        object GetComplexObject();
    }

    public interface IGuessingGameBuilderPictureFetcher
    {
        string GetPictureUrl(object i_Object);
    }

    public interface IGuessingGameBuilderAnswerFetcher
    {
        string GetCorrectAnswer(object i_Object);
    }
}

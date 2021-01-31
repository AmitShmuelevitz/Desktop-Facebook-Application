using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public class FormGuessingGameBuilder : IGuessingGameBuilder
    {
        public FormGuessingGameBuilder()
        {
            // Default parts:
            Title = "Guessing Game";
        }

        public string Title { get; set; }

        public string QuestionText { get; set; }

        public Collection<object> Objects { get; set; }

        public IGuessingGameBuilderPictureFetcher PictureFetcher { get; set; }

        public IGuessingGameBuilderAnswerFetcher AnswerFetcher { get; set; }

        public object GetComplexObject()
        {
            GuessingGameForm form = new GuessingGameForm();
            form.Objects = Objects;
            form.PictureFetcher = PictureFetcher;
            form.AnswerFetcher = AnswerFetcher;
            form.Title = Title;
            form.QuestionText = QuestionText;

            return form;
        }
    }
}

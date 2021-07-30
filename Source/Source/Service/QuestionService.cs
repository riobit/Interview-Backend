using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Source.Models;

namespace Source.Service
{
    public class QuestionService : IQuestionService
    {
        /// <summary>
        /// 
        /// Description that contains "Ergonomics" or Title that contains "Ergonomics"
        /// Tags that contains "Sports"
        /// Order by Id descending
        /// Get the last 3 (three) items only
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public List<QuestionModel> QuestionTwo(List<QuestionModel> models)
        {
            var filter = "Ergonomic";
            var filterTag = "Sports";
            var result = models.Where(x => (x.Description.Contains(filter) || x.Title.Contains(filter)) &&
                                           x.Tags.Contains(filterTag)
                                           )
                .OrderByDescending(x => x.Id)
                .Take(3);

            return result.ToList();
        }
        /// <summary>
        /// Please create a controller that sends request to this endpoint: /backend/question/three
        /// then please flatten property items from the response.
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public List<QuestionModel> QuestionThree(QuestionThreeModel models)
        {
            var result = new List<QuestionModel>();
            var qM = new QuestionModel();
            qM.Id = models.Id;
            qM.Tags = models.Tags;
            qM.Category = models.Category;
            foreach (var model in models.Items)
            {
                qM.Title = model.Title;
                qM.Description = model.Description;
                qM.Footer = model.Footer;
                result.Add(qM);
            }

            return result;
        }
    }
}

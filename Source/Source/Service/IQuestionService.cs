using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Source.Models;

namespace Source.Service
{
    public interface IQuestionService
    {
        List<QuestionModel> QuestionTwo(List<QuestionModel> models);
        List<QuestionModel> QuestionThree(List<QuestionThreeModel> models);
    }
}

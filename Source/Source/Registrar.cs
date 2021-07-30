using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Source.Service;

namespace Source
{
    public class Registrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IQuestionService, QuestionService>();
            
        }
    }
}

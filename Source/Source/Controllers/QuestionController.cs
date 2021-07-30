using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Source.Models;
using Source.Service;
using System.Text.Json;

namespace Source.Controllers
{
    [Route("backend/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IQuestionService _questionService;
        private static readonly HttpClient client = new HttpClient();
        private readonly string _baseUrl;

        public QuestionController(IQuestionService questionService, IConfiguration configuration)
        {
            _questionService = questionService;
            _configuration = configuration;
            _baseUrl = _configuration["BaseUrl"];
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        [Route("one")]
        public async Task<ActionResult<object>>One()
        {
            var request = client.GetStreamAsync(_baseUrl + "backend/question/three");
            var items = await JsonSerializer.DeserializeAsync<object>(await request);
            return Ok(items);
        }
        [HttpGet]
        [Route("two")]
        public async Task<ActionResult> Two()
        {
            var request = client.GetStreamAsync(_baseUrl + "backend/question/three");
            var items = await JsonSerializer.DeserializeAsync<List<QuestionModel>>(await request);
            var result = _questionService.QuestionTwo(items);
            return Ok(result);
        }
        [HttpGet]
        [Route("three")]
        public async Task<ActionResult> Three()
        {
            var request = client.GetStreamAsync(_baseUrl + "backend/question/three");
            var items = await JsonSerializer.DeserializeAsync<QuestionThreeModel>(await request);
            var result = _questionService.QuestionThree(items);
            return Ok(result);
        }
    }
}

﻿using AutoMapper;
using BlazorFormDesigner.BusinessLogic.Services;
using BlazorFormDesigner.Web.Models;
using BlazorFormDesigner.Api.Converters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlazorFormDesigner.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController: AppController
    {
        private readonly AnswerService AnswerService;

        public AnswerController(AnswerService answerService, IMapper mapper) : base(mapper)
        {
            AnswerService = answerService;
        }

        [HttpPost]
        public async Task<ActionResult> Save(Response request)
        {
            var user = ValidateUser();

            var result = await AnswerService.Save(user, request.FormId, request.Answers.ToModel(mapper));

            return Ok(result);
        }
    }
}
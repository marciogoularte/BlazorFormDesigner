﻿using BlazorFormDesigner.BusinessLogic.Models;
using System.Threading.Tasks;

namespace BlazorFormDesigner.BusinessLogic.Interfaces
{
    public interface IAnswerRepository
    {
        Task<Response> Create(Response response);
    }
}
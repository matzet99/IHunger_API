﻿using IHunger.Domain.Interfaces;
using IHunger.Domain.Interfaces.Services;
using IHunger.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHunger.WebAPI.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class CommentController : MainController
    {
        private readonly ICommentService _commentService;

        public CommentController(
            ICommentService commentService,
            INotifier notifier, 
            IUser appUser) : base(notifier, appUser)
        {
            _commentService = commentService;
        }
    }
}

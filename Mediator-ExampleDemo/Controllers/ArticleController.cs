using Mediator_ExampleDemo.Application.Querys;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator_ExampleDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IMediator _mediator;

        public ArticleController(IMediator mediator) => _mediator = mediator;


        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle([FromRoute]GetArticleQuery request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}

using Mediator_ExampleDemo.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator_ExampleDemo.Application.Querys
{
    public class GetArticleQuery : IRequest<Article>
    {
        public int Id { get; set; }
    }
}

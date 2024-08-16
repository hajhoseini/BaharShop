using BaharShop.Application.DTOs.Finances;
using BaharShop.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharShop.Application.Features.Finances.Queries.Requests
{
    public class GetListRequestPayForAdminQuery : IRequest<ResultDTO<List<RequestPayDTO>>>
    {
    }
}

﻿using BaharShop.Application.DTOs.Finances;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Finances.Queries.Requests
{
    public class GetListPaysForAdminQuery : IRequest<ResultDTO<List<PayDTO>>>
    {
    }
}
﻿using MediatR;
using BaharShop.Application.DTOs.Categories;

namespace BaharShop.Application.Features.Categories.Queries.Requests
{
    public class GetListHieararchyCategoriesQuery : IRequest<List<CategoryDTO>>
    {

    }
}
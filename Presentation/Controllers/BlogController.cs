﻿using Business.Abstract.Base;
using Microsoft.AspNetCore.Mvc;
using Presentation.Controllers.Base;
using Presentation.Extensions;

namespace Presentation.Controllers;

public class BlogController : ControllerManager
{
    public BlogController(IServiceManager manager) : base(manager)
    {
    }

    public async Task<IActionResult> Index()
    {
        var result = await _manager.BlogService.GetAllAsync();
        return View(result.Data);
    }

    [Route("detay")]
    public async Task<IActionResult> Detail(string slug)
    {
        var result = await _manager.BlogService.GetSlugAsync(slug);
        return this.ResponseView(result);
    }
}

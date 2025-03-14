﻿using Business.Abstract.Base;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Presentation.Areas.Management.Controllers.Base;
using Presentation.Extensions;
using System.Threading.Tasks;

namespace Presentation.Areas.Management.Controllers;

public class TypeOfEmploymentController : BaseController
{
    public TypeOfEmploymentController(IServiceManager serviceManager, IToastNotification toastNotification) : base(serviceManager, toastNotification)
    {
    }

    public async Task<IActionResult> Index()
    {
        var result = await _serviceManager.TypeOfEmploymentService.GetAllAsync();
        return this.ResponseView(result);
    }
}
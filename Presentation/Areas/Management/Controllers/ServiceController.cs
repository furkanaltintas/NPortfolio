﻿using Business.Abstract.Base;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Presentation.Areas.Management.Controllers.Base;
using Presentation.Areas.Management.ViewModels;
using Presentation.Extensions;
using System.Threading.Tasks;

namespace Presentation.Areas.Management.Controllers;

public class ServiceController : BaseController
{
    public ServiceController(IServiceManager serviceManager, IToastNotification toastNotification) : base(serviceManager, toastNotification)
    {
    }

    public async Task<IActionResult> Index()
    {
        var result = await _serviceManager.ServiceService.GetAllAsync();
        return this.ResponseViewModel<GetAllServiceDto, ServiceViewModel>(result);
    }


    public IActionResult Add() => View();


    [HttpPost]
    public async Task<IActionResult> Add(CreateServiceDto createServiceDto)
    {
        var result = await _serviceManager.ServiceService.AddServiceAsync(createServiceDto);
        return this.ResponseRedirectAction(result, _toastNotification);
    }


    public async Task<IActionResult> Update(int id)
    {
        var result = await _serviceManager.ServiceService.GetUpdateServiceAsync(id);
        return this.ResponseView(result);
    }


    [HttpPost]
    public async Task<IActionResult> Update(UpdateServiceDto updateServiceDto)
    {
        var result = await _serviceManager.ServiceService.UpdateServiceAsync(updateServiceDto);
        return this.ResponseRedirectAction(result, _toastNotification);
    }


    public async Task<IActionResult> Delete(int id)
    {
        var result = await _serviceManager.ServiceService.DeleteServiceAsync(id);
        return this.ResponseRedirectAction(result, _toastNotification);
    }
}
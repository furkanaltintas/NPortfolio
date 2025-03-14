﻿using Business.Abstract.Base;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Presentation.Controllers.Base;
using Presentation.Extensions;

namespace Presentation.Controllers;

public class ContactController : ControllerManager
{
    private readonly IToastNotification _toastNotification;

    public ContactController(IServiceManager manager, IToastNotification toastNotification) : base(manager)
    {
        _toastNotification = toastNotification;
    }

    public IActionResult Index() => View(new CreateContactDto());


    [HttpPost("detail")]
    public async Task<IActionResult> Send(CreateContactDto createContactDto)
    {
        var result = await _manager.ContactService.SendAsync(createContactDto);
        return this.ResponseRedirectAction(result, _toastNotification, createContactDto);
    }
}

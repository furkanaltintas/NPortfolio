﻿using Entities.Dtos;
using Portfolio.Core.Utilities.Results.Abstract;

namespace Business.Abstract;

public interface IUserService
{
    Task<IDataResult<GetUserSidebarDto>> GetUserSidebarDtoAsync();
}
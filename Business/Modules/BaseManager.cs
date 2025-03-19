﻿using AutoMapper;
using DataAccess.Abstract;

namespace Business.Modules;

public class BaseManager
{
    public BaseManager(IRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    protected IRepository Repository { get; }
    protected IMapper Mapper { get; }
}
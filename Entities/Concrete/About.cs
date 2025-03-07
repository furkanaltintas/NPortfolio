﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete;

public class About : BaseEntity, IEntity
{
    public About()
    {

    }

    public About(string description)
    {
        Description = description;
    }

    public string Description { get; set; }
}
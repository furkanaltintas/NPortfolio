﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations;

public class SocialMediaIconConfiguration : IEntityTypeConfiguration<SocialMediaIcon>
{
    public void Configure(EntityTypeBuilder<SocialMediaIcon> builder)
    {
        throw new NotImplementedException();
    }
}
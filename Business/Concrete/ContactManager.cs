﻿using AutoMapper;
using Business.Abstract;
using Business.Concrete.Base;
using Business.Helpers.Validations;
using Business.ValidationRules.FluentValidation.Contacts;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Portfolio.Core.Utilities.Results.Abstract;
using Portfolio.Core.Utilities.Results.ComplexTypes;
using Portfolio.Core.Utilities.Results.Concrete;

namespace Business.Concrete;

public class ContactManager : BaseManager, IContactService
{
    public ContactManager(IValidationHelper validationHelper, IRepository repository, IMapper mapper) : base(validationHelper, repository, mapper)
    {
    }


    public Task<IResult> DeleteContactAsync(int id)
    {
        throw new NotImplementedException();
    }


    public Task<IDataResult<GetContactDto>> GetAboutAsync()
    {
        throw new NotImplementedException();
    }


    [ValidationAspect(typeof(CreateContactValidator), Priority = 1)]
    public async Task<IResult> SendAsync(CreateContactDto createContactDto)
    {
        if (createContactDto != null)
        {
            Contact contact = Mapper.Map<Contact>(createContactDto);
            await Repository.GetRepository<Contact>().AddAsync(contact);
            await Repository.SaveAsync();
            return new Result(ResultStatus.Success, "Mesajınız iletilmiştir");
        }

        return new Result(ResultStatus.Error, "Contact is null");
    }
}
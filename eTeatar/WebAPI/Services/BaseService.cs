﻿using AutoMapper;
using Repository;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    
    public class BaseService<TTransferObject, TSearch, TEntity> : IBaseService<TTransferObject, TSearch> where TEntity : class
    {
        protected readonly IMapper Mapper;
        protected readonly IRepository<TEntity, TSearch> Repository;

        public BaseService(IMapper mapper, IRepository<TEntity, TSearch> repository)
        {
            Mapper = mapper;
            Repository = repository;
        }

        public virtual List<TTransferObject> Get(TSearch search)
        {
            IEnumerable<TEntity> list = Repository.Get(search);
            return Mapper.Map<List<TTransferObject>>(list);
        }

        public virtual TTransferObject GetById(string id)
        {
           TEntity entity = Repository.GetById(id);
           var mapped = Mapper.Map<TTransferObject>(entity);
           return mapped;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using Repository;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class PredstavaService : CrudService<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, Models.Predstava, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest>
    {
        private readonly IBaseService<DataTransferObjects.Zanr, DataTransferObjects.Requests.ZanrSearchRequest> _zanrService;
        public PredstavaService(IMapper mapper, IRepository<Models.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest> repository, IBaseService<DataTransferObjects.Zanr, DataTransferObjects.Requests.ZanrSearchRequest> zanrService) : base(mapper, repository)
        {
            _zanrService = zanrService;
        }

        public override List<DataTransferObjects.Predstava> Get(DataTransferObjects.Requests.PredstavaSearchRequest search)
        {
            var queryresult = base.Get(search);

            //Dodavanje zanrova u model
            foreach (var result in queryresult)
                result.Zanrovi = _zanrService.Get(new DataTransferObjects.Requests.ZanrSearchRequest { PredstavaId = result.Id });

            return queryresult;
        }

        public override Predstava GetById(string id)
        {
            var queryresult = base.GetById(id);

            queryresult.Zanrovi = _zanrService.Get(new DataTransferObjects.Requests.ZanrSearchRequest { PredstavaId = id });

            return queryresult;
        }
    }
}
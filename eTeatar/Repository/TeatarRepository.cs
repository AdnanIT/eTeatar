﻿using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class TeatarRepository : Repository<Teatar, TeatarSearchRequest>
    {
        public TeatarRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Teatar> Get(TeatarSearchRequest search)
        {
            IQueryable<Teatar> query = Context.Set<Teatar>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.GradId))
                query = query.Where(x => x.GradId == search.GradId);
            

            query = query.OrderBy(x => x.Naziv);
            IEnumerable<Teatar> list = query
                .Include(t => t.Grad)
                .ThenInclude(g => g.Drzava)
                .Include(t=>t.Dvorane)
                .ToList();

            return list;
        }

        public override Teatar GetById(string id)
        {
            var query = Context.Set<Teatar>().AsQueryable();
            query = query.Where(w => w.Id == id);

            query = query
                .Include(i => i.Grad)
                .ThenInclude(g=>g.Drzava);

            return query.FirstOrDefault();
        }
    }
}

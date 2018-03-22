using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Controllers.Resources;
using Vega.Models;
using Vega.Persistence;

namespace Vega.Controllers
{
    public class ModelsController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public ModelsController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpGet("/api/models")]
        public async Task<IEnumerable<ModelResource>> GetModels()
        {
            var models = await context.Models.ToListAsync();
            return mapper.Map<List<Model>, List<ModelResource>>(models);
        }
    }
}
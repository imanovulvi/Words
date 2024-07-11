using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Persistence.Context;

namespace Words.Persistence.Extentions
{
    public static class Registrations
    {
        public static void AddPersistenceService(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<WordsDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("sqlConnectionStr")));
        }
    }
}

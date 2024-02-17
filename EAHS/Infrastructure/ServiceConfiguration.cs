using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAHS.Interfaces;
using EAHS.Services;
using EAHS.Repositories;

namespace CGT_API.Infrastructures
{
    public class ServiceConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IJudgesRepository, JudgesRepository>();
            services.AddScoped<IRulesRepository, RulesRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            //Bussiness
            services.AddScoped<JudgesServices>();
            services.AddScoped<RulesServices>();
            services.AddScoped<CountryServices>();
        }
    }
}

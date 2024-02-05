using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DTOLayer;

namespace RealEstate.Extensions
{
    public static class DependenciesContainerExtension
    {
        public static void DependenciesContainer(this IServiceCollection services)
        {
            services.AddScoped<IDanisanDal, DanisanRepository>();
            services.AddScoped<IArsaService, ArsaService>();
            services.AddScoped<IDaireService, DaireService>();
            services.AddScoped<IDepoService, DepoService>();
            services.AddScoped<IDukkanService, DukkanService>();
            services.AddScoped<IIlanService, IlanService>();
            services.AddScoped<IDanisanService, DanisanService>();
            services.AddScoped<ITalepService, TalepService>();
            services.AddScoped<ITarlaService, TarlaService>();

            services.AddScoped<IDanisanDal, DanisanRepository>();
            services.AddScoped<IArsaDal, ArsaRepository>();
            services.AddScoped<IDaireDal, DaireRepository>();
            services.AddScoped<IDepoDal, DepoRepository>();
            services.AddScoped<IDukkanDal, DukkanRepository>();
            services.AddScoped<IIlanDal, IlanRepository>();
            services.AddScoped<IDanisanDal, DanisanRepository>();
            services.AddScoped<ITalepDal, TalepRepository>();
            services.AddScoped<ITarlaDal, TarlaRepository>();
            services.AddScoped<IPortfoyService, PortfoyService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}

using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace RealEstate.Extensions
{
    public static class DependenciesContainerExtension
    {
        public static void DependenciesContainer(this IServiceCollection services)
        {
            services.AddScoped<IAliciService, AliciService>();
            services.AddScoped<IArsaService, ArsaService>();
            services.AddScoped<IDaireService, DaireService>();
            services.AddScoped<IDepoService, DepoService>();
            services.AddScoped<IDukkanService, DukkanService>();
            services.AddScoped<IIlanService, IlanService>();
            services.AddScoped<ISaticiService, SaticiService>();
            services.AddScoped<ITalepService, TalepService>();
            services.AddScoped<ITarlaService, TarlaService>();

            services.AddScoped<IAliciDal, AliciRepository>();
            services.AddScoped<IArsaDal, ArsaRepository>();
            services.AddScoped<IDaireDal, DaireRepository>();
            services.AddScoped<IDepoDal, DepoRepository>();
            services.AddScoped<IDukkanDal, DukkanRepository>();
            services.AddScoped<IIlanDal, IlanRepository>();
            services.AddScoped<ISaticiDal, SaticiRepository>();
            services.AddScoped<ITalepDal, TalepRepository>();
            services.AddScoped<ITarlaDal, TarlaRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}

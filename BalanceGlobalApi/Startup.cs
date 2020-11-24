using System;
using AutoMapper;
using BalanceGlobal.Api.Middleware;
using BalanceGlobal.Database.Context;
using BalanceGlobal.Repository;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BalanceGlobalApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                //options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Balance Global API", Version = "v1" });
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddDbContext<BalanceGlobalContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BalanceGlobalContext")));

            #region Services

            services.AddTransient<IAliasesService, AliasesService>();
            services.AddTransient<ICtcatalogService, CtcatalogService>();
            services.AddTransient<IChangeTrackingDetailService, ChangeTrackingDetailService>();
            services.AddTransient<IChangeTrackingHeaderService, ChangeTrackingHeaderService>();
            services.AddTransient<ITipoDatoColOrigenService , TipoDatoColOrigenService>();      
            services.AddTransient<IBombasService, BombasService>();
            services.AddTransient<ICargaPlataformasService, CargaPlataformasService>();
            services.AddTransient<ICategoriaConsumoAguaService, CategoriaConsumoAguaService>();
            services.AddTransient<ICkmopIiquimaPorteoService, CkmopIiquimaPorteoService>();
            services.AddTransient<ICkmopIivolaPorteoService, CkmopIivolaPorteoService>();
            services.AddTransient<IConsDespachoService, ConsDespachoService>();
            services.AddTransient<IConsInvCarmenService, ConsInvCarmenService>();
            services.AddTransient<IConsLi2Co3Service, ConsLi2Co3Service>();
            services.AddTransient<IConsLitioLiCo3mensualService, ConsLitioLiCo3mensualService>();
            services.AddTransient<IConsPlantaLiOhService, ConsPlantaLiOhService>();
            services.AddTransient<IConsReactivosService, ConsReactivosService>();
            services.AddTransient<IConsRilesyRisesService, ConsRilesyRisesService>();
            services.AddTransient<IConsumoAguaService, ConsumoAguaService>();
            services.AddTransient<IConsumoEnergeticoService, ConsumoEnergeticoService>();
            services.AddTransient<ICorrienteGlobalService, CorrienteGlobalService>();
            services.AddTransient<ICorrienteLi2Co3Service, CorrienteLi2Co3Service>();
            services.AddTransient<ICorrientePciService, CorrientePciService>();
            services.AddTransient<ICorrientesService, CorrientesService>();
            services.AddTransient<ICorrientesRilesyRisesService, CorrientesRilesyRisesService>();
            services.AddTransient<ICosechasService, CosechasService>();
            services.AddTransient<IDescargaInfraestructurasDestinoService, DescargaInfraestructurasDestinoService>();
            services.AddTransient<IDescargaPlataformasService, DescargaPlataformasService>();
            services.AddTransient<IEvaporacionInfiltracionService, EvaporacionInfiltracionService>();
            services.AddTransient<IExtraccionService, ExtraccionService>();
            services.AddTransient<IExtraccionAguaService, ExtraccionAguaService>();
            services.AddTransient<IFactoresImpregnacionService, FactoresImpregnacionService>();
            services.AddTransient<IFaenasService, FaenasService>();
            services.AddTransient<IFaenasSistemasService, FaenasSistemasService>();
            services.AddTransient<IFlujosService, FlujosService>();
            services.AddTransient<IImpregnacionCosechasService, ImpregnacionCosechasService>();
            services.AddTransient<IImpregnacionSistemaRefService, ImpregnacionSistemaRefService>();
            services.AddTransient<IInfraestructurasService, InfraestructurasService>();
            services.AddTransient<IInfraestructurasReinyeccionService, InfraestructurasReinyeccionService>();
            services.AddTransient<IInventariosAtacamaService, InventariosAtacamaService>();
            services.AddTransient<IModalidadPciService, ModalidadPciService>();
            services.AddTransient<IModalidadPlantasService, ModalidadPlantasService>();
            services.AddTransient<IOperaPozasService, OperaPozasService>();
            services.AddTransient<IOrigenesTraspasoPlataformasService, OrigenesTraspasoPlataformasService>();
            services.AddTransient<IPciacopiosCliService, PciacopiosCliService>();
            services.AddTransient<IPciacopiosOrigenService, PciacopiosOrigenService>();
            services.AddTransient<IPcimodosService, PcimodosService>();
            services.AddTransient<IPeriodosService, PeriodosService>();
            services.AddTransient<IPeriodosOperacionalesService, PeriodosOperacionalesService>();
            services.AddTransient<IPermeabilidadService, PermeabilidadService>();
            services.AddTransient<IPorteosService, PorteosService>();
            services.AddTransient<IProdyDespSdeAconsProdKService, ProdyDespSdeAconsProdKService>();
            services.AddTransient<IProdyDespSdeAconsProdK1Service, ProdyDespSdeAconsProdK1Service>();
            services.AddTransient<IProdyDespSdeAvariablesNumService, ProdyDespSdeAvariablesNumService>();
            services.AddTransient<IQuimicaPlataformasService, QuimicaPlataformasService>();
            services.AddTransient<IReactivosService, ReactivosService>();
            services.AddTransient<IReinyeccionService, ReinyeccionService>();
            services.AddTransient<IReservoriosService, ReservoriosService>();
            services.AddTransient<IRiegoPlataformasService, RiegoPlataformasService>();
            services.AddTransient<ISistemasService, SistemasService>();
            services.AddTransient<ISistemasSubSistemasService, SistemasSubSistemasService>();
            services.AddTransient<ISubSistemasService, SubSistemasService>();
            services.AddTransient<ITasaEvaporacionService, TasaEvaporacionService>();
            services.AddTransient<ITipoInfraestructurasService, TipoInfraestructurasService>();
            services.AddTransient<ITipoPciService, TipoPciService>();
            services.AddTransient<ITipoSalService, TipoSalService>();
            services.AddTransient<ITiposInventarioService, TiposInventarioService>();
            services.AddTransient<ITransSistemasCosechasService, TransSistemasCosechasService>();
            services.AddTransient<ITraspasosPlataformasService, TraspasosPlataformasService>();
            services.AddTransient<IDatosEnListaService, DatosEnListaService>();
            services.AddTransient<IImportacionesService, ImportacionesService>();
            services.AddTransient<IImportacionesUserParValuesService, ImportacionesUserParValuesService>();
            services.AddTransient<IImportadoresService, ImportadoresService>();
            services.AddTransient<IImportadoresUserParService, ImportadoresUserParService>();
            services.AddTransient<IImportDestinoService, ImportDestinoService>();
            services.AddTransient<IMensajesImportacionService, MensajesImportacionService>();
            services.AddTransient<IOrigenesDatosService, OrigenesDatosService>();
            services.AddTransient<ISchemaColumnsService, SchemaColumnsService>();
            services.AddTransient<ISchemaColumnsWarningService, SchemaColumnsWarningService>();
            services.AddTransient<ISchemaDefService, SchemaDefService>();

            services.AddTransient<ISchemaDefService, SchemaDefService>();
            services.AddTransient<IDetallePerfilService, DetallePerfilService>();
            services.AddTransient<IEventosService, EventosService>();
            services.AddTransient<IDetallePerfilService, DetallePerfilService>();
            services.AddTransient<IMensajesService, MensajesService>();
            services.AddTransient<IPerfilesUsuarioService, PerfilesUsuarioService>();
            services.AddTransient<ISuscripcionEventosService, SuscripcionEventosService>();
            services.AddTransient<IUsuariosService, UsuariosService>();
            services.AddTransient<IUsuariosPerfilesUsuarioService, UsuariosPerfilesUsuarioService>();
            services.AddTransient<IWorkflowItemService, WorkflowItemService>();


            #endregion

            #region Repository

            services.AddTransient<IChangeTrackingDetailRepository, ChangeTrackingDetailRepository>();
            services.AddTransient<IChangeTrackingHeaderRepository, ChangeTrackingHeaderRepository>();
            services.AddTransient<ICtcatalogRepository, CtcatalogRepository>();
            services.AddTransient<IAliasesRepository, AliasesRepository>();
            services.AddTransient<ITipoDatoColOrigenRepository, TipoDatoColOrigenRepository>();
            services.AddTransient<ICargaPlataformasRepository, CargaPlataformasRepository>();
            services.AddTransient<IBombasRepository, BombasRepository>();
            services.AddTransient<ICategoriaConsumoAguaRepository, CategoriaConsumoAguaRepository>();
            services.AddTransient<ICkmopIiquimaPorteoRepository, CkmopIiquimaPorteoRepository>();
            services.AddTransient<ICkmopIivolaPorteoRepository, CkmopIivolaPorteoRepository>();
            services.AddTransient<IConsDespachoRepository, ConsDespachoRepository>();
            services.AddTransient<IConsInvCarmenRepository, ConsInvCarmenRepository>();
            services.AddTransient<IConsLi2Co3Repository, ConsLi2Co3Repository>();
            services.AddTransient<IConsLitioLiCo3mensualRepository, ConsLitioLiCo3mensualRepository>();
            services.AddTransient<IConsPlantaLiOhRepository, ConsPlantaLiOhRepository>();
            services.AddTransient<IConsReactivosRepository, ConsReactivosRepository>();
            services.AddTransient<IConsRilesyRisesRepository, ConsRilesyRisesRepository>();
            services.AddTransient<IConsumoAguaRepository, ConsumoAguaRepository>();
            services.AddTransient<IConsumoEnergeticoRepository, ConsumoEnergeticoRepository>();
            services.AddTransient<ICorrienteGlobalRepository, CorrienteGlobalRepository>();
            services.AddTransient<ICorrienteLi2Co3Repository, CorrienteLi2Co3Repository>();
            services.AddTransient<ICorrientePciRepository, CorrientePciRepository>();
            services.AddTransient<ICorrientesRepository, CorrientesRepository>();
            services.AddTransient<ICorrientesRilesyRisesRepository, CorrientesRilesyRisesRepository>();
            services.AddTransient<ICosechasRepository, CosechasRepository>();
            services.AddTransient<IDescargaInfraestructurasDestinoRepository, DescargaInfraestructurasDestinoRepository>();
            services.AddTransient<IDescargaPlataformasRepository, DescargaPlataformasRepository>();
            services.AddTransient<IEvaporacionInfiltracionRepository, EvaporacionInfiltracionRepository>();
            services.AddTransient<IExtraccionRepository, ExtraccionRepository>();
            services.AddTransient<IExtraccionAguaRepository, ExtraccionAguaRepository>();
            services.AddTransient<IFactoresImpregnacionRepository, FactoresImpregnacionRepository>();
            services.AddTransient<IFaenasRepository, FaenasRepository>();
            services.AddTransient<IFaenasSistemasRepository, FaenasSistemasRepository>();
            services.AddTransient<IFlujosRepository, FlujosRepository>();
            services.AddTransient<IImpregnacionCosechasRepository, ImpregnacionCosechasRepository>();
            services.AddTransient<IImpregnacionSistemaRefRepository, ImpregnacionSistemaRefRepository>();
            services.AddTransient<IInfraestructurasRepository, InfraestructurasRepository>();
            services.AddTransient<IInfraestructurasReinyeccionRepository, InfraestructurasReinyeccionRepository>();
            services.AddTransient<IInventariosAtacamaRepository, InventariosAtacamaRepository>();
            services.AddTransient<IModalidadPciRepository, ModalidadPciRepository>();
            services.AddTransient<IModalidadPlantasRepository, ModalidadPlantasRepository>();
            services.AddTransient<IOperaPozasRepository, OperaPozasRepository>();
            services.AddTransient<IOrigenesTraspasoPlataformasRepository, OrigenesTraspasoPlataformasRepository>();
            services.AddTransient<IPciacopiosCliRepository, PciacopiosCliRepository>();
            services.AddTransient<IPciacopiosOrigenRepository, PciacopiosOrigenRepository>();
            services.AddTransient<IPcimodosRepository, PcimodosRepository>();
            services.AddTransient<IPeriodosRepository, PeriodosRepository>();
            services.AddTransient<IPeriodosOperacionalesRepository, PeriodosOperacionalesRepository>();
            services.AddTransient<IPermeabilidadRepository, PermeabilidadRepository>();
            services.AddTransient<IPorteosRepository, PorteosRepository>();
            services.AddTransient<IProdyDespSdeAconsProdKRepository, ProdyDespSdeAconsProdKRepository>();
            services.AddTransient<IProdyDespSdeAconsProdK1Repository, ProdyDespSdeAconsProdK1Repository>();
            services.AddTransient<IProdyDespSdeAvariablesNumRepository, ProdyDespSdeAvariablesNumRepository>();
            services.AddTransient<IQuimicaPlataformasRepository, QuimicaPlataformasRepository>();
            services.AddTransient<IReactivosRepository, ReactivosRepository>();
            services.AddTransient<IReinyeccionRepository, ReinyeccionRepository>();
            services.AddTransient<IReservoriosRepository, ReservoriosRepository>();
            services.AddTransient<IRiegoPlataformasRepository, RiegoPlataformasRepository>();
            services.AddTransient<ISistemasRepository, SistemasRepository>();
            services.AddTransient<ISistemasSubSistemasRepository, SistemasSubSistemasRepository>();
            services.AddTransient<ISubSistemasRepository, SubSistemasRepository>();
            services.AddTransient<ITasaEvaporacionRepository, TasaEvaporacionRepository>();
            services.AddTransient<ITipoInfraestructurasRepository, TipoInfraestructurasRepository>();
            services.AddTransient<ITipoPciRepository, TipoPciRepository>();
            services.AddTransient<ITipoSalRepository, TipoSalRepository>();
            services.AddTransient<ITiposInventarioRepository, TiposInventarioRepository>();
            services.AddTransient<ITransSistemasCosechasRepository, TransSistemasCosechasRepository>();
            services.AddTransient<ITraspasosPlataformasRepository, TraspasosPlataformasRepository>();
            services.AddTransient<IDatosEnListaRepository, DatosEnListaRepository>();
            services.AddTransient<IImportacionesRepository, ImportacionesRepository>();
            services.AddTransient<IImportacionesUserParValuesRepository, ImportacionesUserParValuesRepository>();
            services.AddTransient<IImportadoresRepository, ImportadoresRepository>();
            services.AddTransient<IImportadoresUserParRepository, ImportadoresUserParRepository>();
            services.AddTransient<IImportDestinoRepository, ImportDestinoRepository>();
            services.AddTransient<IMensajesImportacionRepository, MensajesImportacionRepository>();
            services.AddTransient<IOrigenesDatosRepository, OrigenesDatosRepository>();
            services.AddTransient<ISchemaColumnsRepository, SchemaColumnsRepository>();
            services.AddTransient<ISchemaColumnsWarningRepository, SchemaColumnsWarningRepository>();
            services.AddTransient<ISchemaDefRepository, SchemaDefRepository>();

            services.AddTransient<ISchemaDefRepository, SchemaDefRepository>();
            services.AddTransient<IDetallePerfilRepository, DetallePerfilRepository>();
            services.AddTransient<IEventosRepository, EventosRepository>();
            services.AddTransient<IDetallePerfilRepository, DetallePerfilRepository>();
            services.AddTransient<IMensajesRepository, MensajesRepository>();
            services.AddTransient<IPerfilesUsuarioRepository, PerfilesUsuarioRepository>();
            services.AddTransient<ISuscripcionEventosRepository, SuscripcionEventosRepository>();
            services.AddTransient<IUsuariosRepository, UsuariosRepository>();
            services.AddTransient<IUsuariosPerfilesUsuarioRepository, UsuariosPerfilesUsuarioRepository>();
            services.AddTransient<IWorkflowItemRepository, WorkflowItemRepository>();


            #endregion Repository

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Balance Global API V1");
            });

            app.UseMiddleware<BasicAuthMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

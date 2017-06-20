using CSPOS.Domain.DTO;
using CSPOS.Domain.Interfaces;
using CSPOS.Domain.Models;
using Nelibur.ObjectMapper;

namespace InventoryManagement.Utils
{
    public class TinyObjectMapperHelper : IObjectMapperService
    {
        // Singleton pattern implementation
        // https://msdn.microsoft.com/en-us/library/ee817670.aspx

        private TinyObjectMapperHelper()
        {
            ConfigureMapper();
        }

        public static readonly TinyObjectMapperHelper Instance = new TinyObjectMapperHelper();

        private void ConfigureMapper()
        {
            // Domain Model <-> Dto
            TinyMapper.Bind<DtoCatalogItem, DmNewCatalogItem>(config =>
            {
                config.Ignore(x => x.ConditionID);
            });
            TinyMapper.Bind<DmNewCatalogItem, DtoCatalogItem>(config =>
            {
                config.Ignore(x => x.Summary);
            });

            TinyMapper.Bind<DtoCatalogItem, DmUsedCatalogItem>(config =>
            {
                config.Ignore(x => x.Warranty);
            });
            TinyMapper.Bind<DmUsedCatalogItem, DtoCatalogItem>(config =>
            {
                config.Ignore(x => x.Summary);
            });

            TinyMapper.Bind<DmOrderItem, DtoOrderItem>();

            TinyMapper.Bind<DmOrder, DtoOrder>(config =>
            {
                config.Ignore(x => x.navOrderItems);
                //config.Bind(source => source.navOrderItems, target => target.navOrderItems);
            });
            TinyMapper.Bind<DtoOrder, DmOrder>(config =>
            {
                config.Ignore(x => x.navOrderItems);
                //config.Bind(source => source.navOrderItems, target => target.navOrderItems);
            });

            // References
            TinyMapper.Bind<DtoCatalogCategory, DmCatalogCategory>();

            TinyMapper.Bind<DtoCatalogCondition, DmCatalogCondition>();

            TinyMapper.Bind<DtoCatalogMaker, DmCatalogMaker>();

            TinyMapper.Bind<DtoCatalogType, DmCatalogType>();

            TinyMapper.Bind<DtoOrderStatus, DmOrderStatus>();
        }

        public TTarget Map<TTarget>(object source)
        {
            return TinyMapper.Map<TTarget>(source);
        }

        public TTarget Map<TSource, TTarget>(TSource source, TTarget target = default(TTarget))
        {
            return TinyMapper.Map<TSource, TTarget>(source, target);
        }
    }
}

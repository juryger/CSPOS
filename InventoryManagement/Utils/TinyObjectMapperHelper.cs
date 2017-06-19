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

            TinyMapper.Bind<DtoCatalogItem, DmUsedCatalogItem>(config =>
            {
                config.Ignore(x => x.Warranty);
            });

            TinyMapper.Bind<DmOrderItem, DtoOrderItem>(config =>
            {
                //config.Ignore(x => x.order);
                //config.Bind(source => source.catalog, target => target.navCatalogItem);
            });

            TinyMapper.Bind<DmOrder, DtoOrder>(config =>
            {
                //config.Ignore(x => x.RowVersion);
                //config.Bind(source => source.orderitems, target => target.navOrderItems);
            });
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

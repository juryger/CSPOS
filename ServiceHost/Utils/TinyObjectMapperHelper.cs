using CSPOS.DAL;
using CSPOS.Domain.DTO;
using CSPOS.Domain.Interfaces;
using Nelibur.ObjectMapper;

namespace ServiceHost.Utils
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
            // Db <-> Dto            
            TinyMapper.Bind<catalog, DtoCatalogItem>(config =>
            {
                config.Ignore(x => x.orderitems);
                config.Ignore(x => x.RowVersion);
            });

            TinyMapper.Bind<orderitem, DtoOrderItem>(config =>
            {
                config.Ignore(x => x.order);
                config.Bind(source => source.catalog, target => target.navCatalogItem);
            });
            TinyMapper.Bind<DtoOrderItem, orderitem>(config =>
            {
                config.Bind(source => source.navCatalogItem, target => target.catalog);
            });

            TinyMapper.Bind<order, DtoOrder>(config =>
            {
                config.Ignore(x => x.RowVersion);
                config.Bind(source => source.orderitems, target => target.navOrderItems);
            });
            TinyMapper.Bind<DtoOrder, order>(config =>
            {
                config.Bind(source => source.navOrderItems, target => target.orderitems);
            });

            // References
            TinyMapper.Bind<catalogcategory, DtoCatalogCategory>(config =>
            {
                config.Ignore(x => x.catalogs);
            });

            TinyMapper.Bind<catalogcondition, DtoCatalogCondition>(config =>
            {
                config.Ignore(x => x.catalogs);
            });

            TinyMapper.Bind<catalogmaker, DtoCatalogMaker>(config =>
            {
                config.Ignore(x => x.catalogs);
            });

            TinyMapper.Bind<catalogtype, DtoCatalogType>(config =>
            {
                config.Ignore(x => x.catalogs);
            });

            TinyMapper.Bind<orderstatus, DtoOrderStatus>(config =>
            {
                config.Ignore(x => x.orders);
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

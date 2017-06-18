namespace CSPOS.Domain.Interfaces
{
    /// <summary>
    /// Represent object-relational mapper between DataLayer, DTO, and Models.
    /// </summary>
    public interface IObjectMapperService
    {
        TTarget Map<TTarget>(object source);
        TTarget Map<TSource, TTarget>(TSource source, TTarget target = default(TTarget));
    }
}

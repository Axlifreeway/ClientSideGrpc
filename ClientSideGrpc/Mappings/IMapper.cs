namespace ClientSideGrpc.Mappings
{
    /// <summary>
    /// Интерфейс мэппера.
    /// </summary>
    /// <typeparam name="TEntity">Сущность.</typeparam>
    /// <typeparam name="TModel">Модель.</typeparam>
    public interface IMapper<TEntity, TModel>
    {
        /// <summary>
        /// Перевести модель в сущность.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <returns>Сущность.</returns>
        TEntity Map(TModel model);

        /// <summary>
        /// Перевести сущность в модель.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Модель gRPC=.</returns>
        TModel Map(TEntity entity);
    }
}
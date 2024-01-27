namespace Model.Mappers
{
    public interface IMapper<T, K>
    {
        T Mapping(K value);
        K Mapping(T value);
    }
}

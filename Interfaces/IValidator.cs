namespace IUIS.Interfaces
{
    public interface IValidator<T>
    {
        bool Validate(T entity, out string errorMessage);
    }
}
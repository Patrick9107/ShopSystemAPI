namespace ShopSystemAPI.Models;

public abstract class BaseEntity<T> where T : struct
{
    public T Id { get; private set; }
    
    public Guid Guid { get; init; } = Guid.NewGuid();

    protected bool Equals(BaseEntity<T> other)
    {
        return Guid.Equals(other.Guid);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((BaseEntity<T>)obj);
    }

    public override int GetHashCode()
    {
        return Guid.GetHashCode();
    }

    protected BaseEntity() {}
}
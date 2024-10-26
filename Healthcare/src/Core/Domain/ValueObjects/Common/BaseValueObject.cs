namespace Healthcare.Domain.ValueObjects.Common;

public abstract class BaseValueObject
{
    public static bool EqualOperator(BaseValueObject left, BaseValueObject right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return left.Equals(right);
    }

    public static bool operator ==(BaseValueObject left, BaseValueObject right)
    {
        return left is null ? right is null : left.Equals(right);
    }

    public static bool operator !=(BaseValueObject left, BaseValueObject right)
    {
        return !(left == right);
    }

    public override bool Equals(object obj)
    {
        if (obj is not BaseValueObject other || other.GetType() != GetType())
            return false;

        var thisValues = GetEqualityComponents().GetEnumerator();
        var otherValues = other.GetEqualityComponents().GetEnumerator();

        while (thisValues.MoveNext() && otherValues.MoveNext())
        {
            if (!Equals(thisValues.Current, otherValues.Current))
            {
                return false;
            }
        }

        return !thisValues.MoveNext() && !otherValues.MoveNext();
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;

            foreach (var obj in GetEqualityComponents())
            {
                hash = hash * 23 + (obj?.GetHashCode() ?? 0);
            }

            return hash;
        }
    }

    protected abstract IEnumerable<object> GetEqualityComponents();
}
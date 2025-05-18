using System.Collections;

namespace MinecraftData;

public abstract class CollectionBase<T, TId> : IReadOnlyCollection<T> where T : INamedItem<TId> where TId : notnull
{
    private readonly Dictionary<TId, T> _byId = [];
    private readonly Dictionary<string, T> _byName = new(StringComparer.OrdinalIgnoreCase);

    public CollectionBase(T[] items)
    {
        Items = items;
        foreach (var item in items)
        {
            _byId[item.Id] = item;
            _byName[item.Name] = item;
        }
    }
    protected T[] Items { get; }

    public T this[TId id] => _byId.TryGetValue(id, out var item) ? item : throw new KeyNotFoundException($"{nameof(T)} with ID {id} not found.");
    public T this[string name] => _byName.TryGetValue(name, out var item) ? item : throw new KeyNotFoundException($"{nameof(T)} with name '{name}' not found.");

    public int Count => Items.Length;

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Items).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();
}

public abstract class CollectionBase<T> : CollectionBase<T, int> where T : INamedItem<int>
{
    public CollectionBase(T[] items) : base(items)
    {
    }
}

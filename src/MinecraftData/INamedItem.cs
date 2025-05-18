namespace MinecraftData;

public interface INamedItem<T>
{
    public T Id { get; }
    public string Name { get; }
}
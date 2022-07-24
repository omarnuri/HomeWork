
public class ServiceLocator
{
    private static ServiceLocator? _instance;
    public static ServiceLocator Instance => _instance ??= new ServiceLocator();
    public Dictionary<Type, Func<Object>> _dependencies;
    public ServiceLocator()
    {
        _dependencies = new();
    }
    public T? Get<T>() where T : class
    {
        if (!_dependencies.TryGetValue(typeof(T), out var factory))
        {
            throw new KeyNotFoundException();
        }
        return (T?)factory.Invoke();
    }
    public ServiceLocator Add<T>(Func<T> factory) where T : class
    {
        ArgumentNullException.ThrowIfNull(nameof(factory));
        if (_dependencies.ContainsKey(typeof(T)))
        {
            throw new InvalidOperationException();

        }
        _dependencies.Add(typeof(T), factory);
        return this;
    }
}

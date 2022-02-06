namespace CSharpLibrary.RemoveBaseItem;

public class BaseItemInfo { }

public class ItemA : IGetInfo<ItemInfoA> { }
public class ItemInfoA : BaseItemInfo { }

public interface IGetInfo<out T> where T : BaseItemInfo { }
public interface IProvider<T, in U>
    where T : IGetInfo<U>
    where U : BaseItemInfo { }

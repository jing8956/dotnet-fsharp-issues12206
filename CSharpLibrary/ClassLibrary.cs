namespace CSharpLibrary;

public class BaseItem : IGetInfo<BaseItemInfo> { }
public class BaseItemInfo { }

public class ItemA : BaseItem, IGetInfo<ItemInfoA> { }
public class ItemInfoA : BaseItemInfo { }

public interface IGetInfo<out T> where T : BaseItemInfo { }
public interface IProvider<T, in U>
    where T : BaseItem, IGetInfo<U>
    where U : BaseItemInfo { }

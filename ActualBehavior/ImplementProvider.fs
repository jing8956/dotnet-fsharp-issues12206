namespace ActualBehavior

open CSharpLibrary

// But when using F#, a compilation error occurred:
type ImplementProvider() = interface IProvider<ItemA, ItemInfoA>

// Related information
// 1. Try define the IProvider<T, U> by F#.
type IProvider<'T, 'U
    when 'T:> BaseItem and 'T :> IGetInfo<'U>
    and 'U:> BaseItemInfo> = interface end

// 2. But compilation succeeded after removing BaseItem.
type ImplementProvider2() =
    interface RemoveBaseItem.IProvider<
        RemoveBaseItem.ItemA, RemoveBaseItem.ItemInfoA>

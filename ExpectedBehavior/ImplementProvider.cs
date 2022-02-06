using CSharpLibrary;

namespace ExpectedBehavior;

// If Implementing IProvider<ItemA, ItemInfoA> by C#, the following code will compile succeed.
public class ImplementProvider : IProvider<ItemA, ItemInfoA> { }


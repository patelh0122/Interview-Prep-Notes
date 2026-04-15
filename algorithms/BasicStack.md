# Basic Stack Pattern (LIFO)

👉 **Use when:**
- Matching brackets
- Undo operations
- Reverse processing

## Template Code (C#)

```csharp
Stack<int> stack = new Stack<int>();

foreach (var x in nums)
{
    stack.Push(x);
}

while (stack.Count > 0)
{
    stack.Pop();
}
```

# Monotonic Stack (MOST IMPORTANT)

👉 **Use when:**
- Next greater element
- Next smaller element
- Daily temperatures

## Template Code (C#)

```csharp
Stack<int> stack = new Stack<int>();

for (int i = 0; i < nums.Length; i++)
{
    while (stack.Count > 0 && nums[i] > nums[stack.Peek()])
    {
        int index = stack.Pop();
        // resolve answer for index
    }
    stack.Push(i);
}
```
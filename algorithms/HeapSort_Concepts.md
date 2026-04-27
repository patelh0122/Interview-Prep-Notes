# Heap Sort: Key Concepts and Steps

## Step 1: Build Max Heap
```csharp
for (int i = n/2 - 1; i >= 0; i--)
    Heapify(arr, n, i);
```
**Why start at n/2-1?**
- `n/2` and beyond are leaves (already satisfy heap property).
- Start from the last non-leaf node, move bottom-up to root.

## Step 2: Extract Elements
```csharp
for (int i = n - 1; i > 0; i--)
{
    Swap root with arr[i]
    Heapify(arr, i, 0)
}
```
**Why n - 1?**
- `n-1` is the last index.
- We repeatedly place the largest remaining element at the end.

## Procedure Outline
1. Build max heap
2. Swap root (max) with the end node
3. Reduce the heap size
4. Heapify root
5. **Repeat** until array is sorted

---

## Important Concepts
- **Heap** is a complete binary tree.
- Stored in an array.
- Root always satisfies:
    - **Max Heap**: Largest element at root
    - **Min Heap**: Smallest element at root

## Efficiency
- **Time Complexity:** O(n log n)
- **Space Complexity:** O(1) (in-place sort)

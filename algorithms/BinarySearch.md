# Binary Search

## When to Use Binary Search

I use binary search when:
- The data is sorted or when the problem has a monotonic property
- I need to eliminate half of the search space each iteration
- Time complexity of O(log n) is required

## Key Applications

- Find exact element in sorted array
- Find first or last occurrence of an element
- Apply on the answer space (binary search on the result)
- Search in rotated sorted arrays
- Find peak elements or boundaries

## Complexity Analysis

- **Time Complexity:** O(log n)
- **Space Complexity:** O(1)

## Implementation Notes

The implementation can be modified to:
1. **Find first occurrence** - When target is found, continue searching left (`right = mid - 1`)
2. **Find last occurrence** - When target is found, continue searching right (`left = mid + 1`)
3. **Binary search on answer** - Apply binary search on the result space rather than the input array

## Example Use Cases

- Search in sorted array
- Find boundary conditions (first/last position)
- Minimize/maximize with constraints
- Search in rotated or partially sorted arrays
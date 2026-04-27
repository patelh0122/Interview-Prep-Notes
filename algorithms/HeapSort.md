# Heap Sort Notes

## Index Relationships
- **Left child:**    `left  = 2*i + 1`
- **Right child:**   `right = 2*i + 2`
- **Parent:**        `parent = (i - 1) / 2`

## Heapify (Sift Down) — The Heart
Heapify ensures the subtree rooted at `i` satisfies the max-heap property.

👉 **Fix one node assuming children are heaps:**

```csharp
void Heapify(int[] arr, int n, int i) {
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    if (left < n && arr[left] > arr[largest])
        largest = left;

    if (right < n && arr[right] > arr[largest])
        largest = right;

    if (largest != i) {
        // swap arr[i] and arr[largest]
        int temp = arr[i];
        arr[i] = arr[largest];
        arr[largest] = temp;
        Heapify(arr, n, largest); // recurse down
    }
}
```

- Heapify is applied as part of heap sort to ensure the heap structure.
- Common for both building a max-heap and sorting with heaps.

## Usage Examples
- Sorting an array in-place with O(n log n) time complexity
- Used in priority queues implementation
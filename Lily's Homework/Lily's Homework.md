Algorithm (Lily’s Homework–Minimum Swaps to Sort):

Prepare two sorted versions of the input array (ascending and descending).

For each sort order:

Count the minimum number of swaps required to turn the input into the sorted form.

To count swaps, use a mapping from value to current index and make all needed swaps, updating the mapping as you go.

Return the lesser swap count for ascending and descending sorts.

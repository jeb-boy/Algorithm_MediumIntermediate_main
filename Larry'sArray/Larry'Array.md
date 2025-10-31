Algorithm (Larry’s Array):

Count inversions using Fenwick Tree:

Create a Fenwick Tree for frequency tracking.

Iterate through the array elements:

For each element, find how many smaller elements have appeared before using fw.Sum(A[i]).

Calculate inversions by adding (i - leq) where leq is count of smaller or equal elements.

Update Fenwick Tree with current element fw.Add(A[i], 1).

Check inversion parity:

If total inversions count is even → return "YES".
If odd → return "NO".

Algorithm for Equal (Min Operations to Equalize Array

1. Find the smallest element in the array and store it as minVal.
2. Try base values: minVal, minVal - 1, minVal - 2, minVal - 3, and minVal - 4.
3. For each baseVal:

    Set operations = 0.
    For each element val in the array:

     1. Compute diff = val - baseVal.
     2. Add diff // 5 to operations, then update diff %= 5.
     3. Add diff // 2 to operations, then update diff %= 2.
     4. Add remaining diff to operations.
    Update minOperations = min(minOperations, operations).
4. Return minOperations as the minimum number of operations needed to make all array elements equal.

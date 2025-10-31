Algorithm (Almost Sorted):

Compare array with its sorted version to find differences:

Iterate through the array and record indices where elements differ from the sorted array.

If there are no differences, print "yes" (array is already sorted).

If there are exactly two differences:
Swap those two elements and print:
"yes"
"swap left right"

If there are more than two differences:
Find the first and last differing positions (left, right).
Reverse the subarray from left to right.

If the result matches the sorted array after reversal:
Print "yes"
"reverse left right"
Else, print "no".

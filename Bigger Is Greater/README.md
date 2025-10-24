Find rightmost pair where the preceding character (chars[i]) is less than its neighbor.

If not found (i < 0), return "no answer", as the input is the largest permutation.

Find the smallest character on the right of i that is bigger than chars[i] (j).

Swap chars[i] and chars[j].

Reverse the substring after index i.

Return the new string.

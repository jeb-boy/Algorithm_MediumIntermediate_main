Algorithm (Absolute Permutation):

If k is zero, return the sequence 1...n.

If n is not divisible by 2 * k, return -1, as no permutation is possible.

Otherwise:

For every group of k, alternate between adding and subtracting k to each index.

Return the resulting permutation.

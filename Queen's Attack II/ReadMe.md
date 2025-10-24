Algorithm

Set up all 8 directions for queen moves (up, down, left, right, all diagonals).

Store obstacles in a set for fast look-up.

For each direction:

Start from queen’s position.

Move step-by-step in that direction.

If out of bounds or hitting obstacle, stop.

Else, increment count for each valid square.

Return total attackable squares.

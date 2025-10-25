Algorithm (3D Shape Surface Area on Grid):
For every cell in the grid:
If height is greater than zero, add top and bottom surface.
For each side (north, south, west, east), add exposed vertical surface:
Compute difference between cell’s height and adjacent cell’s height (or zero if edge).
Add positive differences to area.
Return the total surface area.

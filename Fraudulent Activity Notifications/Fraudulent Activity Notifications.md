Algorithm (Sliding Window Median Notification):

Initialize counter array count of size 201 (for possible expenditures 0-200).

Fill counts for first d days.

For each subsequent day:

Compute the median of the trailing d days using GetMedian(count, d).

If today’s expenditure is at least twice the median, increment notifications.

Slide the window:

Remove oldest day (i-d) from count.

Add current day (i) to count.

Return total notifications.

Median calculation:

If d is odd: median is value at the middle index in sorted window.

If d is even: median is average of the two middle values.

Consider the triangular grid below. Note each node is numbered sequentially from top to bottom as the figure grows in height. Now consider a list of points on the grid identified by node number. These lists can form various figures:
	1. Traingle (example 1,2,3 or 1,4,6)
	2. Parallelogram (example 2,3,5,6 or 3,6,8,10)
	3. Hexagon (example 2,3,6,4,8,9)

Write a function that receives an unsorted list of up to 6 coordinates and reports whether the list represents a triangle, parallelogram, hexagon, or illegal figure.

Rules:
	1. Valid figure edges will lay along the boundaries shown in the below diagram.
	2. The largest node number will be 500500.


   1
  2 3
 4 5 6
7 8 9 10
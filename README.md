# Convex Hull
Constructing a convex hull of a set of points by the Graham traversal method

There are two modes available in the program
- Automatic construction of a convex hull
- Step-by-step construction of a convex hull

## Description of the Graham scan algorithm
Its essence lies in finding the starting point, which is exactly the vertex of the convex hull. Beyond this relative point, the remaining points are sorted in ascending order of the Arctic circle. The sorted points are placed in a doubly linked list, and Graham is traversed through it – at each step, the relative location of the three current points is checked. The check is to determine whether these points form a left turn, and if so, the middle one is removed and a left shift occurs. This procedure is repeated until the algorithm returns to the starting point

## Example of how the program works
![image](https://user-images.githubusercontent.com/109802024/217315411-2ba22965-49a4-4096-aaa8-890de7a7c88b.png)

## Example of how the program works on the 6th step in step-by-step mode
![image](https://user-images.githubusercontent.com/109802024/217315846-cf34b038-a619-4acb-83b0-dc135e36d86d.png)

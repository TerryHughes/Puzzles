You are given a linked list that is either NULL-terminated (acyclic), as shown in FIgure 4-5, or ends in a cycle (cyclic), as shown in Figure 4-6.

Figure 4-5:
3 -> 2 -> 4 -> 6 -> 2 ->

Figure 4-6:
3 -> 2 -> 4 -> 6 -> 2 -|
          ^            |
          |------------|

Write a function that takes a pointer to the head of a list and determines whether the list is cyclic or acyclic. Your function should return false if the list is acyclic and true if it is cyclic. You may not modify the list in any way.
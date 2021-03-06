## Tree Intersection

## Challenge

For this particular challenge we are to create a method that will find if there is a value that two binary trees have on common.
When this common value is discovered, the method will return the common value.

## Approach & Efficiency
For this particular challenge we would take all of the values in the trees and place them in a list. After placing the values in a list,
we then would put them in a hashset. When there is a duplicate/ common number discovered the methothd will return that number.

## Big O

Time O(n) due to the number of operations necessary to complete this problem. While not terrible time consuming, it is also not very fast either.
Space O(w) as the space necessary to solve the problem is really dependent on the width of the tree. In addition to that 
a list will need to be created as well. Additionaly space will be required to solve this problem.


## Solution

For this problem, the two binary trees would be broken down in to a list. This lsit of values from the binary tree will be placed in a hash set. 
As these values are being placed in a hash set, a duplcate will be discovered and when it is discovered that value will be returned as the result. 
The result is the common value that the two binary trees contain.

![Tree intersection whiteboard](https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/tree_intersection.jpg) 



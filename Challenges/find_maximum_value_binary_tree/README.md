## Find Maximum Value Binary Tree


## Challenge

In this challenge we will be traversing a binary tree to find the maximum value from the nodes in the binary tree.

## Approach & Efficiency
For this challenge we will want to traverse the binary tree find the value of each node. We would start at the root of the tree. 
The value of the root would be our first max since it's the first value we have encountered. Then we will proceded in a left to right fashion at the child level.
We will then evaluate the value of the child node against our current max. If the value of the left child node is more than our current max, that value will be our new max.
If the value of the left child node is less then the current max then we will go to the right node child and make the same evaluation. 
This operation would continue until there no nodes left to evaluate.

## Big O
Time -> O(n)
Space - O(w)     ("W" is width of the binary tree)

## Unit Test & Documentation

##Solution

For this solution we would set out Max to the value of the first node in the tree, which is the root. 
We would create an IF statement that would evaluate the node in question and compare if it is greater than the current max. If nodes value is greater then the current max then the max will be set to that nodes value.
If the value of that node is less than the the current max then the method will continue to the next node and do the dame evaluation. This operation will continue until there no nodes to evalute or when node equals null.




![White board](https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/find_maximum_value_binary_tree.jpg)
                    
                 





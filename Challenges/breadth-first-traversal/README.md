## Breadth First Traversal 


## Challenge

In this traversal we will be traversing a binary try. As the binary tree is traveresd through the values of the nodes in the tree are to be printed in the console.

## Approach & Efficiency
For this challenge, we would have to traverse through the binary tree starting at the root and going left to right checking each node's value. 
Once that value is found it will be printed to the console. The operation will be repeated at the next node starting at the left. Once the value is found, it too will be printed.
Then the right node's value will be accessed and then printed. This process will continue until there are no other nodes left in the binary tree.


## Big O
Time -> O(n)
Space - O(w)     ("W" is width of the binary tree)

## Unit Test & Documentation

##Solution

The solution would be to start with a node and tree class. Once those classes are made, a method would need to be made in order to traverse the tree and print the values of the nodes.
The method would pop the first node off and enqueue into a queue. From there, the node value will be extrated and printed. This would be accomplished via a while loop. 
While node does not equal null the operation will continue to pop and enqueue to a queue and print/return the values until node equals null.


![White board](https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/breadth-first-traversal.jpg)
                    
                 





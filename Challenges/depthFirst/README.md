## Depth First

## Challenge
For this challenge we are to conduct a preorder traversal of a graph. We will have to create a function that accepts an adjaency list as a graph,
and conduct a depth first traversal. From this we will return a collection of nodes in the order they were discovered.

## Approach & Efficiiency
For this challenge we would need to create a new graph to begin. We would also create a list to contain the discovered nodes in order.
We then need to create a method to traverse the graph in a depth first fashion. When the nodes are discovered they will be placed in a list.

##Big O

Time -> O(n) goes through every node and every edge in the graph.
Space -> O(n) requires additional space for the list

##Solution
The solution would be to utilize the method to traverse through the graph. As the method discovers a node it it has not encountered before it will be
placed in the list. This method will continue until there are no undiscovered nodes. When node equals null, the method will stop
and return a list of nodes as they were discovered during the depth first traversal.

![Depth First Whiteboard]( https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/depthfirst.jpg)


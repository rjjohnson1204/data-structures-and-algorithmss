## Get Edges

## Challenge
For this challenge we are to find out if there are any direct flights from from our place of
origin and also find the cost of each flight. If there are are no direct flights, then it is not possible to fly there.

## Approach & Efficiiency
For this challenge we will will start with a particular node and find the neighbors of that node. The neighbors will be the direct flights. 
Once the neighbors are found, the weights/price of each edge will be found. If there are additional nodes found that are not neighbors then they are not
neighbors which means they are not direct flights.
##Big O

Time -> O(1)
Space -> O(V)

##Solution
The solution would be to find all the nodes in the graph and place them in an array. When the nodes are discovered, we will find what the central nodes neighbors are.
When the neighbors are found the weights of the edges will be found as well. The weights being flights and the neighbor nodes being the direct flights and all other nodes not being
direct flights. As a result, the neighbors hold true for direct flights while the others nodes would be false. 
![Get Edges Whiteboard]( https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/get-edges.jpg )


## Left Join

## Challenge

Create a method that LEFT JOINs two hashmaps into a single data structure. In each hashmap there will be keys that are they same. These keys will be used to save their values.
Once these key value relationships are found they will be placed in another hashtable combining the two hashtables.


## Approach & Efficiiency
Create a method that takes in two hashmaps and evaluates if the two hashmaps contain the same keys. If the hashmaps contain the same keys,
the values will be placed together (creating a collision) in the new hashmap.

##Big O

Time O(1) due to knowing exactly where each key is and finding its value easily.
Space O(n) do to the creation of an additional hashmap to place the keys and values

##Solution

Create a method that LEFT JOINs two hashmaps into a single data structure.

![Left Join Whiteboard]( https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/Left-Join.jpg  )


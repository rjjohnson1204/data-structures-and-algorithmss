## Repeated Word

## Challenge

For this particular challenge we are to create a method that accepts 
a string as a parameter. This method will find the first duplicate word in the
string and return that word when discovered. The other part of the challenge will be to find
a way to convert a string into in array of words so each word can be assigned a key.


## Approach & Efficiiency
Initially a method would need to be created to take in the arguement of s string.
That string would need to be converted to an array. Once converted, a formula will be utilized 
to take the ASCII numberd of each word and add them together and divide by a prime number. 
The result of this number will be the key of the word. This word will then be placed in the hash table.


##Big O

Time O(1) as it the operation for each word will not take long
Space O(n) as the string will be need to be converted from a string into an array which would 
require additional space to be utilized. 


##Solution

The string will be converted to an array. Each word in the array will be assigned an key based
the math formula. Then the words will be placed in the hash table. As the words are being placed in the hash table
when a duplicate word/key is discovered then the method will return the word. 

![Repeated Word Whiteboard](https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/RepeatWord-Whiteboard.jpg)


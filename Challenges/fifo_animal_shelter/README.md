## First In First Out Shelter


## Unit Test & Documentation


## Challenge

* Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
* Implement the following methods: enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
  dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.


## Approach & Efficiiency

Check to see of the request equals the peek of the queue. If it does not then the result will be null.

Big O = Time -> O(n)  Space -> O(1)

##Solution

* Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
*Implement the following methods: enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
  dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.


  Stretch goal - if request does not match peek then dequeue peek to a temporary queue and check new peek to seeif it matches request. If new peek is does
  not match the request dequeue again to temp queue and check new peek against the request...repeat until request is found or when queue equals null.


![animal shelter whiteboard](https://github.com/rjjohnson1204/data-structures-and-algorithmss/blob/master/Assets/Animal_shelter_whiteboard.jpg)


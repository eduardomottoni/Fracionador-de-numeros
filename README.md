# Converts the given number in a list of numbers that, in sum, give this number<br><br>

Ex: 5 will give all number arrays that, when sum, give you 5 [(4,1), (3,2), (3,1,1), (2,2,1), (2,1,1,1), (1,1,1,1,1)]

![image](https://user-images.githubusercontent.com/56644658/137372583-f61607ea-2095-44ba-99bd-152b15493138.png)
<br><br>
This is a NP that grows exponentialy. Returns until 30, after that, it is to slow.


## The logic is:
1 - Half the number (h)<br>
2 - If the number is even, the first array is [h , h]; else, it is [h , h-1]<br>
3 - After that, a loop make goes trying to sum the bigest combinations, until it lefts [1 , 1, ... , 1^h]<br>


### Possible improvment:
Register the list<array> for numbers, i.e. the list for 3 is equal the list of 2 + 1

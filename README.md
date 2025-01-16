# C# BrioCodinTest

This repository contains a C# console application that demonstrates solutions to three problems:

1. **Palindrome Check**
2. **Reverse an Array by K Distance**
3. **Implement a Queue Using Two Stacks**

---

## Features

### 1. Palindrome Check
This feature checks whether a given string is a palindrome using recursion.

#### How it works:
- The user inputs a string.
- The program checks if the string reads the same forwards and backwards.

#### Example:
Input: `madam`  
Output: `The input string is a palindrome`

### 2. Reverse an Array by K Distance
This feature reverses an array in chunks of size `k`.

#### How it works:
- The user specifies the size of the array and its elements.
- The user provides a value for `k`.
- The program reverses every `k` elements in the array.

#### Example:
Input Array: `[1, 2, 3, 4, 5]`  
Value of `k`: `3`  
Output: `[3, 2, 1, 5, 4]`

### 3. Queue Using Two Stacks
This feature demonstrates a queue implementation using two stacks.

#### How it works:
- The `Enqueue` method pushes elements onto the first stack.
- The `Dequeue` method transfers elements to the second stack (if empty) and pops the front element.

#### Example:
```
Enqueue(1), Enqueue(2), Enqueue(3)
Dequeue() -> 1
Dequeue() -> 2
Enqueue(4)
Dequeue() -> 3
Dequeue() -> 4
```

---

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/SRINADHNAIDU/BrioCodingTest.git
   ```
2. Open the project in an IDE such as Visual Studio or Visual Studio Code.
3. Build and run the project.
4. Follow the prompts in the console to test the features.

---

## Code Structure

### Main Program
- `Palindrome`: Handles user input and invokes the recursive `CheckPalindrome` method.
- `ReverseAnArrayByKDistance`: Reverses an array by `k` distance using the `ReverseArray` method.
- `QueueUsingTwoStacks`: Demonstrates queue operations using the `StackQueue` class.

### Helper Classes
- `StackQueue`: Implements a queue using two stacks with `Enqueue` and `Dequeue` methods.

---

## Sample Input/Output

### Palindrome Check
```
Enter a string to check if it is a palindrome: madam
The input string is a palindrome
```

### Reverse an Array by K Distance
```
Enter the number of elements in the array: 5
Enter the elements of the array: 
1
2
3
4
5
Enter the value of k: 3
The reversed array is: 
3
2
1
5
4
```

### Queue Using Two Stacks
```
Implementing a queue using two stacks
1
2
3
Queue is empty
4
Queue is empty
```

---



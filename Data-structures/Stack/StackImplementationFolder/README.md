# StackImplementation

## Overview

`StackImplementation` is a simple project that demonstrates the implementation of a stack data structure in C#. The project includes classes and interfaces to create and manipulate a stack, using a linked list for internal storage.

## Project Structure

- **LStack.cs**: This class represents a linked list-based stack implementation.
- **Node.cs**: This class represents a node in the linked list used by the stack.
- **Stack<T>.cs**: This interface defines the stack operations.

## Classes and Interfaces

### LStack

`LStack` is a class that implements the stack using a linked list. It includes methods to push, pop, and peek at elements in the stack, as well as checking if the stack is empty.

#### Methods

- **Push(T item)**: Adds an item to the top of the stack.
- **Pop()**: Removes and returns the item at the top of the stack.
- **Peek()**: Returns the item at the top of the stack without removing it.
- **IsEmpty()**: Checks if the stack is empty.

### Node

`Node` is a class representing a node in the linked list. Each node contains a value and a reference to the next node in the list.

#### Properties

- **Value**: The value stored in the node.
- **Next**: A reference to the next node in the list.

### Stack<T>

`Stack<T>` is an interface that defines the operations for a stack. It is a generic interface that allows for the stack to store elements of any type.

#### Methods

- **Push(T item)**: Adds an item to the stack.
- **Pop()**: Removes and returns the item from the stack.
- **Peek()**: Returns the item from the stack without removing it.
- **IsEmpty()**: Checks if the stack is empty.

## Usage

To use the stack implementation in your project, you can create an instance of `LStack` and call the methods defined in the `Stack<T>` interface.

```csharp
using System;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new LStack<int>();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop()); // Output: 3
            Console.WriteLine(stack.Peek()); // Output: 2
            Console.WriteLine(stack.IsEmpty()); // Output: False
        }
    }
}

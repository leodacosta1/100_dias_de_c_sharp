/*
learn.microsoft.com
Create and run simple C# console applications (Get started with C#, Part 2) - Call methods from the .NET Class Library using C# 

What is the .NET Class Library?

When you need to find a book, a public library is a good place to look.
After all, libraries contain thousands and thousands of books,
and they're organized into sections that help you to find what you're looking for.
When you need to implement a programming task, the .NET Class Library is a good place to look,
because it's an organized collection of programming resources.

The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods.
For example, the .NET Class Library includes the Console class for developers working on console applications.
The Console class includes methods for input and output operations such as Write(), WriteLine(), Read(), ReadLine(), and many others.

You can think of a class as a container for methods, kind of like the sections of the public library.
Developers typically keep related methods together in a single class.
As you saw in the previous example, any methods that can send or receive information from a console window
are collected into the System.Console class in the .NET Class Library.

Even data types are part of the .NET Class Library

C# data types (such as string and int) are actually made available through classes in the .NET Class Library.
The string class has lots of these helpful methods.
For example, the string class has methods for converting text to uppercase and lowercase (ToUpper and ToLower).


*/

// Calling diferent kinds of methods in the .Net Class Library:
// System.Random && System.Console classes

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

/*
On the third code line, you include a reference to the Console class and call the Console.WriteLine() method directly.
However, you use a different technique for calling the Random.Next() method.
The reason why you're using two different techniques is because some methods are "stateful" and others are "stateless".

In software development projects, the term state is used to describe
the condition of the execution environment at a specific moment in time.
As your code executes line by line, values are stored in variables.
At any moment during execution, the current state of the application
is the collection of all values stored in memory.

(...) stateless methods are implemented so that they can work without referencing
or changing any values already stored in memory. Stateless methods are also known
as static methods.

Stateful (instance) methods keep track of their state in fields, which are variables defined on the class.
Each new instance of the class gets its own copy of those fields in which to store state.

A single class can support both stateful and stateless methods.
However, when you need to call stateful methods, you must first create an instance of the class so that
the method can access state.

An instance of a class is called an object.
To create a new instance of a class, you use the new operator.
Consider the following line of code that creates a new instance of the Random class to create a new object called dice:

|| Random dice = new Random();

How can you determine whether you need to create an instance of a class before calling its methods?

As an alternative to searching through product documentation,
you can attempt to access the method directly from the class itself.
If it works, you know that it's a stateless method.
The worst that can happen is that you'll get a compilation error.


Recap:

.To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member
 access operator to access a method defined on the class, and the () symbols are the method invocation operators.
.When calling a stateless method, you don't need to create a new instance of its class first.
.When calling a stateful method, you need to create an instance of the class, and access the method on the object.
.Use the new operator to create a new instance of a class.
.An instance of a class is called an object.
*/
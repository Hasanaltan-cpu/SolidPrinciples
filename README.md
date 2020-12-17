# SolidPrinciples

## 1.Single Responsibility Principle

## 2.Open/Closed Principle


## 3.Liskov's Substituion Pinciple

## 4.Interface Segregation Principle

## 5.Dependency Inversion principle

![Spagetthi Codes](https://miro.medium.com/max/700/1*gpkPRXT8loz0xHrkC-pnMg.png)


Let's explain them;


## 1.Single Repsonsibility Principle: 
In this principle, all classes and all methods should have just a one responsibility.I mean, in this principle major point is 
"Do just one job and be the best".Otherwise our code will be spaghetti codes and the others when try to read our code it can be complex.For obeying this principle properly;
we use two questions before project start?

1.Is this method should be in this class?

2.Is this job belong to this method/class?


For this principle, i gave examples in the project.

## 2.Open/Closed Principle:
This principle suggests that the class should be easily extended but there is no need to change its core implementations."Classes should be unchangeable but on the other hand Classes should be open to improve/develop.

The application or software should be flexible to change. How change management is implemented in a system has a significant impact on the success of that application/ software. The OCP states that the behaviors of the system can be extended without having to modify its existing implementation.


## 3.Livkov's Subtitution Principle:
Definition by Robert C. Martin: Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.

The Liskov substitution principle (LSP) is a definition of a subtyping relation, called (strong) behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy.
LSP states that the child class should be perfectly substitutable for their parent class. If class C is derived from P then C should be substitutable for P.

We can check using LSP that inheritance is applied correctly or not in our code.

LSP is a fundamental principle of SOLID Principles and states that if program or module is using base class then derived class should be able to extend their base class without changing their original implementation.

## 4.Interface Segregation Principle

No client should be forced to implement methods which it does not use, and the contracts should be broken down to thin ones.

The ISP was first used and formulated by Robert C. Martin while consulting for Xerox.
Interface segregation principle is required to solve the design problem of the application. When all the tasks are done by a single class or in other words, one class is used in almost all the application classes then it has become a fat class with overburden. Inheriting such class will results in having sharing methods which are not relevant to derived classes but its there in the base class so that will inherit in the derived class.

Using ISP, we can create separate interfaces for each operation or requirement rather than having a single class to do the same work.

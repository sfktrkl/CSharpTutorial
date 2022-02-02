# What is object-oriented programming?

Object-oriented programming (OOP) is a computer programming model that organizes software design around data, or objects, rather than functions and logic.
An object can be defined as a data field that has unique attributes and behavior.

# Class and Object

Thanks to classes that the programs that we use are divided into parts and the complexity is reduced.
Methods and properties are contained within a class we can use a class many times we can use and reuse them.
In a class, both functions and data are closely linked at the same time.

A class must contain a number of members for the objects to be created in it.
Fields, Methods, Constructors, Properties, Events, deletages etc.

Class defines the operations and properties associated with the state of the objects.
Data and procedures for objects with common properties are collected into a class.

Class combines the fields and methods into a single unit in C sharp classes, support the polymorphism inheritance and also provide the concept of derived classes and base classes.

Some concepts about class, Namespace, Class declaration, Field, Constants, Constructors, Properties, Events, Methods and Desctructor.

## Namespace
Namespace is a keyword that defines a distinctive name or last name for the class, a namespace categorises and organizes a library where the class belongs and avoids collisions with classes that share the same name.

## Class Declaration
Class Declaration is a line of code where the class name and type are defined.

## Fields
Fields are a set of variables declared in a class block.

## Constants
Constants are a set of constants declared in a class block.
So it must be defined with a value because later you cannot change these values.

## Constructors
Constructors are methods or a group of methods that contain code to initialize the class. So constructor's will be executed first.

## Properties
Properties are this set of descriptive data of an object.

## Events
Events are program responses that get fired after a user or application action methods are set of functions of the class.

## Desctructor
Destructor is a method that's called when the class is indeed destroyed.
So in managed code, the garbage collector is in charge of destroying objects.
However, in some cases, developers need to take extra actions when objects are being released, such as freeing handles or deallocating unmanaged objects.
So in dot net, there is no concept of deterministic distructors.
The garbage collector will call the finalize method at a non-deterministic time while reclaiming memory for the application.

# What is encapsulation?
Encapsulation is an object oriented, programming based concept, encapsulation means protect important data inside the class, which we don't want exposed outside of the class.
Encapsulation is a process that binds the data members and member functions into a single unit.
Class is one of the best examples of encapsulation.

## Why do we need encapsulation?
Encapsulation complements abstraction.
Encapsulation hides private or unwanted data from outside the class. Unwanted means other classes and assemblies.

So an abstraction displays only the important features of a class.
With encapsulation, we can make variables, properties and methods private.
So it is not accessible to all, but accessible through the proper channels, only to protect it from the accidental corruption from the other classes.

We make encapsulation with access modifiers formally, there were five types of access modifiers. But with C# version 7.2, there are six access modifiers.
private, public, protected, internal, protected internal, private protected.

### private
With private, the scope of the accessibility is limited only inside the classes or structure in which they are declared.
The private members cannot be accessed outside the class and it is the least permissive access level.

In C# for variables default access, modifier values is private.
If you don't give any access, modifier to a variable.

### public
Public is the most common access specifiers in C#. It can be accessed from anywhere.
That means there is no restriction on accessibility. The scope of the accessibility is inside the class as well as outside.
Can be accessed by any other code in the same assembly or any other assembly that references it.

### protected
Protected is useful when you want your class and all the derived child classes to be able to access a method or variable, but you don't want it to be public.

### internal
The internal access specifier hides its member variables and methods from other classes and objects that resides in other namespace.
The variable or classes that are declared with internal can be accessed by any member within an application.
Internal is the default access specified for a class in C# program.

### protected internal
The protected internal access modifier is a combination of protected and internal. 
As a result we can access the protected internal member only in the same assembly or in a derived class in other projects.

### private protected
The private protected access modifier is a combination of the private and protected keywords.
We can access members inside that containing class or in a class that derives from a containing class, but only in the same project.

If we try to access it from another assembly, we will get an error.

# Static
Static is a keyword that can be used to declare a member of a type that is specific to that type.
So when a member is declared static, it can be accessed with the name of it class directly.
So this means, for example, without static, if we wanted to use a variable in a class, we would have to create an object first.
But if we first defined this variable as static, then we can use it with out creating an object.

Static modifier can be used with a variable, method, constructor or class.

## Static variable
When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level.
Static variables are accessed with the name of the class, they do not require any object for access.

## Static method
Static methods are accessed with the name of the class.
A static method can access static and non-static fields, static fields are directly accessed by the static method without class name whereas non-static fields require objects.

## Static constructor
There are two different types of constructors, instant's and static.

The instance constructor is used to initialize instant's data.
Instance constructor is called every time when a class object is created, it is called explicitly.
Instant's constructor takes parameters, it has access specifiers.

Static constructor is used to initialize static data or perform a particular action that needs to be performed only once in the lifecycle of a class.
The static constructor is the first block of code to execute in class.
Static constructor executes one and only one time in the lifecycle of class.

And the static constructor does not take any parameter.
It has no access specifiers and it is not called directly.

## Static class
A static class can only contain static data members, static methods, and a static constructor.
It is not allowed to create objects of the static class.
Static classes are sealed, means one cannot inherit a static class from another class.


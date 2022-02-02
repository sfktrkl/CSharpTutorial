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


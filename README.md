# Zoo
Code 401 started Jan 14, 2019

###Diagram of the classes zoo layout
![](assets/DiagramOne.jpg?raw=true)

Lab 05
## Purpose:
This is a console run app to work with classes and interfaces to demonstrate the 4 OOP principles.

##The four princicples Object-Oriented Programing (OOP)
* Shows the 4 OOP
* 1. Inheritance = This is where an derived class takes in "inheritance" the methods and properties of one abstract (parent) class.
* 2. Abstraction = This indicates that it has missing implementation.  It's to be inheritaded and thus completed in a derived class.
* 3. Polymorphism = Means having many forms.  An example used is in the interface class and virtual methods used to override.
* 4. Encapsulation = It encloses items within a physical package.  This is done through access modifiers.

##Interface
- 1. Interface = It is a contract that all classes that inheriting the interface should follow.
- 2. My interfaces are Itricks & ICuddle.  They are being implemented on the TREX, Dino-otter, and Mammal class.
- 2a. Itricks has a property of FunTricks as boolean and Perform() method as a string.
- 2b. ICuddle has a property of LovesHumans as boolean and Hug() method as a string.
- 3. Diagram shows interface to the top left and implemented on the bottom right corner of the classes it's used on.

##Summary
- This is a console run app that displays all the animals currently in my private zoo.
- All the parent and derived classes are labled.  Please look at the labels in the image provided above to follow:
- 1. Parent and Derived classes.
- 2. Abstract classes and Concrete classes.
- 3. All access modifers are labled and set as PUBLIC.  This is necessary for xUNIT testing.
- 4. Polymorphism:  is used on Surface.class, Water.class, and Land.class using virtual methods on Arms()method, Tails()property, and Noise()method.  This is where they are being overridden.
- 5. There are at least 3 abstract classes.  (7 abstract total)
- 6. There are at least 3 layers of inheritance.  (3 layers inheritance total)
- 7. There are at least 5 concrete animals.  (8 concrete total)
- 8. There are at least 2 abtract methods.  At least 8 are override.  
- 9. There are at least 2 virtual methods.  (2 virtual methods)
- 10. There are at least 2 virtual properties.  (2 virtual properties)
- 11. There are at least 2 Interfaces.  (2 interfaces.  ICuddle & ITricks)

### xUNIT Testing
[x] Test that each concrete animal exhibits 2 appropriate behaviors given to them from the base class.
[x] Prove that the class that implemented interface actually implement it.  (Very first top test)
[x] Prove inheritance. 
[x] Prove methods have been overridden. (Pterodactyl speaks methods overridden)
[x] Prove at least one concrete animal "is an" Animal.  (Orca from Animal class)

### How to run the program:
This program requires visual studio 2017.
Run the program to start the console application.
This will be under "Program.cs".

You may look at the source code to ensure nothing evil is in there.

* The console will welcome you to the amazing World of Jurassic Zoo.



This assignment took about 12 hours to complete.


Below are screen shots of what this should look like.
###Screen Shot 
![](assets/CaptureOne.PNG?raw=true)
![](assets/CaptureTwo.PNG?raw=true)


Lab started on January 14, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.

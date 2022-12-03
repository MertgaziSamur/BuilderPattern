### BuilderPattern

***Purpose:*** Separate the rendering of a complex object from its presentation so that you can create different presentations from the same rendering process.

The client should be independent of different conversion patterns and parts, and should not know the algorithm that performs the conversion.
Storing the building process of this object independently of the client, like **Abstract Factory/Factory Method** or Booch's static factory method
says it should.
Factory method and Abstract Factory method alone do not solve this problem. It is set up as different implementations of an interface.
is the process.
In its simplest form, the builder calls the default constructor of the object and then builds the object with set methods and sends the resulting object to the client.
returns it.

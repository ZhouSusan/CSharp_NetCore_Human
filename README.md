# Assignment Part 1: Human

Let's get our feet wet with some OOP practice in C#! This first assignment shouldn't take us too much effort, but that's ok since at this point we should be feeling pretty comfortable working with Classes and Objects.

Build a new .NET Project for this assignment as we will be revisiting in a later assignment.

Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.

Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.

When an object is constructed from this class it should have the ability to pass a name

Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.

Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).

(Optional) Change the last function to accept any object and just make sure it is of type Human before applying damage. Hint you may need to refer back to the Boxing/Unboxing tab!

# Assignment Part 2: Wizard, Ninja, Samurai
We are going to be revisiting our Human class and building out three new classes that all inherit from it.

Create a class for a Ninja, a Wizard, and a Samurai

Wizard should have a default health of 50 and intelligence of 25

Wizard should have a method called heal, which when invoked, heals the Wizard by 10 * intelligence

Wizard should have a method called fireball, which when invoked, decreases the health of whichever object it attacked by some random integer between 20 and 50

Ninja should have a default dexterity of 175

Ninja should have a steal method, which when invoked, attacks an object and increases the Ninjas health by 10

Ninja should have a get_away method, which when invoked, decreases its health by 15

Samurai should have a default health of 200

Samurai should have a method called death_blow, which when invoked should attack an object and decreases its health to 0 if it has less than 50 health

Samurai should have a method called meditate, which when invoked, heals the Samurai back to full health

(optional) Samurai should have a class method called how_many, which when invoked, displays how many Samurai's there are. Hint you may have to use the static keyword

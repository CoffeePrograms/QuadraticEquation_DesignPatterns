# Design patterns in a mathematical problem
Training of the principles of OOP, SOLID, design patterns on a mathematical project. The program calculates the roots of quadratic equations of different types.

## Mathematic
The program solves the following types of quadratic equations:
- complete;
- incomplete;
- biquadrate.

## Design patterns
- strategy;
- chain of responsibility;
- singleton;
- facade.

## Patterns
### Strategy 
- **ITypeQe**    — interface. Its subclasses determine how the discriminant or the roots of the equation are calculated;
- **ACalcRoots** — abstract class. Its subclasses determine how the roots are calculated through the discriminant;
- **ACalcQe**    — abstract class. Its subclasses determine how the roots of the equation are calculated. 

### Chain of responsibility
The heirs of **ACalcQe** work with objects of heirs of the same class:
- **CalcQeByD** counts roots using **CalcRootsByD**; 
- **CalcIqe**   checks the roots of equations using **CheckRootsBySubstitution**;
- **CalcQeByD** checks the roots of equations using **CheckRootsBySubstitution** or **CheckRootsByVieta**.

### Singletone
**DefineType** defines the type of equation.

### Facade
- **DefineType** hides initialization of objects of type **ACalcQe**: determines the type of equation by the specified variables and selects a class for calculating the equation;
- **CalcQeByD**  works with objects of other classes to calculate the discriminant, the roots of the equation, and verify the solution;  
- **CalcIqe**    works with objects of other classes to calculate the roots of the equation and verify the solution.

## How to improve
- Manual input;
- More tests, in particular, of the DefineType class and equation types;
- The principle of openness/closeness in CalcRootsByD, CheckRootsBySubstitution when working with a biquadrate equation;
- ✅ The principle of substitution of Lisks in the heirs of ACalcQe (the problem is in IsRootsCorrect);
- ✅ Checking the roots of all types of equations.

## Links:
- https://izamorfix.ru/matematika/algebra/kvadratnye_uravn.html
- https://izamorfix.ru/matematika/algebra/diskriminant.html
- https://izamorfix.ru/matematika/algebra/nepolnye_kv_ur.html
- https://izamorfix.ru/matematika/algebra/teorema_vieta.html
- https://izamorfix.ru/matematika/algebra/bikvadratnye_uravn.html

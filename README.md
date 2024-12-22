# Uninitialized Property Access in C#

This example showcases a common yet subtle error in C#: accessing a class property before it's explicitly assigned a value.  In C#, class properties have default values if not initialized (e.g., 0 for integers, null for strings, etc.). This can lead to unexpected behavior and hard-to-debug issues.

The `bug.cs` file demonstrates the problem, while `bugSolution.cs` provides a corrected version.

## How to Reproduce
1. Compile and run `bug.cs`.
2. Observe the output. The value of `MyProperty` will be 0 because it was not set before being read.

## Solution
The `bugSolution.cs` file shows how to initialize the property appropriately, either directly in the declaration or within the constructor.
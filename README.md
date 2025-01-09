# F# Mutability Gotcha: Unexpected Behavior with Mutable Variables

This example demonstrates a potential pitfall when working with mutable variables in F#.  The `add` function uses the initial values of `x` and `y`, even after they're modified.  This is because the function doesn't capture the variables, but rather copies their values at the time of the function call.  The solution shows a way to deal with this issue if you want the function to use the updated values.

## Bug:
The code demonstrates the unexpected behavior: `add` always operates on the initial values of `x` and `y` regardless of their subsequent modifications.

## Solution:
The solution provides a way to use the most recent values of `x` and `y` inside the `add` function, using a different approach that avoids the mutability issue.
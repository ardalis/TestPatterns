# Test Patterns

Examples of approaches to unit testing different kinds of code in C#. These examples start with simple cases and move on to more complex patterns.

## Give a Star! :star:

If you like or are using this project to learn, please give it a star to help others find it. Thanks!

## State-Based Testing

The simplest kinds of unit tests create collaborators, call methods, and inspect the results. These work best with public methods with non-void return signatures and no side effects.

### Resources and Practice

Tests should follow [SOLID principles](https://www.pluralsight.com/courses/csharp-solid-principles), including Single Responsibility. Grouping tests by the method being tested helps achieve this. Read the following naming convention for a proven approach to organizing and naming your tests. Also, the FizzBuzz and String Calculator katas are great to use when first learning state-based testing.

- [Test Naming Convention](https://ardalis.com/unit-test-naming-convention)
- [FizzBuzz Kata](https://github.com/ardalis/kata-catalog/blob/master/katas/FizzBuzz.md)
- [String Calculator Kata](https://github.com/ardalis/kata-catalog/blob/master/katas/String%20Calculator.md)

## Behavior-Based Testing (with Mocks)

When you can't evaluate whether a method did the right thing by looking at the state it returns or modifies publicly, another approach is to test the behavior of the method itself. This is often called "behavior-based" testing and frequently uses *mock objects* (or spies or fakes or other techniques) to capture behavior that took place within the method being tested. Collectively these different techniques are known as [test doubles](http://xunitpatterns.com/Test%20Double.html).

### Resources and Practice

- [Test Doubles](http://xunitpatterns.com/Test%20Double.html)
- [File Logger Kata](https://github.com/ardalis/kata-catalog/blob/master/katas/File%20Logger.md)

## Testing Hard-To-Access State

Confirming the state of private or internal values when testing from another class and assembly can be a challenge. There are some patterns that can be used to overcome these challenges in most cases.




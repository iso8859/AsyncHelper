# AsyncHelper

Example how to call asynchronous C# function from synchronous code.

https://devblogs.microsoft.com/pfxteam/task-factory-startnew-vs-new-task-start/

```C#
int total = Helpers.AsyncHelper.RunSync<int>(() => addAsync(1, 2));
```
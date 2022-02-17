using InheritanceExercise;

var stack = new Stack();

//Happy case!
stack.Push(1);
stack.Push("Hello!");
stack.Push(DateTime.Now);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine();

//Clear Stack
stack.Clear();

//Exception Case in Push method
try
{
    stack.Push(null);
}
catch (InvalidOperationException)
{
    Console.WriteLine("The object have null reference!");    
}

//Exception Case in Pop method
try
{
    var result = stack.Pop();
}
catch (InvalidOperationException)
{
    Console.WriteLine("There is no object in the stack!");
}
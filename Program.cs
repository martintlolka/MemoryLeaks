using MemoryLeaks;

Console.WriteLine($"Memory usage {GC.GetTotalMemory(true) / 1024}kb");

var stack = new Stack(10000);

Console.WriteLine($"Memory usage {GC.GetTotalMemory(true) / 1024}kb");

for (int i = 0;i < 10000; i++)
{
    stack.Push($"Some string {i}");
}

for (int i = 0; i < 10000; i++)
{
    stack.Pop();
}

Console.WriteLine($"Memory usage {GC.GetTotalMemory(true) / 1024}kb");
namespace MM_Guide_Programming_Aptitude.Question2;

public static class Question2
{
    public static LinkedList<T>? ReverseLinkedListWithIteration<T>(LinkedList<T>? list)
    {
        if (list?.First is null)
            return null;
        
        var reversedList = new LinkedList<T>();

        foreach (var item in list)
            reversedList.AddFirst(item);

        return reversedList;
    }
    
    public static LinkedList<T>? ReverseLinkedListWithRecursion<T>(LinkedList<T>? list)
    {
        // in case caller passes null, we just return the same (does not happen during recursion, only during initial call)
        if (list is null)
            return null;
        
        // base case: if list is empty, we're done with recursion
        if (list.First is null)
            return new LinkedList<T>();

        var currentHead = list.First.Value;
        list.RemoveFirst();
        
        var reversed = ReverseLinkedListWithRecursion(list)!;

        reversed.AddLast(currentHead);
        
        return reversed;
    }
}
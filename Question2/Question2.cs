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
    
    // public static LinkedList<T>? ReverseLinkedListWithRecursion<T>(LinkedList<T>? list)
    // {
    //     throw new NotImplementedException();
    // }
}
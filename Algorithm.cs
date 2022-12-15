using System;
using System.Collections.Generic;
using System.Linq;


public static class Algorithm
{
    public static List<T> Copy<T>(List<T> inputList, List<T> outPutList)
    {
        outPutList.Clear();
        foreach (var item in inputList)
        {
            outPutList.Add(item);
        }

        return outPutList;
    }

    public static List<T> CopyIf<T>(List<T> inputList, List<T> outPutList, Func<T, bool> func)
    {
        outPutList.Clear();

        foreach (var item in inputList)
        {
            if (func(item))
            {
                outPutList.Add(item);
            }
        }

        return outPutList;
    }

    public static int Count<T>(List<T> list, T t)
    {
        int value = 0;
        foreach (T item in list)
        {
            T tİtem = item;

            if (tİtem.Equals(t))
            {
                value += 1;
            }
        }

        return value;
    }

    public static int CountIf<T>(List<T> list, Func<T, bool> func)
    {
        var value = 0;

        foreach (var item in list)
        {
            if (func(item))
            {
                value += 1;
            }
        }


        return value;
    }

    public static List<T> RemoveIf<T>(List<T> list, Func<T, bool> func)
    {
        foreach (var item in list.ToList())
        {
            if (func(item))
            {
                list.Remove(item);
            }
        }


        return list;
    }

    public static List<T> Transform<T>(List<T> inputList, List<T> outPutList, Func<T, T> func)
    {
        outPutList.Clear();


        foreach (var item in inputList)
        {
            T t = func(item);
            outPutList.Add(t);
        }


        return outPutList;
    }

    public static List<T> Merge<T>(List<T> inputList1, List<T> inputList2, List<T> outPutList,
        bool clearOutPutList = true)
    {
        if (clearOutPutList)
        {
            outPutList.Clear();
        }

        foreach (var item in inputList1)
        {
            outPutList.Add(item);
        }

        foreach (var item in inputList2)
        {
            outPutList.Add(item);
        }

        return outPutList;
    }

    public static List<T> MergeIf<T>(List<T> inputList1, List<T> inputList2, List<T> outPutList, Func<T, bool> func,
        bool clearOutPutList = true)
    {
        if (clearOutPutList)
        {
            outPutList.Clear();
        }

        foreach (var item in inputList1)
        {
            if (func(item))
            {
                outPutList.Add(item);
            }
        }

        foreach (var item in inputList2)
        {
            if (func(item))
            {
                outPutList.Add(item);
            }
        }

        return outPutList;
    }

    public static void ForEachIf<T>(ref List<T> inputList, Func<T, bool> condition, Func<T, T> func)
    {
        List<T> temp = new();
        for (int i = 0; i < inputList.Count; i++)
        {
            if (condition(inputList[i]))
            {
                T t = func(inputList[i]);
                temp.Add(t);
            }
            else
            {
                temp.Add(inputList[i]);
            }
        }

        inputList = temp;
    }

    public static List<T> Unique<T>(List<T> inputList, List<T> outPutList)
    {
        outPutList.Clear();


        foreach (T item in inputList)
        {
            if (!outPutList.Contains(item))
            {
                outPutList.Add(item);
            }
        }


        return outPutList;
    }

    public static bool AnyOf<T>(List<T> inputList, Func<T, bool> func)
    {
        bool value = false;

        foreach (var item in inputList)
        {
            if(func(item))
            {
                value = true;
                break;
            }
        }




        return value;

    }
    
    public static bool NoneOf<T>(List<T> inputList, Func<T, bool> func)
    {
        bool value = false;

        foreach (var item in inputList)
        {
            if(func(item))
            {
                value = true;
                break;
            }
        }




        return !value;

    }

}

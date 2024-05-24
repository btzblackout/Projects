package com.blackout;

public class DynamicArray
{
    int[] arr;



    public void Add(int number)
    {
        int[] newArr = new int[arr.length + 1];
        for(int i = 0; i < arr.length; i++)
        {
            newArr[i] = arr[i];
        }
        arr = newArr;
        arr[arr.length - 1] = number;
    }
}

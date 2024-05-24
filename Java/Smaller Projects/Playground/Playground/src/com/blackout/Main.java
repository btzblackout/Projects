/*
 *  Author: Raymond Lawson
 *  Date: 02/5/2021
 *  CST-201 Algorithms and Data Structures
 *
 *                                  Topic 3 DQ 1
 *  What is a deque?
 *  Write a small program that demonstrates the deque data structure.
 *  ------------------------------------------------------------------
 *  A deque (pronounced like deck) stands for a double ended queue.
 *  With a deque you can add and remove elements from both front and end.
 *  Because of this a deque can act as both a Queue and a Stack.
 *  A Queue is a FIFO (First In First Out) list in which the element that
 *  is at the front of the list is the first element out.
 *  A Stack is a LIFO (Last In First Out) list in which the element that
 *  is at the last position (top) is the first element out.
 *  ------------------------------------------------------------------
 */

package com.blackout;


import com.blackout.DoublyLinkedList;

import java.util.ArrayList;
import java.util.List;

public class Main
{

    public static void main (String[]args)
    {
        DoublyLinkedList list1 = new DoublyLinkedList();
        DoublyLinkedList list2 = new DoublyLinkedList();

        list1.Insert(4);
        list1.Insert(3);
        list1.Insert(2);
        list1.Insert(6);
        list2.Insert(5);
        list2.Insert(6);
        list2.Insert(1);
        list2.Insert(4);

        System.out.println("List 1");
        list1.Print();

        System.out.println("\nList 2");
        list2.Print();

        DoublyLinkedList list3 = list1.merge(list2);
        System.out.println("\nList 3");
        list3.Print();

        System.out.println("\nList 1");
        list1.Print();

        System.out.println("\nList 2");
        list2.Print();



    }
}
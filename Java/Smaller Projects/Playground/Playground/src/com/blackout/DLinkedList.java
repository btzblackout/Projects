package com.blackout;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.lang.*;


/**
 * provided file for DLinkedList Assignment 
 *
 */
public class DLinkedList<T extends Comparable<T>> {

    public static void main(String[] args) throws FileNotFoundException {

        DLinkedList<String> lst1 = new DLinkedList<>();
        DLinkedList<String> lst2 = new DLinkedList<>();


        Scanner fin = new Scanner(new File("Playground/text1.in"));
        String str;

        while (fin.hasNext()) {
            str = fin.next();
            str = cleanUp(str);
            lst1.insertOrderUnique(str);
        }
        fin.close();
        lst1.Sort(lst1);


        fin = new Scanner(new File("Playground/text2.in"));
        while (fin.hasNext()) {
            str = fin.next();
            str = cleanUp(str);
            lst2.insertOrderUnique(str);
        }

        System.out.println("List 1:  " + lst1);
        System.out.println("List 2:  " + lst2);


        DLinkedList combined = lst1.merge(lst2);

        System.out.println("\nAFTER MERGE");
        System.out.println("List 1:  " + lst1);
        System.out.println("List 2:  " + lst2);
        System.out.println("\n" + combined);
    }

    /**
     * ASSIGNED
     * @param str
     * @return str in all lower case with LEADING and TRAILING non-alpha
     * chars removed
     */
    public static String cleanUp(String str)
    {
        //Convert the string to char array
        char[] oldCharArray = str.toCharArray();
        char[] newCharArray = new char[oldCharArray.length - 1];

        //Check the first element the array for non-alpha numeric
        if(!Character.isLetterOrDigit(oldCharArray[0]))
        {
            int counter = 0;
            for(int i = 1; i < oldCharArray.length; i++)
            {
                newCharArray[counter] = oldCharArray[i];
                counter++;
            }
            str = "";
            for(int i = 0; i < newCharArray.length; i++)
            {
                str = str + newCharArray[i];
            }
        }

        //Check the last element in the array for non-alpha numeric
        else if(!Character.isLetterOrDigit(oldCharArray[oldCharArray.length -1]))
        {
            for(int i = 0; i < oldCharArray.length - 1; i++)
            {
                newCharArray[i] = oldCharArray[i];
            }

            str = "";
            for(int i = 0; i < newCharArray.length; i++)
            {
                str = str + newCharArray[i];
            }
        }

        //return the string.
        return str.toLowerCase();
    }

    //inner DNode class:  PROVIDED
    private class DNode {

        private DNode next, prev;
        private T data;

        private DNode(T val) {
            this.data = val;
            next = null;
            prev = null;
        }
    }

    //DLinkedList fields:  PROVIDED
    private DNode header;

    //create an empty list:  PROVIDED
    public DLinkedList() {
        header = null;
    }

    /**
     * PROVIDED add
     *
     * @param item return ref to newly inserted node
     */
    public DNode add(T item) {
        //make a new node
        DNode newNode = new DNode(item);
        //update newNode
        newNode.prev = header;
        newNode.next = header.next;
        //update surrounding nodes
        header.next.prev = newNode;
        header.next = newNode;
        return newNode;
    }

    //PROVIDED

    public String toString() {
        DNode curr = null;
        String str = "[";
        if(this.header.next != null)
        {
            curr = header.next;
        }
        str = str + this.header.data + " ";
        while (curr.next != null)
        {
            str += curr.data + " ";
            curr = curr.next;
        }

        str = str.substring(0, str.length() - 1);
        return str + "]";
    }

    /**
     * ASSIGNED
     * remove val from the list
     *
     * @param val
     * @return true if successful, false otherwise
     */
    public boolean remove(T val)
    {
        boolean successful = false;

        DNode currentNode = this.header;
        DNode nextNode = currentNode.next;

        if(currentNode.data == val)
        {
            this.header = currentNode.next;
            this.header.prev = null;
            successful = true;
        }
        while(nextNode != null)
        {
            if(nextNode.data == val)
            {
                currentNode.next = nextNode.next;
                currentNode.next.prev = currentNode;
                successful = true;
            }
            currentNode = currentNode.next;
            nextNode = currentNode.next;
        }
        return successful;
    }

    /**
     * ASSIGNED
     *
     * @param item
     */
    public void insertOrder(T item)
    {
        DNode currentNode = this.header;

        //Can't use > with generic type T
        //This should be equivalent to currentNode.data < item.
        while (item.compareTo(currentNode.data) > 0)
        {
            currentNode = currentNode.next;
        }
        DNode placeholder = currentNode.prev;
        currentNode.prev = new DNode(item);
        currentNode.prev.prev = placeholder;
        placeholder.next = currentNode.prev;
        currentNode.prev.next = currentNode;
    }

    /**
     * ASSIGNED
     *
     * @param item
     */
    public boolean insertOrderUnique(T item)
    {
        DNode currentNode = this.header;
        boolean alreadyContained = false;
        boolean successful = false;
        if(currentNode == null)
        {
            this.header = new DNode(item);
            successful = true;
            return successful;
        }
        else
        {
            //Traverse the list to see if it's equal.
            while(currentNode.next != null)
            {
                if(currentNode.data.equals(item))
                {
                    alreadyContained = true;
                }
                currentNode = currentNode.next;
            }

            if(!alreadyContained)
            {
                DNode placeholder = new DNode(item);
                currentNode.next = placeholder;
                placeholder.prev = currentNode;
                successful = true;
            }

        }

        /*
        while (currentNode != null)
        {


            if(alreadyContained == false)
            {
                //Can't use > with generic type T
                //This should be equivalent to currentNode.data < item.
                while (item.compareTo(currentNode.data) > 0)
                {
                    currentNode = currentNode.next;
                }
                DNode placeholder = currentNode.prev;
                currentNode.prev = new DNode(item);
                currentNode.prev.prev = placeholder;
                placeholder.next = currentNode.prev;
                currentNode.prev.next = currentNode;
                successful = true;
            }
            currentNode = currentNode.next;
        }

         */


        return successful;
    }

    /**
     * ASSIGNED
     * PRE:  this and rhs are sorted lists
     * @param rhs
     * @return list that contains this and rhs merged into a sorted list
     * POST:  returned list will not contain duplicates
     */
    public DLinkedList merge(DLinkedList rhs)
    {
        //List that will be returned
        DLinkedList newList = new DLinkedList();

        //Nodes for tracking and traversing the lists
        DNode currentNode = this.header;
        DNode second = rhs.header;

        //Traverse to the end of the parent list
        while(currentNode.next != null)
        {
            currentNode = currentNode.next;
        }

        //Set the last nodes next to the second list
        currentNode.next = second;

        //Go back to the beginning of the list (parent's header)
        while(currentNode.prev != null)
        {
            currentNode = currentNode.prev;
        }

        //Set the new lists header to the parents header
        newList.header = currentNode;

        //Sort the newList
        newList.Sort(newList);

        //Remove duplicates in the newList
        newList.RemoveDuplicates();

        //Set the parent list to empty
        this.Empty();

        //Set the second list to empty
        rhs.Empty();

        //Return the newList
        return newList;
    }
    public void Sort(DLinkedList list)
    {

        //check whether list is empty
        if(list.header == null)
        {
            return;
        }
        else
        {
            DNode currentNode = list.header;
            //This while loop points to the current node.
            while(currentNode.next != null)
            {
                DNode nextNode = currentNode.next;
                //This while loop will point to the next node.
                while(nextNode != null)
                {
                    //This checks if the currentNode's data is greater than the
                    //next node's. If it is, they are switched.
                    if(currentNode.data.compareTo(nextNode.data) > 0)
                    {
                        T temporary = currentNode.data;
                        currentNode.data = nextNode.data;
                        nextNode.data = temporary;
                    }
                    nextNode = nextNode.next;
                }
                currentNode = currentNode.next;
            }
        }
    }

    public void Empty()
    {
        this.header = null;
    }

    public void RemoveDuplicates()
    {
        DNode currentNode = this.header;
        DNode temporary = currentNode.next;

        while(currentNode != null)
        {
            while (temporary != null)
            {
                if(currentNode.data == temporary.data)
                {
                    currentNode.next = temporary.next;
                }
                temporary = temporary.next;
            }
            currentNode = currentNode.next;
            if(currentNode == null)
            {
                return;
            }
            else
            {
                temporary = currentNode.next;
            }
        }
    }

}
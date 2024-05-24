package com.blackout;

import com.blackout.Node;

public class SinglyLinkedList
{
    //Declare variables to hold first and last in list.
    private Node head;
    private Node last;

    //Default constructor.
    public SinglyLinkedList()
    {

    }

    //Copy constructor.
    public SinglyLinkedList SinglyLinkedList(SinglyLinkedList list)
    {
        Node listANode = this.head;
        Node listBNode = list.head;

        while(listANode != null)
        {
            //Keeps from throwing NullPointerException
            if(listBNode == null)
            {
                listBNode = new Node();

            }

            //Copies the Node from list A to list B.
            listBNode.setData(listANode.getData());

            //Continues traversing list A.
            listANode = listANode.getNext();
            listBNode = listBNode.getNext();

        }
        return list;
    }

    //Insert method.
    //O(n) - the larger the list, the more nodes need traversed to find the last node for insertion.
    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if(this.head == null)
        {
            this.head = newNode;
        }
        else
        {
            Node currentNode = this.head;
            while(currentNode.getNext() != null)
            {
                currentNode = currentNode.getNext();
            }
            currentNode.setNext(newNode);
            this.last = newNode;
        }
    }

    //Remove method.
    public void Remove(int data)
    {
        Node currentNode = this.head;
        Node nextNode = currentNode.getNext();
        Node placeholder;

        if(currentNode.getData() == data)
        {
            this.head = currentNode.getNext();
            return;
        }
        while(nextNode != null)
        {
            if(nextNode.getData() == data)
            {
                currentNode.setNext(nextNode.getNext());
            }
            currentNode = currentNode.getNext();
            nextNode = currentNode.getNext();
        }
    }

    //Print method.
    //O(n) - the larger the list, the more nodes need traversed to print the values.
    public void Print()
    {
        Node currentNode = this.head;

        while(currentNode != null)
        {
            System.out.print(currentNode.getData() + ". ");
            currentNode = currentNode.getNext();
        }
    }

    //Access to first element method.
    //O(1) - this has a constant time, regardless of the data size. It only has to execute once, printing the heads data.
    public int FirstElement()
    {
        return this.head.getData();
    }

    //Access to last element method
    //O(1) - this has a constant time, regardless of the data's size. It will only execute once, grabbing the data of the tail node.
    public int LastElement()
    {
        return this.last.getData();
    }

    //Remove value at front method.
    //O(1) - this method will have a constant time. It will always only execute once.
    public void PopFront()
    {
        this.head = this.head.getNext();
    }

    //Remove value at front method.
    //O(n) - the larger the list is, the longer it will take to reach the last node.
    public void PopBack()
    {
        Node currentNode = this.head;

        //Stop at the element right before the last one
        while(currentNode.getNext().getNext() != null)
        {
            currentNode = currentNode.getNext();
        }

        this.last = currentNode;
        currentNode.setNext(null);
    }

    //Determine if empty method.
    //O(1) - this method does not have any loops, therefore it will have a constant time.
    public boolean Empty()
    {
        boolean isEmpty = false;
        if(this.head == null)
        {
            isEmpty = true;
        }
        return isEmpty;
    }

    //Get size of list method.
    //O(n) - this method will take longer the larger the list is.
    public int Size()
    {
        Node currentList = this.head;
        int size = 0;

        while(currentList != null)
        {
            size++;
            currentList = currentList.getNext();
        }
        return size;
    }

    //Reverse order method.
    //O(n) - as the size of the list increases so does the time it takes to traverse the list.
    public void Reverse()
    {
        //Declare variables
        int[] arr = new int[this.Size()];
        int counter = 0;
        Node currentNode = this.head;

        //Populate an array of the numbers in same order
        //as they are in the list.
        while(currentNode != null && counter < arr.length)
        {
            arr[counter] = currentNode.getData();
            counter++;
            currentNode = currentNode.getNext();
        }

        //Traverse the list, setting the data starting from the
        //last of the array and working backwards.
        currentNode = this.head;
        while(currentNode != null && counter >= 0)
        {
            currentNode.setData(arr[counter - 1]);
            counter--;
            currentNode = currentNode.getNext();
        }
    }

    //Merge list method.
    //O(n^2) - this method is O(n^2) because of the nested while loop in my for loop.
    public void Merge(SinglyLinkedList list)
    {
        //Declare variables
        int[] arr = new int[list.Size()]; //O(1)
        int counter = 0;
        Node currentNode = list.head;

        //Save the elements from second list to the array.
        while (currentNode != null && counter < arr.length)
        {
            arr[counter] = currentNode.getData();
            counter++;
            currentNode = currentNode.getNext();
        }

        currentNode = this.head;
        Node placeholder;

        //For each element in the array, add it to
        //the end of the linked list.
        for(int i = 0; i < arr.length; i++)
        {
            //Create a new Node to be saved with data from the arr.
            placeholder = new Node(arr[i]);

            //Ensure the end of the Linked List.
            while(currentNode.getNext() != null)
            {
                currentNode = currentNode.getNext();
            }

            //Set it as the last element.
            currentNode.setNext(placeholder);
            this.last = currentNode;
        }

    }
}

package com.blackout;
import com.blackout.Node;

public class DoublyLinkedList
{
    private Node head;

    public void Insert (int data)
    {
        Node currentNode = this.head;
        if(currentNode == null)
        {
            this.head = new Node(data);
        }
        else
        {
           while(currentNode.getNext() != null)
           {
               currentNode = currentNode.getNext();
           }
           currentNode.setNext(new Node(data));
           currentNode.getNext().setPrev(currentNode);
        }
    }

    public void insertOrder(int data)
    {
        Node currentNode = this.head;
        while (currentNode.getData() < data)
        {
            currentNode = currentNode.getNext();
        }

        Node placeholder = currentNode.getPrev();
        currentNode.setPrev(new Node(data));
        currentNode.getPrev().setPrev(placeholder);
        placeholder.setNext(currentNode.getPrev());
        currentNode.getPrev().setNext(currentNode);
    }

    public boolean remove(int val)
    {
        boolean successful = false;

        Node currentNode = this.head;
        Node nextNode = currentNode.getNext();

        if(currentNode.getData() == val)
        {
            this.head = currentNode.getNext();
            this.head.setPrev(null);
            successful = true;
        }
        while(nextNode != null)
        {
            if(nextNode.getData() == val)
            {
                currentNode.setNext(nextNode.getNext());
                currentNode.getNext().setPrev(currentNode);
                successful = true;
            }
            currentNode = currentNode.getNext();
            nextNode = currentNode.getNext();
        }
        return successful;
    }

    public DoublyLinkedList merge(DoublyLinkedList list2)
    {
        DoublyLinkedList newList = new DoublyLinkedList();

        Node currentNode = this.head;
        Node second = list2.head;

        //Traverse to the end of the parent list
        while(currentNode.getNext() != null)
        {
            currentNode = currentNode.getNext();
        }

        //Set the last nodes next to the second list
        currentNode.setNext(second);

        //Traverse to the beginning of the list
        while(currentNode.getPrev() != null)
        {
            currentNode = currentNode.getPrev();
        }

        //Set the new lists head to the merge lists head
        newList.head = currentNode;

        //Sort the newList
        newList.Sort();

        //Remove all duplicates in the newList
        newList.RemoveDuplicates();

        //Set the parent list to empty
        this.Empty();

        //Set the second list to empty
        list2.Empty();
        return newList;

    }

    public void Sort()
    {
        Node currentNode = null, index = null;
        int temp;

        //check whether list is empty
        if(this.head == null)
        {
            return;
        }
        else
        {
            currentNode = this.head;
            index = currentNode.getNext();
            while(currentNode.getNext() != null)
            {
                while(index != null)
                {
                    if(currentNode.getData() > index.getData())
                    {
                        temp = currentNode.getData();
                        currentNode.setData(index.getData());
                        index.setData(temp);
                    }
                    index = index.getNext();
                }
                currentNode = currentNode.getNext();
                index = currentNode.getNext();
            }

        }

    }

    public void RemoveDuplicates()
    {
        Node currentNode = this.head;
        Node temporary = currentNode.getNext();

        while(currentNode != null)
        {
            while (temporary != null)
            {
                if(currentNode.getData() == temporary.getData())
                {
                    currentNode.setNext(temporary.getNext());
                    currentNode.setData(temporary.getData());
                }
               temporary = temporary.getNext();
            }
            currentNode = currentNode.getNext();
            if(currentNode == null)
            {
                return;
            }
            else
            {
                temporary = currentNode.getNext();
            }
        }
    }

    public void Empty()
    {
        this.head = null;
    }

    public void Print()
    {
        Node currentNode = this.head;
        int counter = 1;
        while(currentNode != null)
        {

            System.out.print("Node " + counter + ": " + currentNode.getData() + ", ");

            if(currentNode.getPrev() == null)
            {
                System.out.print("PREV: NULL, ");
            }
            else
            {
                System.out.print("PREV: " + currentNode.getPrev().getData() + ", ");
            }

            if(currentNode.getNext() == null)
            {
                System.out.print("NEXT: NULL\n");
            }
            else
            {
                System.out.print("NEXT: " + currentNode.getNext().getData() + "\n");
            }
            counter++;
            currentNode = currentNode.getNext();

        }
    }
}

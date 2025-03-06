package LinkedList;

public class DoublyLinkedList
{
    private DoublyNode header;
    private DoublyNode lastNode;
    private int size;

    public DoublyLinkedList()
    {
        this.header = new DoublyNode(null);
        this.lastNode = header;
        size = 0;
    }

    public void Prepend(int data)
    {
        // Create the new node.
        DoublyNode node = new DoublyNode(data);

        // If the list is empty.
        if(size == 0)
        {
            // Set the headers next node to the new node.
            header.setNextNode(node);
            // Set the new nodes prev node to the header.
            node.setPrevNode(header);
            // Set the node as the last node.
            lastNode = node;
            // Increment the list size.
            size++;
        }
        // The list is not empty.
        else
        {
            // Get the headers current next node.
            DoublyNode temp = header.getNextNode();
            // Set the new node as the headers next node.
            header.setNextNode(node);
            // Set the new nodes next as the temp node.
            node.setNextNode(temp);
            // Set the new nodes prev node as the header
            node.setPrevNode(header);
            // Set the new nodes next node's prev as the new node.
            node.getNextNode().setPrevNode(node);
            // Increment the list size;
            size++;
        }
    }

    public void Append(int data)
    {
        // Check if the list is empty, if so then call Prepend.
        if(size == 0)
        {
            Prepend(data);
        }
        else
        {
            // Create the new node.
            DoublyNode node = new DoublyNode(data);
            // Create a temp node for traversing, set to the first node.
            DoublyNode traverseNode = header.getNextNode();
            // Traverse to the end of the list.
            for (int i = 1; i < size; i++)
            {
                traverseNode = traverseNode.getNextNode();
            }
            // Set the new node as the last node.
            traverseNode.setNextNode(node);
            lastNode = node;
            node.setPrevNode(traverseNode);
            size++;
        }
    }

    public String ToString()
    {
        // Create an empty string to build.
        String returnString = "";
        // Ensure the list is not empty.
        if(size > 0)
        {
            // Start at the first actual node.
            DoublyNode parseNode = header.getNextNode();
            while(parseNode != null)
            {
                returnString = returnString + parseNode.getData() + " ";
                parseNode = parseNode.getNextNode();
            }
        }
        return returnString;
    }

    public int Size()
    {
        return size;
    }
}

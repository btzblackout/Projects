package LinkedList;

public class LinkedList
{
    private Node header;
    private Node lastNode;
    private int size;

    public LinkedList()
    {
        this.header = new Node(null);
        this.lastNode = header;
    }

    public void Prepend(int data)
    {
        // Create a new node.
        Node node = new Node(data);
        // If size == 0 then the list is currently empty.
        if(size == 0)
        {
            // Set the headers next node to this node.
            header.setNextNode(node);
            // Set the last node to this node because there is only 1 node.
            lastNode = node;
            // Increase the size of the list.
            size++;
        }
        else
        {
            // Grab the current header's next node.
            Node temp = header.getNextNode();
            // Set the new node to the header's next node.
            header.setNextNode(node);
            // Set the new node's next node to the next in the list.
            node.setNextNode(temp);
            // Increase the size of the list.
            size++;
        }
    }

    public void Append(int data)
    {
        Node node = new Node(data);

        if(size == 0)
        {
            header.setNextNode(node);
            lastNode = node;
            size++;
        }
        else
        {
            lastNode.setNextNode(node);
            lastNode = node;
            size++;
        }
    }

    public void RemoveFirst()
    {
        if(size != 0)
        {
            header.setNextNode(header.getNextNode().getNextNode());
            size--;
        }
    }

    public void RemoveLast()
    {
        if(size == 1)
        {
            header.setNextNode(null);
            lastNode = header;
            size--;
        }
        else if(size != 0)
        {
            Node temp = header.getNextNode();
            while(temp.getNextNode().getNextNode() != null)
            {
                temp = temp.getNextNode();
            }
            temp.setNextNode(null);
            lastNode = temp;
            size--;
        }
    }
    public int getSize()
    {
        return size;
    }

    public String ToString()
    {
        String returnString = "";
        Node parseNode = header.getNextNode();
        while(parseNode != null)
        {
            returnString = returnString + parseNode.getData() + " ";
            parseNode = parseNode.getNextNode();
        }

        return returnString;
    }

    public void InsertAt(int index, int data)
    {
        // If the node is trying to be inserted outside the bounds.
        if (index <= 0 || index > size)
        {
            return;
        }
        // If index is 1, call prepend.
        else if(index == 1)
        {
            Prepend(data);
        }
        // Set the node at the appropriate index.
        else if(index <= size)
        {
            // Create a new node for inserting.
            Node node = new Node(data);
            // Create a temp node for traversing.
            Node temp = header.getNextNode();
            // Start at the first actual node.
            for(int i = 1; i < index - 1; i++)
            {
                temp = temp.getNextNode();
            }
            // Set the current next node to the next node of the inserting node.
            node.setNextNode(temp.getNextNode());
            // Set the next node of this node to the insert node.
            temp.setNextNode(node);
            // Increase the size of the list.
            size++;
        }
    }

    public void RemoveAt(int index)
    {
        if(index <= 0 || index > size)
        {
            return;
        }
        else if(index == 1)
        {
            RemoveFirst();
        }
        else if(index == size)
        {
            RemoveLast();
        }
        else if(index < size)
        {
            // Start temp node at the first true node.
            Node temp = header.getNextNode();
            // Traverse to 1 before the index.
            for (int i = 1; i < index - 1; i++)
            {
                temp = temp.getNextNode();
            }
            // Set the next node as the next node's next node.
            temp.setNextNode(temp.getNextNode().getNextNode());
            size--;
        }

    }
}

package LinkedList;

public class Node
{
    private Integer data;
    private Node nextNode;

    Node(Integer data)
    {
        this.data = data;
        nextNode = null;
    }

    public int getData()
    {
        return data;
    }

    public void setData(int data)
    {
        this.data = data;
    }

    public Node getNextNode()
    {
        return this.nextNode;
    }

    public void setNextNode(Node node)
    {
        this.nextNode = node;
    }
}

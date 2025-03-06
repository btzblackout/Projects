package LinkedList;

public class DoublyNode
{
    private Integer data;
    private DoublyNode nextNode;
    private DoublyNode prevNode;

    DoublyNode(Integer data)
    {
        this.data = data;
        nextNode = null;
        prevNode = null;
    }

    public int getData()
    {
        return data;
    }

    public void setData(int data)
    {
        this.data = data;
    }

    public DoublyNode getNextNode()
    {
        return this.nextNode;
    }

    public void setNextNode(DoublyNode node)
    {
        this.nextNode = node;
    }

    public DoublyNode getPrevNode()
    {
        return this.prevNode;
    }

    public void setPrevNode(DoublyNode node)
    {
        this.prevNode = node;
    }
}

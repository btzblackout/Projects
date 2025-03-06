import java.util.ArrayList;
import java.util.List;

public class MyHashSet
{
    List<Integer> hashSet;

    public MyHashSet()
    {
        hashSet = new ArrayList<>();
    }
    public void add(int key)
    {
        // If the list is empty.
        if(hashSet.size() == 0)
        {
            hashSet.add((key));
        }
        else
        {
            // Traverse the list and check if the number is in the list.
            for (int i = 0; i < hashSet.size(); i++) 
            {
                if(hashSet.get(i).equals(key))
                {
                    return;
                }
            }
            // Add the key to the list.
            hashSet.add((key));
        }
    }

    public boolean contains(int key)
    {
        // Traverse the list and search for the key
        for (int i = 0; i < hashSet.size(); i++) 
        {
            if(hashSet.get(i).equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public void remove(int key)
    {
        // Traverse the list to find the key.
        for (int i = 0; i < hashSet.size(); i++)
        {
            if(hashSet.get(i).equals(key))
            {
                hashSet.remove(i);
            }
        }
    }

}

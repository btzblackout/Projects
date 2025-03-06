import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class FindDuplicates
{
    public boolean findDuplicates(List<Integer> keys)
    {
        Set<Integer> hashSet = new HashSet<>();
        for (Integer key : keys)
        {
            if(hashSet.contains(key))
            {
                return true;
            }
            hashSet.add(key);
        }
        return false;
    }
}

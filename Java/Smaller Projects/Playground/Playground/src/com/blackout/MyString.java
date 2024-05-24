package com.blackout;

public class MyString {

    private char[] charArray;
    private int curr_length;

    //Null constructor.
    public MyString() {
        charArray = null;
        curr_length = 0;
    }

    //Normal constructor.
    public MyString(String str) {
        charArray = str.toCharArray();
        curr_length = charArray.length;
    }

    //Copy constructor.
    public MyString(MyString obj) {
        this.charArray = obj.charArray;
        this.curr_length = obj.Length();
    }

    //Setter for charArray.
    public void setCharArray(String str)
    {
        this.charArray = str.toCharArray();
        this.curr_length = charArray.length;
    }

    //Return number of chars in the string.
    //Getter for curr_length.
    public int Length()
    {
        return curr_length;
    }

    //allocation of additional memory??
    private void EnsureCapacity()
    {

    }

    //ToString method.
    //Getter for charArray.
    public String ToString()
    {
        String str = "";
        try
        {
            for(int i = 0; i < charArray.length; i++)
            {
                str = str + charArray[i];
            }
        } catch (NullPointerException e)
        {
            str = "";
        }


        return str;
    }

    //Concatenation method.
    public MyString Concat(MyString obj)
    {
        MyString myString = new MyString(obj.ToString());
        myString.setCharArray(this.ToString() + myString.ToString());
        return myString;
    }

    //Equals method.
    public boolean Equals(MyString obj)
    {
        boolean isEqual = false;
        if(this.ToString().equals(obj.ToString()))
        {
            isEqual = true;
        }
        return isEqual;
    }

    //CompareTo method.
    public int CompareTo(MyString obj)
    {
        if(this.ToString().compareTo(obj.ToString()) == 0)
        {
            return 0;
        }
        else if(this.ToString().compareTo(obj.ToString()) < 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    //Get method.
    public char Get(int index)
    {
        char charAtIndex = ' ';
        try
        {
            charAtIndex = this.charArray[index];
            return charAtIndex;
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            System.out.println("The index was not found!");
        }
        return charAtIndex;
    }

    //ToUpper method.
    public MyString ToUpper()
    {
        MyString myString = new MyString();
        myString.setCharArray(this.ToString().toUpperCase());
        return myString;
    }

    //ToLower method.
    public MyString ToLower()
    {
        MyString myString = new MyString();
        myString.setCharArray(this.ToString().toLowerCase());
        return myString;
    }

    //Substring method.
    public String Substring(int index)
    {
        String str = "";
        try
        {
            for(int i = index; i < this.Length(); i++)
            {
                str = str + this.charArray[i];
            }
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            str = "The index provided is out of bounds!";
        }
        return str;
    }

    //Second Substring method.
    public String Substring(int n, int m)
    {
        String str = "";
        try
        {
            for(int i = n; i < m + 1; i++)
            {
                str = str + this.charArray[i];
            }
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            str = "One of the indexes provided are out of bounds!";
        }
        return str;
    }

    //IndexOf method.
    public int IndexOf(MyString obj)
    {
        int indexOf = this.ToString().indexOf(obj.ToString());
        return indexOf;
    }

    //LastIndexOf method.
    public int LastIndexOf(MyString obj)
    {
        int lastIndexOf = this.ToString().lastIndexOf(obj.ToString());
        return lastIndexOf;
    }
}

namespace pressure.Models
{
  class challenges
  {
    // num will be an integer. Double it and return it. (ex 12 => 24)
    public int doubleInteger(int num)
    {
      return (num * 2);
    }

    //num will be an integer. Return true if it’s even, and false if it isn’t.
    public int isNumberEven(int num)
    {
      if (num % 2 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    // str will be a string, but it may not have a file extension.
    // return the file extension (with no period) if it has one, otherwise false
    public string getFileExtension(string str)
    {
      // string[] strings = str.Split('.');
      // if (strings[1] != null)
      // {
      //   return strings[1];
      // }
      // else
      // {
      //   return false;
      // }
      string[] strArr = str.Split('.');
      if (strArr.Length < 2) return null;
      return strArr[strArr.Length - 1];
    }
    // arr will be an array. Return the longest string in the array
    public string longestString(string arr)
    // {
    //   string[] strings = arr.Split('.');

    // }
    {
      string longest = arr[0];
      for (int i = 1; i < arr.Length; i++)
      {
        string word = arr[i];
        if (word.Length > longest.Length)
        {
          longest = word;
        }
      }
      return longest;
    }
    //given an array return the sum of all its values
    public int arraySum(int[] arr)
    {
      int sum = 0;
      foreach (int num in arr)
      {
        sum += num;
      }
      return sum;
    }
    // can also use arr.Sum();
    // Is this brough in from linq???????????????????????????????
  }
}
using System;
class HelloWorld {
  static void Main() {
      int sortLength=3;
      int LengthMax=10;
      int LengthMin=0;
      int sizeArray=100;
      string[] arr=genarateArrayString(sizeArray,LengthMin,LengthMax);
      WriteArrayString(arr);
      Console.WriteLine("\n"+count_if(arr,sortLength));
      WriteArrayString(array_if(arr,sortLength));
    
  }
  static int count_if(string[] arr,int size)
  {
      int count=0;
      foreach(string s in arr)
      {
          count+=(s.Length<=size)?1:0;
      }
      return count;
  }
  static char GetLetter()
{
    string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    Random rand = new Random();
    int num = rand.Next(0, chars.Length);
    return chars[num];
}
  static string generateRandomStringWithSize(int size)
  {
      string s = "";
      for(int i=0;i<size;++i)
      {
          s+=GetLetter();
      }
      return s;
  }
  static string generateRandomString(int minSize,int maxSize)
  {
      return generateRandomStringWithSize(new Random().Next(minSize, maxSize + 1));
  }
  static string[] genarateArrayString(int arraySize,int minLenght,int maxLenght)
  {
      string[] arrayString=new string[arraySize];
      for(int i=0;i<arraySize;++i)
      {
          arrayString[i]=generateRandomString(minLenght,maxLenght);
      }
      return arrayString;
  }
  static void WriteString(string s)
  {
      Console.Write("\""+s+"\"");
  }
  static void WriteArrayString(string[] arrayString)
  {
      Console.Write("[");
      WriteString(arrayString[0]);
      for(int i=1;i<arrayString.Length;++i)
      {
          Console.Write(", ");
          WriteString(arrayString[i]);
      }
      Console.Write("]");
  }
     static string[] array_if(string[] arr,int size)
  {
      string[] result=new string[count_if(arr,size)];
      int index=0;
      foreach(string s in arr)
      {
          if(s.Length<=size)
          {
              result[index++]=s;
          }
      }
      return result;
  }
}

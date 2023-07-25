using System;
class HelloWorld {
  static void Main() {
      string[] arr=genarateArrayString(100,0,10);
      WriteArrayString(arr);
    
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
}

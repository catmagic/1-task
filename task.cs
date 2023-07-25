using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine(generateRandomString(0,10));
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
}

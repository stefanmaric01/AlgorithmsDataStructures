//static String reverse(string s)
//{

//    int left = 0;
//    int right = s.Length - 1;
//    char[] reversed = new char[s.Length];

//    while (left < s.Length)
//    {
//        reversed[left++] = s[right--];
//    }

//    Console.WriteLine(reversed);
//    return reversed.ToString();
//}

//reverse("Stefan");

static string isAnagram (string a, string b)
{

    if (a.Length != b.Length)
    {
       
        return "Is not anagram";

    }

    char[] aChar = a.ToLower().ToCharArray();
    char[] bChar = b.ToLower().ToCharArray();

    Array.Sort(aChar);
    Array.Sort(bChar);

   return aChar.SequenceEqual(bChar) ? "IsAnagram" : "Is not Anagram";

}
isAnagram("Ana", "naa");

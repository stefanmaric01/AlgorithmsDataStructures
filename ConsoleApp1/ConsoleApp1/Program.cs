static String reverse(string s)
{

    int left = 0;
    int right = s.Length - 1;
    char[] reversed = new char[s.Length];

    while (left < s.Length)
    {
        reversed[left++] = s[right--];
    }

    Console.WriteLine(reversed);
    return reversed.ToString();
}

reverse("Stefan");

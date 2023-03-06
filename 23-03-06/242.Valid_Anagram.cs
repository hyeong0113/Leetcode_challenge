public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        char[] sList = s.ToArray();
        char[] tList = t.ToArray();
        Array.Sort(sList);
        Array.Sort(tList);

        for(int i = 0; i < t.Length; i++)
        {
            if(sList[i] != tList[i])
            {
                return false;
            }
        }


        return true;
    }
}

public class Solution {
    public boolean isAnagram(String s, String t) {
        int[] alphabet = new int[26];
        for (int i = 0; i < s.length(); i++) alphabet[s.charAt(i) - 'a']++;
        for (int i = 0; i < t.length(); i++) alphabet[t.charAt(i) - 'a']--;
        foreach (int i in alphabet) if (i != 0) return false;
        return true;
    }
}
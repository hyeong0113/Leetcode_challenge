public class Solution {
    /*
    * @title: Return list of groups which have similar anagrams.
    * @precondition: Array of string should be given.
    * @postcondition: Return list of groups which have similar anagrams.
    * @description:
    *             Declare results as a Dictionary which key is anagram key(explained in further steps) and list of string.
    *             Declare alphabets to validate a similar anagram.
    *             Iterate all words in strs.
    *               Fill all elements in strs with 0.
    *               During for loop, record an occurrence of letters in the word.
    *               During for loop, create an anagram key of the word.
    *               Store the anagram key and the word into the dictionary. If the key exists, append the word to the list.
    *             During for loop, convert the results to list.
    *             Return the list.
    * @param:
    *         strs: string[]
    * @return:
    *         IList<IList<string>>
    * @time complexity:
    *         O(nk): since running a for loop with a length of strs, n, then running a for loop inside a length of word in strs, k.
    * @space complexity:
    *         O(nk): since the result stores all words, n spaces, and length of different anagram, k.
    */ 
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IDictionary<string, List<string>> results = new Dictionary<string, List<string>>();
        int[] alphabets = new int[26];

        foreach(var word in strs)
        {
            Array.Fill(alphabets, 0);
            for(int i = 0; i < word.Length; i++)
            {
                alphabets[word[i]-'a']++;
            }

            StringBuilder keyBuild = new StringBuilder();
            for(int i = 0; i < alphabets.Length; i++)
            {
                keyBuild.Append("#");
                keyBuild.Append(alphabets[i].ToString());
            }

            string key = keyBuild.ToString();
            if(!results.ContainsKey(key))
            {
                List<string> temp = new List<string>();
                temp.Add(word);
                results.Add(key, temp);
            }
            else
            {
                results[key].Add(word);
            }
        }

        IList<IList<string>> converted = new List<IList<string>>();
        foreach(var elem in results)
        {
            converted.Add(new List<string>(elem.Value));
        }
        return converted;
    }
}
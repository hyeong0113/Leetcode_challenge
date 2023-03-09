public class Solution {
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
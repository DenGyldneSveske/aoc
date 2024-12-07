namespace aoc.Day01
{
    public class SimilarityScore
    {
        public static int CalculateSimilartyScore()
        {
            Dictionary<int, int> vistitedValues = new Dictionary<int, int>();
            int similarityScore = 0;
            string input;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            using (StreamReader reader = new StreamReader("C:\\Users\\rasmu\\Desktop\\aoc\\aoc\\Day01\\input.txt"))
            {
                while ((input = reader.ReadLine()) != null)
                {
                    var frags = input.Split(" ");
                    list1.Add(int.Parse(frags[0]));
                    list2.Add(int.Parse(frags[3]));
                }
            }

            foreach (var number in list1)
            {
                if (vistitedValues.ContainsKey(number))
                {
                    similarityScore += (number * vistitedValues[number]);
                    continue;
                }
                int count = 0;
                foreach (var num in list2)
                {
                    if (num == number)
                    {
                        count++;
                    }
                }
                vistitedValues.Add(number, count);
                similarityScore += (number * count);
            }
            return similarityScore;
        }
    }
}

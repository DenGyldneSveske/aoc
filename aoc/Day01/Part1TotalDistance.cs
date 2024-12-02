namespace aoc.Day01
{
    public class Part1TotalDistance
    {
        public static int CalculateDistance()
        {
            string input;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            using (StreamReader reader = new StreamReader("C:\\Users\\rasmu\\Desktop\\aoc\\aoc\\Day01\\inputPart1.txt"))
            {
                while ((input = reader.ReadLine()) != null)
                {
                    var frags = input.Split(" ");
                    list1.Add(int.Parse(frags[0]));
                    list2.Add(int.Parse(frags[3]));
                }
            }

            int totalDistance = 0;
            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                totalDistance += list1[i] < list2[i] ? list2[i] - list1[i] : list1[i] - list2[i];
            }

            return totalDistance;
        }
    }
}

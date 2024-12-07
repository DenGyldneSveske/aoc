namespace aoc.Day02
{
    public class SafeReports
    {
        public static int CalculateSafeReports()
        {
            string input;
            int safeReports = 0;

            using (StreamReader reader = new StreamReader("C:\\Users\\rasmu\\Desktop\\aoc\\aoc\\Day02\\input.txt"))
            {
                while ((input = reader.ReadLine()) != null)
                {
                    bool increase = false;
                    List<int> list = new List<int>();
                    var numbers = input.Split(" ");
                    foreach (var item in numbers)
                    {
                        list.Add(int.Parse(item));
                    }

                    increase = list[0] < list[1];

                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        if (increase)
                        {
                            if (list[i] < list[i + 1] && list[i + 1] - list[i] >= 1 && list[i + 1] - list[i] <= 3 && i == list.Count - 2)
                            {
                                safeReports++;
                            }
                            else if (list[i] < list[i + 1] && list[i + 1] - list[i] >= 1 && list[i + 1] - list[i] <= 3)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (list[i] > list[i + 1] && list[i] - list[i + 1] >= 1 && list[i] - list[i + 1] <= 3 && i == list.Count - 2)
                            {
                                safeReports++;
                            }
                            else if (list[i] > list[i + 1] && list[i] - list[i + 1] >= 1 && list[i] - list[i + 1] <= 3)
                            {

                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return safeReports;
        }
    }
}

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courseList = new Dictionary<string, string>();
            string readCourseInfo;
            while ((readCourseInfo = Console.ReadLine()) != "end of contests")
            {
                string[] courseInfo = readCourseInfo.Split(":");
                string courseName = courseInfo[0];
                string coursePassword = courseInfo[1];
                if (!courseList.ContainsKey(courseName))
                {
                    courseList.Add(courseName, coursePassword);
                }
            }
            SortedDictionary<string, Dictionary<string, int>>
              studentMembers = new SortedDictionary<string, Dictionary<string, int>>();
            string readStudentInfo;
            while ((readStudentInfo = Console.ReadLine()) != "end of submissions")
            {
                string[] studentInfo = readStudentInfo.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string courseName = studentInfo[0];
                string coursePassword = studentInfo[1];
                string studentName = studentInfo[2];
                int points = int.Parse(studentInfo[3]);
                if (courseList.ContainsKey(courseName) && courseList[courseName].Contains(coursePassword))
                {
                    if (!studentMembers.ContainsKey(studentName))
                    {
                        studentMembers[studentName] = new Dictionary<string, int>();
                        studentMembers[studentName].Add(courseName, 0);
                    }
                    if (!studentMembers[studentName].ContainsKey(courseName))
                    {
                        studentMembers[studentName].Add(courseName, 0);
                    }
                    if (studentMembers[studentName][courseName] < points)
                    {
                        studentMembers[studentName][courseName] = points;
                    }

                }
            }
            string bestName = string.Empty;
            int bestPoint = 0;
            int sumPoint = 0;
            foreach (var item in studentMembers)
            {
                foreach (var studentName in item.Value)
                {
                    string curentName = studentName.Key;
                    sumPoint += studentName.Value;
                    if (sumPoint > bestPoint)
                    {
                        bestPoint = sumPoint;
                        bestName = item.Key;
                    }
                }
                sumPoint = 0;
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestPoint} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in studentMembers)
            {
                Console.WriteLine(item.Key);
                foreach (var studentName in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {studentName.Key} -> {studentName.Value}");
                }
            }
        }
    }
}
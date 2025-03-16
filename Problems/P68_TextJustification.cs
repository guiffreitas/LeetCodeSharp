using LeetCodeSharp.Interfaces;
namespace LeetCodeSharp.Problems
{
    //Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully(left and right) justified.
    //You should pack your words in a greedy approach; that is, pack as many words as you can in each line.
    //Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.
    //Extra spaces between words should be distributed as evenly as possible.If the number of spaces on a line does not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.
    //For the last line of text, it should be left-justified, and no extra space is inserted between words.
    class P68_TextJustification : IProblem
    {
        public void Run()
        {
            var words = new string[] { "What", "must", "be", "acknowledgment", "shall", "be" };

            var maxWidth = 16;

            var result = FullJustify(words, maxWidth);
        }

        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            var lines = new List<Line>();
            int currLine = -1;

            for (int i = 0; i < words.Length; i++)
            {
                if ((currLine == -1 && i == 0) || lines[currLine].Length() + words[i].Length + 1 > maxWidth)
                {
                    lines.Add(new Line());
                    currLine++;
                    lines[currLine].LineWords.Add(words[i]);
                }
                else
                {
                    lines[currLine].LineWords.Add(" " + words[i]);
                }
            }

            var result = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                if (i == lines.Count - 1)
                {
                    while (lines[i].Length() < maxWidth)
                    {
                        lines[i].LineWords[^1] += " ";
                    }
                }

                int currWord = 1;

                if (lines[i].LineWords.Count == currWord)
                {
                    while (lines[i].Length() < maxWidth)
                    {
                        lines[i].LineWords[^1] += " ";
                    }
                }
                else
                {
                    while (currWord < lines[i].LineWords.Count && lines[i].Length() < maxWidth)
                    {
                        lines[i].LineWords[currWord] = " " + lines[i].LineWords[currWord];
                        currWord++;
                        if (currWord >= lines[i].LineWords.Count)
                        {
                            currWord = 1;
                        }
                    }
                }

                result.Add(string.Concat(lines[i].LineWords));
            }

            return result;
        }

        public class Line
        {
            public List<string> LineWords;

            public Line()
            {
                LineWords = [];
            }

            public int Length()
            {
                return LineWords.Sum(x => x.Length);
            }
        }
    }
}

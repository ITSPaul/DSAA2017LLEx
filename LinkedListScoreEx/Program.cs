using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListScoreEx
{
    public class Score
    {
        public string PlayerName;
        public int score;

        public override string ToString()
        {
            return PlayerName + " " + score.ToString();
        }
    }

    class Program
    {
        static LinkedList<Score> ScoreBoard = new LinkedList<Score>();
        static void Main(string[] args)
        {
            
            Insert(new Score { PlayerName = "Fred", score = 20 });
            Insert(new Score { PlayerName = "Fred", score = 30 });
            foreach (var item in ScoreBoard)
            {
                print(item);
            }
            Console.ReadLine();
        }

        private static void print<T>(T obj)
        {
            Console.WriteLine("Object {0}, Value {1}", obj.GetType(), obj.ToString());
        }

        private static void Insert(Score PlayerScore)
        {
            if (ScoreBoard.Count < 1)
                ScoreBoard.AddFirst(PlayerScore);
            else
            {
                LinkedListNode<Score> node = ScoreBoard.First;
                while (node != null)
                {
                    if (PlayerScore.score > node.Value.score)
                        break;
                    else node = node.Next;
                }
                if (node != null)
                    ScoreBoard.AddBefore(node, PlayerScore);
                else ScoreBoard.AddAfter(node, PlayerScore);
            }
        }
    }
}

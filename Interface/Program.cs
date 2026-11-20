using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPlayer
    {
        void play();

       

        void Pause();
        void Stop();
    }
    public class clsVideoPlayer:IPlayer
    {
        public void play()
        {
            Console.WriteLine("hey  3andek a 7aleb ");
        }
        public void Pause()
        {
            Console.WriteLine(" video pause");
        }
        public void Stop()
        {
            Console.WriteLine(" video stop ");
        }
    }
    public class clsMusicPlayer : IPlayer
    {
        public void play()
        {
            Console.WriteLine("love youuuuuuuuuu");
        }
        public void Pause()
        {
            Console.WriteLine(" music pause");
        }
        public void Stop()
        {
            Console.WriteLine(" music stop ");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

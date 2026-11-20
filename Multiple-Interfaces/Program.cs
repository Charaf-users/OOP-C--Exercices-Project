using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interfaces
{
    public interface Iconnect
    {
        void ConnectToWifi();
        
    }
    public interface  ICamera
    {
        void TakePhoto();
    }
    public interface IMedia
    {
        void PlayMusic();
    }

    public class SmartPhone:Iconnect,ICamera,IMedia
    {
        public void ConnectToWifi()
        {
            Console.WriteLine(" your device is connecting to wifi");
        }
        public void TakePhoto()
        {
            Console.WriteLine("opening camera ");
            Console.WriteLine("Photo captured");
        }
        public void PlayMusic()
        {
            Console.WriteLine("playing music ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numSong = int.Parse(Console.ReadLine());
           List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] curentInput = Console.ReadLine().Split("_",StringSplitOptions.RemoveEmptyEntries);

                string typeList = curentInput[0];
                string name = curentInput[1];
                string time = curentInput[2];

                Song song = new Song(typeList,name,time);      
                songs.Add(song);
              
            }
            string list = Console.ReadLine();
          
            for (int i = 0;i < songs.Count;i++)
            {
                Song curentSong = songs[i];
                if (list == "all")
                {
                    Console.WriteLine(curentSong.Name);
                }
                else if(list == curentSong.TypeList)
                {
                    Console.WriteLine(curentSong.Name);
                }
              
              
               
            }
  
            
        }
    }
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}

/*
You are a music DJ and you need to insert a new song into a playlist. The playlist is 
represented as a list of song titles. You want to insert the song "Happy" at the 3rd 
position in the playlist. Additionally, you want to insert a range of songs from another 
playlist into the original playlist. 
*/

using System;
using System.Collections.Generic;
class Task3{
    static void Main(){
        List<string> playlist = new List<string>{
            "Song A","Song B","Song C"
        };
         playlist.Insert(2, "Happy");
         List<string> otherPlaylist = new List<string>{
             "New Song A", "New Song B", "New Song C"
         };
        playlist.InsertRange(3, otherPlaylist);
        foreach (string song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}
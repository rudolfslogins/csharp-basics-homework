using System;
using System.Collections.Generic;

namespace VideoStore
{
    public class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>(); 
        }

        public void AddNewVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void CheckOut(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title )
                    if (!video.Avalable())
                    {
                        Console.WriteLine("Not available!");
                    }
                    else
                    {
                        video.BeingCheckedOut();
                    }
            }
        }

        public void ReturnVideoToStore(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    if (video.Avalable())
                    {
                        Console.WriteLine("Cant return not rented video");
                    }
                    else
                    {
                        video.BeingReturned();
                    }

                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceivingARaiting(rating);
                }
                
            }
        }

        public void ListInventory()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Be Alright";
        video1._length = "199";
        video1._author = "Dean Lewis";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Geeselikecheese";
        video1Comment1._commentText = "I love this song!";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "bnoo3697";
        video1Comment2._commentText = "i come back to this song and video a lot.";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "thevibeguide";
        video1Comment3._commentText = "Hands down the best song of 2018! Can't stop listening!";

        Video video2 = new Video();
        video2._title = "Golden Hour";
        video2._length = "232";
        video2._author = "JVKE";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Jnnose";
        video2Comment1._commentText = "I use to be a fan, but after hearing this masterpiece, I'm a whole air conditioner";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Dinasdinos";
        video2Comment2._commentText = "Excellent video!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Toricarlson";
        video2Comment3._commentText = "I can never get tired of this song! It's sooo beautifulll!!!";

        Video video3 = new Video();
        video3._title = "If We Have Each Other";
        video3._length = "181";
        video3._author = "Alec Benjamin";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Jessecarter";
        video3Comment1._commentText = "his lyrics are always so deep and meaningful, I love his music so much!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Ecosm";
        video3Comment2._commentText = "Someone please like my comment so i can come back to this video and watch it again!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Chrisverylow";
        video3Comment3._commentText = "Alec is definitely one of my top favorite artists!";



        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);


        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}
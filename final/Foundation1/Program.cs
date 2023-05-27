using System;

class Program
{
    static void Main(string[] args)
    {
           List<Video> videoList = new List<Video>();
        videoList.Add(new Video("Video 1","Nauel Gonzalez",135 ));
        videoList.Add(new Video("Video 2","Rodrigo Gonzalez",16));
        videoList.Add(new Video("Video 3","Anonymous",1653));
        videoList.Add(new Video("Video 4","NG",462));

        videoList[0].AddComment(new Comment("It's a me, Mario", "Mario"));
        videoList[0].AddComment(new Comment("May the Force be with you.", "Anakin S."));
        videoList[0].AddComment(new Comment("It's alive! ", "Dr. Frankie"));
        videoList[0].AddComment(new Comment("My precious", "Gollum"));

        videoList[1].AddComment(new Comment("Hasta la vista, baby", "Model 101"));
        videoList[1].AddComment(new Comment("Chewie, we’re home.", "Han Solo"));
        videoList[1].AddComment(new Comment("I'm going to make him an offer he can't refuse", "Don Corleone"));
        videoList[1].AddComment(new Comment("Mama always said life was like a box of chocolates. You never know what you're gonna get.", "Forrest"));

        videoList[2].AddComment(new Comment("Toto, I've got a feeling we're not in Kansas anymore.", "Dorothy"));
        videoList[2].AddComment(new Comment("We'll always have Paris", "Rick"));
        videoList[2].AddComment(new Comment("Houston, we have a problem.", "John Swigert"));
        videoList[2].AddComment(new Comment("I am Groot", "Groot"));

        videoList[3].AddComment(new Comment("E.T. phone home", "ET"));
        videoList[3].AddComment(new Comment("Wilson!!!", "Chuck Nolan"));
        videoList[3].AddComment(new Comment("I am Iron Man.", "Tony Stark"));
        videoList[3].AddComment(new Comment("To infinity…and beyond!", "Buzz Lightyear"));

    foreach (Video v in videoList){
        v.Display();
    }
    }
}
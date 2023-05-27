class Video{

private string _title;
private string _author;
private int _lenght;
private List<Comment> _comments = new List<Comment>();

public Video(string title, string author, int lenght){
    _title= title;
    _author= author;
    _lenght = lenght;

}
public void AddComment(Comment comment) {
    _comments.Add(comment);
}

public void Display(){
   Console.WriteLine($"Title: '{_title}', Author: {_author}, lenght: {_lenght}");
   Console.WriteLine($"The video as a total of {_comments.Count} comments. Here's the list:");
   foreach (Comment c in _comments){
        c.Display();
   }
}


}
class Comment{
    private string _comment;
    private string _person;


public Comment(string comment, string person){
    _comment  = comment;
    _person = person;


}
public void Display(){

    Console.WriteLine($"     {_person} commented: {_comment}");

}


}

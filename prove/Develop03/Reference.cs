

using System;

class Reference
{

    private string _book;
    private string _chapter;
    private int _start;
    private int _end;
    
    public  Reference(string book, string chapter, int start){
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = -1;
    }
    public  Reference(string book, string chapter, int start, int end){
         _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }
    
    public string GetReference(){
        if (_end >= _start) //this prevents wrong end verses
            return _book + " "+ _chapter + ":" + _start.ToString()+"-" +_end.ToString();  
        else 
            return _book + " "+ _chapter + ":" + _start.ToString();  
    }
    
    public void DisplayReference(){

        Console.WriteLine(GetReference());
    }
    
}

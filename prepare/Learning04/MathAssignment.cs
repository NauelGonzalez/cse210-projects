

class MathAssignment : Assignment {

    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base (studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return _textBookSection + " " + _problems;
    }

    public void SetTextBookSection(string TextBookSection){
        _textBookSection = TextBookSection;
    }
    public void SetProblems(string Problems){
        _problems = Problems;
    }

    public string GetTextBookSection(){
        return _textBookSection;
    }
    public string GetProblems(){
        return _problems;
    }
}
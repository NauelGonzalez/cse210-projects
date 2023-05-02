

public class Fraction
{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;

    }
    public Fraction(int top)

    {
        _bottom = 1;
        _top = top;
    }
    public Fraction(int top, int bottom)

    {
        _bottom = bottom;
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
         _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom= bottom;
    }

    public string GetFractionString(){
        return _top.ToString() + "/" + _bottom.ToString();

    }

    public decimal GetDecimalValue (){
        return Convert.ToDecimal(_top)/Convert.ToDecimal(_bottom);
    }

}
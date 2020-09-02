public class Solution
{
    public bool IsNumber (string s)
    {
        s = s.Trim ();
        if (string.IsNullOrEmpty (s))
        {
            return false;
        }

        Status status = Status.Start;

        foreach (char c in s)
        {
            if (GetType (c) == CharType.Illegal)
            {
                return false;
            }
            switch (status)
            {
                case Status.Start:
                    if (GetType (c) == CharType.Symbol)
                    {
                        status = Status.Symbol;
                    }
                    else if (GetType (c) == CharType.Point)
                    {
                        status = Status.StartPoint;
                    }
                    else if (GetType (c) == CharType.Number)
                    {
                        status = Status.Number;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.Number:
                    if (GetType (c) == CharType.Number)
                    {
                        break;
                    }
                    else if (GetType (c) == CharType.E)
                    {
                        status = Status.E;
                    }
                    else if (GetType (c) == CharType.Point)
                    {
                        status = Status.Point;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.Symbol:
                    if (GetType (c) == CharType.Number)
                    {
                        status = Status.Number;
                    }
                    else if (GetType (c) == CharType.Point)
                    {
                        status = Status.StartPoint;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.Point:
                    if (GetType (c) == CharType.Number)
                    {
                        break;
                    }
                    else if (GetType (c) == CharType.E)
                    {
                        status = Status.E;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.E:
                    if (GetType (c) == CharType.Number)
                    {
                        status = Status.ENumber;
                    }
                    else if (GetType (c) == CharType.Symbol)
                    {
                        status = Status.ESymbol;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.ESymbol:
                    if (GetType (c) == CharType.Number)
                    {
                        status = Status.ENumber;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.ENumber:
                    if (GetType (c) == CharType.Number)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case Status.StartPoint:
                    if (GetType (c) == CharType.Number)
                    {
                        status = Status.Point;

                    }
                    else
                    {
                        return false;
                    }
                    break;
            }

        }

        if (status == Status.Symbol || status == Status.ESymbol || status == Status.StartPoint || status == Status.E)
        {
            return false;
        }

        return true;
    }

    public enum CharType
    {
        Number,
        E,
        Symbol,
        Point,
        Illegal
    }

    public CharType GetType (char c)
    {
        if ('0' <= c && c <= '9')
        {
            return CharType.Number;
        }

        if (c == '.')
        {
            return CharType.Point;
        }

        if (c == 'E' || c == 'e')
        {
            return CharType.E;
        }

        if (c == '+' || c == '-')
        {
            return CharType.Symbol;
        }

        return CharType.Illegal;
    }
    public enum Status
    {
        Start,
        StartPoint,
        Symbol,
        Number,
        Point,
        E,
        ESymbol,
        ENumber,
    }
}

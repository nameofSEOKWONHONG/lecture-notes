namespace Variables;

public class CconditionTypes
{
    public void Run()
    {
        var n = 1;
        var condition = 2;

        #region [basic]

        if (n == condition)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        if (n == 1)
        {
            Console.WriteLine("input is 1");
        }
        else if (n == 2)
        {
            Console.WriteLine("input is 2");
        }
        else
        {
            Console.WriteLine("not matched");
        }

        var s = "A";
        switch (s)
        {
            case "A" : Console.WriteLine(s);
                break;
            case "B" : Console.WriteLine(s);
                break;
            case "C" : Console.WriteLine(s);
                break;
            default: Console.WriteLine("not matched");
                break;
        }

        #endregion


        #region [advance]

        var state = "A";

        if (state == "A")
        {
            
        }

        if (state == "B")
        {
            
        }

        CONTINUE:
        if (state == "A")
        {
            goto CONTINUE;
        }

        switch (state)
        {
            case "A":
                case "B":
                Console.WriteLine("Matched");
                break;
                
                case "C": Console.WriteLine("Not matched.");
                    break;
                
                default:Console.WriteLine("default");
                    break;
        }

        #endregion
    }
}
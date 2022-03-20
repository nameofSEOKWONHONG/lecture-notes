namespace Variables;

public class StringType
{
    public void Run()
    {
        /*
         * char는 하나의 문자를 의미 합니다. 기본 2byte입니다.
         * string은 char[]의 집합입니다. 따라서 string lenght * char byte(2byte) 입니다.
         * string클래스는 특이한 자료형입니다.
         * 선언과 사용이 값형식이지만 사용법은 참조형식처럼 보입니다.
         * 꼭 기억해야 할 건 String은 값형식이라는 거.
         */
        char ch = 'h';
        Console.WriteLine($"char:{ch}");

        char[] chItems = new[] { 'h', 'e', 'l', 'l', 'o' };
        Console.WriteLine($"char array:{chItems}");
        Console.WriteLine($"char array:{String.Join('_', chItems)}");

        String str = "hello";
        Console.WriteLine($"string:{str}");
        str = str + " " + "world";
        Console.WriteLine($"string:{str}");

        String newStr = str;
        newStr = newStr + "!";
        Console.WriteLine($"origin str:{str}");
        Console.WriteLine($"new str:{newStr}");
    }
}
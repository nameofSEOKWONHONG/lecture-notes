namespace Variables;

public class ClassType
{
    public void Run()
    {
        //클래스 선언1
        var oHello = new Hello();
        var oWorld = new World();
        Console.WriteLine($"result:{oHello.Name}, {oWorld.Name}");
        
        //클래스 선언2
        var nHello = new Hello("hello");
        var nWorld = new World("world");
        Console.WriteLine($"result:{nHello.Name}, {nWorld.Name}");
        
        //참조형식이란 (reference type)
        var refHello = oHello; //oHello.Name == "Hello";
        refHello.Name = "Hello Hello"; //oHello.Name = "Hello Hello";
        Console.WriteLine($"oHello:{oHello.Name}");
        Console.WriteLine($"refHello:{refHello.Name}");
        
        /*
         * 모든 클래스는 참조형식이다.
         * 힙에 생성되는 메모리형은 참조형식이다.
         * 모든 클래스의 멤버변수는 참조형식이다.
         */
        
        //소멸자 확인 위해 선언
        GC.Collect();
    }
}

public class Hello
{
    public string Name;

    /// <summary>
    /// 초기가 없는 생성자 선언
    /// </summary>
    public Hello()
    {
        this.Name = "Hello";
        Console.WriteLine($"create {nameof(Hello)}");
    }
    
    /// <summary>
    /// 초기화가 있는 생성자 선언
    /// </summary>
    /// <param name="name">초기화 변수</param>
    public Hello(string name):this()
    {
        this.Name = name;
    }

    /// <summary>
    /// 객체의 소멸자
    /// </summary>
    ~Hello()
    {
        Console.WriteLine($"destroy {nameof(Hello)}");
    }
}

public class World
{
    public string Name;

    public World()
    {
        this.Name = "World";
        Console.WriteLine($"create {nameof(World)}");
    }

    public World(string name):this()
    {
        this.Name = name;
    }

    ~World()
    {
        Console.WriteLine($"destroy {nameof(World)}");
    }
}
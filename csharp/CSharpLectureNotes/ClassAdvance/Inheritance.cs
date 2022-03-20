namespace ClassAdvance;

public class Inheritance
{
    public void Run()
    {
        /*
         * 프로그래밍에서 클래스란 어떤 기능의 집합을 의미한다.
         * 클래스 내부에는 변수를 선언할 수 있고 함수를 선언할 수 있다.
         * 클래스 내부에 선언한 변수를 멤버변수라고 하는데 멤버변수는 해당 클래스 내부에서 동작하도록 할 수 있고
         * 외부에 노출할 수도 있다. (격리화를 알아야 이해됨)
         * 클래스의 멤버 함수는 클래스의 기능을 의미한다.
         * 클래스는 기본적으로 클래스 단일 원칙이라고 하는 원칙이 중요한데
         * 클래스를 만들때 클래스의 기능이 하나의 기능만을 동작시켜야 한다는 의미이다.
         * 만역 Point라는 클래스는 선언했다고 한다면 Point는 좌표를 관리하는 클래스라는 것을 의미해야 하는 것이지
         * Point가 문자열 관리라든지 화면에 표시하는 기능까지 관리해서는 안된다.
         * 따라서 프로그래밍은 각 부품의 조합으로 동작하도록 해야 하며
         * 많은 예가 레고를 예로 사용한다.
         *
         * 이는 OOP언어들이 지향하는 방향으로 재사용성등을 극대화하기 위해 모듈화 하는 과정을 의미한다.
         * 최근에 Functional Programing 언어들은 OOP의 한계를 인식하고 OOP의 극복이 아닌
         * 대체제로 만들어 졌으며 OOP의 복잡성을 탈피하기 위해서 만들어 졌다.
         *
         * 프로그래밍 언어에서 OOP가 좋다, Functional이 좋다는 무의미한 논쟁이다.
         * 서로 사용하고자 하는 목적이 상이하기 때문이다.
         * Functional이 일반적 사용자를 대상으로하고 사용하기 쉽게 하기 위해 만들어진 반면
         * OOP는 프로그램 아키텍쳐를 구성하는 것에 가깝다.
         */
        Person person = new Person();
        person.Eat();

        Student student = new Student();
        student.Eat();

        Teacher teacher = new Teacher();
        teacher.Eat();

        person = student;
        person.Eat();
        
        //error
        //student = person;
        
        student.Study();
        teacher.Teach();
    }
}

/// <summary>
/// 인간에 대한 기초 클래스
/// </summary>
public class Person
{
    public Person()
    {
        Console.WriteLine($"I'm {nameof(Person)}");
    }

    /// <summary>
    /// 함수란 클래스 내부에서 특정 행위를 의미함.
    /// </summary>
    public void Eat()
    {
        Console.WriteLine($"{this.GetType().Name} eat");
    }
}

/// <summary>
/// 인간을 상속받은 학생
/// </summary>
public class Student : Person
{
    public Student()
    {
        Console.WriteLine($"I'm {nameof(Student)}");
    }

    public void Study()
    {
        Console.WriteLine("study");
    }
}

/// <summary>
/// 인간을 상속받은 선생
/// </summary>
public class Teacher : Person
{
    public Teacher()
    {
        Console.WriteLine($"I'm {nameof(Teacher)}");
    }

    public void Teach()
    {
        Console.WriteLine("teach");
    }
}
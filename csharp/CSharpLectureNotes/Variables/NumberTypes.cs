using System.Drawing;
using System.Runtime.InteropServices;

namespace Variables;

public class NumberTypes
{
    public void Run()
    {
        //c# variable explains

        //declare basically signed variable
        //from (-) to (+)
        int min = int.MinValue;
        int max = int.MaxValue;

        //unsigned variable
        //from (+) to (+)
        uint @uint_min = UInt32.MinValue;
        uint @uint_max = UInt32.MaxValue;

        Console.WriteLine("===================variable range(type of number)========================");
        Console.WriteLine($"int min:{min}, max:{max}");
        Console.WriteLine($"uint min:{uint_min}, max:{uint_max}");
        Console.WriteLine($"byte min:{byte.MinValue}, max:{Int16.MaxValue}");
        Console.WriteLine($"int16 min:{Int16.MinValue}, max:{Int16.MaxValue}"); //
        Console.WriteLine($"int32 min:{Int32.MinValue}, max:{Int32.MaxValue}");
        Console.WriteLine($"int64 min:{Int64.MinValue}, max:{Int64.MaxValue}");
        Console.WriteLine($"long min:{long.MinValue}, max:{long.MaxValue}");
        Console.WriteLine($"double min:{double.MinValue}, max:{double.MaxValue}");

        Console.WriteLine("===================size of variable(type of number)========================");
        Console.WriteLine($"int {sizeof(int)}");
        Console.WriteLine($"uint {sizeof(uint)}");
        Console.WriteLine($"byte {sizeof(byte)}");
        Console.WriteLine($"int16 {sizeof(Int16)}");
        Console.WriteLine($"int32 {sizeof(Int32)}");
        Console.WriteLine($"int64 {sizeof(Int64)}");
        Console.WriteLine($"long {sizeof(long)}");
        Console.WriteLine($"double {sizeof(double)}");

        Console.WriteLine("refer : https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/operators/sizeof");

        Console.WriteLine("===================char & string size========================");
        //char -> 2byte
        //char[] = string
        Console.WriteLine($"char {sizeof(char)}");
        var str = "Hello World";
        Console.WriteLine($"string {str.ToCharArray().Length * sizeof(char)}");
        long size=sizeof(char) * str.Length; 
        Console.WriteLine($"string {size}");


        Console.WriteLine("===================size of variable(unmanaged type)========================");
        Point p = new Point();
        p.X = 10;
        p.Y = 20;
        Console.WriteLine(Marshal.SizeOf(p));

        //왜 알아야 할까요?
        /*
        기본 자료형 중 값타입으로 사용되는 형들을 알아 보았습니다.
        값 형식들은 기본적으로 메모리상에 직접 할당되는 형태 입니다.
        따라서 스택에 할당되며 스택에 할당된다는 의미는 프로그램에서 가변적 자료형이 아님을 뜻 합니다.

        또한 숫자형 자료형의 경우 그 범위가 매우 중요합니다.

        예로 유튜브 좋아요 카운터가 있습니다.

        처음 유튜브가 만들어 졌을때 View 카운터는 자료형은 Int32 이었고
        유튜브가 운영되는 20년동안 1억 좋아요를 넘는 컨텐츠들이 나타났을 때 해당 카운터는 Int32에서 Int64(double)로 변경되게 됩니다.
        이처럼 시간이 지남에 따라 데이터 양이 지속적으로 증가하는 자료형에 대하여 주의할 필요가 있습니다.

        단, 무조건 최대 범위의 자료형이 좋냐고 한다면 그렇지 않습니다.
        시스템의 사양 및 예상 범위, 지속성, 퍼포먼스 등 다양한 이슈가 있습니다.
        따라서, 무조건 최대 자료형이라는 설정은 좋다고 할 수 없습니다.

        누군가 무조건 최대 범위를 강요한다면 그 사람이 범인입니다.
        */
    }
}
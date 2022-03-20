namespace Variables;

public class LoopTypes
{
    public void Run()
    {
        //init array (manually)
        var numberArray = new[] { 1, 2, 3, 4, 5 };
        
        //init array (auto)
        numberArray = Enumerable.Range(1, 5).ToArray();
        
        //basic
        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.WriteLine(numberArray[i]);
        }

        var n = 0;
        while (numberArray.Length > n)
        {
            Console.WriteLine(numberArray[n]);
            n++;
        }

        n = 0;
        do
        {
            Console.WriteLine(numberArray[n]);
            n++;
        } while (numberArray.Length > n);
        
        //advance
        foreach (var number in numberArray)
        {
            Console.WriteLine(number);
        }
        
        numberArray.ToList().ForEach(number =>
        {
            Console.WriteLine(number);
        });

        //foreach에서는 컬렉션(배열)의 크기를 직접 수정할 수 없습니다.
        try
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            list.ForEach(number =>
            {
                list.Add(6);
                Console.WriteLine(number);
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
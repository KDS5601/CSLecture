using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto문, 어셈블리에 가장 가까운 형태 아래의 다른 반복문도 이 형태로 번역하여 진행함
            int i = 0;
            FirstLabel:;
            Console.WriteLine(i++);
            if (i < 3)
            {
                goto FirstLabel;
            }

            //while 문
            int j = 0;
            while(j < 3)
            {
                Console.WriteLine(j++);
            }

            //for문
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(k);
            }

            //do-while문, while문
            int o = 1;
            while (o < 0)
            {
                Console.WriteLine("while문 실행");                
            }

            do
            {
                Console.WriteLine("Do-While문 실행");
            } while (o < 0);

            //while문은 실행되지 않고 do-while문은 실행됨

            //구구단 출력

        }
    }
}

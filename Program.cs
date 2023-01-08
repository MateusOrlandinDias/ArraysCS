using System;

namespace ArraysCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new int[5] {1,2,3,4,5};
            //int meuArray = new int[5];

            //->sintaxe for
            // for (int item = 0; item < meuArray.Length; item++)
            // {
            //     Console.WriteLine(meuArray[item]);
            // }

            //->sintaxe foreach
            // foreach (var item in meuArray)
            // {
            //     Console.WriteLine(meuArray[item-1]);
            // }

            /*
            Se atribuir um array a outro array, o array primario se torna referencia, ou seja, quando alterar o array
            que foi atribuido, altera o array o array original.

            O mesmo ocorre com o metodo clone
            */

            var arr = new int[4];
            var arrb = arr;
            var arrc = new int[4];
            arr.CopyTo(arrc, 0);
            arr[0] = 23;
            Console.WriteLine(arrb[0]);
            Console.WriteLine(arrc[0]);
            Console.WriteLine("-----");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication9
{
    /// <summary>
    /// 参照型（クラス）のリストと配列の初期化と列挙 その2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // プリミティブなListの初期化
            var intList = new List<int>() { 1, 2, 3 };
            // ちなみにvarを使わない場合はこちら
            // List<int> intList = new List<int> { 1, 2, 3 };
            // 以下のように宣言する事はできない(配列とは違う)
            // List<int> intList = { 1, 2, 3 };

            // プリミティブな配列の初期化
            var intList2 = new int[] { 4, 5, 6 };
            // ちなみにvarを使わない場合はこちら
            // int[] intList2 = { 4, 5, 6 };

            // 参照型のListの初期化
            var employees = new List<Employee>()
            {
                new Employee {Id = 1, Name = "ジョン" },
                new Employee {Id = 2, Name = "ジャック" }
            };

            // 参照型の配列の初期化
            var employees2 = new Employee[]
            {
                new Employee {Id = 3, Name = "ジョアンナ" },
                new Employee {Id = 4, Name = "ジュリア" }
            };

            // 表示用文字列の列挙を定義
            var intListStrings = intList.Select(i => $"item={i}");
            var intList2Strings = intList2.Select(i => $"item={i}");
            var employeesStrings = employees.Select(o => $"Id={o.Id}, Name={o.Name}");
            var employees2Strings = employees2.Select(o => $"Id={o.Id}, Name={o.Name}");

            // 更にこれらの定義をひとつの定義にまとめる
            var resultStrings = new[]
            {
                intListStrings,
                intList2Strings,
                employeesStrings,
                employees2Strings
            }.SelectMany(e => e);

            // で、最後に一気に表示する
            resultStrings.ForEach(Console.WriteLine);
            // ちなみにForEach拡張メソッドを使用しない場合はこちら
            // Console.WriteLine(string.Join("\n", resultStrings));

            // 結果を確認する為のお約束
            Console.WriteLine("\n\nPush any key!");
            Console.ReadKey();
        }
    }
}

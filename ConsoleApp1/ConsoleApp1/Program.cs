using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array ?
            //만들 때 미리 크기를 지정해야함
            // 추가하거나 삭제 할수없음. 크기가 고정됨
            //int[] arr = new int[3]; // int 형 공간 3개를 만든다 / arr[0] = 0, arr[1]=0, arr[2] = 0
            int[] arr = new int[] { 1, 2, 3 };//arr[0] = 1, ...

            // i++, ++i
            //전위, 후위 연산
            //i++ :i에다가 +1을 더한값을 반환
            //++i :i에다가 +1을 더한값을 반환
            //하지만 차이가 있다! 순서의 차이
            {
                int i = 0, j = 0;

                // i==1 을 비교한후 i에다가 +1
                if (i++ == 1) Console.WriteLine("i");
                // j에다가 +1한후 j == 1을 비교
                if (++j == 1) Console.WriteLine("j");
            }

            //배열의 크기
            //배열은 인덱스 접근이 가능(임의 접근이 가능)
            //int index == arr[0];
            int length = arr.Length;
            int result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            string[] strArrays = new string[] { "Banana", "Apple", "PineApple" };
            //Banana라는 이름의 인덱스 번호를 찾고 싶다 
            for (int i = 0; i < strArrays.Length; ++i)
            {
                if (strArrays[i].Equals("Banana"))
                    Console.WriteLine("index :" + i.ToString());
                    //Console.WriteLine($"index : {i.ToString()}");
            }

            result = Array.FindIndex(strArrays, x => x.Equals("Banana"));
            Console.WriteLine($"index: {result.ToString()}");

            // List?
            // 무언가를 담을 수 있는 클래스
            // 동적 할당 = new ...
            //<T>? 제너릭 형식. 아무거나 
            List<int> list = new List<int> { 1 };
            //list.Add(1);

            int[] arrays = new int[] { 2, 3, 4, 5 };
            list.AddRange(arrays);

            for(int i=0; i < list.Count; ++i)
            {
                Console.WriteLine($"{i.ToString()}");
            }

            int a = list.Find(x => x == 1);

            //list안에 값이 3인 녀석을 삭제
            list.Remove(3);

            //list 안에 list마지막에 있는 요소를 삭제
            list.RemoveAt(list.Count - 1);

            //list 안에 3인 녀석들을 모두 삭제 
            list.RemoveAll(x => x == 3);

            //list 안에 0번째 부터 시작하여 3개를 삭제 한다
            //ex : 0, 1, 2 가 삭제된다
            list.RemoveRange(0, 3);

            //중간 삽입 방법
            //0번째 인덱스에서 2라는 값을 삽입한다
            list.Insert(0, 2);

            // 사전?
            // 왼쪽을 Key(index), 오른쪽을 value(Value)
            // key 값을 이용해서 value 값을 받는다
            Dictionary<string, int> dic = new Dictionary<string, int>
            {
                { "A", 10},
                { "B", 20},
                { "C", 30}
            };

            if (dic.ContainsKey("A"))
                dic["A"]++; // "A"의 value값에 +1해준다

            //dic.Add("A", 10);
            //dic.Add("B", 20);

            result = dic["A"];
            foreach(KeyValuePair<string, int> v in dic)
            {
                Console.WriteLine($"Key :{v.Key}\nValue :{v.Value.ToString()}");
                //Console.WriteLine(string.Format("Key : {0}\nValue : {1}", v.Key, v.Value));
            }

            dic.Remove("A");
            if (dic.ContainsKey("A"))
            {
                Console.WriteLine("A 가 있어요!");
            }

            if(dic.ContainsValue(0))
            {
                Console.WriteLine("값이 0 인 개체가 있어요!");
            }

            if (dic.ContainsKey("A"))
                dic["A"] = 20;

        }

    }
}

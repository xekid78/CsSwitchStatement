# CsSwitchStatement
switch文（.NET Core）

## 処理
`Math.random()`関数を使用して1 ～ 6のランダムな数字を使って、おみくじの結果を出力します。

## コード
```
using System;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var omikuji = rand.Next(1, 6);

            switch (omikuji)
            {
                case 1:
                    Console.WriteLine("大吉");
                    break;
                case 2:
                    Console.WriteLine("中吉");
                    break;
                case 3:
                    Console.WriteLine("小吉");
                    break;
                case 4:
                    Console.WriteLine("吉");
                    break;
                case 5:
                    Console.WriteLine("凶");
                    break;
                default:
                    Console.WriteLine("大凶");
                    break;
            }
        }
    }
}
```

## 出力例  
```
大吉
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |

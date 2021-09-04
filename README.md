# csharp-operator-check

組み込み型にType.GetMethodsをしても、op_\*関数のMethodInfoを取得できないので作成

IntPtr,UIntPtrには対応していない

## OperatorChecker.cs
1つ、または2つの組み込み型同士で演算が可能かどうかを判定したり、演算した結果を返す関数を含むクラス

## csv/*.csv
C#の組み込み型と、それ同士の演算の結果が何になるかのリスト

a+b : 縦+横

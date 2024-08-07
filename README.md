# Cat-JP by C#
## 概要
このファイルはcatコマンドの日本語対応バージョンみたいなもの

のVisual Studio のプロジェクトファイルです。
## ビルド
まず、Visual Studio(以後VS)でCat-JP.sinを開き、そのままビルドします。

すると、実行ファイルが、\Cat-JP\Cat-JP\bin\Debug\に以下のように生成されます。
```
Debug
┣Cat-JP.exe
┣Cat-JP.exe.config
┣Cat-JP.pdb
```
そのうちの"Cat-JP.exe"を任意の場所にコピーし、使用することをお勧めします。

なお、"Cat-JP.exe.config","Cat-JP.pdb"は消去しても差し支えありません。
## 使い方
このプログラムは以下のようにして使用します
```
.\Cat-JP.exe {ファイル名}
```
すると、ファイルの中身がパスと共に表示されます。

また、終了する際には何かキーを押すことによって終了できます。

なお、毎回毎回実行ファイルのパスを指定するのが面倒な場合は、

System32などに実行ファイルを置いたり、環境変数の設定をするとよいです。
## 作者
Syobosyobonn

https://lit.link/Syobosyobonn

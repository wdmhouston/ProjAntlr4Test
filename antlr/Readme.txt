https://blog.csdn.net/weixin_52224421/article/details/124900287

antlr4 Hello.g4
javac Hello*.java
java org.antlr.v4.gui.TestRig Hello r -tree
java org.antlr.v4.gui.TestRig Hello r -gui

c#
java org.antlr.v4.Tool -Dlanguage=CSharp Hello.g4 -visitor

Nuget install antlr.runtime.standard 4.13.1 (remember to match version of antlr java library)

java org.antlr.v4.Tool -package ProjAntlr4Test.antlr -Dlanguage=CSharp Hello.g4 -visitor

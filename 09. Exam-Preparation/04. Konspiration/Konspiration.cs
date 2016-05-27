using System;
using System.Collections.Generic;
using System.Text;

class Konspiration
{
    public enum States { outsideMethod, methodSignature, methodBrackets, methodBody}
    static void Main()
    {
        int codeLines = int.Parse(Console.ReadLine());
        StringBuilder codeInput = new StringBuilder();
        for (int i = 0; i < codeLines; i++)
        {
            codeInput.AppendLine(Console.ReadLine());
        }
        string code = codeInput.ToString();

        States currentState = States.outsideMethod;
        int currentStateStartIndex = 0;
        List<string> methods = new List<string>();
        int signatureBracketsOpen = 0, methodBodyBrackets = 0, invokesBrackets = 0;
        List<string> currentInvokes = new List<string>();
        for (int i = 0; i < code.Length; i++)
        {
            if (currentState == States.outsideMethod && code[i] == 's')
            {
                string temp = code.Remove(0, i);
                temp = temp.Remove(6);
                if (temp == "static")
                {
                    currentState = States.methodSignature;
                    currentStateStartIndex = i;
                    i += 6;
                }
            }
            if (currentState == States.methodSignature && code[i] == '(')
            {
                int methodNameStartIndex = i;
                while (code[methodNameStartIndex] != ' ')
                {
                    methodNameStartIndex--;
                }
                methodNameStartIndex++;
                string temp = code.Remove(0, methodNameStartIndex);
                temp = temp.Remove(i - methodNameStartIndex);
                methods.Add(temp);
                //signatureBracketsOpen++;
                currentState = States.methodBrackets;
            }
            if (currentState == States.methodBrackets && code[i] == '(')
            {
                signatureBracketsOpen++;
            }
            if (currentState == States.methodBrackets && code[i] == ')')
            {
                signatureBracketsOpen--;
                if (signatureBracketsOpen == 0)
                {
                    int methodBodyStartIndex = i;
                    while(code[methodBodyStartIndex] != '{')
                    {
                        methodBodyStartIndex++;
                    }
                    i = methodBodyStartIndex;
                    currentState = States.methodBody;
                }
            }
            if (currentState == States.methodBody && code[i] == '{')
            {
                methodBodyBrackets++;
            }

            if (currentState == States.methodBody && code[i] == '(' && code[i-1] != ' ' && code[i-1] != '>')
            {
                int methodNameStartIndex = i;
                do
                {
                    methodNameStartIndex--;
                }
                while (code[methodNameStartIndex] != ' ' && code[methodNameStartIndex] != '.' && code[methodNameStartIndex] != '(');
                methodNameStartIndex++;
                string temp = code.Remove(0, methodNameStartIndex);
                temp = temp.Remove(i - methodNameStartIndex);
                currentInvokes.Add(temp);
                invokesBrackets++;
            }

            if (currentState == States.methodBody && code[i] == ')')
            {
                if (invokesBrackets > 0)
                {
                    invokesBrackets--;
                }
            }

            if (currentState == States.methodBody && code[i] == '}')
            {
                methodBodyBrackets--;
                if (methodBodyBrackets == 0)
                {
                    if (currentInvokes.Count > 0)
                    {
                        methods[methods.Count - 1] = methods[methods.Count - 1] + string.Format(" -> {0} -> {1}", currentInvokes.Count, string.Join(", ", currentInvokes));
                    }
                    else
                    {
                        methods[methods.Count - 1] = methods[methods.Count - 1] + " -> None";
                    }
                    currentInvokes.Clear();
                    currentState = States.outsideMethod;
                }
            }
        }

        for (int i = 0; i < methods.Count; i++)
        {
            Console.WriteLine(methods[i]);
        }
    }
}
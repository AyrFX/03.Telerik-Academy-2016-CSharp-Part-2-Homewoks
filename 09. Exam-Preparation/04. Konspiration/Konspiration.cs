using System;
using System.Collections.Generic;
using System.Text;

class Konspiration
{
    public enum States { outsideMethod, methodSignature, methodBody}
    static void Main()
    {
        int codeLines = int.Parse(Console.ReadLine());
        StringBuilder codeInput = new StringBuilder();
        for (int i = 0; i < codeLines; i++)
        {
            codeInput.AppendLine(Console.ReadLine());
        }
        string code = codeInput.ToString();

        bool afterStaticKeyword = false;
        States currentState;
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] == 's' && code.Remove(0, i).Remove(6) == "tatic")
            {
                currentState = States.methodSignature;
                i += 6;
            }
        }
    }
}
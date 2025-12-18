public bool IsValid(string s) {
    char first=s[0];
    if(s.Length==1||first==')'||first=='}'||first==']'||s.Length % 2 != 0) return false;

    Stack<char> stack = new Stack<char>();
    foreach (char c in s) {
        if (c == '(') stack.Push(')');
        else if (c == '[') stack.Push(']');
        else if (c == '{') stack.Push('}');
        else if (stack.Count == 0 || stack.Pop() != c) return false;
    }
    return stack.Count == 0;
}

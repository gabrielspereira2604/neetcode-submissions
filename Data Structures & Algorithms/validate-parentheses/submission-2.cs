public class Solution {
    public bool IsValid(string s) {
        if(s == null){
            return true;
        }

        var dict = new Dictionary<char, char> {
            {'[', ']'},
            {'(', ')'},
            {'{', '}'}
        };

        var arrayChars = s.ToCharArray();
        var stack = new Stack<char>();
        foreach(var parenthese in arrayChars){
            if(dict.ContainsKey(parenthese)){
                stack.Push(parenthese);
            }else{
                if(stack.Count == 0){
                    return false;
                }

                var first = stack.Pop();
                if(dict[first] != parenthese){
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}



/*
( - peek
- o proximo é abertura? sim
next
[ - peek
- o proximo é abertura? sim
next
{ - peek
- o proximo é abertura? não
} - peek
- é fechadura de {? sim
pop
pop



*/
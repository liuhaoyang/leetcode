
class 20200814 {
    public boolean isValid(String s) {
        if(s.length() % 2 != 0){
            return false;
        }
        Stack<Character> st = new Stack<Character>();
        for(char c: s.toCharArray()){
            if(c == '(') st.push(')');
            else if(c == '[') st.push(']');
            else if(c == '{') st.push('}');
            else if(st.isEmpty() || c!=st.pop()) return false;
        }
        return st.isEmpty();

    }
}
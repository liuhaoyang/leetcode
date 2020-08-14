class Solution {
    public boolean isValid(String s) {
        if(s==null || s.length() == 0){
            return true;
        }
        if(s.length() % 2 ==1){
            return false;
        }
        Map<Character,Character> map = new HashMap<>();
        map.put('}', '{');
        map.put(')', '(');
        map.put(']', '[');
        Stack<Character> stack = new Stack();
        for(char c:s.toCharArray()){
            if(map.containsKey(c)){
                if(stack.isEmpty() || stack.pop()!= map.get(c)){
                    return false;
                }
            } else{
                stack.push(c);
            }
        }
    
        return stack.isEmpty();
    }
}
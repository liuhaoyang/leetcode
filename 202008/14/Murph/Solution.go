func isValid(s string) bool {
    lennnn := len(s)
    if lennnn % 2 == 1 {
        return false
    }
    dic := map[byte]byte{
        ')': '(',
        ']': '[',
        '}': '{',
    }
    stack := []byte{}
    for i := 0; i < lennnn; i++ {
        if dic[s[i]] > 0 {
            if len(stack) == 0 || stack[len(stack)-1] != dic[s[i]] {
                return false
            }
            stack = stack[:len(stack)-1]
        } else {
            stack = append(stack, s[i])
        }
    }
    return len(stack) == 0
}
func reverseWords(s string) string {
	result := ""

	s1 := []rune(s)
	s1Len := len(s1)
	var s2 []rune

	start := 0
	end := 0
	for i := 0; i < s1Len; i++ {
		end = i
		if s1[i] == 32 || i == s1Len-1 {
			// worldLength := end - start
			j := end - 1
			if i == s1Len-1 {
				j = end
			}

			for ; j >= start; j-- {
				s2 = append(s2, s1[j])
			}
			if i != s1Len-1 {
				s2 = append(s2, 32)
			}

			start = i + 1
		}
	}

	result = string(s2)
	return result
}
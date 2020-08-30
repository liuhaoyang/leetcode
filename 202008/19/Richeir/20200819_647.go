func countSubstrings(s string) int {
	result := 0
	strInt := []rune(s)
	lenS := len(s)
	for i := 1; i <= lenS+1; i++ {
		for j := 0; j < lenS; j++ {
			if (i + j) <= lenS {
				temp := strInt[j : j+i]
				if isMirror(temp) {
					result++
				}
			} else {
				break
			}
		}
	}

	return result
}

func isMirror(str []rune) bool {
	lengthStr := len(str)

	if lengthStr == 1 {
		return true
	}

	for i := 0; i < lengthStr/2; i++ {
		if str[i] != str[lengthStr-i-1] {
			return false
		}
	}

	return true
}
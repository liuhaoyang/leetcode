func repeatedSubstringPattern(s string) bool {
	result := false
	b1 := []rune(s)
	lenS := len(b1)
	isSame := true
	wordMaxLength := lenS / 2
	for i := 1; i <= wordMaxLength; i++ {
		if lenS%i != 0 {
			continue
		}

		isSame = true
		for k := 0; k < i; k++ {
			left := b1[k]
			if isSame {
				bei := lenS / i
				for j := 1; j < bei; j++ {
					//左边是子串的某一位，右边是需要匹配的下N个子串的某一位
					nextPos := k + j*i
					right := b1[nextPos]
					if left != right {
						isSame = false
						break
					}
				}
			} else {
				break
			}
		}
		if isSame {
			return true
		}
	}

	return result
}
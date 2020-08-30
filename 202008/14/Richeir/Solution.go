func isValid(s string) bool {
	intStr := []rune(s)
	targetStack := []rune{}
	if len(intStr)%2 == 1 {
		return false
	}

	for i := 0; i < len(intStr); i++ {
		lengTarget := len(targetStack) - 1
		if lengTarget < 0 {
			lengTarget = 0
		}
		switch intStr[i] {
		case 40:
			targetStack = append(targetStack, intStr[i])
		case 41:
			if len(targetStack) != 0 && targetStack[lengTarget] != 40 {
				return false
			} else {
				targetStack = append(targetStack[:lengTarget])
			}

		case 91:
			targetStack = append(targetStack, intStr[i])
		case 93:
			if len(targetStack) != 0 && targetStack[lengTarget] != 91 {
				return false
			} else {
				targetStack = append(targetStack[:lengTarget])
			}

		case 123:
			targetStack = append(targetStack, intStr[i])
		case 125:
			if len(targetStack) != 0 && targetStack[lengTarget] != 123 {
				return false
			} else {
				targetStack = append(targetStack[:lengTarget])
			}
		}
	}

	if len(targetStack) != 0 {
		return false
	} else {
		return true
	}
}
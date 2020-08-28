var dic = map[string]string{
	"2": "abc",
	"3": "def",
	"4": "ghi",
	"5": "jkl",
	"6": "mno",
	"7": "pqrs",
	"8": "tuv",
	"9": "wxyz",
}

var container []string

func letterCombinations(digits string) []string {
	container = []string{}
	if len(digits) <= 0 {
		return []string{}
	}
	next(digits, 0, "")
	return container
}

func next(digits string, dig int, text string) {
	if dig == len(digits) {
		container = append(container, text)
	} else {
		temp := string(digits[dig]) // 当次指针指向的原数组对象
		last := dic[temp]

		for i := 0; i < len(last); i++ {
			next(digits, dig+1, text+string(last[i]))
		}
	}
}
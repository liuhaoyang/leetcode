var phoneMap map[string]string = map[string]string{
    "2": "abc",
    "3": "def",
    "4": "ghi",
    "5": "jkl",
    "6": "mno",
    "7": "pqrs",
    "8": "tuv",
    "9": "wxyz",
}

var combinations []string

func letterCombinations(digits string) []string {
    if len(digits) == 0 {
        return []string{}
    }
    combinations = []string{}
    backtrack(digits, 0, "")
    return combinations
}

func backtrack(digits string, index int, combination string) {
    if index == len(digits) {
        combinations = append(combinations, combination)
    } else {
        digit := string(digits[index])
        letters := phoneMap[digit]
        lettersCount := len(letters)
        for i := 0; i < lettersCount; i++ {
            backtrack(digits, index + 1, combination + string(letters[i]))
        }
    }
}

var (
    n int
    temp []int
)
func findSubsequences(nums []int) [][]int {
    n = len(nums)
    ans := [][]int{}
    set := map[int]bool{}
    for i := 0; i < 1 << n; i++ {
        findSubsequences1(i, nums)
        hashValue := getHash(263, int(1e9 + 7))
        if check() && !set[hashValue] {
            t := make([]int, len(temp))
            copy(t, temp)
            ans = append(ans, t)
            set[hashValue] = true
        }
    }
    return ans
}

func findSubsequences1(mask int, nums []int) {
    temp = []int{}
    for i := 0; i < n; i++ {
        if (mask & 1) != 0 {
            temp = append(temp, nums[i])
        }
        mask >>= 1
    }
}

func getHash(base, mod int) int {
    hashValue := 0
    for _, x := range temp {
        hashValue = hashValue * base % mod + (x + 101)
        hashValue %= mod
    }
    return hashValue
}

func check() bool {
    for i := 1; i < len(temp); i++ {
        if temp[i] < temp[i - 1] {
            return false
        }
    }
    return len(temp) >= 2
}

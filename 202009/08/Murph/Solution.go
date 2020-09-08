var (
	arr [][]int
	s int
	e int
)

func combine(n int, k int) [][]int {
	arr = [][]int{}
	s=n
	e=k
	dfs(1,[]int{})
	return arr
}

func dfs(i int,tempArr []int){
	if len(tempArr) == e{
		tmp := make([]int, e)
		copy(tmp, tempArr)
		arr = append(arr, tmp)
		return
	}
	if i > s{
		return
	}
	dfs(i+1,tempArr)
	dfs(i+1,append(tempArr,i))
}
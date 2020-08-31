var (
	num int
	arr []byte
)

func canVisitAllRooms(rooms [][]int) bool {

	ln := len(rooms)
	num = 0
	arr = make([]byte, ln)

	dfs(rooms, 0)
	return num == ln
}

func dfs(node [][]int, x int) {
	arr[x] = 1
	num++

	for _, val := range node[x] {
		if arr[val] != 1 {
			dfs(node, val)
		}
	}
}
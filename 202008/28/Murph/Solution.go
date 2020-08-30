
var dic = map[string][]int{
	"U": {0, 1},
	"D": {0, -1},
	"R": {-1, 0},
	"L": {1, 0},
}

func judgeCircle(moves string) bool {

	if len(moves) <= 0 {
		return true
	}

	x := 0
	y := 0

	for _,n := range moves {
		chr := string(n)
        println(chr)
		if valueArr,ok := dic[chr];ok{
			x+=valueArr[0]
			y+=valueArr[1]
		}
	}
	return x == 0 && y == 0
}
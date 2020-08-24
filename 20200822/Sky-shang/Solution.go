const (
    TARGET = 24
    EPSILON = 1e-6
    ADD, MULTIPLY, SUBTRACT, DIVIDE = 0, 1, 2, 3
)

func judgePoint24(nums []int) bool {
    list := []float64{}
    for _, num := range nums {
        list = append(list, float64(num))
    }
    return solve(list)
}

func solve(list []float64) bool {
    if len(list) == 0 {
        return false
    }
    if len(list) == 1 {
        return abs(list[0] - TARGET) < EPSILON
    }
    size := len(list)
    for i := 0; i < size; i++ {
        for j := 0; j < size; j++ {
            if i != j {
                list2 := []float64{}
                for k := 0; k < size; k++ {
                    if k != i && k != j {
                        list2 = append(list2, list[k])
                    }
                }
                for k := 0; k < 4; k++ {
                    if k < 2 && i < j {
                        continue
                    }
                    switch k {
                    case ADD:
                        list2 = append(list2, list[i] + list[j])
                    case MULTIPLY:
                        list2 = append(list2, list[i] * list[j])
                    case SUBTRACT:
                        list2 = append(list2, list[i] - list[j])
                    case DIVIDE:
                        if abs(list[j]) < EPSILON {
                            continue
                        } else {
                            list2 = append(list2, list[i] / list[j])
                        }
                    }
                    if solve(list2) {
                        return true
                    }
                    list2 = list2[:len(list2) - 1]
                }
            }
        }
    }
    return false
}

func abs(x float64) float64 {
    if x < 0 {
        return -x
    }
    return x
}
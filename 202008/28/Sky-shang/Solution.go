func judgeCircle(moves string) bool {
    x, y := 0, 0
    length := len(moves)
    for i := 0; i < length; i++ {
        switch moves[i] {
        case 'U':
            y--
        case 'D':
            y++
        case 'L':
            x--
        case 'R':
            x++
        }
    }
    return x == 0 && y == 0
}

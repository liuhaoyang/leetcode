func floodFill(image [][]int, sr int, sc int, newColor int) [][]int {
	result := recursion(&image, sr, sc, newColor)
	return result
}

//递归算法
func recursion(imageRef *[][]int, x int, y int, newValue int) [][]int {
	//找到对应的4个数，如果数字和原版数字相同，则继续执行递归
	var image = *imageRef
	var orgValue = image[x][y]

	if image[x][y] == newValue {
		return image
	}

	image[x][y] = newValue

	top, left, bottom, right := findRonud(imageRef, x, y, orgValue)
	if top != -1 {
		recursion(imageRef, x-1, y, newValue)
	}

	if left != -1 {
		recursion(imageRef, x, y-1, newValue)
	}

	if bottom != -1 {
		recursion(imageRef, x+1, y, newValue)
	}

	if right != -1 {
		recursion(imageRef, x, y+1, newValue)
	}

	return image
}

func findRonud(imageRef *[][]int, x int, y int, orgValue int) (int, int, int, int) {
	var image = *imageRef
	lenX := len(image) - 1
	lenY := len(image[0]) - 1

	if x < 0 || y < 0 {
		return -1, -1, -1, -1
	}

	if x > lenX || y > lenY {
		return -1, -1, -1, -1
	}
	top := -1
	left := -1
	bottom := -1
	right := -1

	if x-1 < 0 || y < 0 {
		top = -1
	} else {
		top = image[x-1][y]
		if top != orgValue {
			top = -1
		}
	}

	if x < 0 || y-1 < 0 {
		left = -1
	} else {
		left = image[x][y-1]
		if left != orgValue {
			left = -1
		}
	}

	if x+1 > lenX {
		bottom = -1
	} else {
		bottom = image[x+1][y]
		if bottom != orgValue {
			bottom = -1
		}
	}

	if y+1 > lenY {
		right = -1
	} else {
		right = image[x][y+1]
		if right != orgValue {
			right = -1
		}
	}

	return top, left, bottom, right
}
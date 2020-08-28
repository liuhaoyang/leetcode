func findItinerary(tickets [][]string) []string {
	var (
		tempMap = map[string][]string{}
		res     []string
	)

	//把传入来的所有first跟last按照收尾插入map
	for _, ticket := range tickets {
		first, last := ticket[0], ticket[1]
		tempMap[first] = append(tempMap[first], last)
	}
	//然后对map进行一次排序 自然语言
	for key := range tempMap {
		sort.Strings(tempMap[key])
	}

	var dfs func(text string)
	dfs = func(text string) {
		for{
			if v,ok := tempMap[text]; !ok || len(v) <=0{
				break
			}

			tmp:=tempMap[text][0] //当前Start对应的End
			tempMap[text] = tempMap[text][1:] //对当前的Start进行一下切片,取第一个的后面
			dfs(tmp)
		}
		res = append(res,text) //对Map操作完以后,将本次的text推入字典
	}

	dfs("JFK")

	for i:=0;i < len(res) / 2;i++{
		res[i],res[len(res)-1-i] = res[len(res) -1 -i],res[i] //进行一次头尾调转,将栈倒过来
	}

	return res
}

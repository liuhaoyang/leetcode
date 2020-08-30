func reverseWords(s string) string {

	stringArr:= strings.Split(s," ")

	textArr := []string{}
	for _,textTuple := range stringArr{

		charArr :=[]byte(textTuple)

		len := len(charArr)
		for i:=0; i< len/2;i++{
			charArr[i],charArr[(len - i -1)] = charArr[(len-i-1)],charArr[i]
		}
		textArr=append(textArr, string(charArr))
	}
	return strings.Join(textArr," ")
}

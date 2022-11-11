# -_-Int.TryParse
对之前Int.TryParse的复盘，主要是两个点：第一是怎么把输入的内容进行转化。那么有int na = Convert.ToInt32(**);还有int nb = int.Parse(sb);其次是判断输入值是否是数字，如果不是的话，那就要借助while循环，直到输入的是数字为止，如果不是的话用if(!success)的方式判断更加方便，这里返回循环不能用break而是使用continue。

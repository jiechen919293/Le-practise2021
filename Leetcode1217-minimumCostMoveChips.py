from typing import ForwardRef


def minCostTomoveChips(self, position: List[int])-> int:
    a =0;
    b =0;
    for i in position:
        if i%2:
            a+=1
        else:
            b+=1
    return a if a<b else b


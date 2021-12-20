
from typing import List


def minimumAbsDifference(self, arr: List[int]) -> List[List[int]]:
    arr.sort()
    i=1
    minDistance=float("inf")
    result=[]
    while i<len(arr):
        dist=arr[i]-arr[i-1]
        if dist<minDistance:
            minDistance=dist
            result=[[arr[i-1],arr[i]]]
        elif dist==minDistance:
            result.append([arr[i-1],arr[i]])
        i+=1
    return result
"""
    Write a function that reverses a string. The input string is given as an array of characters s.
"""

class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        i = 0
        j = len(s) - 1
        if (len(s) % 2 == 0):
            while(i < j):
                temp = s[j]
                s[j] = s[i]
                s[i] = temp
                i += 1
                j -= 1
        else:
            while(i != j):
                temp = s[j]
                s[j] = s[i]
                s[i] = temp
                i += 1
                j -= 1
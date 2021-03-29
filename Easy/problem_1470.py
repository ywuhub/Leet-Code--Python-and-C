"""
    Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

    Return the array in the form [x1,y1,x2,y2,...,xn,yn].
"""

class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        i = 0
        j = n
        index = 0
        shuffled_array = [None] * (2 * n)
        for number in nums:
            if (index % 2 == 0):
                shuffled_array[index] = nums[i]
                i += 1
            else:
                shuffled_array[index] = nums[j]
                j += 1

            index += 1

        return shuffled_array
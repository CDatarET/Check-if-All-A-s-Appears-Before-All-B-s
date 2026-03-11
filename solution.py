class Solution:
    def checkString(self, s):
        b = False
        for c in s:
            if c == "b": 
                b = True
            else: 
                if b: return False
        
        return True

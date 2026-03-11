public class Solution {
    public bool CheckString(string s) {
        bool b = false;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'b') b = true;
            else if(b) return(false);
        }

        return(true);
    }
}

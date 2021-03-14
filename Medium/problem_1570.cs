public class SparseVector {
    
    public Dictionary<int, int> vect;
    
    public SparseVector(int[] nums) {
        vect = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int value = nums[i];
            
            if (value != 0) {
                vect[i] = value;
            } else {
                vect[i] = 0;
            }  
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int result = 0;
        
        foreach(var item in this.vect) {
            int index = item.Key;
            int val1 = this.vect[index];
            int val2 = vec.vect[index];
            
            if (val1 * val2 != 0) {
                result += val1 * val2; 
            }
        }
        
        return result;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);
public class ASum {
	
	public static long findNb(long m) {
	   long sum = 0;
        long i = 0; 
        
        while (sum < m) {
            i++;
            sum += (i * i * i); 
        }
        
       
        return (sum == m) ? i : -1; 
	}
	
}

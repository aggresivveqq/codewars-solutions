public class BouncingBall {
	
	public static int bouncingBall(double h, double bounce, double window) {
		   int result = 1 ; 

    if(h <= 0 ){
         return -1;
       }else if(bounce <= 0 || bounce >= 1){
         return -1;
       }else if(window >= h){
         return -1;
       }
	    while(h*bounce > window){
        h = h * bounce;
        result+=2;
      }
    return result;
      
	}
}

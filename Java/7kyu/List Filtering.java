import java.util.List;
import java.util.ArrayList;

public class Kata {
  
  public static List<Object> filterList(final List<Object> list) {
   List<Object> resultList = new ArrayList<>();
    
    for (Object e : list) {
      if (e instanceof Integer) {  
        resultList.add((Object) e);
      }
    }
    
    return resultList;
  }
}

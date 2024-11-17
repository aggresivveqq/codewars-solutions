public class Kata
{
	public static int Mango(int quantity, int price)
	{
		int mango = (quantity / 3) * 2 + quantity % 3;
		int result = mango * price;
		return result;

	}
}
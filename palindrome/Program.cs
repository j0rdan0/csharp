using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace palindrome;

class Program
{
    static void Main(string[] args)
    {
			Palindrome p = new Palindrome();
			
			p.Number = int.Parse(Console.ReadLine());
			if(p.IsPalindrome()) {
				Console.Write("is a palindrome\n");
				return;
			}
			Console.Write("not a palindrome\n");
						
    }
	
}

public class Palindrome {

	public int Number { get;set;}
	public bool IsPalindrome() {
		
		int y = Number%10;
			Number = Number/10;
			List<int> l = new List<int>();

			l.Add(y);
			while (Number != 0) {
				
				y = Number%10;
				Number = Number/10;
				l.Add(y);
			}
			int[] a = l.ToArray();
			
			bool pal = true;
			
			for ( int i = 0, j = a.Length-1; i< a.Length/2 ||  j>a.Length/2; i++,j--) {
				 {
				//Console.WriteLine("i: " + i + " = " + a[i] + " " + "j: " +j + " = " + a[j]);
				if(a[i] != a[j]) {
					return false;
					
				}
			}
			}
			
			return pal;
}

}

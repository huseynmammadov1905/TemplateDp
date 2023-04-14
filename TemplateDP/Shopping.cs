using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDp
{
	public abstract class Shopping
	{

		protected string ProductName;

		protected Pay Pay;

		public void StartShop()
		{
            Console.WriteLine("Shopping Started");
        }

		public void Stop()
		{
			Console.WriteLine($"\nShopping Stop\nBuy {ProductName} with {Pay} ");
		}


		 public abstract void Product();
		 public  abstract void Payment();


		public void TemplateMethdod()
		{
			StartShop();

			Product();
			Payment();
			Stop();
		}
	}
}

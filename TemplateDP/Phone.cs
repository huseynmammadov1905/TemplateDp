using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDp
{
	public class Phone :Shopping
	{
		public override void Payment()
		{
			Pay = Pay.CreditCard;
		}

		public override void Product()
		{
			ProductName = "Phone";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDp
{
	public class Television : Shopping
	{
		public override void Payment()
		{
			Pay = Pay.Cash;
		}

		public override void Product()
		{
			ProductName = "Television";
		}
	}
}

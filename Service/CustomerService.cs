using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Git.GitHub.Service
{
	public class CustomerService: ICustomerService
	{
		public int GetTotalEmployees()
		{
			return 100;
		}
	}
}
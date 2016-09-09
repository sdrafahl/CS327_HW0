using System;

namespace FairOrderingSystem
{
	public class OrderForm
	{
		public virtual FairOrderingSystem.Models.Company company { get; set;}
		public virtual Order order { get; set;}
	}
}


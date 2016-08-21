using System;

namespace FairOrderingSystem
{
	public class Order
	{
		public Order ()
		{
		}
		public virtual int orderID { get; set;}
		public virtual string firstName { get; set;}
		public virtual string lastName { get; set;}
		public virtual string email { get; set;}
		public virtual int phone { get; set;}
		public virtual int cellPhone { get; set;}
	}
}


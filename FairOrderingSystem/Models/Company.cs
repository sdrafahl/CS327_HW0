using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;


namespace FairOrderingSystem.Models
{
	public class Company: IValidatableObject
	{
		public IEnumerable<ValidationResult> Validate( ValidationContext valid){
			if(!password2.Equals(password)){
				yield return new ValidationResult ("Passwords Dont Match", new []{ "password2" });
			}
		}


		[Required(ErrorMessage = "You must enter a company")]
		public virtual string companyName { get; set;}

		public virtual string cell { get; set;}

		[Required(ErrorMessage = "You must enter a password")]
		[StringLength(150,MinimumLength=5)]
		public virtual string password { get; set;}

		public virtual string password2 { get; set;}

		[Required(ErrorMessage = "You must enter a phone number")]
		[MaxLength(10,ErrorMessage="Not Long Enought")]
		public virtual string phone { get;set;}

		[Required(ErrorMessage = "You must enter an email address")]
		[StringLength(160,MinimumLength=4,ErrorMessage="Not Long Enough")]
		public virtual string email { get; set;}
	}
}
	
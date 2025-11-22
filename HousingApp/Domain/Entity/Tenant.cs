using System;

public class Tenant
{
	public string FirstName { get; set; }
	public Email Email { get; set; } = Email.CreateEmail("harun@gmail.com");

}
//Tenant.Email 
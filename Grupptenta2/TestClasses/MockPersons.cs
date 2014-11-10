using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;

namespace TestClasses
{
	public class MockPersons
	{
		public static void CreatePersons(int number, PersonManager personManager)
		{
			for (int i = 0; i < number; i++)
			{
				personManager.CreatePerson();
				personManager.GetPersons()[i].FirstName = "Person" + (i + 1);
			}
		}
	}
}

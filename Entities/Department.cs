using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeContratos.Entities
{
	public class Department
	{
		public string Name { get; set; }
		
		public Department()
		{
		}
		
		public Department(String name)
		{
			Name = name;
		}
	}
}
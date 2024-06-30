using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessProject.Classes
{
	public class connectionClass
	{
		public static string connectionString
		{
			get { return "Data Source=CONCHCL\\SQLEXPRESS;Initial Catalog=fitnessDB;Integrated Security=True"; }
		}
	}
}

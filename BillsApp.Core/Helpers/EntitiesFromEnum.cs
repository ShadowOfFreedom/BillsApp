using System;
using System.Collections.Generic;
using System.Linq;
using BillsApp.Core.Entities;

namespace BillsApp.Core.Helpers
{
	public static class EntitiesFromEnum
	{
		public static IEnumerable<EnumEntity> BuildEntityFromEnum<U>() where U : Enum
		{
			var result = Enum.GetValues(typeof(U))
				.Cast<U>()
				.Select(e => new EnumEntity()
				{
					Id = Convert.ToInt32(e),
					Name = e.ToString()
				});

			return result;
		}
	}
}

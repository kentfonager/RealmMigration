using System;
using Realms;

namespace RealmMigration.Models
{
	public class TestModel : RealmObject
	{
		[PrimaryKey]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
	}
}

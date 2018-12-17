namespace Exhibition.Model.DisplaySettingModel
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class DeskSetContext : DbContext
	{
		// Контекст настроен для использования строки подключения "DeskSetContext" из файла конфигурации  
		// приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
		// "Exhibition.Model.DisplaySettingModel.DeskSetContext" в экземпляре LocalDb. 
		// 
		// Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DeskSetContext" 
		// в файле конфигурации приложения.
		public DeskSetContext()
			: base("name=DeskSetContext")
		{
		}

		// Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
		// о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
		public virtual DbSet<ColSet> ColSets { get; set; }
		public virtual DbSet<ColStor> ColStors { get; set; }
		public virtual DbSet<DeskSet> DeskSets { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}
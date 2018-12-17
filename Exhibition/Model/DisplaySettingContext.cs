﻿namespace Exhibition.Model
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class DisplaySettingContext : DbContext
	{
		// Контекст настроен для использования строки подключения "DisplaySettingContext" из файла конфигурации  
		// приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
		// "Exhibition.Model.DisplaySettingContext" в экземпляре LocalDb. 
		// 
		// Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DisplaySettingContext" 
		// в файле конфигурации приложения.
		public DisplaySettingContext()
			: base("name=DisplaySettingContext")
		{
		}

		// Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
		// о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
		public virtual DbSet<Col1> Col1s { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}
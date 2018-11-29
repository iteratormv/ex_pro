CREATE TABLE [DesctopSetting] (
	Id int NOT NULL identity,
	Name nvarchar(50),
	Col1 int,
	Col2 int,
	Col3 int,
	Col4 int,
	Col5 int,
	Col6 int,
	Col7 int,
	Col8 int,
	Col9 int,
	Col10 int,
	Col11 int,
	Col12 int,
	Col13 int,
	Col14 int,
	Col15 int,
	Col16 int,
	Col17 int,
	Col18 int,
	Col19 int,
	Col20 int,
	Col21 int,
	Col22 int,
	Col23 int,
	Col24 int,
  CONSTRAINT [PK_DESCTOPSETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [DisplaySetting] (
	Id int NOT NULL identity,
	ParameterId int,
	Alias nvarchar(100),
	Visible bit,
	Width int,
  CONSTRAINT [PK_DISPLAYSETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Ex_visitor] (
	Id int NOT NULL identity,
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Company nvarchar(100),
	Barcode nvarchar(100),
	Status nvarchar(100),
	AddTextField1 nvarchar(100),
	AddTextField2 nvarchar(100),
	AddTextField3 nvarchar(100),
	AddTextField4 nvarchar(100),
	AddTextField5 nvarchar(100),
	AddTextField6 nvarchar(100),
	AddTextField7 nvarchar(100),
	AddTextField8 nvarchar(100),
	AddTextField9 nvarchar(100),
	AddTextField10 nvarchar(100),
	RegDate datetime,
	VisitDate datetime,
	DiscriptionId int,
	Combofield1Id int,
	Combofield2Id int,
	Combofield3Id int,
	Combofield4Id int,
	Combofield5Id int,
  CONSTRAINT [PK_EX_VISITOR] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Description] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_DESCRIPTION] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ComboField1] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_COMBOFIELD1] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ComboField2] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_COMBOFIELD2] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [RaportSetting] (
	Id int NOT NULL identity,
	Name nvarchar(50),
	Col1 int,
	Col2 int,
	Col3 int,
	Col4 int,
	Col5 int,
	Col6 int,
	Col7 int,
	Col8 int,
	Col9 int,
	Col10 int,
	Col11 int,
	Col12 int,
	Col13 int,
	Col14 int,
	Col15 int,
	Col16 int,
	Col17 int,
	Col18 int,
	Col19 int,
	Col20 int,
	Col21 int,
	Col22 int,
	Col23 int,
	Col24 int,
  CONSTRAINT [PK_RAPORTSETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ColorSetting] (
	Id int NOT NULL identity,
	NameId int,
	Color nvarchar(50),
  CONSTRAINT [PK_COLORSETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ComboField3] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_COMBOFIELD3] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ComboField4] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_COMBOFIELD4] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ComboField5] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_COMBOFIELD5] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [PrintTemplateSetting] (
	Id int NOT NULL identity,
	Name nvarchar(50),
	isCanDelete bit,
	Col1 int,
	Col3 int,
	Col4 int,
	Col5 int,
	Col6 int,
	Col7 int,
	Col8 int,
	Col9 int,
	Col10 int,
	Col11 int,
	Col12 int,
	Col13 int,
	Col14 int,
	Col15 int,
	Col16 int,
	Col17 int,
	Col18 int,
	Col19 int,
	Col20 int,
	Col21 int,
	Col22 int,
	Col23 int,
	Col24 int,
  CONSTRAINT [PK_PRINTTEMPLATESETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [PrintSetting] (
	Id int NOT NULL identity,
	ParameterId int,
	FontName nvarchar(100) NOT NULL,
	FontSize decimal,
	FontStyle nvarchar(100),
	isApper bit,
  CONSTRAINT [PK_PRINTSETTING] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Parameter] (
	Id int NOT NULL identity,
	Name nvarchar(100),
  CONSTRAINT [PK_PARAMETER] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk0] FOREIGN KEY ([Col1]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk0]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk1] FOREIGN KEY ([Col2]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk1]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk2] FOREIGN KEY ([Col3]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk2]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk3] FOREIGN KEY ([Col4]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk3]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk4] FOREIGN KEY ([Col5]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk4]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk5] FOREIGN KEY ([Col6]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk5]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk6] FOREIGN KEY ([Col7]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk6]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk7] FOREIGN KEY ([Col8]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk7]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk8] FOREIGN KEY ([Col9]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk8]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk9] FOREIGN KEY ([Col10]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk9]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk10] FOREIGN KEY ([Col11]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk10]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk11] FOREIGN KEY ([Col12]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk11]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk12] FOREIGN KEY ([Col13]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk12]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk13] FOREIGN KEY ([Col14]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk13]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk14] FOREIGN KEY ([Col15]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk14]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk15] FOREIGN KEY ([Col16]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk15]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk16] FOREIGN KEY ([Col17]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk16]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk17] FOREIGN KEY ([Col18]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk17]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk18] FOREIGN KEY ([Col19]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk18]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk19] FOREIGN KEY ([Col20]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk19]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk20] FOREIGN KEY ([Col21]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk20]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk21] FOREIGN KEY ([Col22]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk21]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk22] FOREIGN KEY ([Col23]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk22]
GO
ALTER TABLE [DesctopSetting] WITH CHECK ADD CONSTRAINT [DesctopSetting_fk23] FOREIGN KEY ([Col24]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DesctopSetting] CHECK CONSTRAINT [DesctopSetting_fk23]
GO

ALTER TABLE [DisplaySetting] WITH CHECK ADD CONSTRAINT [DisplaySetting_fk0] FOREIGN KEY ([ParameterId]) REFERENCES [Parameter]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [DisplaySetting] CHECK CONSTRAINT [DisplaySetting_fk0]
GO

ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk0] FOREIGN KEY ([DiscriptionId]) REFERENCES [Description]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk0]
GO
ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk1] FOREIGN KEY ([Combofield1Id]) REFERENCES [ComboField1]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk1]
GO
ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk2] FOREIGN KEY ([Combofield2Id]) REFERENCES [ComboField2]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk2]
GO
ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk3] FOREIGN KEY ([Combofield3Id]) REFERENCES [ComboField3]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk3]
GO
ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk4] FOREIGN KEY ([Combofield4Id]) REFERENCES [ComboField4]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk4]
GO
ALTER TABLE [Ex_visitor] WITH CHECK ADD CONSTRAINT [Ex_visitor_fk5] FOREIGN KEY ([Combofield5Id]) REFERENCES [ComboField5]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Ex_visitor] CHECK CONSTRAINT [Ex_visitor_fk5]
GO




ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk0] FOREIGN KEY ([Col1]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk0]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk1] FOREIGN KEY ([Col2]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk1]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk2] FOREIGN KEY ([Col3]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk2]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk3] FOREIGN KEY ([Col4]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk3]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk4] FOREIGN KEY ([Col5]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk4]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk5] FOREIGN KEY ([Col6]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk5]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk6] FOREIGN KEY ([Col7]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk6]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk7] FOREIGN KEY ([Col8]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk7]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk8] FOREIGN KEY ([Col9]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk8]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk9] FOREIGN KEY ([Col10]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk9]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk10] FOREIGN KEY ([Col11]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk10]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk11] FOREIGN KEY ([Col12]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk11]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk12] FOREIGN KEY ([Col13]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk12]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk13] FOREIGN KEY ([Col14]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk13]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk14] FOREIGN KEY ([Col15]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk14]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk15] FOREIGN KEY ([Col16]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk15]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk16] FOREIGN KEY ([Col17]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk16]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk17] FOREIGN KEY ([Col18]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk17]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk18] FOREIGN KEY ([Col19]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk18]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk19] FOREIGN KEY ([Col20]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk19]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk20] FOREIGN KEY ([Col21]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk20]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk21] FOREIGN KEY ([Col22]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk21]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk22] FOREIGN KEY ([Col23]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk22]
GO
ALTER TABLE [RaportSetting] WITH CHECK ADD CONSTRAINT [RaportSetting_fk23] FOREIGN KEY ([Col24]) REFERENCES [DisplaySetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [RaportSetting] CHECK CONSTRAINT [RaportSetting_fk23]
GO

ALTER TABLE [ColorSetting] WITH CHECK ADD CONSTRAINT [ColorSetting_fk0] FOREIGN KEY ([NameId]) REFERENCES [Description]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [ColorSetting] CHECK CONSTRAINT [ColorSetting_fk0]
GO




ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk0] FOREIGN KEY ([Col1]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk0]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk1] FOREIGN KEY ([Col3]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk1]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk2] FOREIGN KEY ([Col4]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk2]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk3] FOREIGN KEY ([Col5]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk3]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk4] FOREIGN KEY ([Col6]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk4]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk5] FOREIGN KEY ([Col7]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk5]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk6] FOREIGN KEY ([Col8]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk6]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk7] FOREIGN KEY ([Col9]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk7]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk8] FOREIGN KEY ([Col10]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk8]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk9] FOREIGN KEY ([Col11]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk9]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk10] FOREIGN KEY ([Col12]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk10]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk11] FOREIGN KEY ([Col13]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk11]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk12] FOREIGN KEY ([Col14]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk12]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk13] FOREIGN KEY ([Col15]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk13]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk14] FOREIGN KEY ([Col16]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk14]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk15] FOREIGN KEY ([Col17]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk15]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk16] FOREIGN KEY ([Col18]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk16]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk17] FOREIGN KEY ([Col19]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk17]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk18] FOREIGN KEY ([Col20]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk18]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk19] FOREIGN KEY ([Col21]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk19]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk20] FOREIGN KEY ([Col22]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk20]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk21] FOREIGN KEY ([Col23]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk21]
GO
ALTER TABLE [PrintTemplateSetting] WITH CHECK ADD CONSTRAINT [PrintTemplateSetting_fk22] FOREIGN KEY ([Col24]) REFERENCES [PrintSetting]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintTemplateSetting] CHECK CONSTRAINT [PrintTemplateSetting_fk22]
GO

ALTER TABLE [PrintSetting] WITH CHECK ADD CONSTRAINT [PrintSetting_fk0] FOREIGN KEY ([ParameterId]) REFERENCES [Parameter]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [PrintSetting] CHECK CONSTRAINT [PrintSetting_fk0]
GO


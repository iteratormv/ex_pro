using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exhibition.Model.VisitorModels
{
	public class ExhibitionVisitorPro : INotifyPropertyChanged
	{
		int id;
		string firstname;
		string lastname ;
		string company;
		string barcode;
		string status;

		string addtextfield1 = " ";
		string addtextfield2 = " ";
		string addtextfield3 = " ";
		string addtextfield4 = " ";
		string addtextfield5 = " ";
		string addtextfield6 = " ";
		string addtextfield7  = " ";
		string addtextfield8 = " ";
		string addtextfield9 = " ";
		string addtextfield10 = " ";

		DateTime? regdate;
		DateTime? visitdate;

		int? descriptionId;
		int? addcombofieldid1;
		int? addcombofieldid2;
		int? addcombofieldid3;
		int? addcombofieldid4;
		int? addcombofieldid5;

		public int Id { get { return id; } set { id = value; Notify("Id"); } }
		public string FirstName { get { return firstname; } set { firstname = value; Notify("FirstName"); } }
		public string LastName { get { return lastname; } set { lastname = value; Notify("LastName"); } }
		public string Company { get { return company; } set { company = value; Notify("Company"); } }
		public string Barcode { get { return barcode; } set { barcode = value; Notify("Brcode"); } }
		public string Status { get { return status; } set { status = value; Notify("Status"); } }

		public string AddTextField1 { get { return addtextfield1; } set { addtextfield1 = value; Notify("AddTextField1"); } }
		public string AddTextField2 { get { return addtextfield2; } set { addtextfield2 = value; Notify("AddTextField2"); } }
		public string AddTextField3 { get { return addtextfield3; } set { addtextfield3 = value; Notify("AddTextField3"); } }
		public string AddTextField4 { get { return addtextfield4; } set { addtextfield4 = value; Notify("AddTextField4"); } }
		public string AddTextField5 { get { return addtextfield5; } set { addtextfield5 = value; Notify("AddTextField5"); } }
		public string AddTextField6 { get { return addtextfield6; } set { addtextfield6 = value; Notify("AddTextField6"); } }
		public string AddTextField7 { get { return addtextfield7; } set { addtextfield7 = value; Notify("AddTextField7"); } }
		public string AddTextField8 { get { return addtextfield8; } set { addtextfield8 = value; Notify("AddTextField8"); } }
		public string AddTextField9 { get { return addtextfield9; } set { addtextfield9 = value; Notify("AddTextField9"); } }
		public string AddTextField10 { get { return addtextfield10; } set { addtextfield10 = value; Notify("AddTextField10"); } }

		public DateTime? Regdate { get { return regdate; } set { regdate = value; Notify("RegDate"); } }
		public DateTime? Visit { get { return visitdate; } set { visitdate = value; Notify("VisitDate"); } }

		public int? DescriptionId { get { return descriptionId; } set { descriptionId = value; Notify("DescriptionId"); } }
		public int? AddComboFieldId1 { get { return addcombofieldid1; } set { addcombofieldid1 = value; Notify("AddComboFieldId1"); } }
		public int? AddComboFieldId2 { get { return addcombofieldid2; } set { addcombofieldid2 = value; Notify("AddComboFieldId2"); } }
		public int? AddComboFieldId3 { get { return addcombofieldid3; } set { addcombofieldid3 = value; Notify("AddComboFieldId3"); } }
		public int? AddComboFieldId4 { get { return addcombofieldid4; } set { addcombofieldid4 = value; Notify("AddComboFieldId4"); } }
		public int? AddComboFieldId5 { get { return addcombofieldid5; } set { addcombofieldid5 = value; Notify("AddComboFieldId5"); } }

		public Description Description { get; set; }
		public AddComboField1 AddComboField1 { get; set; }
		public AddComboField2 AddComboField2 { get; set; }
		public AddComboField3 AddComboField3 { get; set; }
		public AddComboField4 AddComboField4 { get; set; }
		public AddComboField5 AddComboField5 { get; set; }

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
using System;

//Hospital application
/*
iterface IHospital -> 
	admit patients
	discharge patients

abstract class person implimenting interface ihospital
*/
enum{
	Nurse;
	Patients;
}

public Nurse{}

public Interface IHospital{
	public void AdmitPatients(Patients patient);
	public void DischargePatients(Patients patient);
}

public abstract class Person : IHospital{

	public void virtual AdmitPatients(Patients patient){
		
	}

	public void DischargePatients(Patients patient){
	
	}

	public abstract void m1();
}

public class ReigonalHospital : IHospital{
	public void AdmitPatients(Patients patient){
		
	}

	public void AdmitPatients(Patients patient, int id){
		
	}

	public string AdmitPatient(Patient patient){
		
	}

	public void DischargePatients(Patients patient){
	
	}
}

public class Patients : Person {
	
	public void override AdmitPatients(Patients patient){
		
	}

	public void DischargePatients(Patients patient){
		
	}

	public void m1(){
	
	}

	public string name{get;set;}
	public int id{get;set;}

	public Patients(string _name, int _id){
		name = _name;
		id = _id;
	}

	public static void Main(string[] args){
		Patients p = new Patients("Abc",1);
		ReigonalHospital r = new ReigonalHospital();
		Person per = new Person();

		List<IHospital> hs = new List<IHospital>();
		hs.Add(p);
		hs.Add(r);
		//hs.Add(per);

		List<string> words = new List<string>(){
			"pki","abc","zse","ghi","jkl"
		};

		var words = for w in words
				OrderBy w
				select w;

		var newW = words.OrderBy(w => w);

		string name = "sanidhaya";
				

		foreach(var item in hs){
			
		}
	}
}


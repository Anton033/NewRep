using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//2.Создать программу для имитации работы клиники.
//Пусть в клинике будет три врача: хирург, терапевт и дантист.
//Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.Так же предусмотреть класс «Пациент» и класс «План лечения».
//Создать объект класса «Пациент» и добавить пациенту план лечения.Так же создать метод, который будет назначать врача пациенту согласно  плану лечения.  
//Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить.  
//Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить.  
//Если план лечения имеет любой другой код – назначить терапевта и выполнить метод лечить.

namespace Test1.Classes
{
	public class Doc
	{
		public virtual void Heal()
		{
			Console.WriteLine("");
		}
	}

	public class Surger : Doc
	{
		public override void Heal()
		{
			Console.WriteLine("The surgeon is started by the Surger");
		}
	}

	public class Therapist : Doc
	{
		public override void Heal()
		{
			Console.WriteLine("The therapy is started by the Therapist");
		}
	}

	public class Dentist : Doc
	{
		public override void Heal()
		{
			Console.WriteLine("The teeth restore is started by the Dentist");
		}
	}

	public class TreatmentPlan
	{
		public int code;

		public TreatmentPlan(int code)
		{
			this.code = code;
		}

		
	}
	
	public class Patient 
	{
		public string patientName;
		public TreatmentPlan plan;

		public Patient(int code, string patientName)
		{
			this.patientName = patientName;
			this.plan = new TreatmentPlan(code);
		}

		public Doc Plan()
		{
			if (plan.code == 1)
			{
				Console.WriteLine($"Your code nubmer is: {plan.code}");
				return new Surger();
			}
			else if (this.plan.code == 2)
			{
				Console.WriteLine($"Your code nubmer is: {plan.code}");
				return new Therapist();
			}
			else
			{
				Console.WriteLine($"Your code nubmer is: {plan.code}");
				return new Dentist();
			}
		}
	}

}


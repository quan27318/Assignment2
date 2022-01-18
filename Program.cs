using System;
using System.Collections.Generic;
using System.Linq;
namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Member> listMember = SeedingData();
            Male(listMember);
            FullName(listMember);
            overSecondThousand(listMember);
            equalSecondThousand(listMember);
            underSecondThousand(listMember);
            BornInHN(listMember);
            Oldest(listMember);
        }
        static void Male(List<Member> members){
            
            List<Member> male = (from member in members
                                where member.Gender =="Male"
                                select member).ToList();
            for (int i = 0; i < male.Count; i++)
            {
                Console.WriteLine(male[i].FistName +"----"+ male[i].LastName +"----"+ male[i].Gender+"----"+ male[i].BirthPlace);
                
            }
        }
        static void FullName(List<Member> members){
            Console.WriteLine("In ra danh sach full name");
            List<Member> fullName = (from member in members
                                
                                select member).ToList();
            for (int i = 0; i < fullName.Count; i++)
            {
                Console.WriteLine(fullName[i].FistName +"----"+ fullName[i].LastName );
                
            }
        }
        static void overSecondThousand(List<Member> members){
            Console.WriteLine("In ra danh sach nguoi sinh nam >2000 :");
            List<Member> over = (from member in members
                                where member.DateOfBirth >2000
                                select member).ToList();
            for (int i = 0; i < over.Count; i++)
            {
                Console.WriteLine(over[i].FistName +"----"+ over[i].LastName +"----"+ over[i].Gender+"----"+ over[i].BirthPlace);
                
            }
        }
        static void equalSecondThousand (List<Member> members){
            Console.WriteLine("In ra danh sach nguoi sinh nam 2000 :");
            List<Member> equal = (from member in members
                                where member.DateOfBirth ==2000
                                select member).ToList();
            for (int i = 0; i < equal.Count; i++)
            {
                Console.WriteLine(equal[i].FistName +"----"+ equal[i].LastName +"----"+ equal[i].Gender+"----"+ equal[i].BirthPlace);
                
            }
        }
        static void underSecondThousand (List<Member> members){
            Console.WriteLine("In ra danh sach nguoi sinh nam <2000 :");
            List<Member> under  = (from member in members
                                where member.DateOfBirth < 2000
                                select member).ToList();
            for (int i = 0; i < under.Count; i++)
            {
                Console.WriteLine(under[i].FistName +"----"+ under[i].LastName +"----"+ under[i].Gender+"----"+ under[i].BirthPlace);
                
            }
        }
        static void BornInHN(List<Member> members){
            Console.WriteLine("In ra danh sach nguoi song o ha noi");
            List<Member> born = (from member in members
                                where member.BirthPlace == "Ha Noi"
                                select member).ToList();
            for (int i = 0; i < born.Count; i++)
            {
                Console.WriteLine(born[i].FistName +"----"+ born[i].LastName +"----"+ born[i].BirthPlace );
                
            }
        }
        static void Oldest(List<Member> oldMember){
            Console.WriteLine("Tra ve nguoi cao tuoi nhat:");
            var oldestMember = (from member in oldMember
                                         orderby member.Age descending
                                         select member ).ToList();
            for (int i = 0; i < oldestMember.Count; i++)
            {
                Console.WriteLine(oldestMember[i].FistName +"----"+ oldestMember[i].LastName +"----"+ oldestMember[i].Age);
                
            }
        }
        
         static List<Member> SeedingData(){
            List<Member> members = new List<Member>();
            members.Add(
                new Member()
                {
                    FistName="Quan",
                    LastName="Pham",
                    Gender="Male",
                    DateOfBirth=2000,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=21,
                    IsGraduated=true
                    });
                    
            members.Add(
                new Member()
                {
                    FistName="Manh",
                    LastName="Nguyen Van",
                    Gender="FeMale",
                    DateOfBirth=1988,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=31,
                    IsGraduated=true
                    });
                members.Add(
                new Member()
                {
                    FistName="A",
                    LastName="Nguyen Van",
                    Gender="FeMale",
                    DateOfBirth=1988,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=31,
                    IsGraduated=true
                    });
                    members.Add(
                new Member()
                {
                    FistName="B",
                    LastName="Nguyen Van",
                    Gender="Male",
                    DateOfBirth=2001,
                    PhoneNumber=012345678,
                    BirthPlace="Ha Noi",
                    Age=20,
                    IsGraduated=true
                    });
                    members.Add(
                new Member()
                {
                    FistName="C",
                    LastName="Nguyen Van",
                    Gender="Male",
                    DateOfBirth=2002,
                    PhoneNumber=012345678,
                    BirthPlace="Ha Noi",
                    Age=19,
                    IsGraduated=true
                    });
                return members;
        }
    }
   
}

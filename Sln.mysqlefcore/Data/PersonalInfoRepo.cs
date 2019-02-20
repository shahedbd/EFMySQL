using Data.Model;
using System;
using System.Linq;
using System.Text;

namespace Data
{
    public class PersonalInfoRepo
    {
        public void Create()
        {
            using (var context = new DatabaseContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                context.PersonalInfo.Add(new PersonalInfo
                {
                    FirstName = "Shahed",
                    LastName = "Islam",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    City = "Dhaka",
                    Country = "Bangladesh",
                    Email = "shahed.mbstu@gmail.com",
                    NID = "798465132",
                    MobileNo = "01674411603",
                    CreatedDate = DateTime.Now,
                    CreationUser = "Admin"

                });
                context.SaveChanges();
            }
        }

        public void PrintData()
        {
            using (var context = new DatabaseContext())
            {
                var listPersonalInfo = context.PersonalInfo.ToList();
                foreach (var item in listPersonalInfo)
                {
                    var data = new StringBuilder();

                    data.AppendLine($"First Name: {item.FirstName}");
                    data.AppendLine($"Last Name: {item.LastName}");
                    data.AppendLine($"Date Of Birth: {item.DateOfBirth}");
                    data.AppendLine($"NID: {item.NID}");
                    data.AppendLine($"MobileNo: {item.MobileNo}");
                    data.AppendLine($"Country: {item.Country}");

                    Console.WriteLine(data.ToString());
                }
            }
        }

    }
}

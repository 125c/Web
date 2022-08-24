using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HW7Project.Models
{
    public class DBinitializer:DropCreateDatabaseAlways<HW7ProjectContext>
    {
        protected override void Seed(HW7ProjectContext context)
        {
            base.Seed(context);
            List<Members> members = new List<Members>
            {
                new Members
                {
                   MemberName="莊孝為",
                   MemberBirthday =Convert.ToDateTime("1981/7/9"),
                   CreateDate=DateTime.Today,
                   Account="shaio",
                   Password= "12345678"
                },
                new Members
                {
                   MemberName="周委行",
                   MemberBirthday =Convert.ToDateTime("1981/7/9"),
                   CreateDate=DateTime.Today,
                   Account="ninjatex",
                   Password= "12345678"
                }
            };


            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();

            List<Shippers> shippers = new List<Shippers>
            {
                new Shippers
                {
                   ShipVia="到店取貨"
                },
                new Shippers
                {
                   ShipVia="宅配到府"
                },
                new Shippers
                {
                   ShipVia="郵寄"
                }
            };

            shippers.ForEach(s => context.Shippers.Add(s));
            context.SaveChanges();

            List<PayTypes> payType = new List<PayTypes>
            {
                new PayTypes
                {
                   PayTypeName="信用卡"
                },
                new PayTypes
                {
                   PayTypeName="Line Pay"
                },
                new PayTypes
                {
                   PayTypeName="貨到付款"
                },
                new PayTypes
                {
                   PayTypeName="到店取貨付款"
                }
            };

            payType.ForEach(s => context.PayTypes.Add(s));
            context.SaveChanges();

            List<Employees> employees = new List<Employees>
            {
                new Employees
                {
                   EmployeesName="王立弘",
                   CreatedDate=DateTime.Today,
                   Account="admin",
                   Password="12345678"
                },
                new Employees
                {
                   EmployeesName="林天天",
                   CreatedDate=DateTime.Today,
                   Account="Linsky",
                   Password="12345678"
                }
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

        }
    }
}
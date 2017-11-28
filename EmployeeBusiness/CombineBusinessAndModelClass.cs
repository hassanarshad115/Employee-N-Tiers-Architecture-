using EmployeeData;
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusiness
{
   public class CombineBusinessAndModelClass
    {
        public static void combineData(EmployeeModelClass combineBusinessAndModelLayer)
        {
            EmployeeDataClass.InsertEmployeeData(combineBusinessAndModelLayer);
        }
    }
}

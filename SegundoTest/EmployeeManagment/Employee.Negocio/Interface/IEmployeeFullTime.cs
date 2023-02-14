using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Negocio.Interface
{
    public interface IEmployeeFullTimeBL
    {

        EmployeeFullTimeDTO GetEmployeeFullTime(int id);
        string CreateEmployeeFullTime(EmployeeFullTimeDTO objEmployeeContractorDTO);
        string UpdateEmployeeFullTime(EmployeeFullTimeDTO objEmployeeContractorDTO);
    }
}

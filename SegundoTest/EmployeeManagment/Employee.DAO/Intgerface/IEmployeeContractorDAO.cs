using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO.Intgerface
{
    public interface IEmployeeContractorDAO
    {

        List<EmployeeContractorDTO> GetEmployeeContractor();
        string CreateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO);
        string UpdateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO);

    }
}

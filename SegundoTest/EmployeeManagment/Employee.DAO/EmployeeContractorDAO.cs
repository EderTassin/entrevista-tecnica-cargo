using Employee.DAO.Intgerface;
using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO
{
    public class EmployeeContractorDAO : IEmployeeContractorDAO
    {

        List<EmployeeContractorDTO>? _listEmployee;

        
        List<EmployeeContractorDTO> IEmployeeContractorDAO.GetEmployeeContractor()
        {
            try
            {
                return RepositoryEmployee();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string CreateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO)
        {
            try
            {
                _listEmployee = RepositoryEmployee();

                _listEmployee.Add(objEmployeeContractorDTO);

                return "Correct insertion";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public string UpdateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO)
        {
            throw new NotImplementedException();
        }


        public List<EmployeeContractorDTO> RepositoryEmployee()
        {
            return _listEmployee = new List<EmployeeContractorDTO>
            {
                new EmployeeContractorDTO {idEmployee = 1, firstName = "Eder", lastName = "Tassin", hoursWorked = 3, salary = 233m, vacationDays = 15, yearsWorked= 2},
                new EmployeeContractorDTO {idEmployee = 4, firstName = "Ricardo", lastName = "Perez", hoursWorked = 3, salary = 200m, vacationDays = 15, yearsWorked= 2}
            };
        }

    }
}

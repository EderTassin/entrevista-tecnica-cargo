using Employee.DAO.Intgerface;
using Employee.DTO;
using Employee.Negocio.Interface;

namespace Employee.Negocio
{
    public class EmployeeContractorBL : IEmployeeContractorBL
    {
        private readonly IEmployeeContractorDAO _employeeDAO;
        public EmployeeContractorBL(IEmployeeContractorDAO EmployeeContractorDAO) 
        { 
            _employeeDAO= EmployeeContractorDAO;
        }


        public List<EmployeeContractorDTO> GetEmployeeContractor(int id = 0)
        {
            try
            {
                List<EmployeeContractorDTO> filterListEmployee = new List<EmployeeContractorDTO>();
                List<EmployeeContractorDTO> listEmployee = _employeeDAO.GetEmployeeContractor();

                if (id != 0)
                {
                    listEmployee = listEmployee.Where(c => c.idEmployee == id).ToList();
                }

                return listEmployee;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public string CreateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO)
        {
            try
            {
                string response = _employeeDAO.CreateEmployeeContractor(objEmployeeContractorDTO);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO)
        {
            throw new NotImplementedException();
        }
    }
}

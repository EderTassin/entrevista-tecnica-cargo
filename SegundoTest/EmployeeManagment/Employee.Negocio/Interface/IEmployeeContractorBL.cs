
using Employee.DTO;

namespace Employee.Negocio.Interface
{
    public interface IEmployeeContractorBL
    {
        List<EmployeeContractorDTO> GetEmployeeContractor(int id);
        string CreateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO);
        string UpdateEmployeeContractor(EmployeeContractorDTO objEmployeeContractorDTO);
    }
}

using Employee.DTO;
using Employee.Negocio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace EmployeeManagment.Controllers
{
    [ApiController]
    [Route("api/employee/contractor")]
    public class EmployeeContractorController : ControllerBase
    {
      
        private readonly IEmployeeContractorBL _employeeBL;
        private readonly ILogger<EmployeeContractorController> _logger;

        public EmployeeContractorController(IEmployeeContractorBL Employee, ILogger<EmployeeContractorController> logger)
        {
            _employeeBL = Employee;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetEmployeeContractor([FromBody]EmployeeContractorDTO objEmployee) 
        {

            try
            {

                var response = _employeeBL.GetEmployeeContractor(objEmployee.idEmployee);
                if (response == null)
                {
                    return NotFound();
                }
                
                return Ok(response);

            }
            catch (ArgumentException ex)
            {
                return BadRequest($"El modelo es inválido: {ex.Message}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el modelo");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor");
            }

        }

        [HttpPost]
        public ActionResult CreateEmployeeContractor([FromBody] EmployeeContractorDTO objEmployeeDTO)
        {

            try
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var response = _employeeBL.CreateEmployeeContractor(objEmployeeDTO);

                return Ok("Modelo creado exitosamente");
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest($"El modelo es nulo: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"El modelo es inválido: {ex.Message}");
            }
            catch (Exception ex)
            {     
                _logger.LogError(ex, "Error al crear el modelo");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor");
            }


        }
        [HttpPut]
        public ActionResult UpdateEmployeeContractor([FromBody] EmployeeContractorDTO objEmployeeContractorDTO)
        {

            try
            {

                var response = _employeeBL.GetEmployeeContractor(objEmployeeContractorDTO.idEmployee);
                if (response == null)
                {
                    return NotFound();
                }

                return Ok(response);

            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}

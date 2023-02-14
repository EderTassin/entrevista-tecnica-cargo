using Employee.DTO;
using Employee.Negocio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Controllers
{
    [ApiController]
    [Route("api/employee/fulltime")]
    public class EmployeeFullTimeController : Controller { 

        private readonly IEmployeeFullTimeBL _employeeBL;
        private readonly ILogger<EmployeeFullTimeController> _logger;

        public EmployeeFullTimeController(IEmployeeFullTimeBL Employee, ILogger<EmployeeFullTimeController> logger)
        {
            _employeeBL = Employee;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetEmployeeFullTime([FromBody] EmployeeFullTimeDTO objEmployeeFullTimeDTO)
        {

            try
            {

                var response = _employeeBL.GetEmployeeFullTime(objEmployeeFullTimeDTO.idEmployee);
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
        public ActionResult CreateEmployeeContractor([FromBody] EmployeeFullTimeDTO objEmployeeFullTimeDTO)
        {

            try
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var response = _employeeBL.CreateEmployeeFullTime(objEmployeeFullTimeDTO);

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
        public ActionResult UpdateEmployeeContractor([FromBody] EmployeeFullTimeDTO objEmployeeFullTimeDTO)
        {

            try
            {

                var response = _employeeBL.UpdateEmployeeFullTime(objEmployeeFullTimeDTO);
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

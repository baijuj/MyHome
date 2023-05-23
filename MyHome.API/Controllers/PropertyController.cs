using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyHome.Domain;
using MyHome.Service;
using MyHome.Shared.Dtos;

namespace MyHome.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {

        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;
        private readonly ILogger<PropertyController> _logger;


        public PropertyController(IPropertyService propertyService, IMapper mapper, ILogger<PropertyController> logger)
        {
            _propertyService = propertyService;
            _mapper = mapper;
            _logger= logger;
        }
        /// <summary>
        /// Retrieves a list of properties.
        /// </summary>
        /// <remarks>
        /// Optional search parameter can be used to filter properties by address.
        /// </remarks>
        /// <param name="search">The search term for filtering properties by address. (Optional)</param>
        /// <param name="pageNumber">The page number for pagination. (Optional)</param>
        /// <param name="pageSize">The number of items per page for pagination. (Optional)</param>
        /// <returns>A list of properties.</returns>
        // GET: api/Property
        [HttpGet]

        public async Task<IActionResult> Get(string? search = "", int pageNumber = 1, int pageSize = 10)
        {
            _logger.LogInformation("Getting properties with search term '{search}' on page {pageNumber} with {pageSize} items per page.", search, pageNumber, pageSize);

            if (pageNumber < 1) { pageNumber= 1; }
            if (pageSize >20) { pageSize = 20; } //max 20 items per page

            var properties = await _propertyService.GetAllAsync(search, pageNumber, pageSize);
            var propertyDtos = _mapper.Map<List<PropertyListDto>>(properties);
            return Ok(propertyDtos);
        }
        /// <summary>
        /// Retrieves a specific property by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the property to retrieve.</param>
        /// <returns>A PropertyListDto object if found, NotFound status code if not found.</returns>
        /// <response code="200">Returns the property corresponding to specified ID</response>
        /// <response code="404">If a property with the provided ID is not found</response>

        // GET: api/Property/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var property = await _propertyService.GetByIdAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            var propertyDto = _mapper.Map<PropertyListDto>(property);
            return Ok(propertyDto);
        }

        /// <summary>
        /// Creates a new property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="propertyDto">The PropertyDto object to create.</param>
        /// <returns>The route to the created property if successful.</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        // POST: api/Property
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PropertyDto propertyDto)
        {
            var property = _mapper.Map<Property>(propertyDto);
            await _propertyService.CreateAsync(property);
            var createdPropertyDto = _mapper.Map<PropertyDto>(property);
            return CreatedAtAction(nameof(Get), new { id = propertyDto.Id }, createdPropertyDto);
        }
        /// <summary>
        /// Updates an existing property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="id">The ID of the property to update.</param>
        /// <param name="propertyDto">The PropertyDto object with updated information.</param>
        /// <returns>NoContent status code if update is successful.</returns>
        /// <response code="204">Returns when the property update was successful</response>
        /// <response code="400">If the id and propertyDto.Id do not match</response>
        /// <response code="404">If the property to update is not found</response>

        // PUT: api/Property/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PropertyDto propertyDto)
        {
            if (id != propertyDto.Id)
            {
                return BadRequest();
            }

            var property = _mapper.Map<Property>(propertyDto);
            bool isUpdated = await _propertyService.UpdateAsync(property);

            if (isUpdated)
            {
                return NoContent();
            }
            else
            {
                return NotFound("Property not found.");
            }
        }
        /// <summary>
        /// Deletes an existing property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="id">The ID of the property to delete.</param>
        /// <returns>NoContent status code if deletion is successful.</returns>
        /// <response code="204">Returns when the property deletion was successful</response>
        /// <response code="404">If the property to delete is not found</response>
        // DELETE: api/Property/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("DELETE: Deleting property with ID {ID}.", id);

            bool isDeleted = await _propertyService.DeleteAsync(id);

            if (isDeleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound("Property not found.");
            }
        }
    }
}

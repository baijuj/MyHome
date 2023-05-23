using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHome.Domain;
using MyHome.Service;
using MyHome.Shared.Dtos;

namespace MyHome.API.Controllers
{
    [Route("api/properties/{propertyId}/[controller]")]
    [ApiController]
    public class NegotiatorController : ControllerBase
    {
        private readonly INegotiatorService _negotiatorService;
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;

        public NegotiatorController(INegotiatorService negotiatorService, IPropertyService propertyService, IMapper mapper)
        {
            _negotiatorService = negotiatorService;
            _propertyService = propertyService;
            _mapper = mapper;
        }
        /// <summary>
        /// Retrieves all negotiators associated with a specific property.
        /// </summary>
        /// <param name="propertyId">The ID of the property.</param>
        /// <returns>A list of negotiators for the property.</returns>
        // GET: api/Property
        [HttpGet]
        public async Task<IActionResult> Get(int propertyId)
        {
            // Validate propertyId
            var property = await _propertyService.GetByIdAsync(propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }
            //passing propertyId to get all negotiators for that property
            var negotiators = await _negotiatorService.GetAllAsync(propertyId);
            var negotiatorDtos = _mapper.Map<List<NegotiatorDto>>(negotiators);
            return Ok(negotiatorDtos);
        }
        /// <summary>
        /// Retrieves a specific negotiator associated with a property.
        /// </summary>
        /// <param name="propertyId">The ID of the property.</param>
        /// <param name="id">The ID of the negotiator.</param>
        /// <returns>The negotiator with the specified ID.</returns>
        // GET: api/Property/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int propertyId,int id)
        {
            // Validate propertyId
            var property = await _propertyService.GetByIdAsync(propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }
            var negotiator = await _negotiatorService.GetByIdAsync(id);
            if (negotiator == null)
            {
                return NotFound();
            }
            var negotiatorDto = _mapper.Map<NegotiatorDto>(negotiator);
            return Ok(negotiatorDto);
        }
        /// <summary>
        /// Creates a new negotiator for a specific property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="propertyId">The ID of the property.</param>
        /// <param name="negotiatorDto">The negotiator data.</param>
        /// <returns>The created negotiator.</returns>
       
        // POST: api/Property
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(int propertyId,[FromBody] NegotiatorDto negotiatorDto)
        {
            // Validate propertyId
            var property = await _propertyService.GetByIdAsync(propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            var negotiator = _mapper.Map<Negotiator>(negotiatorDto);
            negotiator.PropertyId = propertyId;
            await _negotiatorService.CreateAsync(negotiator);
            var createdNegotiatorDto = _mapper.Map<NegotiatorDto>(negotiator);
            return CreatedAtAction(nameof(Get), new { propertyId= propertyId, id = negotiatorDto.NegotiatorId }, createdNegotiatorDto);
        }
        /// <summary>
        /// Updates a negotiator for a specific property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="propertyId">The ID of the property.</param>
        /// <param name="id">The ID of the negotiator.</param>
        /// <param name="negotiatorDto">The negotiator data.</param>
        /// <returns>No content if the negotiator is updated successfully, otherwise returns an error message.</returns>

        // PUT: api/Property/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int propertyId,int id, [FromBody] NegotiatorDto negotiatorDto)
        {
            // Validate propertyId
            var property = await _propertyService.GetByIdAsync(propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            if (id != negotiatorDto.NegotiatorId)
            {
                return BadRequest();
            }

            if (propertyId != negotiatorDto.PropertyId)
            {
                return BadRequest();
            }

            var negotiator = _mapper.Map<Negotiator>(negotiatorDto);

            //we can pass propertyid to the service/repository method for proper but we are just passing negotiator object to the service method here
            bool isUpdated = await _negotiatorService.UpdateAsync(negotiator);

            if (isUpdated)
            {
                return NoContent();
            }
            else
            {
                return NotFound("Negotiator not found.");
            }
        }
        /// <summary>
        /// Deletes a negotiator for a specific property.
        /// </summary>
        /// <remarks>
        /// Requires the user to be authorized.
        /// </remarks>
        /// <param name="propertyId">The ID of the property.</param>
        /// <param name="id">The ID of the negotiator.</param>
        /// <returns>No content if the negotiator is deleted successfully, otherwise returns an error message.</returns>

        // DELETE: api/Property/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int propertyId, int id)
        {
            // Validate propertyId
            var property = await _propertyService.GetByIdAsync(propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }
            //we can pass propertyid to the service/repository method for proper but we are just passing negotiator object to the service method here
            bool isDeleted = await _negotiatorService.DeleteAsync(id);

            if (isDeleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound("Negotiator not found.");
            }
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;
using CustomerApi.Repositories;
using AutoMapper;
using CustomerApi.Controllers.Dtos.Read;
using CustomerApi.Controllers.Dtos.Create;
using CustomerApi.Controllers.Dtos.Update;

namespace CustomerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _repository;
    private readonly IMapper _mapper;

    public CustomersController(ICustomerRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CustomerReadDto>> GetCustomer(int id)
    {
        var customer = await _repository.GetByIdAsync(id);
        if (customer == null) return NotFound();
        return _mapper.Map<CustomerReadDto>(customer);
    }

    [HttpPost]
    public async Task<ActionResult<CustomerReadDto>> PostCustomer(CustomerCreateDto customerDto)
    {
        var customer = _mapper.Map<Customer>(customerDto);
        await _repository.CreateAsync(customer);
        return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, _mapper.Map<CustomerReadDto>(customer));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutCustomer(int id, CustomerUpdateDto customerDto)
    {
        var customer = await _repository.GetByIdAsync(id);
        if (customer == null) return NotFound();

        _mapper.Map(customerDto, customer);
        await _repository.UpdateAsync(customer);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var customer = await _repository.GetByIdAsync(id);
        if (customer == null) return NotFound();
        
        await _repository.DeleteAsync(id);
        return NoContent();
    }
}



using Microsoft.AspNetCore.Mvc;
using CustomerCrud.Core;
using CustomerCrud.Requests;
using CustomerCrud.Repositories;
using System.Windows.Markup;

namespace CustomerCrud.Controllers;

[ApiController]
[Route("customers")]
public class CustomerController : ControllerBase
{
  private readonly ICustomerRepository _repository;

  public CustomerController(ICustomerRepository repository)
  {
    _repository = repository;
  }

  [HttpGet]
  public ActionResult GetAll()
  {
    var customers = _repository.GetAll();
    return Ok(customers);
  }

  [HttpGet("{id}", Name = "GetById")]
  public ActionResult GetById(int id)
  {
    var customer = _repository.GetById(id);

    if (customer == null) return NotFound("Customer not found");

    return Ok(customer);
  }

  [HttpPost]
  public ActionResult Create(CustomerRequest request)
  {
    var id = _repository.GetNextIdValue();

    var customer = new Customer(id, request);
    _repository.Create(customer);

    return CreatedAtAction("GetById", new { id = customer.Id }, customer);
  }

  [HttpPut("{id}")]
  public ActionResult Update(int id, CustomerRequest request)
  {
    var didUpdate = _repository.Update(id, new
    {
      Name = request.Name,
      CPF = request.CPF,
      Transactions = request.Transactions,
      UpdatedAt = DateTime.Now
    });

    if(!didUpdate)
      return NotFound("Customer not found.");

    return Ok($"Customer {id} updated!");
  }


  [HttpDelete("{id}")]
  public ActionResult Delete(int id)
  {
    var didDelete = _repository.Delete(id);

    if(!didDelete)
      return NotFound("Customer not found.");

    return NoContent();
  }
}

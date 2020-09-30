using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_api_entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet_api_entity.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<Contact> contacts = new List<Contact>
        {
            new Contact {Id = 1, FirstName = "Dharmendra", LastName="Rathod", NickName="Tillu", Place="Port Blair"},
            new Contact {Id = 2, FirstName = "Sheral", LastName="Rathod", NickName="Golu", Place="Mangalore"},
            new Contact {Id = 3, FirstName = "Sneha", LastName="Rathod", NickName="FuckHot", Place="Darjeeling"},
            new Contact {Id = 4, FirstName = "Shruti", LastName="Rathod", NickName="Wow Job", Place="Belgaum"},
        };
        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        //[HttpGet]
        //[Route("id/[action]/{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound(new { Message = "Contact Not Found in Database", Retry = "You may want to retry with correct ID again"});
            }
            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact newContact)
        {
            contacts.Add(newContact);
            return Ok(contacts);
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put(int id, Contact updateContact)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.NickName = updateContact.NickName;
            contact.IsDeleted = updateContact.IsDeleted;
            return Ok(contacts);

        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contacts.Remove(contact);
            return Ok(contacts);
        }
    }
}

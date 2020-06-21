using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly DoctorDbContext _context;

        public DoctorController(DoctorDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctor.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(_context.Doctor.Where(e => e.IdDoctor == id).Single());
        }

        [HttpPost("{id}")]
        public IActionResult UpdateDoctor(Doctor doctor, int id)
        {
            var doctorUpdate = new Doctor
            {
                IdDoctor = id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };
            _context.Attach(doctorUpdate);
            _context.Entry(doctorUpdate).Property("FirstName").IsModified = true;
            _context.Entry(doctorUpdate).Property("LasttName").IsModified = true;
            _context.Entry(doctorUpdate).Property("Email").IsModified = true;
            _context.SaveChanges();

            return Ok(doctorUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {

            var s = _context.Doctor.Where(s => s.IdDoctor == id).First();
            _context.Doctor.Remove(s);
            _context.SaveChanges();
            return Ok("Done");

        }
    }
}

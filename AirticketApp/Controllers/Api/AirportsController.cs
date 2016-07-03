using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AirticketApp.Dtos;
using AirticketApp.Models;
using AutoMapper;

namespace AirticketApp.Controllers.Api
{
    public class AirportsController : ApiController
    {
        private ApplicationDbContext _context;

        public AirportsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/airports
        public IEnumerable<AirportDto> GetAirports()
        {
            return _context.Airports.ToList().Select(Mapper.Map<Airport, AirportDto>);
        }

        // GET /api/airports/1
        public IHttpActionResult GetAirport(int id)
        {
            var airport = _context.Airports.SingleOrDefault(a => a.Id == id);

            if (airport == null)
            {
                return NotFound();
            }

            return Ok((Mapper.Map<Airport, AirportDto>(airport));
        }

        // POST /api/airports
        [HttpPost]
        public IHttpActionResult CreAirport(AirportDto airportDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var airport = Mapper.Map<AirportDto, Airport>(airportDto);

            _context.Airports.Add(airport);
            _context.SaveChanges();

            airportDto.Id = airport.Id;

            return Created(new Uri(Request.RequestUri + "/" + airport.Id), airportDto);
        }


        // PUT /api/airports/1
        [HttpPut]
        public void UpdateAirport(int id, AirportDto airportDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var airportInDb = _context.Airports.SingleOrDefault(a=> a.Id == id);

            if (airportInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(airportDto, airportInDb);

            _context.SaveChanges();

        }

        // DELETE /api/airportDto/1
        [HttpDelete]
        public void DeleteAirport(int id)
        {
            var airportInDb = _context.Airports.SingleOrDefault(a => a.Id == id);

            if (airportInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Airports.Remove(airportInDb);
            _context.SaveChanges();
        }
    }
}

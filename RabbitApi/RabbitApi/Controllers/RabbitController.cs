using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitApi.Models;


namespace RabbitProj.Controllers

{

    [Route("[controller]")]

    [ApiController]

    public class RabbitsController : ControllerBase
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
       
       
        public RabbitsController()
        {
            Rabbit rabbit1 = new Rabbit("Miki",1, Rabbit.FurColors.Brown, Rabbit.EyeColors.Black, Rabbit.Genders.Female);
            Rabbit rabbit2 = new Rabbit("Kiki",3, Rabbit.FurColors.Grey, Rabbit.EyeColors.Blue, Rabbit.Genders.Male);
            if (!rabbits.Any())
            {
                rabbits.Add(rabbit1);
                rabbits.Add(rabbit2);
            }

        }
        public IEnumerable<Rabbit> Get()
        {

            /*Rabbit rabbit1 = new Rabbit("Miki", Rabbit.FurColors.Brown, Rabbit.EyeColors.Black, Rabbit.Gender.Female);
            Rabbit rabbit2 = new Rabbit("Bibi", Rabbit.FurColors.Grey, Rabbit.EyeColors.Blue, Rabbit.Gender.Male);

            List<Rabbit> rabbits = new List<Rabbit>();
            rabbits.Add(rabbit1);
            rabbits.Add(rabbit2);*/
            return rabbits;

        }


        [HttpGet("{id}", Name = "Get")]

        public Rabbit Get(int id)
        {
            Rabbit rabbit1 = new Rabbit("Miki", 1, Rabbit.FurColors.Brown, Rabbit.EyeColors.Black, Rabbit.Genders.Female);
          
            return rabbit1;

        }

        // POST: Rabbits

        [HttpPost]

        public IActionResult Post([FromBody] Rabbit model)
        {
            if (ModelState.IsValid)
            {
                rabbits.Add(model);
                //save in database
                return Ok();

            }
            return BadRequest();

        }


        // PUT: Rabbits/5

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: ApiWithActions/5

        [HttpDelete("{id}")]

        public void Delete(int id)

        {

        }

    }

}
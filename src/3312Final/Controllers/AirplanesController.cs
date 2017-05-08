using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _3312Final.Data;
using _3312Final.Models;

namespace _3312Final.Controllers
{
    public class AirplanesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirplanesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Airplanes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Airplane.ToListAsync());
        }

        // GET: Airplanes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplane.SingleOrDefaultAsync(m => m.ID == id);
            if (airplane == null)
            {
                return NotFound();
            }

            return View(airplane);
        }

        // GET: Airplanes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Airplanes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Altitude,FlapSetting,Ice,Rain,RunwayDirection,Snow,TripDistance,Weight,WindDirection,WindSpeed")] Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                int windangle;
                int winddir = random.Next(91);
                airplane.WindSpeed = random.Next(0, 26);
                //finds the angle of the wind compared to the plane (0 is head)
                windangle = airplane.RunwayDirection - winddir;
                //makes sure wind angle is positive
                if (windangle < 0)
                {
                    windangle = windangle * -1;
                }
                int chance = random.Next(11);
                //gives 90% chance for headwind
                if (chance < 10)
                {
                    airplane.Headwind = true;
                    int chance2 = random.Next(2);
                    if (chance2 == 1)
                    {
                        airplane.WindDirection = airplane.RunwayDirection + winddir;
                    }
                    else
                    {
                        airplane.WindDirection = airplane.RunwayDirection - winddir;

                    }
                }
                else
                {
                    int chance2 = random.Next(2);
                    if (chance2 == 1)
                    {
                        airplane.WindDirection = airplane.RunwayDirection + winddir + 90;
                    }
                    else
                    {
                        airplane.WindDirection = airplane.RunwayDirection + winddir - 90;
                    }
                    //shows a tailwind
                    airplane.Headwind = false;
                }
                //these two if statements keep the windhead between 0 - 359
                if (airplane.WindDirection < 0)
                {
                    airplane.WindDirection *= -1;
                }
                if (airplane.WindDirection > 360)
                {
                    airplane.WindDirection -= 360;
                }
                //converts the heading (in degrees) to radians

                airplane.DirectionalWind = airplane.WindSpeed * Math.Cos(airplane.WindDirection);

                

                airplane.ID = Guid.NewGuid().ToString();
                _context.Add(airplane);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(airplane);
        }

        // GET: Airplanes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplane.SingleOrDefaultAsync(m => m.ID == id);
            if (airplane == null)
            {
                return NotFound();
            }
            return View(airplane);
        }

        // POST: Airplanes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Altitude,FlapSetting,Ice,Rain,RunwayDirection,Snow,TripDistance,Weight,WindDirection,WindSpeed")] Airplane airplane)
        {
            if (id != airplane.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airplane);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirplaneExists(airplane.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(airplane);
        }

        // GET: Airplanes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplane.SingleOrDefaultAsync(m => m.ID == id);
            if (airplane == null)
            {
                return NotFound();
            }

            return View(airplane);
        }

        // POST: Airplanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var airplane = await _context.Airplane.SingleOrDefaultAsync(m => m.ID == id);
            _context.Airplane.Remove(airplane);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AirplaneExists(string id)
        {
            return _context.Airplane.Any(e => e.ID == id);
        }

        public async Task<IActionResult> Card(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplane.SingleOrDefaultAsync(m => m.ID == id);
            if (airplane == null)
            {
                return NotFound();
            }

            



            return View(airplane);
        }
    }
}

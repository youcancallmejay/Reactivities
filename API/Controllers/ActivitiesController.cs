using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence; 
using Microsoft.AspNetCore.Mvc;
using Domain;
using Microsoft.EntityFrameworkCore;




namespace API.Controllers
{

    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
            
        }
        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync(); 
        }

        [HttpGet("{id}")] //api/acitivities/_____
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);    
        }



    }

}
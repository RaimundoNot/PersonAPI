using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Person.Data;
using Person.Models;

namespace Person.Routes;
public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");

        route.MapPost("", 
            async (PersonRequest req, PersonContext context) =>
            {
              var person = new PersonModels(req.name);
              await context.AddAsync(person);
              await context.SaveChangesAsync();     
            });
    }
}
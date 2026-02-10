using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Routes;

public static class PersonRoute
{
    public static async Task PersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");

        //Create
        route.MapPost("",
            async (PersonRequest req, PersonContext context) =>
            {
                var person = new PersonModels(req.name);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            });

        //Read
        route.MapGet("", async (PersonContext context) =>
        {
            var people = await context.People.ToListAsync();
            return Results.Ok(people);
        });

        //Update
        route.MapPut("{id:guid}",
        async (Guid id, PersonRequest req, PersonContext context) =>
        {
            var person =
                await context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person == null)
                return Results.NotFound();

            person.ChangeName(req.name);
            await context.SaveChangesAsync();

            return Results.Ok(person);
        });
        
        //Delete
        route.MapDelete("{id:guid}", 
        async (Guid id, PersonContext context) =>
        {
            var person = 
                await context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person == null)
                return Results.NotFound();
            
            person.SetInactive();
            await context.SaveChangesAsync();

            return Results.Ok(person);
        });
    }
}
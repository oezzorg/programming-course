using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    /// <summary>
    /// Obtener todos los usuarios
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        using var db = new Context();

        List<User> users = db.Users
            .OrderBy(user => user.Id)
            .ToList();
        
        return Ok(users);
    }

    /// <summary>
    /// Crear un usuario
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<User> CreateUser(User user)
    {
        // Conectarse a la base de datos
        using var db = new Context();
        
        user.Created = DateTime.UtcNow;

        // Agregamos a la tabla "Users"
        db.Users.Add(user);
        // Guardamos cambios en la base de datos
        db.SaveChanges();
        
        return Created(nameof(GetUser), user);
    }

    /// <summary>
    /// Obtener un usuario por su username
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id:int}")]
    public ActionResult<User> GetUser(int id)
    {
        using var db = new Context();
        
        var user = db.Users.FirstOrDefault(u => u.Id == id);

        if (user is null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    /// <summary>
    /// Actualizar un usuario
    /// </summary>
    /// <param name="id"></param>
    /// <param name="sentUser"></param>
    /// <returns></returns>
    [HttpPut("{id:int}")]
    public ActionResult<User> UpdateUser(int id, User sentUser)
    {
        using var db = new Context();
        try
        {
            User userToUpdate = db.Users.First(u => u.Id == id);
            userToUpdate.Username = sentUser.Username;
            userToUpdate.Email = sentUser.Email;
            userToUpdate.Password = sentUser.Password;
            userToUpdate.Updated = DateTime.UtcNow;
            
            // Actualizamos en la tabla de usuarios
            db.Users.Update(userToUpdate);
            
            // Guardamos cambios en la base de datos
            db.SaveChanges();
            
            return Ok(userToUpdate);
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }

    /// <summary>
    /// Eliminar un usuario
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id:int}")]
    public ActionResult DeleteUser(int id)
    {
        using var db = new Context();
        try
        {
            User userToDelete = db.Users.First(u => u.Id == id);
            
            // Eliminar de la tabla de usuarios
            db.Users.Remove(userToDelete);
            
            // Guardamos cambios en la base de datos
            db.SaveChanges();
            
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }
}
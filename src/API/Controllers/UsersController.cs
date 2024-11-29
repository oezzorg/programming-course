using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    /// <summary>
    /// Simulación de base de datos
    /// </summary>
    private static readonly List<User> Users = [];

    /// <summary>
    /// Obtener todos los usuarios
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        List<User> users = Users;
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
        user.Id = Users.Count + 1;
        user.Created = DateTime.UtcNow;
        Users.Add(user);
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
        var user = Users.FirstOrDefault(u => u.Id == id);

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
        try
        {
            User userToUpdate = Users.First(u => u.Id == id);
            userToUpdate.Username = sentUser.Username;
            userToUpdate.Email = sentUser.Email;
            userToUpdate.Password = sentUser.Password;
            userToUpdate.Updated = DateTime.UtcNow;
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
        try
        {
            User userToDelete = Users.First(u => u.Id == id);
            Users.Remove(userToDelete);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }
}
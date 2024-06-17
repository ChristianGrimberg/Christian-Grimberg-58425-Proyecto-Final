using System.Data.SqlClient;

using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Proyecto_Final.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
  [HttpGet(Name = "ObtenerUsuarios")]
  [ProducesResponseType<List<Usuario>>(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult ObtenerUsuarios()
  {
    var users = UsuarioBussiness.ListarUsuarios(Connection.DatabaseConnection);

    return users.Count == 0 ? NotFound() : Ok(users.ToArray());
  }

  [HttpGet("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public ActionResult<Usuario> ObtenerUsuarioPorId(int id)
  {
      var user = UsuarioBussiness.ObtenerUsuario(Connection.DatabaseConnection, id);
      return user.Id == 0 ? NotFound() : user;
  }

  [HttpPut(Name = "ModificarUsuario")]
  public void ModificarUsuario([FromBody] Usuario usuario)
  {
    UsuarioBussiness.ModificarUsuario(Connection.DatabaseConnection, usuario);
  }
}
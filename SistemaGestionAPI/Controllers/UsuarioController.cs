using System.Data.SqlClient;

using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Proyecto_Final.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
  [HttpPut(Name = "ModificarUsuario")]
  public void ModificarUsuario([FromBody] Usuario usuario)
  {
    UsuarioBussiness.ModificarUsuario(Connection.DatabaseConnection, usuario);
  }
}
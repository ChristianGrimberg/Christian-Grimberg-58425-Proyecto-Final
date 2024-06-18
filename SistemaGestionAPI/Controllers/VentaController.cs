using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

using SistemaGestionAPI.Models;

namespace SistemaGestionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VentaController : ControllerBase
{
  [HttpPost(Name = "CargarVenta")]
  public void CargarVenta(Venta venta)
  {
    VentaBussiness.CrearVenta(Connection.DatabaseConnection, venta);
  }
}
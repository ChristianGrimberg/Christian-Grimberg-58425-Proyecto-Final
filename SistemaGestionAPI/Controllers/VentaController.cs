using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

namespace Christian_Grimberg_58425_Proyecto-Final.Controllers;

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
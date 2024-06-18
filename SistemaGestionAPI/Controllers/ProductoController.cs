﻿using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;

using SistemaGestionEntities;

using SistemaGestionAPI.Models;

namespace SistemaGestionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductoController : ControllerBase
{
  [HttpPost(Name = "CrearProducto")]
  public void CrearProducto([FromBody] Producto producto)
  {
    ProductoBussiness.CrearProducto(Connection.DatabaseConnection, producto);
  }

  [HttpPut(Name = "ModificarProducto")]
  public void ModificarProducto([FromBody] Producto producto)
  {
    ProductoBussiness.ModificarProducto(Connection.DatabaseConnection, producto);
  }

  [HttpDelete(Name = "EliminarProducto")]
  public void EliminarProducto([FromBody] int id)
  {
    ProductoBussiness.EliminarProducto(Connection.DatabaseConnection, ProductoBussiness.ObtenerProducto(Connection.DatabaseConnection, id));
  }
}
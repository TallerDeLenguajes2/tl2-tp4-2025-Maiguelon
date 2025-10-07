using miCadeteria;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp4_2025_Maiguelon.Controllers;

[ApiController]
[Route("[controller]")]
public class CadeteriaController : ControllerBase
{
    private Cadeteria cadeteria;

    public CadeteriaController()
    {
        cadeteria = new Cadeteria("Cadeteria HallowNest", "3819356782");

        cadeteria.Cadetes = new List<Cadete>()
        {
            new Cadete(1, "Sherma", "High Halls 236", "3883098463"),
            new Cadete(2, "Hornet", "Queen Garden 10", "3867871948")
        };

        cadeteria.Clientes = new List<Cliente>()
        {
            new Cliente("Lace", "ClockWork 123", "38748593484", "Insecto Blanco portador de aguja", 40),
            new Cliente("Shanka", "BileWater 234", "381456709456", "Insecto alto guerrero", 41)
        };

        cadeteria.ListadoPedidos1 = new List<Pedidos>()
        {
            new Pedidos(10, "No agitar", estado_pedido.En_camino, "Milanesa Napolitana", cadeteria.Clientes[0]),
            new Pedidos(11, "Evitar cruzar la Gusanera", estado_pedido.Listo_para_retirar, "12 empanadas de carne", cadeteria.Clientes[1])
        };

        cadeteria.ReasignarPedido(cadeteria.Cadetes[0], cadeteria.ListadoPedidos1[0]);
        cadeteria.ReasignarPedido(cadeteria.Cadetes[1], cadeteria.ListadoPedidos1[1]);
    }

    [HttpGet("GetPedidos")]
    public ActionResult<List<Pedidos>> GetPedidos()
    {
        return Ok(cadeteria.ListadoPedidos1);
    } 
}
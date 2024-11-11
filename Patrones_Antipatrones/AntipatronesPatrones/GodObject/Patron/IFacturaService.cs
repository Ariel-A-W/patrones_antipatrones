using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.GodObject.Patron;

public interface IFacturaService
{
    void GenerarFactura(Pedido pedido);
}

using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.GodObject.Patron;

public interface IPagoService
{
    void ProcesarPago(Pedido pedido);
}

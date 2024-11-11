using Patrones_Antipatrones.AntipatronesPatrones.SpaghettiCode.Entidades;

namespace Patrones_Antipatrones.AntipatronesPatrones.GodObject.Patron;

public interface INotificacionService
{
    void EnviarNotificacion(Pedido pedido);
}

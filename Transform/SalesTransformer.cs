using HorizonETL.Models;

namespace HorizonETL.Transform;

public class SalesTransformer
{
    public List<object> Transform(List<SaleRecord> records)
    {
        return records.Select(r => new
        {
            date = r.Fecha.ToString("yyyy-MM-dd"),
            customer = r.Cliente.Trim(),
            product = r.Producto.Trim(),
            quantity = r.Cantidad,
            price = r.Precio,
            total = r.Total
        }).ToList<object>();
    }
}
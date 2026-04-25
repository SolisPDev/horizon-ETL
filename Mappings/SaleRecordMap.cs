using CsvHelper.Configuration;
using HorizonETL.Models;

namespace HorizonETL.Mappings;

public class SaleRecordMap : ClassMap<SaleRecord>
{
    public SaleRecordMap()
    {
        Map(m => m.Fecha).Name("fecha");
        Map(m => m.Cliente).Name("cliente");
        Map(m => m.Producto).Name("producto");
        Map(m => m.Cantidad).Name("cantidad");
        Map(m => m.Precio).Name("precio");
    }
}
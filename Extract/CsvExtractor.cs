using CsvHelper;
using System.Globalization;
using HorizonETL.Models;
using HorizonETL.Mappings;

namespace HorizonETL.Extract;

public class CsvExtractor
{
    public List<SaleRecord> Extract(string filePath)
    {
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, new CultureInfo("es-MX"));

        // AQUÍ se descarta la primera fila (encabezados) y
        // se mapea a la clase SaleRecord asi independientemente de si estan escritas en mayusculas o minusculas
        csv.Context.RegisterClassMap<SaleRecordMap>();

        // Simplificación de la inicialización de la colección usando ToList directamente
        return csv.GetRecords<SaleRecord>().ToList();
    }
}
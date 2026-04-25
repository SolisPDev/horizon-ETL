using HorizonETL.Extract;
using HorizonETL.Transform;
using HorizonETL.Load;

Console.WriteLine("🚀 HorizonETL iniciado...");

var extractor = new CsvExtractor();
var transformer = new SalesTransformer();
var loader = new ApiLoader();

var filePath = "data/sales.csv";

// Extract
var records = extractor.Extract(filePath);
Console.WriteLine($"Extracted: {records.Count} records");

// Transform
var transformed = transformer.Transform(records);
Console.WriteLine("Transformation completed");

// Load
await loader.SendAsync(transformed);
Console.WriteLine("Load completed");

Console.WriteLine("✅ ETL finalizado");
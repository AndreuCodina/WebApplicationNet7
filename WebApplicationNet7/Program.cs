var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/nullability", (MyDto dto) =>
{
    return TypedResults.Ok(dto.NonNullableField);
});


app.Run();

public class MyDto
{
    public required string NonNullableField { get; set; }
}
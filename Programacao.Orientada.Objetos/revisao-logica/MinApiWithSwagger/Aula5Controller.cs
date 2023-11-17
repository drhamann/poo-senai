using Aula_5;
using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger;

[ApiController]
[Route("[controller]")]
public class Aula5Controller : ControllerBase
{
    FiguraGeometrica FiguraGeometrica { get; set; }

    [HttpGet("figura-geometrica-quadrado")]
    public IActionResult Quadrado(double lado)
    {
        FiguraGeometrica = new Quadrado(lado);

        return Ok(FiguraGeometrica.ToString());
    }

    [HttpGet("figura-geometrica-circulo")]
    public IActionResult Circulo(double raio)
    {
        FiguraGeometrica = new Circulo(raio);

        return Ok(FiguraGeometrica.ToString());
    }

    [HttpGet("figura-geometrica-quadrado-retangulo")]
    public IActionResult Quadrado_Retangulo(double lado)
    {
        FiguraGeometrica quadrado = new Retangulo(lado, lado);
        FiguraGeometrica retangulo = new Quadrado(lado);


        return Ok(
            $"{retangulo.ToString()}" +
            $"\r\n{quadrado.ToString()}");
    }
}

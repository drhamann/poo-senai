using Aula_5;
using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger;

[ApiController]
[Route("[controller]")]
public class Aula5Controller : ControllerBase
{
    FiguraGeometrica FiguraGeometrica { get; set; }
    public Aula5Controller()
    {
    }

    [HttpGet("figura-geometrica-quadrado")]
    public IActionResult Quadrado(double lado)
    {
        FiguraGeometrica = new Quadrado(lado);
        if (FiguraGeometrica is Retangulo retangulo)
        {
            retangulo.Altura = lado;
            retangulo.Lado = lado;
        }

        return Ok(FiguraGeometrica.ToString());
    }

    [HttpGet("figura-geometrica-circulo")]
    public IActionResult Circulo(double raio)
    {
        FiguraGeometrica = new Circulo(raio);

        return Ok(FiguraGeometrica.ToString());
    }

    [HttpGet("figura-geometrica-quadrado-retangulo")]
    public IActionResult Quadrado_Retangulo(double lado, double altura)
    {
        FiguraGeometrica quadrado = new Retangulo(lado, altura);
        FiguraGeometrica retangulo = new Quadrado(lado);

        return Ok(
            $"{retangulo.ToString()}" +
            $"\r\n{quadrado.ToString()}");
    }
}

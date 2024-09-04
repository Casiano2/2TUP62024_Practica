using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    public int result;
    [HttpGet]
    public int Get(int num1, int num2, int num3)
    {
        result = num1 + num2 + num3;
        return result;
    }
}
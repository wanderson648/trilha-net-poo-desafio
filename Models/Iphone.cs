

namespace trilha_net_poo_desafio.Models;

class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }


    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo \"{nome}\" no Iphone");
    }
}

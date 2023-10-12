using System.Globalization;

namespace trilha_net_poo_desafio.Models;

abstract class Smartphone 
{
    public string Numero { get; set; }
    public string Modelo { get; private set;}
    public string Imei { get; private set; }
    public int Memoria { get; private set; }

    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebenco ligação...");
    }

    public abstract void InstalarAplicativo(string nome);
}

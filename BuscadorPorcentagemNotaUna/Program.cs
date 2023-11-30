using BuscadorPorcentagemNotaUna.Models;
using static System.Console;

WriteLine($"\nInício Avaliação - {DateTime.Now}");
Nota nota = new();
Conversor conversor = new();
int stop = 0;

do
{
    nota.TipoNota = conversor.LerTipoNota();
    nota.NotaColetada = conversor.LerNota();
    conversor.ValidaTipoNota(nota);
    conversor.CalcularPorcentagem(nota);

    WriteLine("\nContinuar avaliando, digite 1, senão digite 0:");
    stop = Convert.ToInt32(ReadLine());
    Clear();
} while (stop > 0);

WriteLine("\nAté o próximo semestre!!! =)");
using static System.Console;
namespace BuscadorPorcentagemNotaUna.Models;

public class Conversor
{
    public void ValidaTipoNota(Nota nota)
    {
        nota.TetoNota = nota.TipoNota switch
        {
            1 => 30,
            3 => 40,
            _ => (double)1,
        };
    }
    public void CalcularPorcentagem(Nota nota)
    {
        if (nota.NotaColetada > 0)
        {
            double porcentagem = (nota.NotaColetada * 100) / nota.TetoNota;
            WriteLine($"\nEm uma prova valendo: {nota.TetoNota} pontos.");
            WriteLine($"\nAluno(a) ficou: {porcentagem:N} % porcento!!!");
        }
        else
            WriteLine($"\n0% porcento!");
    }
    public int LerTipoNota()
    {
        try
        {
            WriteLine("\nInforme '1' para avaliação A01, '3' para avaliação A03: ");
            int tipoNota = Convert.ToInt32(ReadLine());
            return tipoNota;
        }
        catch (Exception e)
        {
            WriteLine($"\nErro ao obter tipo nota.\nErro: {e}");
            return 0;
        }
    }

    public double LerNota()
    {
        try
        {
            WriteLine("\nInforme a nota do aluno(a): ");
            double nota = Convert.ToDouble(ReadLine());
            return nota;
        }
        catch (Exception e)
        {
            WriteLine($"\nErro ao obter nota.\nErro: {e}");
            return 0;
        }
    }
}


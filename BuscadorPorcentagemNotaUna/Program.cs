﻿using BuscadorPorcentagemNotaUna.Models;
using static System.Console;

WriteLine($"\nInício Avaliação - {DateTime.Now}");
Nota nota = new();
int stop;

nota.TipoAvaliacao = Conversor.LerTipoNota();
do
{
    if(nota.TipoAvaliacao == 1 || nota.TipoAvaliacao == 3)
    {
        Clear();
        WriteLine($"\nAvaliacao Escolhida: A{nota.TipoAvaliacao}");
        nota.NotaColetada = Conversor.LerNota();
        Conversor.ValidaTipoNota(nota);
        Conversor.CalcularPorcentagem(nota);

        WriteLine("\nContinuar avaliando, digite 1, senão digite 0:");
        stop = Convert.ToInt32(ReadLine());
        Clear();
    } else
    {
        Clear();
        WriteLine("\nContinuar avaliando, digite 1, senão digite 0:");
        stop = Convert.ToInt32(ReadLine());
        Clear();
    }
} while (stop > 0);

WriteLine($"\nAté o próximo semestre!!! =) - {DateTime.Now}");
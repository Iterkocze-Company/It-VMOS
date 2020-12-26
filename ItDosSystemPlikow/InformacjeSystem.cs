﻿using System;

namespace CosmosKernel2
{
    class InformacjeSystem
    {
        public static void Informacje_o_Systemie()
        {
            Console.WriteLine("System: Iterkocze Company. (R) It-VMOS 32-Bit OS");
            Console.WriteLine("Wersja systemu: 0.0.5.8: Service Pack 1");
            Console.WriteLine("Data wydania: 20.12.2020");
            Console.WriteLine("RAM: " + Cosmos.Core.CPU.GetAmountOfRAM() + " MB");
            Console.WriteLine($"Ilosc wolnego miejsca: {Kernel.fs.GetAvailableFreeSpace("0:/") / 1000000}MB");
            Console.WriteLine($"Typ systemu plikow: {Kernel.fs.GetFileSystemType("0:/")}");
        }
    }
}

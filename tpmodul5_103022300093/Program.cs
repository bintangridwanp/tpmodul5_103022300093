using System;

class Program
{
    static void Main()
    {
        // Memanggil generic method
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Budi");

        // Menggunakan generic class
        DataGeneric<string> data = new DataGeneric<string>("1202200001");
        data.PrintData();
    }
}
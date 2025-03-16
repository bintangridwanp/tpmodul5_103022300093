using tpmodul5_103022300093;
using System;
namespace tpmodul5_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("NamaPanggilan");

            DataGeneric<string> data = new DataGeneric<string>("NIMAnda");
            data.PrintData();
        }
    }
}

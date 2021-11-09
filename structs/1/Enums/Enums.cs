using System;
using System.Collections.Generic;
using System.Text;

namespace Programming1.Enums
{
    public class Enums
    {
        public void Executar()
        {
            DiasDaSemana primeiroDia = DiasDaSemana.seg;
            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.ter | DiasDeTrabalho.qui | DiasDeTrabalho.sex;
            Console.WriteLine(diasDeTrabalho);
        }
    }
    enum DiasDaSemana : long { seg, ter, qua, qui, sex, sab, dom}
    [Flags]
    enum DiasDeTrabalho : long { seg = 0, ter = 1, qua = 2, qui = 4, sex = 8, sab = 16, dom = 32}
}

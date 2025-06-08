using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDisc.Classes.Codes
{
    public enum ErrorCodes
    {
        NoError = 0x0000,

        // FileSystem Error
        fsNotADirectory = 0x0100,
        fsNotAFile = 0x0101
    }
}

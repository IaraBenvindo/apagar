using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fidelizando.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}

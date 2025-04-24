using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNotebook.Core.Enums
{
    public enum VeteranStatusType
    {
        None = 0, // Heç bir statusu olmayan
        WarVeteran = 1, // Müharibə veteranı
        LaborVeteran = 2, // Əmək veteranı
        MilitaryServiceVeteran = 3, // Hərbi xidmət veteranı
        ArmedForcesVeteran = 4, // Silahlı Qüvvələr veteranı
        KarabakhWarVeteran = 5, // Qarabağ müharibəsi veteranı
        SecondKarabakhWarVeteran = 6, // 2020-ci Vətən Müharibəsi veteranı
        DisabledVeteran = 7 // Xəsarət almış (əlil) veteran

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GMap.NET
{
   static class Constants
   {
      public const double centralMeridian = 0.41887902047863912;  // Center longitude (projection center) 
      public const double COS_67P5 = 0.38268343236508977;  // cosine of 67.5 degrees
      public const double latOrigin = 0.0;                     // center latitude
      public const double semiMajor = 6378137.0;		    // major axis
      public const double semiMinor = 6356752.3141403561; // minor axis
      public const double semiMinor2 = 6356752.3142451793;		// minor axis
      public const double AD_C = 1.0026000;               // Toms region 1 constant
      public const double metersPerUnit = 1.0;
      public const double Flattening = (1.0 / 298.257222101);
   }
}

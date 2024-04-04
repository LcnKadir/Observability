using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observability
{
    internal class ActivitySourceProvider
    {
        internal static ActivitySource Source = new ActivitySource(OpenTelemetryConstants.ActivitySourceName);
    }
}

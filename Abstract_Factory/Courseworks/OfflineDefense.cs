using Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Courseworks
{
    public class OfflineDefense : ISubmissionCoursework
    {
        public void Submit(string load)
        {

            if (string.IsNullOrWhiteSpace(load)) throw new ArgumentNullException(nameof(load));

            var s = load.Trim();

            if (!s.EndsWith(".MP4", StringComparison.OrdinalIgnoreCase)) throw new ArgumentException("Expected a string that ends with '.MP4'.", nameof(load));

        }
    }
}

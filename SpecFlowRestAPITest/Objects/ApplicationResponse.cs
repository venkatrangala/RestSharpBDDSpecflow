using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowRestAPITest.Objects
{
    public class ApplicationResponse
    {
        public string id { get; set; }
        public string applicationReference { get; set; }
        public string sessionToken { get; set; }
        public DateTime applicationStartDate { get; set; }
        public DateTime applicationLastUpdatedDate { get; set; }
        public DateTime applicationSubmittedDate { get; set; }
        public DateTime applicationCompletedDate { get; set; }
        public string applicationStatus { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surferbot.Core.Exceptions
{
    public class ErrorValidationException: SystemException
    {
        public List<string> Errors { get; set; }
        public ErrorValidationException(List<string> errorMenssages)
        {
            Errors = errorMenssages;

        }
    }
}

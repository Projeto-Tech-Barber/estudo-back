using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surferbot.Application.Modelos
{
    public class ErrorValidationModel
    {
        public List<string> Errors { get; set; }

        public ErrorValidationModel(List<string> errors)
        {
            Errors = errors;
        }
    }
}

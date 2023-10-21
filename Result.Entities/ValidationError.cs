using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result.Entities
{
    public class ValidationError : Error
    {
        public string[] Errors { get; set; }

        public ValidationError(params string[] errors)
        {
            Errors = errors;
        }
    }
}

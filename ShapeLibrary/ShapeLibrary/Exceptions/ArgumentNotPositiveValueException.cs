using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Exceptions
{
  internal class ArgumentNotPositiveValueException(string? message) : Exception(message)
  {
  }
}

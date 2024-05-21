using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Exceptions
{
  public class ArgumentSideLengthException(string? message) : ArgumentException(message)
  {
  }
}

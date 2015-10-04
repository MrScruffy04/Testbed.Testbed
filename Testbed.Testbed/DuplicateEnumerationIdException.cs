using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Testbed.Testbed
{
	public class DuplicateEnumerationIdException : Exception
	{
		public DuplicateEnumerationIdException()
		{
		}

		public DuplicateEnumerationIdException(string message)
			: base(message)
		{
		}

		public DuplicateEnumerationIdException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}

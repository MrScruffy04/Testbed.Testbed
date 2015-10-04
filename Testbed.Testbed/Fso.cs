using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using LinqToTree;

namespace Testbed.Testbed
{
	public class Fso : ILinqToTree<Fso>
	{
		private List<Fso> _children;

		public Fso(string name, params Fso[] children)
		{
			Name = name;
			_children = children.ToList();

			foreach (var child in children)
			{
				child.Parent = this;
			}
		}

		#region ILinqToTree<Fso> Members

		public IEnumerable<ILinqToTree<Fso>> Children { get { return _children; } }

		public ILinqToTree<Fso> Parent { get; private set; }

		public Fso Item
		{
			get { return this; }
		}

		#endregion

		public string Name { get; private set; }

		public override string ToString()
		{
			return ToString(0);
		}

		private string ToString(int indent)
		{
			var sb = new StringBuilder();

			sb.Append(new String('\t', indent));
			sb.AppendLine(Name);

			foreach (var child in _children)
			{
				sb.Append(child.ToString(indent + 1));
			}

			return sb.ToString();
		}
	}
}

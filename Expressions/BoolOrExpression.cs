﻿using Exodrifter.Rumor.Engine;
using System;
using System.Runtime.Serialization;

namespace Exodrifter.Rumor.Expressions
{
	/// <summary>
	/// Represents a boolean "or" operator.
	/// </summary>
	[Serializable]
	public class BoolOrExpression : OpExpression
	{
		public BoolOrExpression(Expression left, Expression right)
			: base(left, right)
		{
		}

		public override Value Evaluate(Engine.Rumor rumor)
		{
			var l = left.Evaluate(rumor);
			var r = right.Evaluate(rumor);
			return l.BoolOr(r);
		}

		public override string ToString()
		{
			return left + " or " + right;

		}

		#region Serialization

		public BoolOrExpression
			(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		#endregion
	}
}

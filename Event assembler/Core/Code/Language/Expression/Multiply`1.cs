﻿// Decompiled with JetBrains decompiler
// Type: Nintenlord.Event_Assembler.Core.Code.Language.Expression.Multiply`1
// Assembly: Core, Version=9.10.4713.28131, Culture=neutral, PublicKeyToken=null
// MVID: 65F61606-8B59-4B2D-B4B2-32AA8025E687
// Assembly location: E:\crazycolorz5\Dropbox\Unified FE Hacking\ToolBox\EA V9.12.1\Core.exe

using Nintenlord.IO;

namespace Nintenlord.Event_Assembler.Core.Code.Language.Expression
{
  public sealed class Multiply<T> : BinaryOperator<T>
  {
    public Multiply(IExpression<T> first, IExpression<T> second, FilePosition position)
      : base(first, second, EAExpressionType.Multiply, position)
    {
    }
  }
}

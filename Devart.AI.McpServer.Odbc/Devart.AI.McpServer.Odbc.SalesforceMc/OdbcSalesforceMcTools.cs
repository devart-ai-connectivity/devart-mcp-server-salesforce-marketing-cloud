// --------------------------------------------------------------------------
// <copyright file="OdbcSalesforceMcTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using Devart.AI.McpServer.Odbc.SalesforceMc.Tools;
using ModelContextProtocol.Server;

namespace Devart.AI.McpServer.Odbc.SalesforceMc
{
  internal static class OdbcSalesforceMcTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcSalesforceMcPrimaryKeysTool(configuration))
        .Add(new OdbcSalesforceMcForeignKeysTool(configuration))
        .Build();
  }
}
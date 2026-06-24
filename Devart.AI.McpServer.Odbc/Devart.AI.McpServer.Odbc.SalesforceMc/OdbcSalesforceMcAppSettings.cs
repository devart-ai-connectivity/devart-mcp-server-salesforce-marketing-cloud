// --------------------------------------------------------------------------
// <copyright file="OdbcSalesforceMcAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.SalesforceMc
{
  internal sealed class OdbcSalesforceMcAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Salesforce Marketing Cloud";

    public override bool OnPremise => false;
  }
}

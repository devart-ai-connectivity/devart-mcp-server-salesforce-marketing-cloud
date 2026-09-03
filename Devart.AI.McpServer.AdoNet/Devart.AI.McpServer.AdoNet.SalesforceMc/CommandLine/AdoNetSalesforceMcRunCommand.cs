// --------------------------------------------------------------------------
// <copyright file="AdoNetSalesforceMcRunCommand.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using Devart.AI.McpServer.AdoNet.CommandLine;
using Devart.AI.McpServer.AdoNet.SalesforceMc.Properties;
using Devart.AI.McpServer.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Devart.AI.McpServer.AdoNet.SalesforceMc.CommandLine
{
  internal sealed class AdoNetSalesforceMcRunCommand : AdoNetRunCommand
  {
    protected override void SetupConnectionBuilder(IHostApplicationBuilder builder) => builder.Services.AddSingleton<IConnectionBuilder, AdoNetSalesforceMcConnectionBuilder>();

    protected override void SetupMetadata(IHostApplicationBuilder builder) => builder.Services.AddSingleton<IMetadata, AdoNetCloudMetadata>();

    protected override void RegisterTools(IMcpServerBuilder serverBuilder, McpConfiguration configuration)
      => serverBuilder.WithTools(AdoNetCloudTools.CreateTools(configuration));

    public override string ProductFullName => ProductInfo.ProductFullName;

    public override string ProductId => ProductInfo.ProductId;

    protected override McpAppSettings CreateAppSettings() => new AdoNetSalesforceMcAppSettings();
  }
}
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Bicep.Core.Diagnostics;

namespace Bicep.Core.TypeSystem.Providers
{
    public interface IResourceTypeProviderFactory
    {
        ResultWithDiagnostic<IResourceTypeProvider> GetResourceTypeProvider(Uri typesTgzUri, bool useAzLoader);

        IResourceTypeProvider GetBuiltInAzResourceTypesProvider();
    }
}

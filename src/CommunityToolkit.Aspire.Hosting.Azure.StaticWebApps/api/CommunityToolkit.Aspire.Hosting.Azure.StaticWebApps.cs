//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class SwaAppHostingExtension
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> AddSwaEmulator(this IDistributedApplicationBuilder builder, string name, SwaResourceOptions options) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> AddSwaEmulator(this IDistributedApplicationBuilder builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> WithApiResource(this ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> builder, ApplicationModel.IResourceBuilder<ApplicationModel.IResourceWithEndpoints> apiResource) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> WithAppResource(this ApplicationModel.IResourceBuilder<ApplicationModel.SwaResource> builder, ApplicationModel.IResourceBuilder<ApplicationModel.IResourceWithEndpoints> appResource) { throw null; }
    }

    public partial class SwaResourceOptions
    {
        public int DevServerTimeout { get { throw null; } set { } }

        public int Port { get { throw null; } set { } }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public partial class SwaApiEndpointAnnotation : IResourceAnnotation
    {
        public SwaApiEndpointAnnotation(IResourceBuilder<IResourceWithEndpoints> resource) { }

        public string Endpoint { get { throw null; } }
    }

    public partial class SwaAppEndpointAnnotation : IResourceAnnotation
    {
        public SwaAppEndpointAnnotation(IResourceBuilder<IResourceWithEndpoints> resource) { }

        public string Endpoint { get { throw null; } }
    }

    public partial class SwaResource : ExecutableResource
    {
        public SwaResource(string name, string workingDirectory) : base(default!, default!, default!) { }
    }
}
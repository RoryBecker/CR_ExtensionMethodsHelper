using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_ExtensionMethodsHelper
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_ExtensionMethodsHelperExtension : IVsixPluginExtension { }
}
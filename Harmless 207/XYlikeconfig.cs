using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Harmless_207
{
    public sealed class XYlikeconfig : IConfig
    {
        [Description("Do you want to enable the plugin? / 是否开启此插件?")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Is 1853 harmless? / 是否开启1853(洗手液)无害?")]
        public bool Harmless_1853 { get; set; } = true;
    }
}

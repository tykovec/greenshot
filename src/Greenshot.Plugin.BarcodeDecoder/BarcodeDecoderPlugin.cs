using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Greenshot.Base.Core;
using Greenshot.Base.Interfaces;
using Greenshot.Base.Interfaces.Plugin;
using log4net.Config;

namespace Greenshot.Plugin.BarcodeDecoder
{
    public class BarcodeDecoderPlugin : IGreenshotPlugin
    {
        private IGreenshotHost _host;
        private PluginAttribute _pluginAttribute;
        private BarcodeDecoderConfiguration _config;

        public string Name => "BarcodeDecoder";

        public bool IsConfigurable => false;

        public BindingList<BarcodeInfo> DecodedValues { get; private set; } = new BindingList<BarcodeInfo>();

        public void Configure()
        {

        }

        public IEnumerable<IDestination> Destinations()
        {
            yield return new BarcodeDecoderDestination(this);
        }

        public void Dispose()
        {

        }

        public bool Initialize()
        {
            // Get configuration
            //_config = IniConfig.GetIniSection<ImgurConfiguration>();
            //_resources = new ComponentResourceManager(typeof(ImgurPlugin));

            //ToolStripMenuItem itemPlugInRoot = new ToolStripMenuItem("Imgur")
            //{
            //    Image = (Image)_resources.GetObject("Imgur")
            //};

            // Provide the IDestination
            SimpleServiceProvider.Current.AddService(Destinations());
            //_historyMenuItem = new ToolStripMenuItem(Language.GetString("imgur", LangKey.history));
            //_historyMenuItem.Click += delegate { ImgurHistory.ShowHistory(); };
            //itemPlugInRoot.DropDownItems.Add(_historyMenuItem);

            //_itemPlugInConfig = new ToolStripMenuItem(Language.GetString("imgur", LangKey.configure));
            //_itemPlugInConfig.Click += delegate { _config.ShowConfigDialog(); };
            //itemPlugInRoot.DropDownItems.Add(_itemPlugInConfig);

            //PluginUtils.AddToContextMenu(itemPlugInRoot);
            //Language.LanguageChanged += OnLanguageChanged;

            //// Enable history if there are items available
            //UpdateHistoryMenuItem();

            return true;
        }

        public IEnumerable<IProcessor> Processors() => Enumerable.Empty<IProcessor>();

        public void Shutdown()
        {
        }
    }
}

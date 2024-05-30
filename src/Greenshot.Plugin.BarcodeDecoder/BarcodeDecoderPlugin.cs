using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Greenshot.Base.Core;
using Greenshot.Base.IniFile;
using Greenshot.Base.Interfaces;
using Greenshot.Base.Interfaces.Plugin;

namespace Greenshot.Plugin.BarcodeDecoder
{
    public class BarcodeDecoderPlugin : IGreenshotPlugin
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(BarcodeDecoderPlugin));

        private BarcodeDecoderConfiguration _config;

        public string Name => "BarcodeDecoder";

        public bool IsConfigurable => true;

        private BindingList<BarcodeInfo> _decodedValues = new BindingList<BarcodeInfo>();

        public BindingList<BarcodeInfo> GetDecodedValues() => _decodedValues;

        public void AddDecodedValue(BarcodeInfo bi)
        {
            _decodedValues.Insert(0, bi);
            if (_config.MaxLastValuesSize >= 0 && _decodedValues.Count > _config.MaxLastValuesSize)
            {
                var toRemove = _decodedValues.Count - _config.MaxLastValuesSize;

                Log.Debug($"Decoded values higher than max value ({_decodedValues.Count} > {_config.MaxLastValuesSize}), removing additional values ({toRemove})");
                for (int i = 0; i < toRemove; i++)
                {
                    _decodedValues.Remove(_decodedValues.Last());
                }
            }
        }

        public void Configure()
        {
            _config.ShowConfigDialog();
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
            _config = IniConfig.GetIniSection<BarcodeDecoderConfiguration>();

            // Provide the IDestination
            SimpleServiceProvider.Current.AddService(Destinations());

            //_resources = new ComponentResourceManager(typeof(ImgurPlugin));

            //ToolStripMenuItem itemPlugInRoot = new ToolStripMenuItem("Imgur")
            //{
            //    Image = (Image)_resources.GetObject("Imgur")
            //};

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

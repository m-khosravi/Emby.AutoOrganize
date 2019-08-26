using System;
using System.Collections.Generic;
using Emby.AutoOrganizeMD.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using System.IO;
using MediaBrowser.Model.Drawing;

namespace Emby.AutoOrganizeMD
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages, IHasThumbImage
    {
        public Plugin(IApplicationPaths appPaths, IXmlSerializer xmlSerializer)
            : base(appPaths, xmlSerializer)
        {
        }

        public override string Name => "Auto Organize EP edition";


        public override string Description
            => "Automatically organize new media EP edition";

        public PluginConfiguration PluginConfiguration => Configuration;

        private Guid _id = new Guid("2FE6E99B-D07D-4AE6-B976-5B4F455DFD3A");
        public override Guid Id
        {
            get { return _id; }
        }

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.jpg");
        }

        public ImageFormat ThumbImageFormat
        {
            get
            {
                return ImageFormat.Jpg;
            }
        }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = "AutoOrganizeLog",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizelog.html",
                    EnableInMainMenu = true
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeSmart",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizesmart.html"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeTv",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizetv.html"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeMovie",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizemovie.html"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeLogJs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizelog.js"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeSmartJs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizesmart.js"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeTvJs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizetv.js"
                },
                new PluginPageInfo
                {
                    Name = "AutoOrganizeMovieJs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.autoorganizemovie.js"
                },
                new PluginPageInfo
                {
                    Name = "FileOrganizerJs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.fileorganizer.js"
                },
                new PluginPageInfo
                {
                    Name = "FileOrganizerHtml",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.fileorganizer.template.html"
                }
            };
        }
    }
}

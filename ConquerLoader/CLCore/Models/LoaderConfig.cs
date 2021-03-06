﻿using System.ComponentModel;

namespace CLCore.Models
{
    public class LoaderConfig
    {
        public BindingList<ServerConfiguration> Servers { get; set; }
        public ServerConfiguration DefaultServer { get; set; }
        public bool DebugMode { get; set; }
        public bool CloseOnFinish { get; set; }
        public bool HighResolution { get; set; }
        public bool FullScreen { get; set; }
        public bool ServernameChange { get; set; }
        public bool DisableAutoFixFlash { get; set; }
        public bool CLServer { get; set; }
        public string Title { get; set; }
        public string LicenseKey { get; set; }

        public LoaderConfig()
        {
            if (Servers == null)
            {
                Servers = new BindingList<ServerConfiguration>();
            }
        }
    }
}

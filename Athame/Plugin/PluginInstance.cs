﻿using System;
using System.Reflection;
using Athame.PluginAPI;
using Athame.PluginAPI.Service;
using Athame.Settings;

namespace Athame.Plugin
{
    public class PluginInstance
    {
        public PluginInfo Info { get; set; }
        public IPlugin Plugin { get; set; }
        public PluginContext Context { get; set; }
        public Assembly Assembly { get; set; }
        public string AssemblyDirectory { get; set; }
        public string Name { get; set; }
        public Version AssemblyFileVersion { get; set; }
        public SettingsFile SettingsFile { get; set; }
        public MusicService Service => Plugin as MusicService;
    }
}

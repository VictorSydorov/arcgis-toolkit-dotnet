﻿// /*******************************************************************************
//  * Copyright 2012-2018 Esri
//  *
//  *  Licensed under the Apache License, Version 2.0 (the "License");
//  *  you may not use this file except in compliance with the License.
//  *  You may obtain a copy of the License at
//  *
//  *  http://www.apache.org/licenses/LICENSE-2.0
//  *
//  *   Unless required by applicable law or agreed to in writing, software
//  *   distributed under the License is distributed on an "AS IS" BASIS,
//  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  *   See the License for the specific language governing permissions and
//  *   limitations under the License.
//  ******************************************************************************/

using System.Resources;

namespace Esri.ArcGISRuntime.Toolkit.Preview.Properties
{
    internal static class Resources
    {
#if NETFX_CORE
        private static readonly Windows.ApplicationModel.Resources.ResourceLoader s_resource = Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse("Esri.ArcGISRuntime.Toolkit.Preview/Resources");

        public static string GetString(string name)
        {
            return s_resource.GetString(name);
        }
#else
        private static ResourceManager s_resourceManager;

        private static ResourceManager ResourceManager
        {
            get
            {
                if (s_resourceManager == null)
                {
                    s_resourceManager = new ResourceManager("Esri.ArcGISRuntime.Toolkit.Preview.LocalizedStrings.Resources", typeof(Resources).Assembly);
                }

                return s_resourceManager;
            }
        }

        public static string GetString(string name)
        {
            return ResourceManager.GetString(name);
        }
#endif
    }
}
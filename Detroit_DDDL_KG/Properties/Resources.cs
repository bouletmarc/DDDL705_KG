namespace Detroit_DDDL_KG.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal class Resources
    {
        private static System.Resources.ResourceManager resourceManager_0;
        private static CultureInfo cultureInfo_0;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (resourceManager_0 == null)
                {
                    resourceManager_0 = new System.Resources.ResourceManager("Detroit_DDDL_KG.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceManager_0;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => 
                cultureInfo_0;
            set => 
                cultureInfo_0 = value;
        }
    }
}


// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Runtime Version:4.0.30319.42000
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace WindowsAppVb.My.Resources
{

    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    public class Resource1
    {

        private static System.Resources.ResourceManager resourceMan;

        private static System.Globalization.CultureInfo resourceCulture;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() : base()

        {
        }

        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (ReferenceEquals(resourceMan, null))
                {
                    var temp = new System.Resources.ResourceManager("WindowsAppVb.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Colour.
        /// </summary>
        public static string String1
        {
            get
            {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static Bitmap test
        {
            get
            {
                var obj = ResourceManager.GetObject("test", resourceCulture);
                return (Bitmap)obj;
            }
        }

        /// <summary>
        /// Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static Bitmap test2
        {
            get
            {
                var obj = ResourceManager.GetObject("test2", resourceCulture);
                return (Bitmap)obj;
            }
        }

        /// <summary>
        /// Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static Bitmap test3
        {
            get
            {
                var obj = ResourceManager.GetObject("test3", resourceCulture);
                return (Bitmap)obj;
            }
        }
    }
}

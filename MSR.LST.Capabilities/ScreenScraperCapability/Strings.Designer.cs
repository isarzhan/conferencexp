﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSR.LST.ConferenceXP {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScreenScraperCapability.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close.
        /// </summary>
        internal static string Close {
            get {
                return ResourceManager.GetString("Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression bit rate, in kilobits: .
        /// </summary>
        internal static string CompressionBitRate {
            get {
                return ResourceManager.GetString("CompressionBitRate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error starting or stopping the data stream.
        ///{0}.
        /// </summary>
        internal static string DataStreamError {
            get {
                return ResourceManager.GetString("DataStreamError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Frame Rate ({0} - {1}): {2} / second.
        /// </summary>
        internal static string FrameRateText {
            get {
                return ResourceManager.GetString("FrameRateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Frame Rate (1 - 30): 5 / second.
        /// </summary>
        internal static string FrameRateTitle {
            get {
                return ResourceManager.GetString("FrameRateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh List.
        /// </summary>
        internal static string RefreshList {
            get {
                return ResourceManager.GetString("RefreshList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Screen Scraper - please select window.
        /// </summary>
        internal static string SelectWindow {
            get {
                return ResourceManager.GetString("SelectWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start.
        /// </summary>
        internal static string Start {
            get {
                return ResourceManager.GetString("Start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop.
        /// </summary>
        internal static string Stop {
            get {
                return ResourceManager.GetString("Stop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This capability sends an updated screen shot of your primary monitor&apos;s desktop {0} time per second and compresses it with the {1} encoder at the bit rate you specify. Avoid changing the screen resolution or color depth of your monitor while sending screen shots..
        /// </summary>
        internal static string ThisCapabilityInformation {
            get {
                return ResourceManager.GetString("ThisCapabilityInformation", resourceCulture);
            }
        }
    }
}

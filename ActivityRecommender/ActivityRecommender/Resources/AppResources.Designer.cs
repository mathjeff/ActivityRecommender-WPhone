﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityRecommendation.Resources {
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
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ActivityRecommendation.Resources.AppResources", typeof(AppResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to add.
        /// </summary>
        public static string AppBarButtonText {
            get {
                return ResourceManager.GetString("AppBarButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Menu Item.
        /// </summary>
        public static string AppBarMenuItemText {
            get {
                return ResourceManager.GetString("AppBarMenuItemText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MY APPLICATION.
        /// </summary>
        public static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Inheritance&gt;&lt;Child&gt;&lt;Name&gt;Sleeping&lt;/Name&gt;&lt;/Child&gt;&lt;Parent&gt;&lt;Name&gt;Activity&lt;/Name&gt;&lt;/Parent&gt;&lt;/Inheritance&gt;
        ///&lt;Inheritance&gt;&lt;Child&gt;&lt;Name&gt;Eating&lt;/Name&gt;&lt;/Child&gt;&lt;Parent&gt;&lt;Name&gt;Activity&lt;/Name&gt;&lt;/Parent&gt;&lt;DiscoveryDate&gt;2011-10-22T22:08:50&lt;/DiscoveryDate&gt;&lt;/Inheritance&gt;
        ///
        ///&lt;Inheritance&gt;&lt;Child&gt;&lt;Name&gt;Useful&lt;/Name&gt;&lt;/Child&gt;&lt;Parent&gt;&lt;Name&gt;Activity&lt;/Name&gt;&lt;/Parent&gt;&lt;/Inheritance&gt;
        /// &lt;Inheritance&gt;&lt;Child&gt;&lt;Name&gt;Work&lt;/Name&gt;&lt;/Child&gt;&lt;Parent&gt;&lt;Name&gt;Useful&lt;/Name&gt;&lt;/Parent&gt;&lt;/Inheritance&gt;
        ///  &lt;Inheritance&gt;&lt;Child&gt;&lt;Name&gt;Studying&lt;/Name&gt;&lt;/Child&gt;&lt;Paren [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Default_ActivityInheritances {
            get {
                return ResourceManager.GetString("Default_ActivityInheritances", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Participation&gt;&lt;Activity&gt;&lt;Name&gt;Frisbee&lt;/Name&gt;&lt;/Activity&gt;&lt;StartDate&gt;2011-10-16T19:00:00&lt;/StartDate&gt;&lt;EndDate&gt;2011-10-16T20:00:00&lt;/EndDate&gt;&lt;/Participation&gt;
        ///&lt;Participation&gt;&lt;Activity&gt;&lt;Name&gt;Working on the Activity Recommendation Engine&lt;/Name&gt;&lt;/Activity&gt;&lt;StartDate&gt;2011-10-17T20:00:00&lt;/StartDate&gt;&lt;EndDate&gt;2011-10-18T01:13:00&lt;/EndDate&gt;&lt;/Participation&gt;
        ///&lt;Participation&gt;&lt;Activity&gt;&lt;Name&gt;Sleeping&lt;/Name&gt;&lt;/Activity&gt;&lt;StartDate&gt;2011-10-18T01:30:00&lt;/StartDate&gt;&lt;EndDate&gt;2011-10-18T12:30:00&lt;/EndDate&gt;&lt;/Participation&gt;
        ///&lt;Participat [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Default_ActivityRatings {
            get {
                return ResourceManager.GetString("Default_ActivityRatings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LeftToRight.
        /// </summary>
        public static string ResourceFlowDirection {
            get {
                return ResourceManager.GetString("ResourceFlowDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to en-US.
        /// </summary>
        public static string ResourceLanguage {
            get {
                return ResourceManager.GetString("ResourceLanguage", resourceCulture);
            }
        }
    }
}
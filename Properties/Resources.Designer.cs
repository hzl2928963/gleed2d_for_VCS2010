﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GLEED2D.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GLEED2D.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 (Left Click) = start new circle      (Right Click) = exit circle draw mode 的本地化字符串。
        /// </summary>
        internal static string Circle_Entered {
            get {
                return ResourceManager.GetString("Circle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Left Click) = add circle to level      (Right Click) = cancel circle 的本地化字符串。
        /// </summary>
        internal static string Circle_Started {
            get {
                return ResourceManager.GetString("Circle_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 There is no layer in the level. Please add a new layer before adding items. 的本地化字符串。
        /// </summary>
        internal static string No_Layer {
            get {
                return ResourceManager.GetString("No_Layer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Left Click) = start new path      (Right Click) = exit path draw mode 的本地化字符串。
        /// </summary>
        internal static string Path_Entered {
            get {
                return ResourceManager.GetString("Path_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Left Click) = next point      (BackSpace) = delete last point      (Middle Click) = add path to level      (Right Click) = cancel path 的本地化字符串。
        /// </summary>
        internal static string Path_Started {
            get {
                return ResourceManager.GetString("Path_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Left Click) = start new rectangle      (Right Click) = exit rectangle draw mode 的本地化字符串。
        /// </summary>
        internal static string Rectangle_Entered {
            get {
                return ResourceManager.GetString("Rectangle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Left Click) = add rectangle to level      (LeftCtrl) = make square      (Right Click) = cancel rectangle 的本地化字符串。
        /// </summary>
        internal static string Rectangle_Started {
            get {
                return ResourceManager.GetString("Rectangle_Started", resourceCulture);
            }
        }
    }
}
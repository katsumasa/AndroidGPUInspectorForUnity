using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor.Android;
using UnityEditor.Build;
using UTJ.Android.Extensions;

namespace UTJ.Android
{
    public class AndroidManifestPost : IPostGenerateGradleAndroidProject
    {

        public static int prio = 0;

        int IOrderedCallback.callbackOrder
        {
            // 取り合えず先頭で
            get { return prio; }
        }


        void IPostGenerateGradleAndroidProject.OnPostGenerateGradleAndroidProject(string path)
        {            
            path = Path.Combine(path,"src","main", "AndroidManifest.xml");
            var androidManifest = new AndroidManifestReflection(path);
            androidManifest.SetDebuggableActivity("com.unity3d.player.UnityPlayerActivity", true);
            androidManifest.AddApplicationMetaDataAttribute("com.android.graphics.developerdriver.enable", "true");
            androidManifest.Save();
        }
    }
}
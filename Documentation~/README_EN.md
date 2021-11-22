# AndroidGPUInspectorForUnity

## Summary

Rewrites AndroidManifest.xml at build time to use [Android GPU Inspector](https://gpuinspector.dev/) with binaries built with Unity.

## Installing

```
git clone https://github.com/katsumasa/AndroidManifestReflection.git
git cline https://github.com/katsumasa/AndroidGPUInspectorForUnity.git
```

## How to use

![image](https://user-images.githubusercontent.com/29646672/139030370-48abcf2d-686e-44f7-9858-475d7b394258.png)

1. Switch Platform to Android
2. Put check in Development Build
3. Execute Build

Tha'll be all.

### NOTE

- Profiling can be performed even if Development Build is not checked, but the information that can be profiled is limited.
- When you attempt to run a build with Android GPU Inspector running, it'll get a following error. Please be sure to close the Android GPU Inspector before building.

```
CommandWithNoStdoutInvokationFailure: Unable to start ADB server. Please make sure the Android SDK is installed and is properly configured in the Editor. See the Console for more details.
```

### Rewriting AndroidManifest.xml


Add the following elements to AndroidManifest.xml output at build time for profiling with Android GPU Inspector

```
<application [...] android:debuggable="true">
```

```
 <meta-data android:name="com.android.graphics.developerdriver.enable" android:value="true" />
```


## How to use Android GPU Inspector

Please get Android GPU Inspector [here](https://github.com/google/agi).




1. Select Create a new trace.
  ![image](https://user-images.githubusercontent.com/29646672/139036473-87555766-e761-437c-bdee-8605734ef541.png)
2. Select a [Compatible device](https://gpuinspector.dev/docs/devices) from Device and Type.
  ![CaptureSystemProfile](https://user-images.githubusercontent.com/29646672/139029565-b9cbf54d-1061-4ef2-a031-a79dc4358711.jpg).
3. Select UnityPlayerActivity of the application built from Application.
4. Specify Output Director in Output.
5. Press Start whenever you wish to begin Profiling.

### NOTE

After profiling for the time set in Duration, the profiling result will display automatically.

![Capturing](https://user-images.githubusercontent.com/29646672/139029618-0a1571eb-42e0-4c7c-be12-aff1aec2c9aa.jpg)

### Change key of`Android GPU Inspector`

![GPU Inspector](https://user-images.githubusercontent.com/29646672/139029653-a49d6d42-526e-4939-a751-7416ac0a744d.jpg)

```
W,S: Zoom In/Out
A,D: Scroll left and right
```

# AndroidGPUInspectorForUnity
Unityで[Android GPU Inspector](https://gpuinspector.dev/)を使用する為のAndroidManifest.xmlのSample


## 使い方

1. [AndroidManifest.xml](https://github.com/katsumasa/AndroidGPUInspectorForUnity/blob/master/Assets/Plugins/Android/AndroidManifest.xml)を`Assets/Plugins/Android`へ配置する
2. Development Buildにチェックを入れる
3. Buildを実行する

以上

### NOTE

- Development Buildにチェックを入れない場合でもProfilingを行うことは可能ですが、Profiling可能な情報が制限されます。
- Android GPU Inspectorwが実行された状態でビルドを実行すると次のエラーが発生します。ビルドを行う場合は必ず`Android GPU Inspector`を終了させておいて下さい。


```
CommandWithNoStdoutInvokationFailure: Unable to start ADB server. Please make sure the Android SDK is installed and is properly configured in the Editor. See the Console for more details.
```

### 補足
Android GPU Inspectorでプロファイリングを行う為には、[AndroidManifest.xml](https://github.com/katsumasa/AndroidGPUInspectorForUnity/blob/master/Assets/Plugins/Android/AndroidManifest.xml)に次の設定を追加する必要があります。

- `<application [...] android:debuggable="true">`  [必須]
- `<meta-data android:name="com.android.graphics.developerdriver.enable" android:value="true" />` [β版のGPU Driverを使用する場合のみ]

※詳細は(Getting Started)[https://gpuinspector.dev/docs/getting-started]のPrepare your applicationを参照

## Android GPU Inspectorの使い方

![img](https://github.com/katsumasa/AndroidGPUInspectorForUnity/blob/master/Graphics/CaptureSystemProfile.jpg)

1. Create a new traceを選択
2. Device and TypeでGoogle Pixel4 (Standard又はXL)を選択
3. ApplicationからビルドしたアプリケーションのUnityPlayerActivityを選択
4. OutputでOutput Directorを指定.
5. Profilingを開始したいタイミングで、Startを押す。

### NOTE

Durationで設定した時間Profilingを行った後、自動的にProfiling結果が表示されます。

![img](https://github.com/katsumasa/AndroidGPUInspectorForUnity/blob/master/Graphics/Capturing.jpg)

### `Android GPU Inspector`のキーアサイン

![img](https://github.com/katsumasa/AndroidGPUInspectorForUnity/blob/master/Graphics/GPU%20Inspector.jpg)

```
W,S: Zoom In/Out
A,D: 左右へのスクロール
```

# AndroidGPUInspectorForUnity

## 概要

Unityでビルドしたバイナリで[Android GPU Inspector](https://gpuinspector.dev/)を使用する為にビルド時にAndroidManifest.xmlを書き換えます。

## インストール

```
git clone https://github.com/katsumasa/AndroidManifestReflection.git
git cline https://github.com/katsumasa/AndroidGPUInspectorForUnity.git
```

## 使い方

![image](https://user-images.githubusercontent.com/29646672/139030370-48abcf2d-686e-44f7-9858-475d7b394258.png)

1. PlatformをAndroidへ切り替える
2. Development Buildにチェックを入れる
3. Buildを実行する

以上

### NOTE

- Development Buildにチェックを入れない場合でもProfilingを行うことは可能ですが、Profiling可能な情報が制限されます。
- Android GPU Inspectorwが実行された状態でビルドを実行すると次のエラーが発生します。ビルドを行う場合は必ず`Android GPU Inspector`を終了させておいて下さい。


```
CommandWithNoStdoutInvokationFailure: Unable to start ADB server. Please make sure the Android SDK is installed and is properly configured in the Editor. See the Console for more details.
```

### AndroidManifest.xmlの書き換え


Android GPU Inspectorでプロファイリングを行う為に、ビルド時に出力されるAndroidManifest.xmlに下記の要素を追加します

```
<application [...] android:debuggable="true">
```

```
 <meta-data android:name="com.android.graphics.developerdriver.enable" android:value="true" />
```


## Android GPU Inspectorの使い方

Android GPU Inspectorは[こちら](https://github.com/google/agi)から取得してください。




1. Create a new traceを選択
  ![image](https://user-images.githubusercontent.com/29646672/139036473-87555766-e761-437c-bdee-8605734ef541.png)
2. Device and Typeで[対応デバイス](https://gpuinspector.dev/docs/devices)を選択
  ![CaptureSystemProfile](https://user-images.githubusercontent.com/29646672/139029565-b9cbf54d-1061-4ef2-a031-a79dc4358711.jpg)
3. ApplicationからビルドしたアプリケーションのUnityPlayerActivityを選択
4. OutputでOutput Directorを指定.
5. Profilingを開始したいタイミングで、Startを押す。

### NOTE

Durationで設定した時間Profilingを行った後、自動的にProfiling結果が表示されます。

![Capturing](https://user-images.githubusercontent.com/29646672/139029618-0a1571eb-42e0-4c7c-be12-aff1aec2c9aa.jpg)

### `Android GPU Inspector`のキーアサイン

![GPU Inspector](https://user-images.githubusercontent.com/29646672/139029653-a49d6d42-526e-4939-a751-7416ac0a744d.jpg)

```
W,S: Zoom In/Out
A,D: 左右へのスクロール
```

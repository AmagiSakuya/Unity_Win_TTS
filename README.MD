# Unity_Win_TTS

基于[TTS_Tool](https://github.com/AmagiSakuya/TTS_Tool)的Unity微软TTS插件

使用调用exe的方式 有效解决Unity的.net无法完美使用微软tts的接口的问题

## 简单使用方法

1. 按照TTS_Tool的配置方式配置相关json

2. 在Unity中的SpeechManager 配置程序路径 必须相对于StreamingAssets

3. 代码调用
```
  SpeechManager.Instance.Speak("你的语音");
  //停止播放
  SpeechManager.Instance.Stop();
```

使用例见工程demo

## 关于我

[新浪微博](https://weibo.com/233742343/)

[bilibili](https://space.bilibili.com/259362/)

[Twitter](https://twitter.com/Sakuya_fm)

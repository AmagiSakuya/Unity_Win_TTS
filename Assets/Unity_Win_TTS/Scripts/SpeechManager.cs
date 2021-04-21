using UnityEngine;
using System;
using System.Diagnostics;

namespace UnityWinTTS
{
    [Serializable]
    public class SpeechManager : MonoBehaviour
    {
        public static SpeechManager Instance;
        public string exeRelativePath = "/TTS_Tool";
        public string exeFileName = "TTS_Tool.exe";

        Process process;
        void Awake()
        {
            Instance = this;
        }

        public void Speak(string str)
        {
            try
            {
                if (process != null)
                {
                    Stop();
                }
                process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = Application.streamingAssetsPath + exeRelativePath + "/" + exeFileName;
                process.StartInfo.WorkingDirectory = Application.streamingAssetsPath + exeRelativePath;
                process.StartInfo.Arguments = $"-speak {str}";
                process.Start();
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log(e);
            }
        }
        public void Stop()
        {
            if (process == null) return;
            if (!process.HasExited)
                process.CloseMainWindow();
            process = null;
        }

        void OnDestroy()
        {
            Stop();
        }
    }
}
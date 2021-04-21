using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace UnityWinTTS
{
    [CustomEditor(typeof(SpeechExample))]
    public class SpeechExampleEditor : Editor
    {
        SpeechExample t;
        SpeechManager m_speechMgr;
        private void OnEnable()
        {
            t = (SpeechExample)target;
            m_speechMgr = t.GetComponent<SpeechManager>();
        }

        public override void OnInspectorGUI()
        {
            if (m_speechMgr == null)
            {
                EditorGUILayout.HelpBox("当前场景没有正确设置SpeechManager", MessageType.Error);
            }
            else
            {
                GUILayout.BeginHorizontal();
                Color oldBgColor = GUI.backgroundColor;
                GUI.backgroundColor = Color.green;
                if (GUILayout.Button("语音试听"))
                {
                    m_speechMgr.Speak(t.testText);
                }
                GUI.backgroundColor = Color.red;
                if (GUILayout.Button("停止"))
                {
                    m_speechMgr.Stop();
                }
                GUI.backgroundColor = oldBgColor;
                GUILayout.EndHorizontal();
            }
            base.OnInspectorGUI();
        }
    }
}


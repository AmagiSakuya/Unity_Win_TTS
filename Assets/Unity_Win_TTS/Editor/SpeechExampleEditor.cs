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
                EditorGUILayout.HelpBox("��ǰ����û����ȷ����SpeechManager", MessageType.Error);
            }
            else
            {
                GUILayout.BeginHorizontal();
                Color oldBgColor = GUI.backgroundColor;
                GUI.backgroundColor = Color.green;
                if (GUILayout.Button("��������"))
                {
                    m_speechMgr.Speak(t.testText);
                }
                GUI.backgroundColor = Color.red;
                if (GUILayout.Button("ֹͣ"))
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


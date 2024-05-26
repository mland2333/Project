using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx.Logging;
using UnityEngine;
using System.Runtime.CompilerServices;
namespace HelloMod
{
    [BepInPlugin("mland.plugin.HelloMod","HelloWorld","1.0.0")]
    public class HelloWorld : BaseUnityPlugin
    {
        void Start()
        {
            //Logger.LogInfo("Hello World");
            Harmony.CreateAndPatchAll(typeof(HelloWorld));
        }

        [HarmonyPrefix, HarmonyPatch(typeof(PlayerAction_Mine), "AddProductionStat")]
        public static void MineAdd(PlayerAction_Mine __instance)
        {
            Debug.Log("Mine + 1");
        }

        private Rect windowRect = new Rect(50, 50, 300, 300);
        private String testString = "";
        private bool testBool = false;
        private String[] testToolBarNames = new string[] { "页面1", "页面2", "页面3" };
        private int testToolBarIndex = 0;
        void OnGUI()
        {
            GUILayout.Window(123, windowRect, WindowFunc, "测试");
        }
        public void WindowFunc(int id)
        {
            testToolBarIndex = GUILayout.Toolbar(testToolBarIndex, testToolBarNames);
            GUILayout.Label(testToolBarIndex.ToString());
            GUILayout.Label("Hello World");
            if (GUILayout.Button("Button"))
            {
                Debug.Log("点击了按钮");
            }
            GUILayout.Label("测试字符");
            testString = GUILayout.TextField(testString);
            testBool = GUILayout.Toggle(testBool, "开关");
            GUI.DragWindow();
        }
    }
    
}

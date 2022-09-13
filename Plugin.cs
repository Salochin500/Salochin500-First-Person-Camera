using BepInEx;
using Bepinject;
using System;
using UnityEngine;
using Utilla;
using System.Reflection;
using System.Collections;


namespace FirstPersonCamera
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(5);
            var camera = GameObject.Find("Shoulder Camera")?.GetComponent<Camera>();
            if (camera != null)
            {
                camera.enabled = false;
            }
            else
            {
                Console.WriteLine("Error! Could not find Camera. Please contact HyperSilver69#6725 and let me know it doesn't work!");
            }

            Console.WriteLine("Set to first person");
        }
    }
}

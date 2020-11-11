/*
 * Script to hold general functions that may be repeated in multiple scripts
 * Main Editor: Josh-Tim Allen
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public struct FUNCS {

    public static float Distance(Vector3 A, Vector3 B) {
        return float.Parse(Math.Sqrt((B - A).sqrMagnitude).ToString());
    }
    public static float ValueDistance(float A, float B) {
        if (A < 0) {
            A -= -1;
        }
        if (B < 0) {
            B -= -1;
        }
        if (A > B) {
            return A - B;
        }
        else if (B > A) {
            return B - A;
        }
        else {
            return 0;
        }
    }
    public static T Clone<T>(T source) {
        if (!typeof(T).IsSerializable) {
            throw new ArgumentException("The type must be serializable.", "source");
        }

        // Don't serialize a null object, simply return the default for that object
        if (System.Object.ReferenceEquals(source, null)) {
            return default(T);
        }

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream) {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }

    }

    public static int Intify(string str) {
        List<char> charlist = str.ToList();

        for (int c = 0; c < charlist.Count; c++) {
            char ch = charlist[c];
            try {
                int.Parse(ch.ToString());
            }
            catch {
                charlist.Remove(charlist[c]);
                c--;
            }
        }
        str = "";
        for (int c = 0; c < charlist.Count; c++) {
            str += charlist[c];
        }
        try {
            return int.Parse(str);
        }
        catch {
            return 0;
        }
    }

    public static void Randomise<T>(List<T> list) {
        List<T> templist = new List<T>();
        foreach (T item in list) {
            templist.Add(item);
        }
        List<int> indexlist = new List<int>();

        for (int c = 0; c < list.Count; c++) {
            indexlist.Add(c);
        }

        for (int c = 0; c < list.Count; c++) {
            int r = UnityEngine.Random.Range(0, indexlist.Count);

            list[c] = templist[indexlist[r]];

            indexlist.Remove(indexlist[r]);
        }

    }

    public static string RemoveCharacter(string STRING, char characterToRemove) {
        string derivedString = "";
        if (STRING == null) { STRING = ""; }
        for (int c = 0; c < STRING.Length; c++) {
            if (STRING[c] != characterToRemove) {
                derivedString += STRING[c];
            }
        }
        return derivedString;
    }


    public static string IP_Address() {
        IPHostEntry host;
        string localIP = "";
        host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList) {
            if (ip.AddressFamily == AddressFamily.InterNetwork) {
                localIP = ip.ToString();
                break;
            }
        }
        foreach (IPAddress ip in host.AddressList) {
            if (ip.ToString() == "192.168.43.1") {
                localIP = ip.ToString();
                break;
            }
        }

        return localIP;
    }

    public static string GenerateConnectionKey() {
        Guid g;
        g = Guid.NewGuid();
        return g.ToString();

    }
    public static byte[] GetHash(string inputString) {
        HashAlgorithm algorithm = SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }
    public static string GetHashString(string inputString) {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }

    /// <summary>
    /// Calls a function after a given time. Invoker object has to be given, Action is Function to call, if needed to pass values use ()=>{ func(x); } 
    /// </summary>
    /// <param name="action">Function to call, if needed to pass values use ()=>{ func(x); }</param>
    /// <param name="time"></param>
    /// <param name="InvokerObject"></param>
    /// <param name="realTime"></param>
    public static void Invoke(Action action, float time, MonoBehaviour InvokerObject, bool realTime) {
        InvokerObject.StartCoroutine(invoker(action, time, realTime));
    }
    static IEnumerator invoker(Action action, float time, bool realTime) {
        if (!realTime) {
            yield return new WaitForSeconds(time);
        }
        else {
            yield return new WaitForSecondsRealtime(time);
        }
        action?.Invoke();
        action = null;
    }
    public static void WaitUntil(Func<bool> predicate, Action action, MonoBehaviour InvokerObject) {
        InvokerObject.StartCoroutine(waitUntil(predicate, action));
    }
    static IEnumerator waitUntil(Func<bool> predicate, Action action) {
        if (predicate != null) {
            yield return new WaitUntil(predicate);
        }
        action?.Invoke();
        predicate = null;
    }
    public static Color32 GetPingColour(float ping) {
        if (ping > 130 && ping < 300) {
            return new Color32(255, 137, 0, 255);//ORANGE
        }
        else if (ping > 300) {
            return new Color32(227, 0, 23, 255);//RED
        }
        else {
            return new Color32(0, 195, 13, 255);//GREEN
        }
    }
    public static void CopyToClipboard(string s) {
        TextEditor te = new TextEditor();
        te.text = s;
        te.SelectAll();
        te.Copy();
    }
    public static Dictionary<string, Texture> savedImageTextures = new Dictionary<string, Texture>();
    public static void GetTexture(string ImageUrl, RawImage rawImage, Texture defaultTexture, MonoBehaviour invokerObject) {
        if (invokerObject.gameObject.activeInHierarchy) {
            invokerObject.StartCoroutine(_GetTexture(ImageUrl, rawImage, defaultTexture));
        }
    }
    static IEnumerator _GetTexture(string ImageUrl, RawImage rawImage, Texture defaultTexture) {

        if (savedImageTextures.ContainsKey(ImageUrl)) {
            rawImage.texture = savedImageTextures[ImageUrl];
            yield return new WaitForSeconds(0.01f);
        }
        else {
            rawImage.texture = defaultTexture;

            UnityWebRequest www = UnityWebRequestTexture.GetTexture(ImageUrl);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError) {
                Debug.Log(www.error);
            }
            else {
                Texture texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
                rawImage.texture = texture;
                if (!savedImageTextures.ContainsKey(ImageUrl)) {
                    savedImageTextures.Add(ImageUrl, texture);
                }
            }
        }
    }
}
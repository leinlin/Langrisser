using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.UI;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Profiling;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B8 RID: 4280
	[CustomLuaClass]
	public class Utility
	{
		// Token: 0x060158BF RID: 88255 RVA: 0x0057CC38 File Offset: 0x0057AE38
		public static void LogMemorySize(string prefix)
		{
			global::Debug.Log(string.Format("{0} AllocateMemory: {1:N0}", prefix, Utility.GetRuntimeMemorySize()));
		}

		// Token: 0x060158C0 RID: 88256 RVA: 0x0057CC54 File Offset: 0x0057AE54
		public static IEnumerator GetUpdateClientURL(GameObject parentObj = null)
		{
			if (PDSDK.IsIosReview)
			{
				yield break;
			}
			string url = null;
			string[] urls = null;
			yield return Util.DownloadHttpFile(DefaultServerAddress.URLToSaveUpdateClientServerURL, delegate(bool ret, WWW www)
			{
				if (!ret)
				{
					return;
				}
				urls = www.text.Trim().Split(new char[]
				{
					','
				});
			}, null);
			int idx = -1;
			if (urls != null && urls.Length > 0)
			{
				for (int i = 0; i < urls.Length; i++)
				{
					url = string.Format("{0}/{1}/{2}", urls[i].Trim(new char[]
					{
						'/'
					}), Util.GetCurrentTargetPlatform(), PathHelper.BundleDataVersionFileName);
					bool isSuccess = false;
					yield return Util.DownloadHttpFile(url, delegate(bool ret, WWW www)
					{
						isSuccess = ret;
					}, null);
					if (isSuccess)
					{
						idx = i;
						break;
					}
				}
			}
			if (idx < 0)
			{
				global::Debug.LogError(string.Format("Utility.GetUpdateClientURL Failed to get update client server url from {0}", DefaultServerAddress.URLToSaveUpdateClientServerURL));
				if (parentObj != null)
				{
					yield return DialogBox.Show(parentObj, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgGetUpdateClinetUrlFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
					{
						global::Debug.Log("ProjectLGameEntryUITask.GetUpdateClientURL call Quit().");
						Application.Quit();
					});
				}
				yield break;
			}
			ResourceManager.Instance.SetDownloadUrlRoot(urls[idx]);
			AudioManager4CRI.DownloadUrlRoot = string.Format("{0}/{1}", urls[idx], GameManager.Instance.GameClientSetting.AudioSetting.CRIAudioManagerAsset);
			yield break;
		}

		// Token: 0x060158C1 RID: 88257 RVA: 0x0057CC70 File Offset: 0x0057AE70
		public static long GetRuntimeMemorySize()
		{
			return Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x060158C2 RID: 88258 RVA: 0x0057CC78 File Offset: 0x0057AE78
		public static Texture2D ResizeTexture(Texture2D pSource, ImageFilterMode pFilterMode, float pScale)
		{
			Color[] pixels = pSource.GetPixels(0);
			Vector2 vector = new Vector2((float)pSource.width, (float)pSource.height);
			float num = (float)Mathf.RoundToInt((float)pSource.width * pScale);
			float num2 = (float)Mathf.RoundToInt((float)pSource.height * pScale);
			Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false);
			int num3 = (int)num * (int)num2;
			Color[] array = new Color[num3];
			Vector2 vector2 = new Vector2(vector.x / num, vector.y / num2);
			Vector2 vector3 = default(Vector2);
			for (int i = 0; i < num3; i++)
			{
				float num4 = (float)i % num;
				float num5 = Mathf.Floor((float)i / num);
				vector3.x = num4 / num * vector.x;
				vector3.y = num5 / num2 * vector.y;
				if (pFilterMode == ImageFilterMode.Nearest)
				{
					vector3.x = Mathf.Round(vector3.x);
					vector3.y = Mathf.Round(vector3.y);
					int num6 = (int)(vector3.y * vector.x + vector3.x);
					array[i] = pixels[num6];
				}
				else if (pFilterMode == ImageFilterMode.Biliner)
				{
					float t = vector3.x - Mathf.Floor(vector3.x);
					float t2 = vector3.y - Mathf.Floor(vector3.y);
					int num7 = (int)(Mathf.Floor(vector3.y) * vector.x + Mathf.Floor(vector3.x));
					int num8 = (int)(Mathf.Floor(vector3.y) * vector.x + Mathf.Ceil(vector3.x));
					int num9 = (int)(Mathf.Ceil(vector3.y) * vector.x + Mathf.Floor(vector3.x));
					int num10 = (int)(Mathf.Ceil(vector3.y) * vector.x + Mathf.Ceil(vector3.x));
					array[i] = Color.Lerp(Color.Lerp(pixels[num7], pixels[num8], t), Color.Lerp(pixels[num9], pixels[num10], t), t2);
				}
				else if (pFilterMode == ImageFilterMode.Average)
				{
					int num11 = (int)Mathf.Max(Mathf.Floor(vector3.x - vector2.x * 0.5f), 0f);
					int num12 = (int)Mathf.Min(Mathf.Ceil(vector3.x + vector2.x * 0.5f), vector.x);
					int num13 = (int)Mathf.Max(Mathf.Floor(vector3.y - vector2.y * 0.5f), 0f);
					int num14 = (int)Mathf.Min(Mathf.Ceil(vector3.y + vector2.y * 0.5f), vector.y);
					Color a = default(Color);
					float num15 = 0f;
					for (int j = num13; j < num14; j++)
					{
						for (int k = num11; k < num12; k++)
						{
							a += pixels[(int)((float)j * vector.x + (float)k)];
							num15 += 1f;
						}
					}
					array[i] = a / num15;
				}
			}
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060158C3 RID: 88259 RVA: 0x0057D010 File Offset: 0x0057B210
		public static void SetUIStateOpen(CommonUIStateController ctrl, string stateName, Action onEnd = null, Action<bool> EnableInput = null, bool allowToRefreshSameState = true)
		{
			if (ctrl == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(stateName))
			{
				return;
			}
			if (EnableInput != null)
			{
				EnableInput(false);
			}
			ctrl.gameObject.SetActive(true);
			ctrl.SetActionForUIStateFinshed(stateName, delegate
			{
				if (EnableInput != null)
				{
					EnableInput(true);
				}
				if (onEnd != null)
				{
					onEnd();
				}
			});
			ctrl.SetToUIState(stateName, false, allowToRefreshSameState);
		}

		// Token: 0x060158C4 RID: 88260 RVA: 0x0057D08C File Offset: 0x0057B28C
		public static void SetUIStateClose(CommonUIStateController ctrl, string stateName, Action onEnd = null, Action<bool> EnableInput = null, bool allowToRefreshSameState = true)
		{
			if (ctrl == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(stateName))
			{
				return;
			}
			if (!ctrl.gameObject.activeSelf)
			{
				return;
			}
			if (EnableInput != null)
			{
				EnableInput(false);
			}
			ctrl.SetActionForUIStateFinshed(stateName, delegate
			{
				MonoBehaviour monoBehaviour = null;
				if (onEnd != null && ctrl.transform.parent != null)
				{
					monoBehaviour = ctrl.transform.parent.GetComponentInParent<MonoBehaviour>();
				}
				if (monoBehaviour != null)
				{
					monoBehaviour.StartCoroutine(Utility.Co_UIStateCloseFinished(ctrl, onEnd, EnableInput));
				}
				else
				{
					ctrl.gameObject.SetActive(false);
					if (EnableInput != null)
					{
						EnableInput(true);
					}
					if (onEnd != null)
					{
						onEnd();
					}
				}
			});
			ctrl.SetToUIState(stateName, false, allowToRefreshSameState);
		}

		// Token: 0x060158C5 RID: 88261 RVA: 0x0057D128 File Offset: 0x0057B328
		private static IEnumerator<object> Co_UIStateCloseFinished(CommonUIStateController ctrl, Action onEnd, Action<bool> EnableInput)
		{
			ctrl.gameObject.SetActive(false);
			yield return null;
			if (EnableInput != null)
			{
				EnableInput(true);
			}
			if (onEnd != null)
			{
				onEnd();
			}
			yield break;
		}

		// Token: 0x060158C6 RID: 88262 RVA: 0x0057D154 File Offset: 0x0057B354
		public static T FindChildComponent<T>(GameObject go, string name, bool warning = true) where T : Component
		{
			if (go == null)
			{
				return (T)((object)null);
			}
			Transform transform = go.transform.Find(name);
			if (transform == null)
			{
				if (warning)
				{
					global::Debug.LogError(name + " not found.");
				}
				return (T)((object)null);
			}
			T component = transform.GetComponent<T>();
			if (component == null)
			{
				if (warning)
				{
					global::Debug.LogError(typeof(T).Name + " componnent not found.");
				}
				return (T)((object)null);
			}
			return component;
		}

		// Token: 0x060158C7 RID: 88263 RVA: 0x0057D1F0 File Offset: 0x0057B3F0
		public static GameObject FindChildGameObject(GameObject go, string name, bool warning = true)
		{
			if (go == null)
			{
				return null;
			}
			Transform transform = go.transform.Find(name);
			if (transform == null)
			{
				if (warning)
				{
					global::Debug.LogError(name + " not found.");
				}
				return null;
			}
			return transform.gameObject;
		}
	}
}

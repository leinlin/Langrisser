using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001883 RID: 6275
[Preserve]
public class Lua_UnityEngine_WWW : LuaObject
{
	// Token: 0x06024464 RID: 148580 RVA: 0x00CC0884 File Offset: 0x00CBEA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string url;
				LuaObject.checkType(l, 2, out url);
				WWW o = new WWW(url);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(WWWForm)))
			{
				string url2;
				LuaObject.checkType(l, 2, out url2);
				WWWForm form;
				LuaObject.checkType<WWWForm>(l, 3, out form);
				WWW o = new WWW(url2, form);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(byte[])))
			{
				string url3;
				LuaObject.checkType(l, 2, out url3);
				byte[] postData;
				LuaObject.checkArray<byte>(l, 3, out postData);
				WWW o = new WWW(url3, postData);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				string url4;
				LuaObject.checkType(l, 2, out url4);
				byte[] postData2;
				LuaObject.checkArray<byte>(l, 3, out postData2);
				Dictionary<string, string> headers;
				LuaObject.checkType<Dictionary<string, string>>(l, 4, out headers);
				WWW o = new WWW(url4, postData2, headers);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024465 RID: 148581 RVA: 0x00CC09F4 File Offset: 0x00CBEBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadImageIntoTexture(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			Texture2D texture;
			LuaObject.checkType<Texture2D>(l, 2, out texture);
			www.LoadImageIntoTexture(texture);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024466 RID: 148582 RVA: 0x00CC0A4C File Offset: 0x00CBEC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			www.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024467 RID: 148583 RVA: 0x00CC0A98 File Offset: 0x00CBEC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAudioClip(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				WWW www = (WWW)LuaObject.checkSelf(l);
				AudioClip audioClip = www.GetAudioClip();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClip);
				result = 2;
			}
			else if (num == 2)
			{
				WWW www2 = (WWW)LuaObject.checkSelf(l);
				bool threeD;
				LuaObject.checkType(l, 2, out threeD);
				AudioClip audioClip2 = www2.GetAudioClip(threeD);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClip2);
				result = 2;
			}
			else if (num == 3)
			{
				WWW www3 = (WWW)LuaObject.checkSelf(l);
				bool threeD2;
				LuaObject.checkType(l, 2, out threeD2);
				bool stream;
				LuaObject.checkType(l, 3, out stream);
				AudioClip audioClip3 = www3.GetAudioClip(threeD2, stream);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClip3);
				result = 2;
			}
			else if (num == 4)
			{
				WWW www4 = (WWW)LuaObject.checkSelf(l);
				bool threeD3;
				LuaObject.checkType(l, 2, out threeD3);
				bool stream2;
				LuaObject.checkType(l, 3, out stream2);
				AudioType audioType;
				LuaObject.checkEnum<AudioType>(l, 4, out audioType);
				AudioClip audioClip4 = www4.GetAudioClip(threeD3, stream2, audioType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClip4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetAudioClip to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024468 RID: 148584 RVA: 0x00CC0C04 File Offset: 0x00CBEE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAudioClipCompressed(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				WWW www = (WWW)LuaObject.checkSelf(l);
				AudioClip audioClipCompressed = www.GetAudioClipCompressed();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClipCompressed);
				result = 2;
			}
			else if (num == 2)
			{
				WWW www2 = (WWW)LuaObject.checkSelf(l);
				bool threeD;
				LuaObject.checkType(l, 2, out threeD);
				AudioClip audioClipCompressed2 = www2.GetAudioClipCompressed(threeD);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClipCompressed2);
				result = 2;
			}
			else if (num == 3)
			{
				WWW www3 = (WWW)LuaObject.checkSelf(l);
				bool threeD2;
				LuaObject.checkType(l, 2, out threeD2);
				AudioType audioType;
				LuaObject.checkEnum<AudioType>(l, 3, out audioType);
				AudioClip audioClipCompressed3 = www3.GetAudioClipCompressed(threeD2, audioType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, audioClipCompressed3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetAudioClipCompressed to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024469 RID: 148585 RVA: 0x00CC0D0C File Offset: 0x00CBEF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EscapeURL_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				string s2 = WWW.EscapeURL(s);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else if (num == 2)
			{
				string s3;
				LuaObject.checkType(l, 1, out s3);
				Encoding e;
				LuaObject.checkType<Encoding>(l, 2, out e);
				string s4 = WWW.EscapeURL(s3, e);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function EscapeURL to call");
				result = 2;
			}
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0602446A RID: 148586 RVA: 0x00CC0DC4 File Offset: 0x00CBEFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnEscapeURL_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				string s2 = WWW.UnEscapeURL(s);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else if (num == 2)
			{
				string s3;
				LuaObject.checkType(l, 1, out s3);
				Encoding e;
				LuaObject.checkType<Encoding>(l, 2, out e);
				string s4 = WWW.UnEscapeURL(s3, e);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function UnEscapeURL to call");
				result = 2;
			}
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0602446B RID: 148587 RVA: 0x00CC0E7C File Offset: 0x00CBF07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromCacheOrDownload_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Hash128)))
			{
				string url;
				LuaObject.checkType(l, 1, out url);
				Hash128 hash;
				LuaObject.checkValueType<Hash128>(l, 2, out hash);
				WWW o = WWW.LoadFromCacheOrDownload(url, hash);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(int)))
			{
				string url2;
				LuaObject.checkType(l, 1, out url2);
				int version;
				LuaObject.checkType(l, 2, out version);
				WWW o2 = WWW.LoadFromCacheOrDownload(url2, version);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(CachedAssetBundle), typeof(uint)))
			{
				string url3;
				LuaObject.checkType(l, 1, out url3);
				CachedAssetBundle cachedBundle;
				LuaObject.checkValueType<CachedAssetBundle>(l, 2, out cachedBundle);
				uint crc;
				LuaObject.checkType(l, 3, out crc);
				WWW o3 = WWW.LoadFromCacheOrDownload(url3, cachedBundle, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Hash128), typeof(uint)))
			{
				string url4;
				LuaObject.checkType(l, 1, out url4);
				Hash128 hash2;
				LuaObject.checkValueType<Hash128>(l, 2, out hash2);
				uint crc2;
				LuaObject.checkType(l, 3, out crc2);
				WWW o4 = WWW.LoadFromCacheOrDownload(url4, hash2, crc2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(int), typeof(uint)))
			{
				string url5;
				LuaObject.checkType(l, 1, out url5);
				int version2;
				LuaObject.checkType(l, 2, out version2);
				uint crc3;
				LuaObject.checkType(l, 3, out crc3);
				WWW o5 = WWW.LoadFromCacheOrDownload(url5, version2, crc3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromCacheOrDownload to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602446C RID: 148588 RVA: 0x00CC10CC File Offset: 0x00CBF2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_assetBundle(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.assetBundle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602446D RID: 148589 RVA: 0x00CC1120 File Offset: 0x00CBF320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bytes(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.bytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602446E RID: 148590 RVA: 0x00CC1174 File Offset: 0x00CBF374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bytesDownloaded(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.bytesDownloaded);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602446F RID: 148591 RVA: 0x00CC11C8 File Offset: 0x00CBF3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_error(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.error);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024470 RID: 148592 RVA: 0x00CC121C File Offset: 0x00CBF41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isDone(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.isDone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024471 RID: 148593 RVA: 0x00CC1270 File Offset: 0x00CBF470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_progress(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.progress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024472 RID: 148594 RVA: 0x00CC12C4 File Offset: 0x00CBF4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_responseHeaders(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.responseHeaders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024473 RID: 148595 RVA: 0x00CC1318 File Offset: 0x00CBF518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024474 RID: 148596 RVA: 0x00CC136C File Offset: 0x00CBF56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_texture(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.texture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024475 RID: 148597 RVA: 0x00CC13C0 File Offset: 0x00CBF5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureNonReadable(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.textureNonReadable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024476 RID: 148598 RVA: 0x00CC1414 File Offset: 0x00CBF614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_threadPriority(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)www.threadPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024477 RID: 148599 RVA: 0x00CC1468 File Offset: 0x00CBF668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_threadPriority(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			ThreadPriority threadPriority;
			LuaObject.checkEnum<ThreadPriority>(l, 2, out threadPriority);
			www.threadPriority = threadPriority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024478 RID: 148600 RVA: 0x00CC14C0 File Offset: 0x00CBF6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uploadProgress(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.uploadProgress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024479 RID: 148601 RVA: 0x00CC1514 File Offset: 0x00CBF714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_url(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.url);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602447A RID: 148602 RVA: 0x00CC1568 File Offset: 0x00CBF768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keepWaiting(IntPtr l)
	{
		int result;
		try
		{
			WWW www = (WWW)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, www.keepWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602447B RID: 148603 RVA: 0x00CC15BC File Offset: 0x00CBF7BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WWW");
		if (Lua_UnityEngine_WWW.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WWW.LoadImageIntoTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache0);
		if (Lua_UnityEngine_WWW.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WWW.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache1);
		if (Lua_UnityEngine_WWW.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_WWW.GetAudioClip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache2);
		if (Lua_UnityEngine_WWW.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_WWW.GetAudioClipCompressed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache3);
		if (Lua_UnityEngine_WWW.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_WWW.EscapeURL_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache4);
		if (Lua_UnityEngine_WWW.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_WWW.UnEscapeURL_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache5);
		if (Lua_UnityEngine_WWW.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_WWW.LoadFromCacheOrDownload_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWW.<>f__mg$cache6);
		string name = "assetBundle";
		if (Lua_UnityEngine_WWW.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_WWW.get_assetBundle);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_WWW.<>f__mg$cache7, null, true);
		string name2 = "bytes";
		if (Lua_UnityEngine_WWW.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_WWW.get_bytes);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_WWW.<>f__mg$cache8, null, true);
		string name3 = "bytesDownloaded";
		if (Lua_UnityEngine_WWW.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_WWW.get_bytesDownloaded);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_WWW.<>f__mg$cache9, null, true);
		string name4 = "error";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_WWW.get_error);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_WWW.<>f__mg$cacheA, null, true);
		string name5 = "isDone";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_WWW.get_isDone);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_WWW.<>f__mg$cacheB, null, true);
		string name6 = "progress";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_WWW.get_progress);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_WWW.<>f__mg$cacheC, null, true);
		string name7 = "responseHeaders";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_WWW.get_responseHeaders);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_WWW.<>f__mg$cacheD, null, true);
		string name8 = "text";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_WWW.get_text);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_WWW.<>f__mg$cacheE, null, true);
		string name9 = "texture";
		if (Lua_UnityEngine_WWW.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_WWW.get_texture);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_WWW.<>f__mg$cacheF, null, true);
		string name10 = "textureNonReadable";
		if (Lua_UnityEngine_WWW.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_WWW.get_textureNonReadable);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_WWW.<>f__mg$cache10, null, true);
		string name11 = "threadPriority";
		if (Lua_UnityEngine_WWW.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_WWW.get_threadPriority);
		}
		LuaCSFunction get = Lua_UnityEngine_WWW.<>f__mg$cache11;
		if (Lua_UnityEngine_WWW.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_WWW.set_threadPriority);
		}
		LuaObject.addMember(l, name11, get, Lua_UnityEngine_WWW.<>f__mg$cache12, true);
		string name12 = "uploadProgress";
		if (Lua_UnityEngine_WWW.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_WWW.get_uploadProgress);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_WWW.<>f__mg$cache13, null, true);
		string name13 = "url";
		if (Lua_UnityEngine_WWW.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_WWW.get_url);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_WWW.<>f__mg$cache14, null, true);
		string name14 = "keepWaiting";
		if (Lua_UnityEngine_WWW.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_WWW.get_keepWaiting);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_WWW.<>f__mg$cache15, null, true);
		if (Lua_UnityEngine_WWW.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_WWW.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_WWW.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WWW.<>f__mg$cache16, typeof(WWW), typeof(CustomYieldInstruction));
	}

	// Token: 0x04019FBC RID: 106428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FBD RID: 106429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019FBE RID: 106430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019FBF RID: 106431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019FC0 RID: 106432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019FC1 RID: 106433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019FC2 RID: 106434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019FC3 RID: 106435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019FC4 RID: 106436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019FC5 RID: 106437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019FC6 RID: 106438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019FC7 RID: 106439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019FC8 RID: 106440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019FC9 RID: 106441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019FCA RID: 106442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019FCB RID: 106443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019FCC RID: 106444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019FCD RID: 106445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019FCE RID: 106446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019FCF RID: 106447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019FD0 RID: 106448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019FD1 RID: 106449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019FD2 RID: 106450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015DC RID: 5596
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoiceRecordHelper : LuaObject
{
	// Token: 0x06022282 RID: 139906 RVA: 0x00BA93F4 File Offset: 0x00BA75F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitXFSDKManager(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			XunfeiSDKWrapper wrapper;
			LuaObject.checkType<XunfeiSDKWrapper>(l, 2, out wrapper);
			voiceRecordHelper.InitXFSDKManager(wrapper);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022283 RID: 139907 RVA: 0x00BA944C File Offset: 0x00BA764C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			Action onMicrophoneStarted;
			LuaObject.checkDelegate<Action>(l, 3, out onMicrophoneStarted);
			voiceRecordHelper.StartRecord(channel, onMicrophoneStarted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022284 RID: 139908 RVA: 0x00BA94B0 File Offset: 0x00BA76B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMicrophoneAvailable(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool b = voiceRecordHelper.IsMicrophoneAvailable();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022285 RID: 139909 RVA: 0x00BA9504 File Offset: 0x00BA7704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.StopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022286 RID: 139910 RVA: 0x00BA9550 File Offset: 0x00BA7750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRecording(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool b = voiceRecordHelper.IsRecording();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022287 RID: 139911 RVA: 0x00BA95A4 File Offset: 0x00BA77A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022288 RID: 139912 RVA: 0x00BA95F0 File Offset: 0x00BA77F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsArrivalMaxLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool b = voiceRecordHelper.IsArrivalMaxLength();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022289 RID: 139913 RVA: 0x00BA9644 File Offset: 0x00BA7844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTooShort(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool b = voiceRecordHelper.IsTooShort();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228A RID: 139914 RVA: 0x00BA9698 File Offset: 0x00BA7898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRecordLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			float recordLength = voiceRecordHelper.GetRecordLength();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recordLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228B RID: 139915 RVA: 0x00BA96EC File Offset: 0x00BA78EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.CancelRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228C RID: 139916 RVA: 0x00BA9738 File Offset: 0x00BA7938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSaveAudioFullPath(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int voiceRecordId;
			LuaObject.checkType(l, 2, out voiceRecordId);
			string saveAudioFullPath = voiceRecordHelper.GetSaveAudioFullPath(voiceRecordId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, saveAudioFullPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228D RID: 139917 RVA: 0x00BA979C File Offset: 0x00BA799C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228E RID: 139918 RVA: 0x00BA97F0 File Offset: 0x00BA79F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.OnStopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602228F RID: 139919 RVA: 0x00BA9844 File Offset: 0x00BA7A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickForRecordVoice(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.TickForRecordVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022290 RID: 139920 RVA: 0x00BA9898 File Offset: 0x00BA7A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartXFRecognize(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.StartXFRecognize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022291 RID: 139921 RVA: 0x00BA98EC File Offset: 0x00BA7AEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnXFSpeechRecognizedSuccess(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			string returnTxt;
			LuaObject.checkType(l, 2, out returnTxt);
			voiceRecordHelper.m_luaExportHelper.OnXFSpeechRecognizedSuccess(returnTxt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022292 RID: 139922 RVA: 0x00BA9948 File Offset: 0x00BA7B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnXFSpeechRecognizeFailed(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.OnXFSpeechRecognizeFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022293 RID: 139923 RVA: 0x00BA999C File Offset: 0x00BA7B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteAudioTempFile(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.DeleteAudioTempFile();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022294 RID: 139924 RVA: 0x00BA99F0 File Offset: 0x00BA7BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.ClearRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022295 RID: 139925 RVA: 0x00BA9A44 File Offset: 0x00BA7C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocRecordId(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int i = voiceRecordHelper.m_luaExportHelper.AllocRecordId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022296 RID: 139926 RVA: 0x00BA9AA0 File Offset: 0x00BA7CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVoiceRecordTimeout(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			ChatChannel obj;
			LuaObject.checkEnum<ChatChannel>(l, 2, out obj);
			voiceRecordHelper.m_luaExportHelper.__callDele_EventOnVoiceRecordTimeout(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022297 RID: 139927 RVA: 0x00BA9AFC File Offset: 0x00BA7CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceRecordTimeout(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			ChatChannel obj;
			LuaObject.checkEnum<ChatChannel>(l, 2, out obj);
			voiceRecordHelper.m_luaExportHelper.__clearDele_EventOnVoiceRecordTimeout(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022298 RID: 139928 RVA: 0x00BA9B58 File Offset: 0x00BA7D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_eventStopRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.__callDele_m_eventStopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022299 RID: 139929 RVA: 0x00BA9BAC File Offset: 0x00BA7DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_eventStopRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			voiceRecordHelper.m_luaExportHelper.__clearDele_m_eventStopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229A RID: 139930 RVA: 0x00BA9C00 File Offset: 0x00BA7E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_recordIdSeed(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_recordIdSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229B RID: 139931 RVA: 0x00BA9C58 File Offset: 0x00BA7E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recordIdSeed(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int recordIdSeed;
			LuaObject.checkType(l, 2, out recordIdSeed);
			voiceRecordHelper.m_luaExportHelper.m_recordIdSeed = recordIdSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229C RID: 139932 RVA: 0x00BA9CB4 File Offset: 0x00BA7EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isRecording(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_isRecording);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229D RID: 139933 RVA: 0x00BA9D0C File Offset: 0x00BA7F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isRecording(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool isRecording;
			LuaObject.checkType(l, 2, out isRecording);
			voiceRecordHelper.m_luaExportHelper.m_isRecording = isRecording;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229E RID: 139934 RVA: 0x00BA9D68 File Offset: 0x00BA7F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCancelRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_isCancelRecord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602229F RID: 139935 RVA: 0x00BA9DC0 File Offset: 0x00BA7FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCancelRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool isCancelRecord;
			LuaObject.checkType(l, 2, out isCancelRecord);
			voiceRecordHelper.m_luaExportHelper.m_isCancelRecord = isCancelRecord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A0 RID: 139936 RVA: 0x00BA9E1C File Offset: 0x00BA801C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preRecordPos(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_preRecordPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A1 RID: 139937 RVA: 0x00BA9E74 File Offset: 0x00BA8074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preRecordPos(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int preRecordPos;
			LuaObject.checkType(l, 2, out preRecordPos);
			voiceRecordHelper.m_luaExportHelper.m_preRecordPos = preRecordPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A2 RID: 139938 RVA: 0x00BA9ED0 File Offset: 0x00BA80D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_recordClip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_recordClip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A3 RID: 139939 RVA: 0x00BA9F28 File Offset: 0x00BA8128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recordClip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			AudioClip recordClip;
			LuaObject.checkType<AudioClip>(l, 2, out recordClip);
			voiceRecordHelper.m_luaExportHelper.m_recordClip = recordClip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A4 RID: 139940 RVA: 0x00BA9F84 File Offset: 0x00BA8184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frequency(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_frequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A5 RID: 139941 RVA: 0x00BA9FDC File Offset: 0x00BA81DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frequency(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int frequency;
			LuaObject.checkType(l, 2, out frequency);
			voiceRecordHelper.m_luaExportHelper.m_frequency = frequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A6 RID: 139942 RVA: 0x00BAA038 File Offset: 0x00BA8238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_startTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A7 RID: 139943 RVA: 0x00BAA094 File Offset: 0x00BA8294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			DateTime startTime;
			LuaObject.checkValueType<DateTime>(l, 2, out startTime);
			voiceRecordHelper.m_luaExportHelper.m_startTime = startTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A8 RID: 139944 RVA: 0x00BAA0F0 File Offset: 0x00BA82F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_endTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222A9 RID: 139945 RVA: 0x00BAA14C File Offset: 0x00BA834C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			DateTime endTime;
			LuaObject.checkValueType<DateTime>(l, 2, out endTime);
			voiceRecordHelper.m_luaExportHelper.m_endTime = endTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AA RID: 139946 RVA: 0x00BAA1A8 File Offset: 0x00BA83A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deviceName(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_deviceName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AB RID: 139947 RVA: 0x00BAA200 File Offset: 0x00BA8400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_deviceName(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			string deviceName;
			LuaObject.checkType(l, 2, out deviceName);
			voiceRecordHelper.m_luaExportHelper.m_deviceName = deviceName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AC RID: 139948 RVA: 0x00BAA25C File Offset: 0x00BA845C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recordNextTickTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_recordNextTickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AD RID: 139949 RVA: 0x00BAA2B8 File Offset: 0x00BA84B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recordNextTickTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			DateTime recordNextTickTime;
			LuaObject.checkValueType<DateTime>(l, 2, out recordNextTickTime);
			voiceRecordHelper.m_luaExportHelper.m_recordNextTickTime = recordNextTickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AE RID: 139950 RVA: 0x00BAA314 File Offset: 0x00BA8514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currRecordChannel(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_currRecordChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222AF RID: 139951 RVA: 0x00BAA370 File Offset: 0x00BA8570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRecordChannel(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			ChatChannel? currRecordChannel;
			LuaObject.checkNullable<ChatChannel>(l, 2, out currRecordChannel);
			voiceRecordHelper.m_luaExportHelper.m_currRecordChannel = currRecordChannel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B0 RID: 139952 RVA: 0x00BAA3CC File Offset: 0x00BA85CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVoiceRecordTimeout(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			Action<ChatChannel> value;
			int num = LuaObject.checkDelegate<Action<ChatChannel>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordHelper.EventOnVoiceRecordTimeout += value;
				}
				else if (num == 2)
				{
					voiceRecordHelper.EventOnVoiceRecordTimeout -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B1 RID: 139953 RVA: 0x00BAA44C File Offset: 0x00BA864C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceMaxLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.VoiceMaxLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B2 RID: 139954 RVA: 0x00BAA4A4 File Offset: 0x00BA86A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_VoiceMaxLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int voiceMaxLength;
			LuaObject.checkType(l, 2, out voiceMaxLength);
			voiceRecordHelper.m_luaExportHelper.VoiceMaxLength = voiceMaxLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B3 RID: 139955 RVA: 0x00BAA500 File Offset: 0x00BA8700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceMinLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.VoiceMinLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B4 RID: 139956 RVA: 0x00BAA558 File Offset: 0x00BA8758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceMinLength(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int voiceMinLength;
			LuaObject.checkType(l, 2, out voiceMinLength);
			voiceRecordHelper.m_luaExportHelper.VoiceMinLength = voiceMinLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B5 RID: 139957 RVA: 0x00BAA5B4 File Offset: 0x00BA87B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EncodeAndDecodeFrameSize(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.EncodeAndDecodeFrameSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B6 RID: 139958 RVA: 0x00BAA60C File Offset: 0x00BA880C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EncodeAndDecodeFrameSize(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			int encodeAndDecodeFrameSize;
			LuaObject.checkType(l, 2, out encodeAndDecodeFrameSize);
			voiceRecordHelper.m_luaExportHelper.EncodeAndDecodeFrameSize = encodeAndDecodeFrameSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B7 RID: 139959 RVA: 0x00BAA668 File Offset: 0x00BA8868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isXFRecognizing(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_isXFRecognizing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B8 RID: 139960 RVA: 0x00BAA6C0 File Offset: 0x00BA88C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isXFRecognizing(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool isXFRecognizing;
			LuaObject.checkType(l, 2, out isXFRecognizing);
			voiceRecordHelper.m_luaExportHelper.m_isXFRecognizing = isXFRecognizing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222B9 RID: 139961 RVA: 0x00BAA71C File Offset: 0x00BA891C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_xfWaitForRecognizeFilePathList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_xfWaitForRecognizeFilePathList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BA RID: 139962 RVA: 0x00BAA774 File Offset: 0x00BA8974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_xfWaitForRecognizeFilePathList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LinkedList<string> xfWaitForRecognizeFilePathList;
			LuaObject.checkType<LinkedList<string>>(l, 2, out xfWaitForRecognizeFilePathList);
			voiceRecordHelper.m_luaExportHelper.m_xfWaitForRecognizeFilePathList = xfWaitForRecognizeFilePathList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BB RID: 139963 RVA: 0x00BAA7D0 File Offset: 0x00BA89D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_xfRecognizedResultList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_xfRecognizedResultList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BC RID: 139964 RVA: 0x00BAA828 File Offset: 0x00BA8A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_xfRecognizedResultList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LinkedList<string> xfRecognizedResultList;
			LuaObject.checkType<LinkedList<string>>(l, 2, out xfRecognizedResultList);
			voiceRecordHelper.m_luaExportHelper.m_xfRecognizedResultList = xfRecognizedResultList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BD RID: 139965 RVA: 0x00BAA884 File Offset: 0x00BA8A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_xfWrapper(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_xfWrapper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BE RID: 139966 RVA: 0x00BAA8DC File Offset: 0x00BA8ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_xfWrapper(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			XunfeiSDKWrapper xfWrapper;
			LuaObject.checkType<XunfeiSDKWrapper>(l, 2, out xfWrapper);
			voiceRecordHelper.m_luaExportHelper.m_xfWrapper = xfWrapper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222BF RID: 139967 RVA: 0x00BAA938 File Offset: 0x00BA8B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, VoiceRecordHelper.LuaExportHelper.m_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C0 RID: 139968 RVA: 0x00BAA980 File Offset: 0x00BA8B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instance(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper instance;
			LuaObject.checkType<VoiceRecordHelper>(l, 2, out instance);
			VoiceRecordHelper.LuaExportHelper.m_instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C1 RID: 139969 RVA: 0x00BAA9CC File Offset: 0x00BA8BCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isRunningStartRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.m_isRunningStartRecord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C2 RID: 139970 RVA: 0x00BAAA24 File Offset: 0x00BA8C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRunningStartRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			bool isRunningStartRecord;
			LuaObject.checkType(l, 2, out isRunningStartRecord);
			voiceRecordHelper.m_luaExportHelper.m_isRunningStartRecord = isRunningStartRecord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C3 RID: 139971 RVA: 0x00BAAA80 File Offset: 0x00BA8C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventStopRecord(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordHelper.m_luaExportHelper.m_eventStopRecord += value;
				}
				else if (num == 2)
				{
					voiceRecordHelper.m_luaExportHelper.m_eventStopRecord -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C4 RID: 139972 RVA: 0x00BAAB08 File Offset: 0x00BA8D08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_XFRecognizedResultList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.XFRecognizedResultList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C5 RID: 139973 RVA: 0x00BAAB5C File Offset: 0x00BA8D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordHelper voiceRecordHelper = (VoiceRecordHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordHelper.m_luaExportHelper.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C6 RID: 139974 RVA: 0x00BAABB4 File Offset: 0x00BA8DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, VoiceRecordHelper.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222C7 RID: 139975 RVA: 0x00BAABFC File Offset: 0x00BA8DFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoiceRecordHelper");
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.InitXFSDKManager);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.StartRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.IsMicrophoneAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.StopRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.IsRecording);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.IsArrivalMaxLength);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.IsTooShort);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.GetRecordLength);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.CancelRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.GetSaveAudioFullPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.OnStopRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.TickForRecordVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.StartXFRecognize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.OnXFSpeechRecognizedSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.OnXFSpeechRecognizeFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.DeleteAudioTempFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.ClearRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.AllocRecordId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.__callDele_EventOnVoiceRecordTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.__clearDele_EventOnVoiceRecordTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.__callDele_m_eventStopRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.__clearDele_m_eventStopRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache17);
		string name = "m_recordIdSeed";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_recordIdSeed);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_recordIdSeed);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache19, true);
		string name2 = "m_isRecording";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_isRecording);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_isRecording);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1B, true);
		string name3 = "m_isCancelRecord";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_isCancelRecord);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_isCancelRecord);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1D, true);
		string name4 = "m_preRecordPos";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_preRecordPos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_preRecordPos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache1F, true);
		string name5 = "m_recordClip";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_recordClip);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_recordClip);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache21, true);
		string name6 = "m_frequency";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_frequency);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_frequency);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache23, true);
		string name7 = "m_startTime";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_startTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_startTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache25, true);
		string name8 = "m_endTime";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_endTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_endTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache27, true);
		string name9 = "m_deviceName";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_deviceName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_deviceName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache29, true);
		string name10 = "m_recordNextTickTime";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_recordNextTickTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_recordNextTickTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2B, true);
		string name11 = "m_currRecordChannel";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_currRecordChannel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_currRecordChannel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2D, true);
		string name12 = "EventOnVoiceRecordTimeout";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_EventOnVoiceRecordTimeout);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2E, true);
		string name13 = "VoiceMaxLength";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_VoiceMaxLength);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_VoiceMaxLength);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache30, true);
		string name14 = "VoiceMinLength";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_VoiceMinLength);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_VoiceMinLength);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache32, true);
		string name15 = "EncodeAndDecodeFrameSize";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_EncodeAndDecodeFrameSize);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_EncodeAndDecodeFrameSize);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache34, true);
		string name16 = "m_isXFRecognizing";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_isXFRecognizing);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_isXFRecognizing);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache36, true);
		string name17 = "m_xfWaitForRecognizeFilePathList";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_xfWaitForRecognizeFilePathList);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_xfWaitForRecognizeFilePathList);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache38, true);
		string name18 = "m_xfRecognizedResultList";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_xfRecognizedResultList);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_xfRecognizedResultList);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3A, true);
		string name19 = "m_xfWrapper";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_xfWrapper);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_xfWrapper);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3C, true);
		string name20 = "m_instance";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_instance);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_instance);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3E, false);
		string name21 = "m_isRunningStartRecord";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_m_isRunningStartRecord);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_isRunningStartRecord);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache40, true);
		string name22 = "m_eventStopRecord";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.set_m_eventStopRecord);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache41, true);
		string name23 = "XFRecognizedResultList";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_XFRecognizedResultList);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache42, null, true);
		string name24 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache43, null, true);
		string name25 = "Instance";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.get_Instance);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.<>f__mg$cache44, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(VoiceRecordHelper));
	}

	// Token: 0x040180AC RID: 98476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040180AD RID: 98477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040180AE RID: 98478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040180AF RID: 98479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040180B0 RID: 98480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040180B1 RID: 98481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040180B2 RID: 98482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040180B3 RID: 98483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040180B4 RID: 98484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040180B5 RID: 98485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040180B6 RID: 98486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040180B7 RID: 98487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040180B8 RID: 98488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040180B9 RID: 98489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040180BA RID: 98490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040180BB RID: 98491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040180BC RID: 98492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040180BD RID: 98493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040180BE RID: 98494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040180BF RID: 98495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040180C0 RID: 98496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040180C1 RID: 98497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040180C2 RID: 98498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040180C3 RID: 98499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040180C4 RID: 98500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040180C5 RID: 98501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040180C6 RID: 98502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040180C7 RID: 98503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040180C8 RID: 98504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040180C9 RID: 98505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040180CA RID: 98506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040180CB RID: 98507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040180CC RID: 98508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040180CD RID: 98509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040180CE RID: 98510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040180CF RID: 98511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040180D0 RID: 98512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040180D1 RID: 98513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040180D2 RID: 98514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040180D3 RID: 98515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040180D4 RID: 98516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040180D5 RID: 98517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040180D6 RID: 98518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040180D7 RID: 98519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040180D8 RID: 98520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040180D9 RID: 98521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040180DA RID: 98522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040180DB RID: 98523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040180DC RID: 98524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040180DD RID: 98525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040180DE RID: 98526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040180DF RID: 98527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040180E0 RID: 98528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040180E1 RID: 98529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040180E2 RID: 98530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040180E3 RID: 98531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040180E4 RID: 98532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040180E5 RID: 98533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040180E6 RID: 98534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040180E7 RID: 98535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040180E8 RID: 98536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040180E9 RID: 98537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040180EA RID: 98538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040180EB RID: 98539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040180EC RID: 98540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040180ED RID: 98541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040180EE RID: 98542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040180EF RID: 98543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040180F0 RID: 98544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;
}

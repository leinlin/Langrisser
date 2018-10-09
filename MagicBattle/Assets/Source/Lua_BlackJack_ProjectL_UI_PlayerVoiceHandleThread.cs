using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001535 RID: 5429
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread : LuaObject
{
	// Token: 0x060205E4 RID: 132580 RVA: 0x00AC5B30 File Offset: 0x00AC3D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			playerVoiceHandleThread.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205E5 RID: 132581 RVA: 0x00AC5B7C File Offset: 0x00AC3D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			playerVoiceHandleThread.Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205E6 RID: 132582 RVA: 0x00AC5BC8 File Offset: 0x00AC3DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDataContentToInputBuffer(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			float[] audioData;
			LuaObject.checkArray<float>(l, 2, out audioData);
			playerVoiceHandleThread.AddDataContentToInputBuffer(audioData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205E7 RID: 132583 RVA: 0x00AC5C20 File Offset: 0x00AC3E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDataHeadToInputBuffer(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			playerVoiceHandleThread.AddDataHeadToInputBuffer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205E8 RID: 132584 RVA: 0x00AC5C6C File Offset: 0x00AC3E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDataEndToInputBuffer(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			ChatVoiceInfo chatInfo;
			LuaObject.checkType<ChatVoiceInfo>(l, 2, out chatInfo);
			bool isValid;
			LuaObject.checkType(l, 3, out isValid);
			playerVoiceHandleThread.AddDataEndToInputBuffer(chatInfo, isValid);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205E9 RID: 132585 RVA: 0x00AC5CD0 File Offset: 0x00AC3ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOutputBufferData(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			PlayerVoiceHandleThread.VoicePacket outputBufferData = playerVoiceHandleThread.GetOutputBufferData();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, outputBufferData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205EA RID: 132586 RVA: 0x00AC5D24 File Offset: 0x00AC3F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDataToInputBuffer(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			PlayerVoiceHandleThread.VoicePacket packet;
			LuaObject.checkType<PlayerVoiceHandleThread.VoicePacket>(l, 2, out packet);
			playerVoiceHandleThread.m_luaExportHelper.AddDataToInputBuffer(packet);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205EB RID: 132587 RVA: 0x00AC5D80 File Offset: 0x00AC3F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInputBufferData(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			PlayerVoiceHandleThread.VoicePacket inputBufferData = playerVoiceHandleThread.m_luaExportHelper.GetInputBufferData();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputBufferData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205EC RID: 132588 RVA: 0x00AC5DDC File Offset: 0x00AC3FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDataToOutputBuffer(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			PlayerVoiceHandleThread.VoicePacket packet;
			LuaObject.checkType<PlayerVoiceHandleThread.VoicePacket>(l, 2, out packet);
			playerVoiceHandleThread.m_luaExportHelper.AddDataToOutputBuffer(packet);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205ED RID: 132589 RVA: 0x00AC5E38 File Offset: 0x00AC4038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTickTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			int tickTime = playerVoiceHandleThread.m_luaExportHelper.GetTickTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205EE RID: 132590 RVA: 0x00AC5E94 File Offset: 0x00AC4094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int VoiceThreadProc(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			playerVoiceHandleThread.m_luaExportHelper.VoiceThreadProc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205EF RID: 132591 RVA: 0x00AC5EE8 File Offset: 0x00AC40E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ByteArrayListToByteArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			List<byte[]> list;
			LuaObject.checkType<List<byte[]>>(l, 2, out list);
			byte[] a = playerVoiceHandleThread.m_luaExportHelper.ByteArrayListToByteArray(list);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F0 RID: 132592 RVA: 0x00AC5F50 File Offset: 0x00AC4150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startHandle(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_startHandle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F1 RID: 132593 RVA: 0x00AC5FA4 File Offset: 0x00AC41A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startHandle(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			bool startHandle;
			LuaObject.checkType(l, 2, out startHandle);
			playerVoiceHandleThread.m_startHandle = startHandle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F2 RID: 132594 RVA: 0x00AC5FFC File Offset: 0x00AC41FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceHandleThread(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_voiceHandleThread);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F3 RID: 132595 RVA: 0x00AC6050 File Offset: 0x00AC4250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceHandleThread(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			Thread voiceHandleThread;
			LuaObject.checkType<Thread>(l, 2, out voiceHandleThread);
			playerVoiceHandleThread.m_voiceHandleThread = voiceHandleThread;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F4 RID: 132596 RVA: 0x00AC60A8 File Offset: 0x00AC42A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inputQueue(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_inputQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F5 RID: 132597 RVA: 0x00AC6100 File Offset: 0x00AC4300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inputQueue(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			Queue<PlayerVoiceHandleThread.VoicePacket> inputQueue;
			LuaObject.checkType<Queue<PlayerVoiceHandleThread.VoicePacket>>(l, 2, out inputQueue);
			playerVoiceHandleThread.m_luaExportHelper.m_inputQueue = inputQueue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F6 RID: 132598 RVA: 0x00AC615C File Offset: 0x00AC435C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_outputQueue(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_outputQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F7 RID: 132599 RVA: 0x00AC61B4 File Offset: 0x00AC43B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_outputQueue(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			Queue<PlayerVoiceHandleThread.VoicePacket> outputQueue;
			LuaObject.checkType<Queue<PlayerVoiceHandleThread.VoicePacket>>(l, 2, out outputQueue);
			playerVoiceHandleThread.m_luaExportHelper.m_outputQueue = outputQueue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F8 RID: 132600 RVA: 0x00AC6210 File Offset: 0x00AC4410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_validIdList(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_validIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205F9 RID: 132601 RVA: 0x00AC6268 File Offset: 0x00AC4468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_validIdList(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			List<int> validIdList;
			LuaObject.checkType<List<int>>(l, 2, out validIdList);
			playerVoiceHandleThread.m_luaExportHelper.m_validIdList = validIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FA RID: 132602 RVA: 0x00AC62C4 File Offset: 0x00AC44C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lock(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_lock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FB RID: 132603 RVA: 0x00AC631C File Offset: 0x00AC451C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_seclock(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_seclock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FC RID: 132604 RVA: 0x00AC6374 File Offset: 0x00AC4574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_idListLock(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread playerVoiceHandleThread = (PlayerVoiceHandleThread)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerVoiceHandleThread.m_luaExportHelper.m_idListLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FD RID: 132605 RVA: 0x00AC63CC File Offset: 0x00AC45CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayerVoiceHandleThread.LuaExportHelper.m_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FE RID: 132606 RVA: 0x00AC6414 File Offset: 0x00AC4614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instance(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread instance;
			LuaObject.checkType<PlayerVoiceHandleThread>(l, 2, out instance);
			PlayerVoiceHandleThread.LuaExportHelper.m_instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205FF RID: 132607 RVA: 0x00AC6460 File Offset: 0x00AC4660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayerVoiceHandleThread.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020600 RID: 132608 RVA: 0x00AC64A8 File Offset: 0x00AC46A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerVoiceHandleThread");
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.AddDataContentToInputBuffer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.AddDataHeadToInputBuffer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.AddDataEndToInputBuffer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.GetOutputBufferData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.AddDataToInputBuffer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.GetInputBufferData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.AddDataToOutputBuffer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.GetTickTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.VoiceThreadProc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.ByteArrayListToByteArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheB);
		string name = "m_startHandle";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_startHandle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_startHandle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheD, true);
		string name2 = "m_voiceHandleThread";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_voiceHandleThread);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_voiceHandleThread);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cacheF, true);
		string name3 = "m_inputQueue";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_inputQueue);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_inputQueue);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache11, true);
		string name4 = "m_outputQueue";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_outputQueue);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_outputQueue);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache13, true);
		string name5 = "m_validIdList";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_validIdList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_validIdList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache15, true);
		string name6 = "m_lock";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_lock);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache16, null, true);
		string name7 = "m_seclock";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_seclock);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache17, null, true);
		string name8 = "m_idListLock";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_idListLock);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache18, null, true);
		string name9 = "m_instance";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_m_instance);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.set_m_instance);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1A, false);
		string name10 = "Instance";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.get_Instance);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.<>f__mg$cache1B, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerVoiceHandleThread));
	}

	// Token: 0x0401655C RID: 91484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401655D RID: 91485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401655E RID: 91486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401655F RID: 91487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016560 RID: 91488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016561 RID: 91489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016562 RID: 91490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016563 RID: 91491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016564 RID: 91492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016565 RID: 91493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016566 RID: 91494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016567 RID: 91495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016568 RID: 91496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016569 RID: 91497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401656A RID: 91498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401656B RID: 91499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401656C RID: 91500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401656D RID: 91501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401656E RID: 91502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401656F RID: 91503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016570 RID: 91504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016571 RID: 91505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016572 RID: 91506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016573 RID: 91507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016574 RID: 91508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016575 RID: 91509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016576 RID: 91510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016577 RID: 91511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}

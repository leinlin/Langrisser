using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000837 RID: 2103
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomGetAck")]
	[Serializable]
	public class TeamRoomGetAck : IExtensible
	{
		// Token: 0x06006980 RID: 27008 RVA: 0x001DB28C File Offset: 0x001D948C
		public TeamRoomGetAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x001DB2F4 File Offset: 0x001D94F4
		// (set) Token: 0x06006982 RID: 27010 RVA: 0x001DB2FC File Offset: 0x001D94FC
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x001DB308 File Offset: 0x001D9508
		// (set) Token: 0x06006984 RID: 27012 RVA: 0x001DB310 File Offset: 0x001D9510
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Room", DataFormat = DataFormat.Default)]
		public ProTeamRoom Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				this._Room = value;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x001DB31C File Offset: 0x001D951C
		// (set) Token: 0x06006986 RID: 27014 RVA: 0x001DB324 File Offset: 0x001D9524
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "FrontOfYouWaitingNums", DataFormat = DataFormat.TwosComplement)]
		public int FrontOfYouWaitingNums
		{
			get
			{
				return this._FrontOfYouWaitingNums;
			}
			set
			{
				this._FrontOfYouWaitingNums = value;
			}
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x001DB330 File Offset: 0x001D9530
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x001DB340 File Offset: 0x001D9540
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x001DB40C File Offset: 0x001D960C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400514C RID: 20812
		private int _Result;

		// Token: 0x0400514D RID: 20813
		private ProTeamRoom _Room;

		// Token: 0x0400514E RID: 20814
		private int _FrontOfYouWaitingNums;

		// Token: 0x0400514F RID: 20815
		private IExtension extensionObject;

		// Token: 0x04005150 RID: 20816
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005151 RID: 20817
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005152 RID: 20818
		private LuaFunction m_ctor_hotfix;
	}
}

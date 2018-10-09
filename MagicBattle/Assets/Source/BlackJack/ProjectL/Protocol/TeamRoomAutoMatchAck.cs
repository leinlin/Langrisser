using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082D RID: 2093
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomAutoMatchAck")]
	[Serializable]
	public class TeamRoomAutoMatchAck : IExtensible
	{
		// Token: 0x06006938 RID: 26936 RVA: 0x001DA094 File Offset: 0x001D8294
		public TeamRoomAutoMatchAck()
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

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06006939 RID: 26937 RVA: 0x001DA0FC File Offset: 0x001D82FC
		// (set) Token: 0x0600693A RID: 26938 RVA: 0x001DA104 File Offset: 0x001D8304
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600693B RID: 26939 RVA: 0x001DA110 File Offset: 0x001D8310
		// (set) Token: 0x0600693C RID: 26940 RVA: 0x001DA118 File Offset: 0x001D8318
		[ProtoMember(2, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600693D RID: 26941 RVA: 0x001DA124 File Offset: 0x001D8324
		// (set) Token: 0x0600693E RID: 26942 RVA: 0x001DA12C File Offset: 0x001D832C
		[ProtoMember(3, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600693F RID: 26943 RVA: 0x001DA138 File Offset: 0x001D8338
		// (set) Token: 0x06006940 RID: 26944 RVA: 0x001DA140 File Offset: 0x001D8340
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Room", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06006941 RID: 26945 RVA: 0x001DA14C File Offset: 0x001D834C
		// (set) Token: 0x06006942 RID: 26946 RVA: 0x001DA154 File Offset: 0x001D8354
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "FrontOfYouWaitingNums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006943 RID: 26947 RVA: 0x001DA160 File Offset: 0x001D8360
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x001DA170 File Offset: 0x001D8370
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

		// Token: 0x06006945 RID: 26949 RVA: 0x001DA23C File Offset: 0x001D843C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAutoMatchAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005114 RID: 20756
		private int _Result;

		// Token: 0x04005115 RID: 20757
		private int _GameFunctionTypeId;

		// Token: 0x04005116 RID: 20758
		private int _LocationId;

		// Token: 0x04005117 RID: 20759
		private ProTeamRoom _Room;

		// Token: 0x04005118 RID: 20760
		private int _FrontOfYouWaitingNums;

		// Token: 0x04005119 RID: 20761
		private IExtension extensionObject;

		// Token: 0x0400511A RID: 20762
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400511B RID: 20763
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400511C RID: 20764
		private LuaFunction m_ctor_hotfix;
	}
}

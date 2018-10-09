using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000812 RID: 2066
	[ProtoContract(Name = "RealTimePVPGetInfoAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPGetInfoAck : IExtensible
	{
		// Token: 0x0600684F RID: 26703 RVA: 0x001D6E2C File Offset: 0x001D502C
		public RealTimePVPGetInfoAck()
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

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06006850 RID: 26704 RVA: 0x001D6E94 File Offset: 0x001D5094
		// (set) Token: 0x06006851 RID: 26705 RVA: 0x001D6E9C File Offset: 0x001D509C
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

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06006852 RID: 26706 RVA: 0x001D6EA8 File Offset: 0x001D50A8
		// (set) Token: 0x06006853 RID: 26707 RVA: 0x001D6EB0 File Offset: 0x001D50B0
		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public ProRealTimePVPLeaderboardPlayerInfo Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				this._Info = value;
			}
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x001D6EBC File Offset: 0x001D50BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x001D6ECC File Offset: 0x001D50CC
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

		// Token: 0x06006856 RID: 26710 RVA: 0x001D6F98 File Offset: 0x001D5198
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPGetInfoAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005064 RID: 20580
		private int _Result;

		// Token: 0x04005065 RID: 20581
		private ProRealTimePVPLeaderboardPlayerInfo _Info;

		// Token: 0x04005066 RID: 20582
		private IExtension extensionObject;

		// Token: 0x04005067 RID: 20583
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005068 RID: 20584
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005069 RID: 20585
		private LuaFunction m_ctor_hotfix;
	}
}
